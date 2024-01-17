using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblPermissionRequestForm
    {
        public int Id { get; set; }
        public DateTime? RequestDatetime { get; set; }
        public int? ResultCount { get; set; }
        public DateTime? RequestDateParam { get; set; }
        public string? Efolderid { get; set; }
        public string? FormNumber { get; set; }
        public string? SappersonnelNumber { get; set; }
        public string? PersonnelAdaccount { get; set; }
        public string? PersonelNameSurname { get; set; }
        public string? PermissionTypeCode { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
        public string? ReturnToWorkDate { get; set; }
        public string? StatusCode { get; set; }
        public string? StatusDefinition { get; set; }
        public string? ExcuseLeaveStartDate { get; set; }
        public string? ExcuseLeaveEndDate { get; set; }
        public string? PermissionSubTypeDetailCode { get; set; }
        public string? PermissionSubTypeDetailDefinition { get; set; }
        public string? PermissionSubTypeDetailExplanationCode { get; set; }
        public string? PermissionSubTypeDetailExplanation { get; set; }
        public string? PermissionTypeDefinition { get; set; }
        public string? PermissionSubTypeDefinition { get; set; }
    }
}
