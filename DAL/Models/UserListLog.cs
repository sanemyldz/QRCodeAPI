using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class UserListLog
    {
        public int Id { get; set; }
        public int CardType { get; set; }
        public string? CardId { get; set; }
        public int CardAttribute { get; set; }
        public string? FacilityCode { get; set; }
        public string? FingerId1 { get; set; }
        public string? FingerId2 { get; set; }
        public string? Fpdata { get; set; }
        public int UserDef { get; set; }
        public int? Function { get; set; }
        public int Master { get; set; }
        public int BypassCard { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public string? CardId26 { get; set; }
        public int IsTimezone { get; set; }
        public string? UserListId { get; set; }
        public int LoginUserId { get; set; }
        public int IslemTipId { get; set; }
        public DateTime IslemDatetime { get; set; }
        public string UserId { get; set; } = null!;
        public string? Aciklama { get; set; }
    }
}
