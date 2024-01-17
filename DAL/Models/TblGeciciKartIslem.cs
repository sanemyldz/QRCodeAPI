using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblGeciciKartIslem
    {
        public int Id { get; set; }
        public string GeciciKartUserId { get; set; } = null!;
        public int GeciciKartVerilenSicilId { get; set; }
        public DateTime GeciciKartVerilmeTarih { get; set; }
        public DateTime SonGecerlilikTarih { get; set; }
        public DateTime? GeciciKartIslemBitisTarihi { get; set; }
    }
}
