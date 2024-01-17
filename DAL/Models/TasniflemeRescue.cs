using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TasniflemeRescue
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
    }
}
