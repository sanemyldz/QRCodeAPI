using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblLastMailSendTime
    {
        public int Id { get; set; }
        public DateTime? LastMailSendTime { get; set; }
    }
}
