using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SysLanguage
    {
        public string Form { get; set; } = null!;
        public string Kind { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int Index { get; set; }
        public string Ad { get; set; } = null!;
        public string? AdEnglish { get; set; }
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
    }
}
