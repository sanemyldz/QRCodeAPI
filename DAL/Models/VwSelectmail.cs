using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectmail
    {
        public int Id { get; set; }
        public bool? Aktif { get; set; }
        public int SicilId { get; set; }
        public string? MailAdresi { get; set; }
        public int? FirmaId { get; set; }
        public int? BolumId { get; set; }
        public int? BirimId { get; set; }
        public int? YetkiId { get; set; }
        public string? MailYetkiAdi { get; set; }
        public int MailRaporId { get; set; }
        public string? RaporDosyaAdi { get; set; }
        public string? RaporBosText { get; set; }
        public string? RaporDoluText { get; set; }
    }
}
