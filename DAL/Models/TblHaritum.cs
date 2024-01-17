using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblHaritum
    {
        public int Id { get; set; }
        public int KonumId { get; set; }
        public string Ad { get; set; } = null!;
        public string Url { get; set; } = null!;
        public string? Kat { get; set; }
        public string? Bolge { get; set; }
        public DateTime? KesifTarih { get; set; }
        public DateTime? SonguncellemeZamani { get; set; }
        public string? SonGuncelleyen { get; set; }
        public string? BinaAdi { get; set; }
    }
}
