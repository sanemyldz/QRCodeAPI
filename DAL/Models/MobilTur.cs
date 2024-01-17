using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MobilTur
    {
        public int Id { get; set; }
        public string? Guid { get; set; }
        public int? BolumId { get; set; }
        public int? GorevId { get; set; }
        public DateTime? DateStarted { get; set; }
        public DateTime? DateEnded { get; set; }
        public int? CreatedBy { get; set; }
        public string? FormenFullName { get; set; }
        public int? Type { get; set; }
        public int? PdksType { get; set; }
        public string? Longitude { get; set; }
        public string? Latitude { get; set; }
        public string? PhotoBase64 { get; set; }
        public string? PhotoBase64Finish { get; set; }
        public string? PhotoUrl { get; set; }
        public string? PhotoUrlFinish { get; set; }
        public int? Status { get; set; }
    }
}
