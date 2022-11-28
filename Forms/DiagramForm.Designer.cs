﻿namespace DoQL
{
    partial class DiagramForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newEntityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAttributeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRelationshipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 453);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEntityToolStripMenuItem,
            this.newAttributeToolStripMenuItem,
            this.newRelationshipToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(195, 76);
            // 
            // newEntityToolStripMenuItem
            // 
            this.newEntityToolStripMenuItem.Name = "newEntityToolStripMenuItem";
            this.newEntityToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.newEntityToolStripMenuItem.Text = "New Entity";
            this.newEntityToolStripMenuItem.Click += new System.EventHandler(this.newEntityToolStripMenuItem_Click);
            // 
            // newAttributeToolStripMenuItem
            // 
            this.newAttributeToolStripMenuItem.Name = "newAttributeToolStripMenuItem";
            this.newAttributeToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.newAttributeToolStripMenuItem.Text = "New Attribute";
            this.newAttributeToolStripMenuItem.Click += new System.EventHandler(this.newAttributeToolStripMenuItem_Click);
            // 
            // newRelationshipToolStripMenuItem
            // 
            this.newRelationshipToolStripMenuItem.Name = "newRelationshipToolStripMenuItem";
            this.newRelationshipToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.newRelationshipToolStripMenuItem.Text = "New Relationship";
            this.newRelationshipToolStripMenuItem.Click += new System.EventHandler(this.newRelationshipToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 453);
            this.panel2.TabIndex = 1;
            // 
            // DiagramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "DiagramForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem newEntityToolStripMenuItem;
        private ToolStripMenuItem newAttributeToolStripMenuItem;
        private ToolStripMenuItem newRelationshipToolStripMenuItem;
    }
}