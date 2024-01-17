using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblOdaTerminalTanim
    {
        public int Id { get; set; }
        public int OdaId { get; set; }
        public int GirisTerminalId { get; set; }
        public int CikisTerminalId { get; set; }
    }
}
