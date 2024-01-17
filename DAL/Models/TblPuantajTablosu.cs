using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblPuantajTablosu
    {
        public int Id { get; set; }
        public int? SicilId { get; set; }
        public DateTime? Tarih { get; set; }
        public string? Department { get; set; }
        public DateTime? Giris { get; set; }
        public DateTime? Cikis { get; set; }
        public int? NormalCalisma { get; set; }
        public int? Devamsizlik { get; set; }
        public int? PazarTatili { get; set; }
        public int? FazlaMesai { get; set; }
        public int? YillikIzin { get; set; }
        public int? UcretliIzin { get; set; }
        public int? UcretsizIzin { get; set; }
        public int? OdenmeyenRapor { get; set; }
        public int? GenelTatil { get; set; }
        public int? Cumartesi { get; set; }
        public int? ResmiTatilFazlaMesai { get; set; }
    }
}
