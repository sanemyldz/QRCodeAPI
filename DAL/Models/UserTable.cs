using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class UserTable
    {
        public UserTable()
        {
            DinamikRaporSearchParams = new HashSet<DinamikRaporSearchParam>();
            TblIzinAkisSicilOnays = new HashSet<TblIzinAkisSicilOnay>();
            TblSicilBirimLogs = new HashSet<TblSicilBirimLog>();
            TblUserSearchParams = new HashSet<TblUserSearchParam>();
            Roles = new HashSet<WebpagesRole>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; } = null!;

        public virtual ICollection<DinamikRaporSearchParam> DinamikRaporSearchParams { get; set; }
        public virtual ICollection<TblIzinAkisSicilOnay> TblIzinAkisSicilOnays { get; set; }
        public virtual ICollection<TblSicilBirimLog> TblSicilBirimLogs { get; set; }
        public virtual ICollection<TblUserSearchParam> TblUserSearchParams { get; set; }

        public virtual ICollection<WebpagesRole> Roles { get; set; }
    }
}
