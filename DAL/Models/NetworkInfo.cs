using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class NetworkInfo
    {
        public int Id { get; set; }
        public int? TerminalId { get; set; }
        public DateTime? Zaman { get; set; }
        public int? Ping { get; set; }
        public DateTime? SonPingZamani { get; set; }
        public DateTime? SonGecisZamani { get; set; }
        public int? PoolId { get; set; }
    }
}
