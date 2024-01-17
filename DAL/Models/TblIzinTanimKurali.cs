using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TblIzinTanimKurali
    {
        public TblIzinTanimKurali()
        {
            TblIzinKidemKuralis = new HashSet<TblIzinKidemKurali>();
            TblIzinLimitKuralis = new HashSet<TblIzinLimitKurali>();
            TblIzinYasKuralis = new HashSet<TblIzinYasKurali>();
            TblSicilIzinKurals = new HashSet<TblSicilIzinKural>();
            TblSicilKalanKullanilanIzins = new HashSet<TblSicilKalanKullanilanIzin>();
        }

        public int Id { get; set; }
        public string KuralAdi { get; set; } = null!;
        public int VarsayilanMesaiSuresi { get; set; }
        public int NegatifIzinBakiye { get; set; }
        public bool VarsayilanKural { get; set; }
        public int IlkHakEdilenIzinHakki { get; set; }
        public int IzinHesaplamaTipId { get; set; }
        public int VarsayilanIzinTipId { get; set; }
        public bool TalepDosyasiGereklidir { get; set; }
        public bool Deleted { get; set; }

        public virtual TblSysIzinHesaplamaTipi IzinHesaplamaTip { get; set; } = null!;
        public virtual ICollection<TblIzinKidemKurali> TblIzinKidemKuralis { get; set; }
        public virtual ICollection<TblIzinLimitKurali> TblIzinLimitKuralis { get; set; }
        public virtual ICollection<TblIzinYasKurali> TblIzinYasKuralis { get; set; }
        public virtual ICollection<TblSicilIzinKural> TblSicilIzinKurals { get; set; }
        public virtual ICollection<TblSicilKalanKullanilanIzin> TblSicilKalanKullanilanIzins { get; set; }
    }
}
