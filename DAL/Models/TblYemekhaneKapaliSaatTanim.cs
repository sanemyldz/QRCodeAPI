using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblYemekhaneKapaliSaatTanim
    {
        public int Id { get; set; }
        public int KapaliSaatBas { get; set; }
        public int KapaliSaatSon { get; set; }
        public string Aciklama { get; set; } = null!;
        public DateTime AddDate { get; set; }
    }
}
