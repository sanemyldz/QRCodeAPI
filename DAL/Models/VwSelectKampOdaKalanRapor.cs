using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectKampOdaKalanRapor
    {
        public int Id { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public string? BlokAdi { get; set; }
        public string? OdaAdi { get; set; }
        public int FirmaId { get; set; }
        public int BolumId { get; set; }
        public int GorevId { get; set; }
        public int PozisyonId { get; set; }
        public int BirimId { get; set; }
        public DateTime MesaiTarih { get; set; }
        public DateTime CikisTarih { get; set; }
    }
}
