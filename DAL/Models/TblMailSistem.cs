using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblMailSistem
    {
        public int Id { get; set; }
        public string? Smtp { get; set; }
        public string? Port { get; set; }
        public bool? Ssl { get; set; }
        public string? MainMail { get; set; }
        public string? MainPass { get; set; }
        public DateTime? Saat1 { get; set; }
        public DateTime? Saat2 { get; set; }
        public DateTime? Saat3 { get; set; }
        public bool? Saat1Aktif { get; set; }
        public bool? Saat2Aktif { get; set; }
        public bool? Saat3Aktif { get; set; }
        public bool? Attachment { get; set; }
        public bool? Pazartesi { get; set; }
        public bool? Sali { get; set; }
        public bool? Carsamba { get; set; }
        public bool? Persembe { get; set; }
        public bool? Cuma { get; set; }
        public bool? Cumartesi { get; set; }
        public bool? Pazar { get; set; }
        public int? GonderimAraBeklemeSuresiSn { get; set; }
    }
}
