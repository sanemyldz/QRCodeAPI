using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectMail1
    {
        public int Id { get; set; }
        public string? MailAdresi { get; set; }
        public bool? Aktif { get; set; }
        public int? BirimId { get; set; }
        public int? BolumId { get; set; }
        public int? FirmaId { get; set; }
        public int SicilId { get; set; }
        public int? YetkiId { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? SicilNo { get; set; }
        public string? FirmaAdi { get; set; }
        public string? BolumAdi { get; set; }
        public string? MailYetkiAdi { get; set; }
    }
}
