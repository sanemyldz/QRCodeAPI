using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Login
    {
        public Login()
        {
            Menus = new HashSet<Menu>();
        }

        public int Id { get; set; }
        public string LoginName { get; set; } = null!;
        public string? Password { get; set; }
        public bool TerminalServer { get; set; }
        public bool Admin { get; set; }
        public int TerminalGrubu { get; set; }
        public bool Flag { get; set; }
        public int Yetki { get; set; }
        public int Firma { get; set; }
        public int Pozisyon { get; set; }
        public int Bolum { get; set; }
        public int SicilGroup { get; set; }
        public string? Pcip { get; set; }
        public int Gorev { get; set; }
        public int? Kademe { get; set; }
        public int? AltFirma { get; set; }
        public int? XSicilId { get; set; }
        public string YetkiGrubu { get; set; } = null!;

        public virtual ICollection<Menu> Menus { get; set; }
    }
}
