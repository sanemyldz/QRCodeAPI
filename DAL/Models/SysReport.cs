using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SysReport
    {
        public int GroupCode { get; set; }
        public string ReportCode { get; set; } = null!;
        public int Id { get; set; }
        public int Kind { get; set; }
        public int Section { get; set; }
        public string FieldName { get; set; } = null!;
        public int FieldType { get; set; }
        public int ObjectType { get; set; }
        public int ObjectIndex { get; set; }
        public int Direction { get; set; }
        public string? Sqlstring { get; set; }
        public string Ad { get; set; } = null!;
        public string AdEnglish { get; set; } = null!;
        public string? AdKorean { get; set; }
        public string? AdGerman { get; set; }
        public string? AdFrench { get; set; }
        public string? AdSpanish { get; set; }
        public string? AdItalian { get; set; }
        public string? AdPortuguese { get; set; }
        public string? AdRussian { get; set; }
        public string? AdChinese { get; set; }
        public string? AdThiland { get; set; }
        public string? AdVietnam { get; set; }
        public string? AdMalaysia { get; set; }
        public string? AdArabic { get; set; }

        public virtual SysReport1 ReportCodeNavigation { get; set; } = null!;
    }
}
