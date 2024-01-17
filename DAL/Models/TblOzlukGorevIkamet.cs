using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblOzlukGorevIkamet
    {
        public int Id { get; set; }
        public string? Ad { get; set; }
        public string? Adres { get; set; }
        public string? Il { get; set; }
        public string? Ilce { get; set; }
        public string? Tip { get; set; }
        public string? KiraTutari { get; set; }
        public string? AidatTutari { get; set; }
        public string? ElektrikAboneNo { get; set; }
        public string? SuAboneNo { get; set; }
        public string? TelefonAboneNo { get; set; }
        public DateTime? KiraBaslangicTarihi { get; set; }
        public int? KiraParaBirimi { get; set; }
        public int? AidatParaBirimi { get; set; }
    }
}
