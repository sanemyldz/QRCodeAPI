using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Menu
    {
        public int Id { get; set; }
        public int Login { get; set; }
        public int Program { get; set; }
        public bool Active { get; set; }
        public bool Flag { get; set; }

        public virtual Login LoginNavigation { get; set; } = null!;
    }
}
