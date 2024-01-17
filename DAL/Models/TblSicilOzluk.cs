using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblSicilOzluk
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public int? HizmetGorevId { get; set; }
        public int? HizmetKadroId { get; set; }
        public int? SgkmeslekKoduId { get; set; }
        public int? SendikaDurum { get; set; }
        public DateTime? SendikaUyelikBaslangic { get; set; }
        public DateTime? SendikaUyelikBitis { get; set; }
        public string? SendikaCikisNeden { get; set; }
        public int? SozlesmeTuru { get; set; }
        public int? HizmetFiiliGorevId { get; set; }
    }
}
