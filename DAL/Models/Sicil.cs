using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Sicil
    {
        public Sicil()
        {
            AnketSonucs = new HashSet<AnketSonuc>();
            CariIslemlers = new HashSet<CariIslemler>();
            EgitimKatilimcilars = new HashSet<EgitimKatilimcilar>();
            Egitimlers = new HashSet<Egitimler>();
            HysTblKullanicilars = new HashSet<HysTblKullanicilar>();
            HysTblKullaniciyaAtananSureclers = new HashSet<HysTblKullaniciyaAtananSurecler>();
            HysTblMasrafTalepleris = new HashSet<HysTblMasrafTalepleri>();
            HysTblSeyahatIstekleris = new HashSet<HysTblSeyahatIstekleri>();
            Izinlers = new HashSet<Izinler>();
            OtomatikTransfers = new HashSet<OtomatikTransfer>();
            Pass24s = new HashSet<Pass24>();
            PeriyodikOdemelers = new HashSet<PeriyodikOdemeler>();
            SerbestMesaiBilgisis = new HashSet<SerbestMesaiBilgisi>();
            SicilAttaches = new HashSet<SicilAttach>();
            SicilGroupMembers = new HashSet<SicilGroupMember>();
            SicilHaftaTatilis = new HashSet<SicilHaftaTatili>();
            Tasniflemes = new HashSet<Tasnifleme>();
            TblIzinAkisSicilOnays = new HashSet<TblIzinAkisSicilOnay>();
            TblSicilBirimLogs = new HashSet<TblSicilBirimLog>();
            TblSicilIzinKurals = new HashSet<TblSicilIzinKural>();
            TblSicilIzinMasters = new HashSet<TblSicilIzinMaster>();
            TblSicilKalanHaks = new HashSet<TblSicilKalanHak>();
            TblSicilKalanKullanilanIzins = new HashSet<TblSicilKalanKullanilanIzin>();
            TblSicilYemekhanes = new HashSet<TblSicilYemekhane>();
            UrunSicilHakedis = new HashSet<UrunSicilHakedi>();
            UrunSiparis = new HashSet<UrunSipari>();
            UrunSiparisDetays = new HashSet<UrunSiparisDetay>();
            UserListTmps = new HashSet<UserListTmp>();
        }

        public int Id { get; set; }
        public string? UserId { get; set; }
        public int? Firma { get; set; }
        public int? TerminalGrubu { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? PersonelNo { get; set; }
        public DateTime? GirisTarih { get; set; }
        public DateTime? CikisTarih { get; set; }
        public string? SicilNo { get; set; }
        public int? Pozisyon { get; set; }
        public int? Bolum { get; set; }
        public string? Telefon1 { get; set; }
        public string? Telefon2 { get; set; }
        public string? CepTelefon { get; set; }
        public string? Adres { get; set; }
        public string? Il { get; set; }
        public string? Ilce { get; set; }
        public int? KanGrubu { get; set; }
        public byte[]? FotoImage { get; set; }
        public string? Bilgi { get; set; }
        public int MesaiPeriyodu { get; set; }
        public DateTime? PeriyodBaslangici { get; set; }
        public bool SonDurum { get; set; }
        public DateTime ExpireDate { get; set; }
        public bool FazlaMesai { get; set; }
        public bool EksikMesai { get; set; }
        public bool EksikMesaiFm { get; set; }
        public bool ErkenMesai { get; set; }
        public bool EksikGun { get; set; }
        public int MaasTipi { get; set; }
        public int Maas { get; set; }
        public float AylikCalismaSaati { get; set; }
        public int SonTasnifId { get; set; }
        public byte? SicilKilit { get; set; }
        public DateTime? DogumTarih { get; set; }
        public string? Okod1 { get; set; }
        public string? Okod2 { get; set; }
        public string? Okod3 { get; set; }
        public string? Okod4 { get; set; }
        public string? Okod5 { get; set; }
        public string? Okod6 { get; set; }
        public string? Okod7 { get; set; }
        public string? Okod8 { get; set; }
        public string? Okod9 { get; set; }
        public string? Okod10 { get; set; }
        public bool GeceZammi { get; set; }
        public bool FmEm { get; set; }
        public int? Gorev { get; set; }
        public DateTime? Bitistarih { get; set; }
        public int? AltFirma { get; set; }
        public int? Cinsiyet { get; set; }
        public string? Email { get; set; }
        public int? Direktorluk { get; set; }
        public int? Yaka { get; set; }
        public int? Puantaj { get; set; }
        public DateTime? KidemTarih { get; set; }
        public int? BirimId { get; set; }
        public string? PictureId { get; set; }
        public bool? ZiyaretciKabulDurum { get; set; }
        public int? GorevId { get; set; }
        public bool Deleted { get; set; }
        public int? AmirId { get; set; }
        public string? GlobalSicilId { get; set; }
        public bool? IlkGirisSonCikisAktif { get; set; }
        public bool? FabrikadaYemekYer { get; set; }
        public int? ServisGuzergahId { get; set; }
        public string? YetkiStr { get; set; }
        public string? YetkiStrAd { get; set; }
        public int? SgkDurum { get; set; }
        public string? IstenAyrilisNedeni { get; set; }
        public int? YakaTipi { get; set; }
        public string? Iban { get; set; }
        public string? AcilDurumIrtibatKisisi { get; set; }
        public string? AcilDurumIrtibatKisisiEvTel { get; set; }
        public string? AcilDurumIrtibatKisisiIsTel { get; set; }
        public int? IzinAkisId { get; set; }
        public string? HesCode { get; set; }
        public bool? GeciciKartBirimBazli { get; set; }
        public int? YapilacakFazlaMesaiAkisId { get; set; }
        public int? TaseronFirmaId { get; set; }

        public virtual CboBolum? BolumNavigation { get; set; }
        public virtual CboFirma? FirmaNavigation { get; set; }
        public virtual CboGorev? GorevNavigation { get; set; }
        public virtual CboPozisyon? PozisyonNavigation { get; set; }
        public virtual TerminalGroup? TerminalGrubuNavigation { get; set; }
        public virtual Message? Message { get; set; }
        public virtual ICollection<AnketSonuc> AnketSonucs { get; set; }
        public virtual ICollection<CariIslemler> CariIslemlers { get; set; }
        public virtual ICollection<EgitimKatilimcilar> EgitimKatilimcilars { get; set; }
        public virtual ICollection<Egitimler> Egitimlers { get; set; }
        public virtual ICollection<HysTblKullanicilar> HysTblKullanicilars { get; set; }
        public virtual ICollection<HysTblKullaniciyaAtananSurecler> HysTblKullaniciyaAtananSureclers { get; set; }
        public virtual ICollection<HysTblMasrafTalepleri> HysTblMasrafTalepleris { get; set; }
        public virtual ICollection<HysTblSeyahatIstekleri> HysTblSeyahatIstekleris { get; set; }
        public virtual ICollection<Izinler> Izinlers { get; set; }
        public virtual ICollection<OtomatikTransfer> OtomatikTransfers { get; set; }
        public virtual ICollection<Pass24> Pass24s { get; set; }
        public virtual ICollection<PeriyodikOdemeler> PeriyodikOdemelers { get; set; }
        public virtual ICollection<SerbestMesaiBilgisi> SerbestMesaiBilgisis { get; set; }
        public virtual ICollection<SicilAttach> SicilAttaches { get; set; }
        public virtual ICollection<SicilGroupMember> SicilGroupMembers { get; set; }
        public virtual ICollection<SicilHaftaTatili> SicilHaftaTatilis { get; set; }
        public virtual ICollection<Tasnifleme> Tasniflemes { get; set; }
        public virtual ICollection<TblIzinAkisSicilOnay> TblIzinAkisSicilOnays { get; set; }
        public virtual ICollection<TblSicilBirimLog> TblSicilBirimLogs { get; set; }
        public virtual ICollection<TblSicilIzinKural> TblSicilIzinKurals { get; set; }
        public virtual ICollection<TblSicilIzinMaster> TblSicilIzinMasters { get; set; }
        public virtual ICollection<TblSicilKalanHak> TblSicilKalanHaks { get; set; }
        public virtual ICollection<TblSicilKalanKullanilanIzin> TblSicilKalanKullanilanIzins { get; set; }
        public virtual ICollection<TblSicilYemekhane> TblSicilYemekhanes { get; set; }
        public virtual ICollection<UrunSicilHakedi> UrunSicilHakedis { get; set; }
        public virtual ICollection<UrunSipari> UrunSiparis { get; set; }
        public virtual ICollection<UrunSiparisDetay> UrunSiparisDetays { get; set; }
        public virtual ICollection<UserListTmp> UserListTmps { get; set; }
    }
}
