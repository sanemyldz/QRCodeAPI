using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblLoginYetkiliPeriyodlar
    {
        public int Id { get; set; }
        public int LoginId { get; set; }
        public int PeriyodId { get; set; }
    }
}
