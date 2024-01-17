using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSysLoggedTable
    {
        public int Id { get; set; }
        public string? ModuleName { get; set; }
        public string? TableName { get; set; }
        public string? SqltableName { get; set; }
    }
}
