﻿namespace DoQL.Models
{
    public class Database
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DatabaseType Type { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public List<Table> Tables { get; set; }
    }
}
