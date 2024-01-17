using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Denied
    {
        public string? CardId { get; set; }
        public string? FacilityCode { get; set; }
        public DateTime? AccessDate { get; set; }
        public string? Reader { get; set; }
    }
}
