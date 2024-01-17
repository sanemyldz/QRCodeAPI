using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblZiyaretciTerminalYetkiDurum
    {
        public int Id { get; set; }
        public int? ZiyaretciId { get; set; }
        public int? UserId { get; set; }
        public int? PanelId { get; set; }
        public int? TerminalId { get; set; }
        public int? YetkiId { get; set; }
        public DateTime? IslemTarihi { get; set; }
    }
}
