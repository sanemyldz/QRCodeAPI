using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class YapilacakFazlaMesaiOnaylar
    {
        public int Id { get; set; }
        public int OnaySiraNo { get; set; }
        public int OnayciSicilId { get; set; }
        public int TalepId { get; set; }
        public int IzinOnayIslemDurumId { get; set; }
        public int? UserId { get; set; }
        public DateTime KayitTarih { get; set; }
        public DateTime? IslemTarih { get; set; }
        public int? AkisId { get; set; }
    }
}
