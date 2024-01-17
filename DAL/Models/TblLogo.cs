using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblLogo
    {
        public int Id { get; set; }
        public string? MainLogo { get; set; }
        public string? SideLogo { get; set; }
    }
}
