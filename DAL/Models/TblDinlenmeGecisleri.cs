using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblDinlenmeGecisleri
    {
        public int Id { get; set; }
        public DateTime? MesaiTarih { get; set; }
        public string SicilId { get; set; } = null!;
        public int? TasnifId { get; set; }
        public int? MesaiId { get; set; }
        public int DinlenmeId { get; set; }
        public string? CikisId { get; set; }
        public string? CikisTerminalId { get; set; }
        public DateTime? Cikis { get; set; }
        public int? Zaman { get; set; }
        public DateTime? Giris { get; set; }
        public string? GirisId { get; set; }
        public string? GirisTerminalId { get; set; }
        public bool? MesaiIciDinlenme { get; set; }
        public int? MesaiIciMolaIceriSure { get; set; }
        public int? MesaiIciMolaDisariSure { get; set; }
        public int? MesaiDisiMolaIceriSure { get; set; }
        public int? MesaiDisiMolaDisariSure { get; set; }
    }
}
