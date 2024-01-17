using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblIzinAkisSicilOnay
    {
        public int Id { get; set; }
        public int OnaySiraNo { get; set; }
        public int IzinAkisSicilId { get; set; }
        public int SicilId { get; set; }
        public int IzinId { get; set; }
        public int IzinOnayIslemDurumId { get; set; }
        public int? UserId { get; set; }
        public DateTime KayitTarih { get; set; }
        public DateTime? IslemTarih { get; set; }
        public string? DosyaYolu { get; set; }
        public string? IslemNotu { get; set; }

        public virtual Izinler Izin { get; set; } = null!;
        public virtual TblSysIzinOnayIslemDurum IzinOnayIslemDurum { get; set; } = null!;
        public virtual Sicil Sicil { get; set; } = null!;
        public virtual UserTable? User { get; set; }
    }
}
