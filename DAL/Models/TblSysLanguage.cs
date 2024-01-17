using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSysLanguage
    {
        public int Id { get; set; }
        public string? LanguageName { get; set; }
        public string? LangCode { get; set; }
    }
}
