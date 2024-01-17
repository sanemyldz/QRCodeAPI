using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectsize
    {
        public string TableName { get; set; } = null!;
        public string? SchemaName { get; set; }
        public long? RowCounts { get; set; }
        public long? TotalSpaceKb { get; set; }
        public decimal? TotalSpaceMb { get; set; }
        public long? UsedSpaceKb { get; set; }
        public decimal? UsedSpaceMb { get; set; }
        public long? UnusedSpaceKb { get; set; }
        public decimal? UnusedSpaceMb { get; set; }
    }
}
