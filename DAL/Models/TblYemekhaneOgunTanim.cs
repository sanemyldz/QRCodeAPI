using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblYemekhaneOgunTanim
    {
        public int Id { get; set; }
        public string? OgunAdi { get; set; }
        public int? OgunBaslangic { get; set; }
        public int? OgunBitis { get; set; }
    }
}
