using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblTravelRequestResult
    {
        public int Id { get; set; }
        public DateTime? RequestDatetime { get; set; }
        public int? ResultCount { get; set; }
        public DateTime? RequestDateParam { get; set; }
        public string? Efolderid { get; set; }
        public string? FormNumber { get; set; }
        public string? SappersonelNumber { get; set; }
        public string? PersonellUniqueNumber { get; set; }
        public string? PersonnelAdaccount { get; set; }
        public string? TravelTypeCode { get; set; }
        public string? TravelTypeDefinition { get; set; }
        public string? TravelStartDate { get; set; }
        public string? TravelEndDate { get; set; }
        public string? StatusCode { get; set; }
        public string? StatusDefinition { get; set; }
    }
}
