using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MailRapor
    {
        public int Id { get; set; }
        public int? RaporId { get; set; }
        public int? SicilId { get; set; }
        public byte? Tip { get; set; }
        public int? YetkiId { get; set; }
        public int? FirmaId { get; set; }
        public int? BolumId { get; set; }
        public int? BirimId { get; set; }
        public byte? GunDurum { get; set; }
        public byte? AyDurum { get; set; }
        public byte? HaftaDurum { get; set; }
    }
}
