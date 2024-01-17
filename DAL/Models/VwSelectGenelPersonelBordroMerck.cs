using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSelectGenelPersonelBordroMerck
    {
        public string? CardId { get; set; }
        public string? SicilNo { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public int NetMaas { get; set; }
        public int Ncgun { get; set; }
        public int Ncsaat { get; set; }
        public int Ncucret { get; set; }
        public int Fmsaat { get; set; }
        public int Fmgun { get; set; }
        public int SicilId { get; set; }
        public int BolumId { get; set; }
        public int GorevId { get; set; }
        public int PozisyonId { get; set; }
        public int FirmaId { get; set; }
        public int BirimId { get; set; }
        public DateTime? MesaiTarih { get; set; }
    }
}
