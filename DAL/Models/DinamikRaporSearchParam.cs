using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class DinamikRaporSearchParam
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? BirimId { get; set; }
        public string? BolumId { get; set; }
        public string? FirmaId { get; set; }
        public string? PozisyonId { get; set; }
        public string? GorevId { get; set; }
        public string? SicilId { get; set; }
        public DateTime? BaslangicTarihi { get; set; }
        public DateTime? BitisTarihi { get; set; }

        public virtual UserTable User { get; set; } = null!;
    }
}
