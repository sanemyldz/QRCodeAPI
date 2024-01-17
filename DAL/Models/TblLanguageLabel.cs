using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblLanguageLabel
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public string? LabelName { get; set; }
        public string? LabelText { get; set; }
    }
}
