using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Mesailer
    {
        public Mesailer()
        {
            DinlenmeAtamalaris = new HashSet<DinlenmeAtamalari>();
            MesaiGruplariUyeleris = new HashSet<MesaiGruplariUyeleri>();
            SicilHaftaTatilis = new HashSet<SicilHaftaTatili>();
            Yuvarlamalars = new HashSet<Yuvarlamalar>();
        }

        public int Id { get; set; }
        public int MesaiBas { get; set; }
        public int MesaiBit { get; set; }
        public int NormalSure { get; set; }
        public int EncokSure { get; set; }
        public int EnAzSure { get; set; }
        public int EnAzFazlaMesai { get; set; }
        public int FazlaMesaiHassasiyeti { get; set; }
        public int FazlaMesaiYuzde { get; set; }
        public int EksikMesaiYuzde { get; set; }
        public int EksikGunYuzde { get; set; }
        public int YarimGunSaat { get; set; }
        public string Aciklama { get; set; } = null!;
        public string Kod { get; set; } = null!;
        public bool GeceMesaisi { get; set; }
        public int SerbestMesaiHassasiyeti { get; set; }
        public int EnCokFazlaMesai { get; set; }
        public int NetSure { get; set; }
        public int? Xfm1basi { get; set; }
        public int? Xfm1sonu { get; set; }
        public int? Xfm2basi { get; set; }
        public int? Xfm2sonu { get; set; }
        public int? Xfm1oran { get; set; }
        public int? Xfm2oran { get; set; }
        public int? Artiek { get; set; }
        public int? Eksiek { get; set; }
        public int? Tatilgunu { get; set; }
        public int? GecTolerans { get; set; }
        public int? ErkenTolerans { get; set; }
        public bool ErkenMesaiEtkin { get; set; }
        public bool FazlaMesaiEtkin { get; set; }
        public int? MinimumErkenMesaiSure { get; set; }
        public int? MinimumFazlaMesaiSure { get; set; }
        public int? MesaiToplamDinlenmeSuresi { get; set; }
        public bool? OncekiGunMesaisi { get; set; }
        public int? MesaiIciDinlenmeSuresi { get; set; }
        public int? MesaiDisiDinlenmeSuresi { get; set; }
        public int? FmhesapTipi { get; set; }
        public int? FmesikSuresi { get; set; }
        public bool? HaftaSonuMesaisi { get; set; }
        public int? OpsiyonelDinlenmeSuresi { get; set; }
        public int? MaksGirisSapma { get; set; }
        public int? MaksCikisSapma { get; set; }
        public bool TatilDinlenmesiDus { get; set; }
        public int? GeceMesaiBaslangic { get; set; }
        public int? GeceMesaiBitis { get; set; }
        public int? TumGunMesai { get; set; }
        public int HesaplamaTipId { get; set; }
        public int FazlaMesaiYuvarlama { get; set; }
        public int PdksCikisGirisToleransi { get; set; }
        public int? CekirdekCalismaBaslangic { get; set; }
        public int? CekirdekCalismaBitis { get; set; }
        public int? CekirdekCalismaliEsnekMesaideOrtalamaMesaiSuresi { get; set; }
        public int? EksikCalismaToleransi { get; set; }
        public bool? ToleransiEksikCalismadanDus { get; set; }
        public int? CekirdekCalismaliEsnekMesaideYarimGunMesaiSuresi { get; set; }
        public bool? TatilFazlaMesaiSinirlandir { get; set; }
        public int? FazlaMesaiUstLimit { get; set; }

        public virtual HesaplamaTipleri HesaplamaTip { get; set; } = null!;
        public virtual ICollection<DinlenmeAtamalari> DinlenmeAtamalaris { get; set; }
        public virtual ICollection<MesaiGruplariUyeleri> MesaiGruplariUyeleris { get; set; }
        public virtual ICollection<SicilHaftaTatili> SicilHaftaTatilis { get; set; }
        public virtual ICollection<Yuvarlamalar> Yuvarlamalars { get; set; }
    }
}
