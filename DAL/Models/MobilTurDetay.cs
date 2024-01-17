using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MobilTurDetay
    {
        public int Id { get; set; }
        public int? MobilTurId { get; set; }
        public byte? Type { get; set; }
        public int? SicilId { get; set; }
        public string? LaborFullName { get; set; }
        public int? BolumId { get; set; }
        public string? LokasyonAdi { get; set; }
        public string? BolumAdi { get; set; }
        public int? GorevId { get; set; }
        public DateTime? EventTime { get; set; }
        public byte? Direction { get; set; }
        public string? Longitude { get; set; }
        public string? Latitude { get; set; }
        public string? PhotoBase64 { get; set; }
        public string? PhotoUrl { get; set; }
    }
}
