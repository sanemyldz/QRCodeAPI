using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwPagoResimselect
    {
        public int Id { get; set; }
        public int RowDataozetId { get; set; }
        public byte[]? Image { get; set; }
        public string? PersonelNo { get; set; }
        public bool? FileAktarildi { get; set; }
    }
}
