using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblMailYetkiliRaporlar
    {
        public int Id { get; set; }
        public int MailId { get; set; }
        public int MailRaporId { get; set; }
        public int HaftalikDurum { get; set; }
        public int? AylikDurum { get; set; }
        public int? AcilDurum { get; set; }

        public virtual TblSysMailRaporlar MailRapor { get; set; } = null!;
    }
}
