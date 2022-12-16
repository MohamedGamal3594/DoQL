﻿using System.Drawing.Drawing2D;
using DoQL.Interfaces;
using DoQL.Utilities;

namespace DoQL.Controls.ERD
{
    public partial class RelationshipControl : BaseControl, IConnectable
    {
        public string Id { get; init; }

        public RelationshipControl()
        {
            InitializeComponent();
            Text = "Has";
        }

        private Size strSize;

        protected override void OnLoad(EventArgs e)
        {
            using (Graphics graphics = CreateGraphics())
            {
                var padding = new Size(64, 64);
                strSize = graphics.MeasureString(Text, Font).ToSize();
                Size = strSize + padding;
            }

            using (var path = new GraphicsPath())
            {
                path.AddPolygon(new Point[]
                {
                    new Point(0, Height/2),
                    new Point(Width/2, 0),
                    new Point(Width, Height/2),
                    new Point(Width/2, Height),
                });
                Region = new Region(path);
            }

            base.OnLoad(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var centerPoint = new Point(Width / 2 - strSize.Width / 2, Height / 2 - strSize.Height / 2);
            e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), centerPoint);
            base.OnPaint(e);
        }

        #region connections

        public Point[] GetConnectablePoints()
        {
            return new[]
            {
                // left
                new Point(0, Height / 2),
                // center
                new Point(Width / 2, 0),
                new Point(Width / 2, Height),
                // right
                new Point(Width, Height / 2)
            };
        }

        public ErdSymbol[] GetSupportedSymbols()
        {
            return new[] { ErdSymbol.Entity, ErdSymbol.Attribute };
        }

        public void Connect(IConnectable connectableControl)
        {
            // make sure it is connected with 2 entities only
            if (connectableControl is EntityControl entityControl)
            {
                var diagramPanel = Parent as DiagramPanel;

                IEnumerable<Connection> currentConnections = diagramPanel.Connections
                    .Where(c => c.IsValidConnection())
                    .Where(c => c.Control1.ConnectableControl == this || c.Control2.ConnectableControl == this)
                    .Where(c => c.Control1.ConnectableControl is EntityControl || c.Control2.ConnectableControl is EntityControl);

                Connection duplicateConnection = currentConnections.FirstOrDefault(c => c.Control1.ConnectableControl == entityControl || c.Control2.ConnectableControl == entityControl);
                if (duplicateConnection != null)
                    diagramPanel.Connections.Remove(duplicateConnection);

                if (currentConnections.Count() == 2)
                    diagramPanel.Connections.Remove(currentConnections.First());
            }

            if (connectableControl is AttributeControl attributeControl)
            {
                attributeControl.Connect(this);
            }
        }

        #endregion
    }
}
