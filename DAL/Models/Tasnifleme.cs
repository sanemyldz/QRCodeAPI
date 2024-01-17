using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Tasnifleme
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public DateTime Giris { get; set; }
        public int GirisId { get; set; }
        public int GirisKayitTipi { get; set; }
        public DateTime? Cikis { get; set; }
        public int CikisId { get; set; }
        public int CikisKayitTipi { get; set; }
        public int MesaiSuresi { get; set; }
        public int HamFazlaMesai { get; set; }
        public int NormalMesai { get; set; }
        public int OnaylananFazlaMesai { get; set; }
        public int FazlaMesai { get; set; }
        public int ErkenMesai { get; set; }
        public int FazlamesaiOran { get; set; }
        public int EksikmesaiOran { get; set; }
        public int ResmiTatil { get; set; }
        public string? MesaiAciklama { get; set; }
        public int IzinTip { get; set; }
        public int IzinSaat { get; set; }
        public int? MesaiPeriyodu { get; set; }
        public int Mesaigrubu { get; set; }
        public int Mesaibirimi { get; set; }
        public bool Ayrinti { get; set; }
        public int Tatil { get; set; }
        public bool _24pass { get; set; }
        public bool Kilit { get; set; }
        public bool Ucretli { get; set; }
        public int ResmiTatilMesai { get; set; }
        public int GeceVardiya { get; set; }
        public int Hakedis { get; set; }
        public bool UpdateLock { get; set; }
        public DateTime? MesaiTarih { get; set; }
        public int Izinsaat2 { get; set; }
        public DateTime? Ggiris { get; set; }
        public DateTime? Index { get; set; }
        public DateTime? Gcikis { get; set; }
        public int? Xfm1 { get; set; }
        public int? Xfm1Oran { get; set; }
        public int? Fmneden { get; set; }
        public int? Xfm2 { get; set; }
        public int? Xfm2Oran { get; set; }
        public int? AraSure { get; set; }
        public int? IzinId { get; set; }
        public string? MesaiOzetAciklama { get; set; }
        public string? Itfaciklama { get; set; }
        public string? Sgfaciklama { get; set; }
        public int? ToplamIzinSuresi { get; set; }
        public int? UcretliIzinSure { get; set; }
        public int? UcretsizIzinSure { get; set; }
        public string? IzinIdList { get; set; }
        public string? FazlaMesaiNedeni { get; set; }
        public int? TalepEdilenFmsure { get; set; }
        public bool? ManuelMesaiTanimi { get; set; }
        public int? DayOfYear { get; set; }
        public bool? OtomatikPeriyod { get; set; }
        public bool? Hesapla { get; set; }
        public bool? Kilitli { get; set; }
        public int? FaraSure { get; set; }

        public virtual Sicil Sicil { get; set; } = null!;
    }
}
