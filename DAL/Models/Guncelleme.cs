using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Guncelleme
    {
        public int Id { get; set; }
        public DateTime? SelectedUpdateTime { get; set; }
        public string? TableorViewName { get; set; }
        public string? SqlQuery { get; set; }
        public DateTime? ScriptDate { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
