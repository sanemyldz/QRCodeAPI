using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Models
{
    public partial class DEVELOP_MEYERContext : DbContext
    {
        public DEVELOP_MEYERContext()
        {
        }

        public DEVELOP_MEYERContext(DbContextOptions<DEVELOP_MEYERContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Access> Accesses { get; set; } = null!;
        public virtual DbSet<Activation> Activations { get; set; } = null!;
        public virtual DbSet<Aktarim> Aktarims { get; set; } = null!;
        public virtual DbSet<Aktarimhr> Aktarimhrs { get; set; } = null!;
        public virtual DbSet<AnketSonuc> AnketSonucs { get; set; } = null!;
        public virtual DbSet<AnketSoru> AnketSorus { get; set; } = null!;
        public virtual DbSet<AnketSoruCevap> AnketSoruCevaps { get; set; } = null!;
        public virtual DbSet<AnketTamamlanan> AnketTamamlanans { get; set; } = null!;
        public virtual DbSet<AnketTanim> AnketTanims { get; set; } = null!;
        public virtual DbSet<AraKayitlar> AraKayitlars { get; set; } = null!;
        public virtual DbSet<Arac> Aracs { get; set; } = null!;
        public virtual DbSet<AuthLog> AuthLogs { get; set; } = null!;
        public virtual DbSet<BakiyeGuncelleIslem> BakiyeGuncelleIslems { get; set; } = null!;
        public virtual DbSet<BioPlu> BioPlus { get; set; } = null!;
        public virtual DbSet<BioPlusServer> BioPlusServers { get; set; } = null!;
        public virtual DbSet<Bordro> Bordros { get; set; } = null!;
        public virtual DbSet<CariIslemler> CariIslemlers { get; set; } = null!;
        public virtual DbSet<CboAltFirma> CboAltFirmas { get; set; } = null!;
        public virtual DbSet<CboAracCinsi> CboAracCinsis { get; set; } = null!;
        public virtual DbSet<CboBolum> CboBolums { get; set; } = null!;
        public virtual DbSet<CboCalismaTip> CboCalismaTips { get; set; } = null!;
        public virtual DbSet<CboDirektorluk> CboDirektorluks { get; set; } = null!;
        public virtual DbSet<CboEkOdeme> CboEkOdemes { get; set; } = null!;
        public virtual DbSet<CboFirma> CboFirmas { get; set; } = null!;
        public virtual DbSet<CboFmnedenleri> CboFmnedenleris { get; set; } = null!;
        public virtual DbSet<CboGercekKategori> CboGercekKategoris { get; set; } = null!;
        public virtual DbSet<CboGorev> CboGorevs { get; set; } = null!;
        public virtual DbSet<CboGorevli> CboGorevlis { get; set; } = null!;
        public virtual DbSet<CboIsCikisNedeni> CboIsCikisNedenis { get; set; } = null!;
        public virtual DbSet<CboIsCikisNedeniSgk> CboIsCikisNedeniSgks { get; set; } = null!;
        public virtual DbSet<CboIzinHakki> CboIzinHakkis { get; set; } = null!;
        public virtual DbSet<CboKimlik> CboKimliks { get; set; } = null!;
        public virtual DbSet<CboOzlukAlan> CboOzlukAlans { get; set; } = null!;
        public virtual DbSet<CboOzlukBolum> CboOzlukBolums { get; set; } = null!;
        public virtual DbSet<CboOzlukGorev> CboOzlukGorevs { get; set; } = null!;
        public virtual DbSet<CboOzlukGorevYeri> CboOzlukGorevYeris { get; set; } = null!;
        public virtual DbSet<CboOzlukHizmetGorev> CboOzlukHizmetGorevs { get; set; } = null!;
        public virtual DbSet<CboOzlukHizmetKadro> CboOzlukHizmetKadros { get; set; } = null!;
        public virtual DbSet<CboOzlukKadro> CboOzlukKadros { get; set; } = null!;
        public virtual DbSet<CboOzlukOkul> CboOzlukOkuls { get; set; } = null!;
        public virtual DbSet<CboPozisyon> CboPozisyons { get; set; } = null!;
        public virtual DbSet<CboPuantaj> CboPuantajs { get; set; } = null!;
        public virtual DbSet<CboSaglikRapor> CboSaglikRapors { get; set; } = null!;
        public virtual DbSet<CboSendikaUnvan> CboSendikaUnvans { get; set; } = null!;
        public virtual DbSet<CboSgkbilgi> CboSgkbilgis { get; set; } = null!;
        public virtual DbSet<CboSicil> CboSicils { get; set; } = null!;
        public virtual DbSet<CboSirket> CboSirkets { get; set; } = null!;
        public virtual DbSet<CboSirketArac> CboSirketAracs { get; set; } = null!;
        public virtual DbSet<CboSirketBilgisayar> CboSirketBilgisayars { get; set; } = null!;
        public virtual DbSet<CboSirketTelefonCihaz> CboSirketTelefonCihazs { get; set; } = null!;
        public virtual DbSet<CboStatu> CboStatus { get; set; } = null!;
        public virtual DbSet<CboTaseronFirma> CboTaseronFirmas { get; set; } = null!;
        public virtual DbSet<CboTimezone> CboTimezones { get; set; } = null!;
        public virtual DbSet<CboUcakBiletHakki> CboUcakBiletHakkis { get; set; } = null!;
        public virtual DbSet<CboUnvan> CboUnvans { get; set; } = null!;
        public virtual DbSet<CboVizeKategori> CboVizeKategoris { get; set; } = null!;
        public virtual DbSet<CboYaka> CboYakas { get; set; } = null!;
        public virtual DbSet<Checkup> Checkups { get; set; } = null!;
        public virtual DbSet<CiftayDetayliFazlaMesaiRaporu> CiftayDetayliFazlaMesaiRaporus { get; set; } = null!;
        public virtual DbSet<CihazDurum> CihazDurums { get; set; } = null!;
        public virtual DbSet<ClockworkBellControl> ClockworkBellControls { get; set; } = null!;
        public virtual DbSet<CompanyInfo> CompanyInfos { get; set; } = null!;
        public virtual DbSet<Creport> Creports { get; set; } = null!;
        public virtual DbSet<CustomReport> CustomReports { get; set; } = null!;
        public virtual DbSet<DayLight> DayLights { get; set; } = null!;
        public virtual DbSet<DebugmoniTor> DebugmoniTors { get; set; } = null!;
        public virtual DbSet<Denied> Denieds { get; set; } = null!;
        public virtual DbSet<DeviceYetki> DeviceYetkis { get; set; } = null!;
        public virtual DbSet<DeviceYetkiLog> DeviceYetkiLogs { get; set; } = null!;
        public virtual DbSet<DinamikLokasyon> DinamikLokasyons { get; set; } = null!;
        public virtual DbSet<DinamikRaporJoin> DinamikRaporJoins { get; set; } = null!;
        public virtual DbSet<DinamikRaporKolon> DinamikRaporKolons { get; set; } = null!;
        public virtual DbSet<DinamikRaporSearchParam> DinamikRaporSearchParams { get; set; } = null!;
        public virtual DbSet<DinamikRaporSecim> DinamikRaporSecims { get; set; } = null!;
        public virtual DbSet<DinamikRaporTip> DinamikRaporTips { get; set; } = null!;
        public virtual DbSet<DinamikRaporlar> DinamikRaporlars { get; set; } = null!;
        public virtual DbSet<DinlenmeAtamalari> DinlenmeAtamalaris { get; set; } = null!;
        public virtual DbSet<Dinlenmeler> Dinlenmelers { get; set; } = null!;
        public virtual DbSet<DoorControl> DoorControls { get; set; } = null!;
        public virtual DbSet<Doorduty> Doorduties { get; set; } = null!;
        public virtual DbSet<Duty> Duties { get; set; } = null!;
        public virtual DbSet<DutyOther> DutyOthers { get; set; } = null!;
        public virtual DbSet<DuyuruTanim> DuyuruTanims { get; set; } = null!;
        public virtual DbSet<EgitimKatilimcilar> EgitimKatilimcilars { get; set; } = null!;
        public virtual DbSet<Egitimler> Egitimlers { get; set; } = null!;
        public virtual DbSet<EkYetkiler> EkYetkilers { get; set; } = null!;
        public virtual DbSet<Email> Emails { get; set; } = null!;
        public virtual DbSet<Export> Exports { get; set; } = null!;
        public virtual DbSet<FirmaBilgisi> FirmaBilgisis { get; set; } = null!;
        public virtual DbSet<Fmplanlari> Fmplanlaris { get; set; } = null!;
        public virtual DbSet<Forceddoor> Forceddoors { get; set; } = null!;
        public virtual DbSet<Fotograf> Fotografs { get; set; } = null!;
        public virtual DbSet<Function> Functions { get; set; } = null!;
        public virtual DbSet<GeciciKartGecisListesi> GeciciKartGecisListesis { get; set; } = null!;
        public virtual DbSet<GorevlendirmeTipler> GorevlendirmeTiplers { get; set; } = null!;
        public virtual DbSet<Gorevlendirmeler> Gorevlendirmelers { get; set; } = null!;
        public virtual DbSet<Guncelleme> Guncellemes { get; set; } = null!;
        public virtual DbSet<HbysAktarim> HbysAktarims { get; set; } = null!;
        public virtual DbSet<HesaplamaTipleri> HesaplamaTipleris { get; set; } = null!;
        public virtual DbSet<HesaplayiciIstisnalar> HesaplayiciIstisnalars { get; set; } = null!;
        public virtual DbSet<Holiday> Holidays { get; set; } = null!;
        public virtual DbSet<HysTblGorevler> HysTblGorevlers { get; set; } = null!;
        public virtual DbSet<HysTblKullaniciRolleri> HysTblKullaniciRolleris { get; set; } = null!;
        public virtual DbSet<HysTblKullanicilar> HysTblKullanicilars { get; set; } = null!;
        public virtual DbSet<HysTblKullaniciyaAtananSurecler> HysTblKullaniciyaAtananSureclers { get; set; } = null!;
        public virtual DbSet<HysTblMasrafOnaylari> HysTblMasrafOnaylaris { get; set; } = null!;
        public virtual DbSet<HysTblMasrafTalepleri> HysTblMasrafTalepleris { get; set; } = null!;
        public virtual DbSet<HysTblMasrafTuru> HysTblMasrafTurus { get; set; } = null!;
        public virtual DbSet<HysTblMasraflar> HysTblMasraflars { get; set; } = null!;
        public virtual DbSet<HysTblOdemeSekli> HysTblOdemeSeklis { get; set; } = null!;
        public virtual DbSet<HysTblOnaySurecleri> HysTblOnaySurecleris { get; set; } = null!;
        public virtual DbSet<HysTblOnaycilar> HysTblOnaycilars { get; set; } = null!;
        public virtual DbSet<HysTblSeyahatIstekleri> HysTblSeyahatIstekleris { get; set; } = null!;
        public virtual DbSet<HysTblSeyahatOnaylari> HysTblSeyahatOnaylaris { get; set; } = null!;
        public virtual DbSet<HysTblSeyahatler> HysTblSeyahatlers { get; set; } = null!;
        public virtual DbSet<HysTblUlasimAraclari> HysTblUlasimAraclaris { get; set; } = null!;
        public virtual DbSet<HysVwSicilListesi> HysVwSicilListesis { get; set; } = null!;
        public virtual DbSet<IsGorevTanim> IsGorevTanims { get; set; } = null!;
        public virtual DbSet<IzinGirisFormu> IzinGirisFormus { get; set; } = null!;
        public virtual DbSet<IzinTalepBakiye> IzinTalepBakiyes { get; set; } = null!;
        public virtual DbSet<IzinTipleri> IzinTipleris { get; set; } = null!;
        public virtual DbSet<Izinler> Izinlers { get; set; } = null!;
        public virtual DbSet<IzinlerLog> IzinlerLogs { get; set; } = null!;
        public virtual DbSet<JsonLog> JsonLogs { get; set; } = null!;
        public virtual DbSet<KafeteryaHarcamaLimit> KafeteryaHarcamaLimits { get; set; } = null!;
        public virtual DbSet<KafeteryaKalanHakLog> KafeteryaKalanHakLogs { get; set; } = null!;
        public virtual DbSet<KafeteryaLog> KafeteryaLogs { get; set; } = null!;
        public virtual DbSet<KafeteryaOnaysizFazlaMesai> KafeteryaOnaysizFazlaMesais { get; set; } = null!;
        public virtual DbSet<KrediTakip> KrediTakips { get; set; } = null!;
        public virtual DbSet<KullaniciRolTanimlari> KullaniciRolTanimlaris { get; set; } = null!;
        public virtual DbSet<Licence> Licences { get; set; } = null!;
        public virtual DbSet<LiftTemplate> LiftTemplates { get; set; } = null!;
        public virtual DbSet<Login> Logins { get; set; } = null!;
        public virtual DbSet<MailDuty> MailDuties { get; set; } = null!;
        public virtual DbSet<MailRapor> MailRapors { get; set; } = null!;
        public virtual DbSet<Menu> Menus { get; set; } = null!;
        public virtual DbSet<MesaiGruplari> MesaiGruplaris { get; set; } = null!;
        public virtual DbSet<MesaiGruplariUyeleri> MesaiGruplariUyeleris { get; set; } = null!;
        public virtual DbSet<MesaiPeriyodlari> MesaiPeriyodlaris { get; set; } = null!;
        public virtual DbSet<MesaiPeriyodlariUyeleri> MesaiPeriyodlariUyeleris { get; set; } = null!;
        public virtual DbSet<MesaiYakalamaTipleri> MesaiYakalamaTipleris { get; set; } = null!;
        public virtual DbSet<Mesailer> Mesailers { get; set; } = null!;
        public virtual DbSet<Message> Messages { get; set; } = null!;
        public virtual DbSet<MeyerExport> MeyerExports { get; set; } = null!;
        public virtual DbSet<MeyerExportIstek> MeyerExportIsteks { get; set; } = null!;
        public virtual DbSet<MobilGirisCiki> MobilGirisCikis { get; set; } = null!;
        public virtual DbSet<MobilKomut> MobilKomuts { get; set; } = null!;
        public virtual DbSet<MobilKomutGrup> MobilKomutGrups { get; set; } = null!;
        public virtual DbSet<MobilKullanici> MobilKullanicis { get; set; } = null!;
        public virtual DbSet<MobilTur> MobilTurs { get; set; } = null!;
        public virtual DbSet<MobilTurDetay> MobilTurDetays { get; set; } = null!;
        public virtual DbSet<MobileAppUser> MobileAppUsers { get; set; } = null!;
        public virtual DbSet<MobileDeviceLog> MobileDeviceLogs { get; set; } = null!;
        public virtual DbSet<Moduller> Modullers { get; set; } = null!;
        public virtual DbSet<Monitor> Monitors { get; set; } = null!;
        public virtual DbSet<Monitoring> Monitorings { get; set; } = null!;
        public virtual DbSet<NetsisFbutonGirisCiki> NetsisFbutonGirisCikis { get; set; } = null!;
        public virtual DbSet<NetsisIlkGirisSonCiki> NetsisIlkGirisSonCikis { get; set; } = null!;
        public virtual DbSet<NetsisOglenGirisCiki> NetsisOglenGirisCikis { get; set; } = null!;
        public virtual DbSet<NetworkInfo> NetworkInfos { get; set; } = null!;
        public virtual DbSet<OglenUyumsuzGecisler> OglenUyumsuzGecislers { get; set; } = null!;
        public virtual DbSet<OneTowerAktarim> OneTowerAktarims { get; set; } = null!;
        public virtual DbSet<OtomatikTransfer> OtomatikTransfers { get; set; } = null!;
        public virtual DbSet<Otopark> Otoparks { get; set; } = null!;
        public virtual DbSet<OzelKodTanim> OzelKodTanims { get; set; } = null!;
        public virtual DbSet<ParaBirimleri> ParaBirimleris { get; set; } = null!;
        public virtual DbSet<Parameter> Parameters { get; set; } = null!;
        public virtual DbSet<Pass24> Pass24s { get; set; } = null!;
        public virtual DbSet<PeriyodikOdemeler> PeriyodikOdemelers { get; set; } = null!;
        public virtual DbSet<PersonelBilgileri> PersonelBilgileris { get; set; } = null!;
        public virtual DbSet<PersonelGeriBildirim> PersonelGeriBildirims { get; set; } = null!;
        public virtual DbSet<PersonelGirisCikisRaporu> PersonelGirisCikisRaporus { get; set; } = null!;
        public virtual DbSet<PersonelItiraz> PersonelItirazs { get; set; } = null!;
        public virtual DbSet<Pool> Pools { get; set; } = null!;
        public virtual DbSet<PoolSuspect> PoolSuspects { get; set; } = null!;
        public virtual DbSet<Poolgunler> Poolgunlers { get; set; } = null!;
        public virtual DbSet<ProcessedDuty> ProcessedDuties { get; set; } = null!;
        public virtual DbSet<RawDataOzet> RawDataOzets { get; set; } = null!;
        public virtual DbSet<RawDatum> RawData { get; set; } = null!;
        public virtual DbSet<Recovery> Recoveries { get; set; } = null!;
        public virtual DbSet<RepairLog> RepairLogs { get; set; } = null!;
        public virtual DbSet<Report> Reports { get; set; } = null!;
        public virtual DbSet<Report1> Reports1 { get; set; } = null!;
        public virtual DbSet<ReportsSetting> ReportsSettings { get; set; } = null!;
        public virtual DbSet<Sablonlar> Sablonlars { get; set; } = null!;
        public virtual DbSet<SablonlarDetay> SablonlarDetays { get; set; } = null!;
        public virtual DbSet<SdtuserAktarim> SdtuserAktarims { get; set; } = null!;
        public virtual DbSet<SelectIzinSuresiRaporu> SelectIzinSuresiRaporus { get; set; } = null!;
        public virtual DbSet<SelectIzinSuresiRaporu2> SelectIzinSuresiRaporu2s { get; set; } = null!;
        public virtual DbSet<SelectPdk> SelectPdks { get; set; } = null!;
        public virtual DbSet<SelectSicilOzelYetki> SelectSicilOzelYetkis { get; set; } = null!;
        public virtual DbSet<SelectSicilUserList> SelectSicilUserLists { get; set; } = null!;
        public virtual DbSet<SelectTumGeci> SelectTumGecis { get; set; } = null!;
        public virtual DbSet<SelectTumGeci1> SelectTumGecis1 { get; set; } = null!;
        public virtual DbSet<SelectYetkİ> SelectYetkİs { get; set; } = null!;
        public virtual DbSet<SerbestMesaiBilgisi> SerbestMesaiBilgisis { get; set; } = null!;
        public virtual DbSet<Sicil> Sicils { get; set; } = null!;
        public virtual DbSet<Sicil017> Sicil017s { get; set; } = null!;
        public virtual DbSet<SicilAttach> SicilAttaches { get; set; } = null!;
        public virtual DbSet<SicilEkParametrikIzin> SicilEkParametrikIzins { get; set; } = null!;
        public virtual DbSet<SicilFoto> SicilFotos { get; set; } = null!;
        public virtual DbSet<SicilGroup> SicilGroups { get; set; } = null!;
        public virtual DbSet<SicilGroupMember> SicilGroupMembers { get; set; } = null!;
        public virtual DbSet<SicilHaftaTatili> SicilHaftaTatilis { get; set; } = null!;
        public virtual DbSet<SicilLog> SicilLogs { get; set; } = null!;
        public virtual DbSet<SicilRescue> SicilRescues { get; set; } = null!;
        public virtual DbSet<Sicilfromsap> Sicilfromsaps { get; set; } = null!;
        public virtual DbSet<Sifre> Sifres { get; set; } = null!;
        public virtual DbSet<SonGuncellemeZamani> SonGuncellemeZamanis { get; set; } = null!;
        public virtual DbSet<Srintegration> Srintegrations { get; set; } = null!;
        public virtual DbSet<StmargeicerdeKalmaSuresi> StmargeicerdeKalmaSuresis { get; set; } = null!;
        public virtual DbSet<Summertime> Summertimes { get; set; } = null!;
        public virtual DbSet<SysAccessType> SysAccessTypes { get; set; } = null!;
        public virtual DbSet<SysAracTuru> SysAracTurus { get; set; } = null!;
        public virtual DbSet<SysBellTimeType> SysBellTimeTypes { get; set; } = null!;
        public virtual DbSet<SysCardAttribute> SysCardAttributes { get; set; } = null!;
        public virtual DbSet<SysCardFormat> SysCardFormats { get; set; } = null!;
        public virtual DbSet<SysCardType> SysCardTypes { get; set; } = null!;
        public virtual DbSet<SysCinsiyet> SysCinsiyets { get; set; } = null!;
        public virtual DbSet<SysCommandType> SysCommandTypes { get; set; } = null!;
        public virtual DbSet<SysEventCode> SysEventCodes { get; set; } = null!;
        public virtual DbSet<SysIo> SysIos { get; set; } = null!;
        public virtual DbSet<SysKanGrubu> SysKanGrubus { get; set; } = null!;
        public virtual DbSet<SysLanguage> SysLanguages { get; set; } = null!;
        public virtual DbSet<SysLanguageStmt> SysLanguageStmts { get; set; } = null!;
        public virtual DbSet<SysMaasTipi> SysMaasTipis { get; set; } = null!;
        public virtual DbSet<SysMedeniHali> SysMedeniHalis { get; set; } = null!;
        public virtual DbSet<SysMonth> SysMonths { get; set; } = null!;
        public virtual DbSet<SysOperator> SysOperators { get; set; } = null!;
        public virtual DbSet<SysProgram> SysPrograms { get; set; } = null!;
        public virtual DbSet<SysReport> SysReports { get; set; } = null!;
        public virtual DbSet<SysReport1> SysReports1 { get; set; } = null!;
        public virtual DbSet<SysReportGroup> SysReportGroups { get; set; } = null!;
        public virtual DbSet<SysTerminalKind> SysTerminalKinds { get; set; } = null!;
        public virtual DbSet<SysTerminalMode> SysTerminalModes { get; set; } = null!;
        public virtual DbSet<SysTerminalModel> SysTerminalModels { get; set; } = null!;
        public virtual DbSet<SysTerminalType> SysTerminalTypes { get; set; } = null!;
        public virtual DbSet<SysUserDef> SysUserDefs { get; set; } = null!;
        public virtual DbSet<SysUserLevel> SysUserLevels { get; set; } = null!;
        public virtual DbSet<TalepSebepleri> TalepSebepleris { get; set; } = null!;
        public virtual DbSet<Tasnifleme> Tasniflemes { get; set; } = null!;
        public virtual DbSet<TasniflemeRescue> TasniflemeRescues { get; set; } = null!;
        public virtual DbSet<TasniflemeSonEventList> TasniflemeSonEventLists { get; set; } = null!;
        public virtual DbSet<TatilTipleri> TatilTipleris { get; set; } = null!;
        public virtual DbSet<Tatiller> Tatillers { get; set; } = null!;
        public virtual DbSet<TblAcEtkin> TblAcEtkins { get; set; } = null!;
        public virtual DbSet<TblAktarim> TblAktarims { get; set; } = null!;
        public virtual DbSet<TblAnfaAktarimBilgileri> TblAnfaAktarimBilgileris { get; set; } = null!;
        public virtual DbSet<TblAraGeci> TblAraGecis { get; set; } = null!;
        public virtual DbSet<TblAraGecisHareketleri> TblAraGecisHareketleris { get; set; } = null!;
        public virtual DbSet<TblAsansor> TblAsansors { get; set; } = null!;
        public virtual DbSet<TblAsansorDuty> TblAsansorDuties { get; set; } = null!;
        public virtual DbSet<TblAsansorKat> TblAsansorKats { get; set; } = null!;
        public virtual DbSet<TblAylikPdk> TblAylikPdks { get; set; } = null!;
        public virtual DbSet<TblAyrilanSiciller> TblAyrilanSicillers { get; set; } = null!;
        public virtual DbSet<TblBilet> TblBilets { get; set; } = null!;
        public virtual DbSet<TblBiletIzinTip> TblBiletIzinTips { get; set; } = null!;
        public virtual DbSet<TblBirimler> TblBirimlers { get; set; } = null!;
        public virtual DbSet<TblBosSifre> TblBosSifres { get; set; } = null!;
        public virtual DbSet<TblDaireTanimlari> TblDaireTanimlaris { get; set; } = null!;
        public virtual DbSet<TblDetailedLog> TblDetailedLogs { get; set; } = null!;
        public virtual DbSet<TblDinlenmeGecisleri> TblDinlenmeGecisleris { get; set; } = null!;
        public virtual DbSet<TblEventKey> TblEventKeys { get; set; } = null!;
        public virtual DbSet<TblExcel> TblExcels { get; set; } = null!;
        public virtual DbSet<TblFizin> TblFizins { get; set; } = null!;
        public virtual DbSet<TblGateIodoorDuty> TblGateIodoorDuties { get; set; } = null!;
        public virtual DbSet<TblGeciciKartIslem> TblGeciciKartIslems { get; set; } = null!;
        public virtual DbSet<TblGonderilenMailIcerik> TblGonderilenMailIceriks { get; set; } = null!;
        public virtual DbSet<TblGunlukIzinOzeti> TblGunlukIzinOzetis { get; set; } = null!;
        public virtual DbSet<TblHakDusenIzinTip> TblHakDusenIzinTips { get; set; } = null!;
        public virtual DbSet<TblHaritaKonum> TblHaritaKonums { get; set; } = null!;
        public virtual DbSet<TblHaritaMarker> TblHaritaMarkers { get; set; } = null!;
        public virtual DbSet<TblHaritaSubeMarker> TblHaritaSubeMarkers { get; set; } = null!;
        public virtual DbSet<TblHaritum> TblHarita { get; set; } = null!;
        public virtual DbSet<TblHataliGecisler> TblHataliGecislers { get; set; } = null!;
        public virtual DbSet<TblHesaplayiciAyar> TblHesaplayiciAyars { get; set; } = null!;
        public virtual DbSet<TblHesaplayiciZaman> TblHesaplayiciZamen { get; set; } = null!;
        public virtual DbSet<TblIlaveYetki> TblIlaveYetkis { get; set; } = null!;
        public virtual DbSet<TblIlaveYetkiLog> TblIlaveYetkiLogs { get; set; } = null!;
        public virtual DbSet<TblIller> TblIllers { get; set; } = null!;
        public virtual DbSet<TblIzinAki> TblIzinAkis { get; set; } = null!;
        public virtual DbSet<TblIzinAkisSicil> TblIzinAkisSicils { get; set; } = null!;
        public virtual DbSet<TblIzinAkisSicilOnay> TblIzinAkisSicilOnays { get; set; } = null!;
        public virtual DbSet<TblIzinKidemKurali> TblIzinKidemKuralis { get; set; } = null!;
        public virtual DbSet<TblIzinLimitKurali> TblIzinLimitKuralis { get; set; } = null!;
        public virtual DbSet<TblIzinTanimKurali> TblIzinTanimKuralis { get; set; } = null!;
        public virtual DbSet<TblIzinYasKurali> TblIzinYasKuralis { get; set; } = null!;
        public virtual DbSet<TblKameraDuty> TblKameraDuties { get; set; } = null!;
        public virtual DbSet<TblKameraEvent> TblKameraEvents { get; set; } = null!;
        public virtual DbSet<TblKameraTanim> TblKameraTanims { get; set; } = null!;
        public virtual DbSet<TblKameraTerminal> TblKameraTerminals { get; set; } = null!;
        public virtual DbSet<TblKartNoCevirmeTipi> TblKartNoCevirmeTipis { get; set; } = null!;
        public virtual DbSet<TblKroki> TblKrokis { get; set; } = null!;
        public virtual DbSet<TblKurulu> TblKurulus { get; set; } = null!;
        public virtual DbSet<TblLanguageLabel> TblLanguageLabels { get; set; } = null!;
        public virtual DbSet<TblLastMailSendTime> TblLastMailSendTimes { get; set; } = null!;
        public virtual DbSet<TblLedPanel> TblLedPanels { get; set; } = null!;
        public virtual DbSet<TblLedPanelBeklemeMesaji> TblLedPanelBeklemeMesajis { get; set; } = null!;
        public virtual DbSet<TblLedPanelBeklemeMesajiLog> TblLedPanelBeklemeMesajiLogs { get; set; } = null!;
        public virtual DbSet<TblLedPanelHatakodlari> TblLedPanelHatakodlaris { get; set; } = null!;
        public virtual DbSet<TblLedPanelTatilMesaji> TblLedPanelTatilMesajis { get; set; } = null!;
        public virtual DbSet<TblLedPanelYaziIslem> TblLedPanelYaziIslems { get; set; } = null!;
        public virtual DbSet<TblLog> TblLogs { get; set; } = null!;
        public virtual DbSet<TblLogType> TblLogTypes { get; set; } = null!;
        public virtual DbSet<TblLoginFirmaYetki> TblLoginFirmaYetkis { get; set; } = null!;
        public virtual DbSet<TblLoginLokasyonYetki> TblLoginLokasyonYetkis { get; set; } = null!;
        public virtual DbSet<TblLoginRaporYetki> TblLoginRaporYetkis { get; set; } = null!;
        public virtual DbSet<TblLoginTerminalYetki> TblLoginTerminalYetkis { get; set; } = null!;
        public virtual DbSet<TblLoginYetkiGrubu> TblLoginYetkiGrubus { get; set; } = null!;
        public virtual DbSet<TblLoginYetkiliPeriyodlar> TblLoginYetkiliPeriyodlars { get; set; } = null!;
        public virtual DbSet<TblLogo> TblLogos { get; set; } = null!;
        public virtual DbSet<TblMailAliciTerminal> TblMailAliciTerminals { get; set; } = null!;
        public virtual DbSet<TblMailAlicilar> TblMailAlicilars { get; set; } = null!;
        public virtual DbSet<TblMailAylik> TblMailAyliks { get; set; } = null!;
        public virtual DbSet<TblMailHaftalik> TblMailHaftaliks { get; set; } = null!;
        public virtual DbSet<TblMailSistem> TblMailSistems { get; set; } = null!;
        public virtual DbSet<TblMailYetkiliRaporlar> TblMailYetkiliRaporlars { get; set; } = null!;
        public virtual DbSet<TblMesaiSapma> TblMesaiSapmas { get; set; } = null!;
        public virtual DbSet<TblMesaiTanimsizOdaKalinanSure> TblMesaiTanimsizOdaKalinanSures { get; set; } = null!;
        public virtual DbSet<TblMolaHesapTablosu> TblMolaHesapTablosus { get; set; } = null!;
        public virtual DbSet<TblOdaIcerisindekiSiciller> TblOdaIcerisindekiSicillers { get; set; } = null!;
        public virtual DbSet<TblOdaKalinanSure> TblOdaKalinanSures { get; set; } = null!;
        public virtual DbSet<TblOdaKalinanSureToplam> TblOdaKalinanSureToplams { get; set; } = null!;
        public virtual DbSet<TblOdaTanim> TblOdaTanims { get; set; } = null!;
        public virtual DbSet<TblOdaTerminalTanim> TblOdaTerminalTanims { get; set; } = null!;
        public virtual DbSet<TblOgunSayilari> TblOgunSayilaris { get; set; } = null!;
        public virtual DbSet<TblOnaylananFazlaMesai> TblOnaylananFazlaMesais { get; set; } = null!;
        public virtual DbSet<TblOzlukGorevDetay> TblOzlukGorevDetays { get; set; } = null!;
        public virtual DbSet<TblOzlukGorevIkamet> TblOzlukGorevIkamets { get; set; } = null!;
        public virtual DbSet<TblOzlukGorevlendirme> TblOzlukGorevlendirmes { get; set; } = null!;
        public virtual DbSet<TblOzlukKadro> TblOzlukKadros { get; set; } = null!;
        public virtual DbSet<TblOzlukMezuniyet> TblOzlukMezuniyets { get; set; } = null!;
        public virtual DbSet<TblOzlukSendika> TblOzlukSendikas { get; set; } = null!;
        public virtual DbSet<TblOzlukVekalet> TblOzlukVekalets { get; set; } = null!;
        public virtual DbSet<TblPanelAsansor> TblPanelAsansors { get; set; } = null!;
        public virtual DbSet<TblPanelKapiDurum> TblPanelKapiDurums { get; set; } = null!;
        public virtual DbSet<TblPanelTimeZone> TblPanelTimeZones { get; set; } = null!;
        public virtual DbSet<TblPanelTimeZoneDetaylari> TblPanelTimeZoneDetaylaris { get; set; } = null!;
        public virtual DbSet<TblPanelTimezoneDuty> TblPanelTimezoneDuties { get; set; } = null!;
        public virtual DbSet<TblPanelUsersTimeZone> TblPanelUsersTimeZones { get; set; } = null!;
        public virtual DbSet<TblPaneller> TblPanellers { get; set; } = null!;
        public virtual DbSet<TblParameter> TblParameters { get; set; } = null!;
        public virtual DbSet<TblPermissionRequestForm> TblPermissionRequestForms { get; set; } = null!;
        public virtual DbSet<TblPoolHataliGecisler> TblPoolHataliGecislers { get; set; } = null!;
        public virtual DbSet<TblPuantajTablosu> TblPuantajTablosus { get; set; } = null!;
        public virtual DbSet<TblRandevu> TblRandevus { get; set; } = null!;
        public virtual DbSet<TblReCheckEventsDuty> TblReCheckEventsDuties { get; set; } = null!;
        public virtual DbSet<TblRonesansElazigBirimEnt> TblRonesansElazigBirimEnts { get; set; } = null!;
        public virtual DbSet<TblRonesansPozisyonAktarimi> TblRonesansPozisyonAktarimis { get; set; } = null!;
        public virtual DbSet<TblRonesansSirketGorevYeriAktarim> TblRonesansSirketGorevYeriAktarims { get; set; } = null!;
        public virtual DbSet<TblRoom> TblRooms { get; set; } = null!;
        public virtual DbSet<TblRoomContainer> TblRoomContainers { get; set; } = null!;
        public virtual DbSet<TblRoomContainerLog> TblRoomContainerLogs { get; set; } = null!;
        public virtual DbSet<TblRoomLog> TblRoomLogs { get; set; } = null!;
        public virtual DbSet<TblRoomSicil> TblRoomSicils { get; set; } = null!;
        public virtual DbSet<TblRoomSicilHareket> TblRoomSicilHarekets { get; set; } = null!;
        public virtual DbSet<TblRoomSicilHareketLog> TblRoomSicilHareketLogs { get; set; } = null!;
        public virtual DbSet<TblRoomSicilLog> TblRoomSicilLogs { get; set; } = null!;
        public virtual DbSet<TblSaatlikIzinAsimSure> TblSaatlikIzinAsimSures { get; set; } = null!;
        public virtual DbSet<TblSaatlikIzinBakiye> TblSaatlikIzinBakiyes { get; set; } = null!;
        public virtual DbSet<TblServisGuzergah> TblServisGuzergahs { get; set; } = null!;
        public virtual DbSet<TblSicilAdre> TblSicilAdres { get; set; } = null!;
        public virtual DbSet<TblSicilArac> TblSicilAracs { get; set; } = null!;
        public virtual DbSet<TblSicilAracLog> TblSicilAracLogs { get; set; } = null!;
        public virtual DbSet<TblSicilBakiyeHareket> TblSicilBakiyeHarekets { get; set; } = null!;
        public virtual DbSet<TblSicilBirim> TblSicilBirims { get; set; } = null!;
        public virtual DbSet<TblSicilBirimLog> TblSicilBirimLogs { get; set; } = null!;
        public virtual DbSet<TblSicilBolge> TblSicilBolges { get; set; } = null!;
        public virtual DbSet<TblSicilCocuk> TblSicilCocuks { get; set; } = null!;
        public virtual DbSet<TblSicilDetay> TblSicilDetays { get; set; } = null!;
        public virtual DbSet<TblSicilDosyalar> TblSicilDosyalars { get; set; } = null!;
        public virtual DbSet<TblSicilE> TblSicilEs { get; set; } = null!;
        public virtual DbSet<TblSicilEgitimKur> TblSicilEgitimKurs { get; set; } = null!;
        public virtual DbSet<TblSicilGorev> TblSicilGorevs { get; set; } = null!;
        public virtual DbSet<TblSicilGunlukMesaiOzeti> TblSicilGunlukMesaiOzetis { get; set; } = null!;
        public virtual DbSet<TblSicilHesCodeLog> TblSicilHesCodeLogs { get; set; } = null!;
        public virtual DbSet<TblSicilIlceler> TblSicilIlcelers { get; set; } = null!;
        public virtual DbSet<TblSicilIller> TblSicilIllers { get; set; } = null!;
        public virtual DbSet<TblSicilIsBilgileri> TblSicilIsBilgileris { get; set; } = null!;
        public virtual DbSet<TblSicilIzinDetail> TblSicilIzinDetails { get; set; } = null!;
        public virtual DbSet<TblSicilIzinKural> TblSicilIzinKurals { get; set; } = null!;
        public virtual DbSet<TblSicilIzinMaster> TblSicilIzinMasters { get; set; } = null!;
        public virtual DbSet<TblSicilKalanHak> TblSicilKalanHaks { get; set; } = null!;
        public virtual DbSet<TblSicilKalanHakGecmi> TblSicilKalanHakGecmis { get; set; } = null!;
        public virtual DbSet<TblSicilKalanKullanilanIzin> TblSicilKalanKullanilanIzins { get; set; } = null!;
        public virtual DbSet<TblSicilKimlik> TblSicilKimliks { get; set; } = null!;
        public virtual DbSet<TblSicilKurum> TblSicilKurums { get; set; } = null!;
        public virtual DbSet<TblSicilLoginInfo> TblSicilLoginInfos { get; set; } = null!;
        public virtual DbSet<TblSicilLoginInfoLog> TblSicilLoginInfoLogs { get; set; } = null!;
        public virtual DbSet<TblSicilOdulCeza> TblSicilOdulCezas { get; set; } = null!;
        public virtual DbSet<TblSicilOzelBilgileri> TblSicilOzelBilgileris { get; set; } = null!;
        public virtual DbSet<TblSicilOzluk> TblSicilOzluks { get; set; } = null!;
        public virtual DbSet<TblSicilReferan> TblSicilReferans { get; set; } = null!;
        public virtual DbSet<TblSicilResimKayit> TblSicilResimKayits { get; set; } = null!;
        public virtual DbSet<TblSicilYemekhane> TblSicilYemekhanes { get; set; } = null!;
        public virtual DbSet<TblSicilYolUcret> TblSicilYolUcrets { get; set; } = null!;
        public virtual DbSet<TblSilinecekMesaiOzetler> TblSilinecekMesaiOzetlers { get; set; } = null!;
        public virtual DbSet<TblSilinecekSicilNo> TblSilinecekSicilNos { get; set; } = null!;
        public virtual DbSet<TblSonBaglantiDurum> TblSonBaglantiDurums { get; set; } = null!;
        public virtual DbSet<TblSonGeci> TblSonGecis { get; set; } = null!;
        public virtual DbSet<TblSonKapiDurum> TblSonKapiDurums { get; set; } = null!;
        public virtual DbSet<TblSonOdaHareketi> TblSonOdaHareketis { get; set; } = null!;
        public virtual DbSet<TblSonTerminalSokulmeIslemi> TblSonTerminalSokulmeIslemis { get; set; } = null!;
        public virtual DbSet<TblSube> TblSubes { get; set; } = null!;
        public virtual DbSet<TblSubeKroki> TblSubeKrokis { get; set; } = null!;
        public virtual DbSet<TblSysGateIoEventName> TblSysGateIoEventNames { get; set; } = null!;
        public virtual DbSet<TblSysIzinHesaplamaTipi> TblSysIzinHesaplamaTipis { get; set; } = null!;
        public virtual DbSet<TblSysIzinLimitTipi> TblSysIzinLimitTipis { get; set; } = null!;
        public virtual DbSet<TblSysIzinOnayIslemDurum> TblSysIzinOnayIslemDurums { get; set; } = null!;
        public virtual DbSet<TblSysLanguage> TblSysLanguages { get; set; } = null!;
        public virtual DbSet<TblSysLedPanelIdleTime> TblSysLedPanelIdleTimes { get; set; } = null!;
        public virtual DbSet<TblSysLoggedTable> TblSysLoggedTables { get; set; } = null!;
        public virtual DbSet<TblSysMailRaporlar> TblSysMailRaporlars { get; set; } = null!;
        public virtual DbSet<TblSysMailYetkiAdlari> TblSysMailYetkiAdlaris { get; set; } = null!;
        public virtual DbSet<TblSysMesaiHesaplamaTipleri> TblSysMesaiHesaplamaTipleris { get; set; } = null!;
        public virtual DbSet<TblSysProcess> TblSysProcesses { get; set; } = null!;
        public virtual DbSet<TblSysReport> TblSysReports { get; set; } = null!;
        public virtual DbSet<TblSysTerminalUrunGrubu> TblSysTerminalUrunGrubus { get; set; } = null!;
        public virtual DbSet<TblSysYetkiKey> TblSysYetkiKeys { get; set; } = null!;
        public virtual DbSet<TblTasnifLog> TblTasnifLogs { get; set; } = null!;
        public virtual DbSet<TblTerminalAlertEvent> TblTerminalAlertEvents { get; set; } = null!;
        public virtual DbSet<TblTerminalGrubu> TblTerminalGrubus { get; set; } = null!;
        public virtual DbSet<TblTerminalGrup> TblTerminalGrups { get; set; } = null!;
        public virtual DbSet<TblTerminalUrunGrubu> TblTerminalUrunGrubus { get; set; } = null!;
        public virtual DbSet<TblTestPlakaKontrol> TblTestPlakaKontrols { get; set; } = null!;
        public virtual DbSet<TblTravelRequestResult> TblTravelRequestResults { get; set; } = null!;
        public virtual DbSet<TblUserAsansorYetki> TblUserAsansorYetkis { get; set; } = null!;
        public virtual DbSet<TblUserSearchParam> TblUserSearchParams { get; set; } = null!;
        public virtual DbSet<TblUyruk> TblUyruks { get; set; } = null!;
        public virtual DbSet<TblVardiyasizMesaiOzeti> TblVardiyasizMesaiOzetis { get; set; } = null!;
        public virtual DbSet<TblWcgeci> TblWcgecis { get; set; } = null!;
        public virtual DbSet<TblWcgirisCiki> TblWcgirisCikis { get; set; } = null!;
        public virtual DbSet<TblYasakliZiyaretci> TblYasakliZiyaretcis { get; set; } = null!;
        public virtual DbSet<TblYemekhaneBilgi> TblYemekhaneBilgis { get; set; } = null!;
        public virtual DbSet<TblYemekhaneKapaliSaatTanim> TblYemekhaneKapaliSaatTanims { get; set; } = null!;
        public virtual DbSet<TblYemekhaneOgunTanim> TblYemekhaneOgunTanims { get; set; } = null!;
        public virtual DbSet<TblYillikHakEdilenIzin> TblYillikHakEdilenIzins { get; set; } = null!;
        public virtual DbSet<TblYillikPdk> TblYillikPdks { get; set; } = null!;
        public virtual DbSet<TblZiyaretciRandevu> TblZiyaretciRandevus { get; set; } = null!;
        public virtual DbSet<TblZiyaretciSearchParam> TblZiyaretciSearchParams { get; set; } = null!;
        public virtual DbSet<TblZiyaretciTerminalYetkiDurum> TblZiyaretciTerminalYetkiDurums { get; set; } = null!;
        public virtual DbSet<TerminalAcu121> TerminalAcu121s { get; set; } = null!;
        public virtual DbSet<TerminalFonksiyon> TerminalFonksiyons { get; set; } = null!;
        public virtual DbSet<TerminalGroup> TerminalGroups { get; set; } = null!;
        public virtual DbSet<TerminalPort> TerminalPorts { get; set; } = null!;
        public virtual DbSet<TerminalRelation> TerminalRelations { get; set; } = null!;
        public virtual DbSet<TerminalTimeZone> TerminalTimeZones { get; set; } = null!;
        public virtual DbSet<TerminalYetkiDurum> TerminalYetkiDurums { get; set; } = null!;
        public virtual DbSet<Terminaller> Terminallers { get; set; } = null!;
        public virtual DbSet<TerminallerLog> TerminallerLogs { get; set; } = null!;
        public virtual DbSet<TimeZone> TimeZones { get; set; } = null!;
        public virtual DbSet<UnauthorizedCardAccess> UnauthorizedCardAccesses { get; set; } = null!;
        public virtual DbSet<UrunFiyatGuncelleIslem> UrunFiyatGuncelleIslems { get; set; } = null!;
        public virtual DbSet<UrunKategori> UrunKategoris { get; set; } = null!;
        public virtual DbSet<UrunSicilHakedi> UrunSicilHakedis { get; set; } = null!;
        public virtual DbSet<UrunSipari> UrunSiparis { get; set; } = null!;
        public virtual DbSet<UrunSiparisDetay> UrunSiparisDetays { get; set; } = null!;
        public virtual DbSet<UrunTur> UrunTurs { get; set; } = null!;
        public virtual DbSet<UrunTurLog> UrunTurLogs { get; set; } = null!;
        public virtual DbSet<UserAuthStatus> UserAuthStatuses { get; set; } = null!;
        public virtual DbSet<UserCardHistory> UserCardHistories { get; set; } = null!;
        public virtual DbSet<UserFinger> UserFingers { get; set; } = null!;
        public virtual DbSet<UserList> UserLists { get; set; } = null!;
        public virtual DbSet<UserListIndex> UserListIndices { get; set; } = null!;
        public virtual DbSet<UserListLog> UserListLogs { get; set; } = null!;
        public virtual DbSet<UserListTmp> UserListTmps { get; set; } = null!;
        public virtual DbSet<UserTable> UserTables { get; set; } = null!;
        public virtual DbSet<UserYetki> UserYetkis { get; set; } = null!;
        public virtual DbSet<Userlimit> Userlimits { get; set; } = null!;
        public virtual DbSet<Version> Versions { get; set; } = null!;
        public virtual DbSet<Vw0200101> Vw0200101s { get; set; } = null!;
        public virtual DbSet<VwAaGecisler> VwAaGecislers { get; set; } = null!;
        public virtual DbSet<VwAaIlkGirisSonCiki> VwAaIlkGirisSonCikis { get; set; } = null!;
        public virtual DbSet<VwAllViewsName> VwAllViewsNames { get; set; } = null!;
        public virtual DbSet<VwArgeAraGeci> VwArgeAraGecis { get; set; } = null!;
        public virtual DbSet<VwArgeAraGecisStg> VwArgeAraGecisStgs { get; set; } = null!;
        public virtual DbSet<VwArgeRapor> VwArgeRapors { get; set; } = null!;
        public virtual DbSet<VwAselsanRapor> VwAselsanRapors { get; set; } = null!;
        public virtual DbSet<VwAssanselectGunlukMesaiOzet> VwAssanselectGunlukMesaiOzets { get; set; } = null!;
        public virtual DbSet<VwAstorPuantaj2023> VwAstorPuantaj2023s { get; set; } = null!;
        public virtual DbSet<VwAylikCalismaVeIzinRaporu> VwAylikCalismaVeIzinRaporus { get; set; } = null!;
        public virtual DbSet<VwAylikCalismaVeIzinRaporuBarkom> VwAylikCalismaVeIzinRaporuBarkoms { get; set; } = null!;
        public virtual DbSet<VwAylikDetayliFm> VwAylikDetayliFms { get; set; } = null!;
        public virtual DbSet<VwAylikDetayliFmCrossTab> VwAylikDetayliFmCrossTabs { get; set; } = null!;
        public virtual DbSet<VwAylikDetayliPdk> VwAylikDetayliPdks { get; set; } = null!;
        public virtual DbSet<VwAylikDevam> VwAylikDevams { get; set; } = null!;
        public virtual DbSet<VwAylikDevamDetay> VwAylikDevamDetays { get; set; } = null!;
        public virtual DbSet<VwAylikDevamDetayCizelge> VwAylikDevamDetayCizelges { get; set; } = null!;
        public virtual DbSet<VwAylikFazlaMesaiListesi> VwAylikFazlaMesaiListesis { get; set; } = null!;
        public virtual DbSet<VwAylikFirmaBazliGelenPersonelRaporu> VwAylikFirmaBazliGelenPersonelRaporus { get; set; } = null!;
        public virtual DbSet<VwAylikNetPuantajSonucRaporu> VwAylikNetPuantajSonucRaporus { get; set; } = null!;
        public virtual DbSet<VwAylikNetPuantajSonucRaporuNurdil> VwAylikNetPuantajSonucRaporuNurdils { get; set; } = null!;
        public virtual DbSet<VwAylikVardiyaListesi> VwAylikVardiyaListesis { get; set; } = null!;
        public virtual DbSet<VwAylikYemekYiyenPersonel> VwAylikYemekYiyenPersonels { get; set; } = null!;
        public virtual DbSet<VwBastugSapAktarimCsv> VwBastugSapAktarimCsvs { get; set; } = null!;
        public virtual DbSet<VwBeyazYakaOglenHesaplama> VwBeyazYakaOglenHesaplamas { get; set; } = null!;
        public virtual DbSet<VwBeyazYakaOglenHesaplamaHataliKayit> VwBeyazYakaOglenHesaplamaHataliKayits { get; set; } = null!;
        public virtual DbSet<VwCalismaPlani> VwCalismaPlanis { get; set; } = null!;
        public virtual DbSet<VwCalismaSure> VwCalismaSures { get; set; } = null!;
        public virtual DbSet<VwCalismaSuresi> VwCalismaSuresis { get; set; } = null!;
        public virtual DbSet<VwCalismaVeMolaSuresi> VwCalismaVeMolaSuresis { get; set; } = null!;
        public virtual DbSet<VwCaniasPdksaktarim> VwCaniasPdksaktarims { get; set; } = null!;
        public virtual DbSet<VwCaniasPuantajAktarim> VwCaniasPuantajAktarims { get; set; } = null!;
        public virtual DbSet<VwCekirdekCalismaliEsnekMesaiCalismaRaporu> VwCekirdekCalismaliEsnekMesaiCalismaRaporus { get; set; } = null!;
        public virtual DbSet<VwCesOnaylananFazlaMesaiRaporu> VwCesOnaylananFazlaMesaiRaporus { get; set; } = null!;
        public virtual DbSet<VwCihazDurumRapor> VwCihazDurumRapors { get; set; } = null!;
        public virtual DbSet<VwDetayYemekhaneRaporu> VwDetayYemekhaneRaporus { get; set; } = null!;
        public virtual DbSet<VwDinamikGelmeyenPersonel> VwDinamikGelmeyenPersonels { get; set; } = null!;
        public virtual DbSet<VwDsimesaiHesapla> VwDsimesaiHesaplas { get; set; } = null!;
        public virtual DbSet<VwEgitimKatilimciSure> VwEgitimKatilimciSures { get; set; } = null!;
        public virtual DbSet<VwEgitimRaporu> VwEgitimRaporus { get; set; } = null!;
        public virtual DbSet<VwEgitimRaporuSicilBazli> VwEgitimRaporuSicilBazlis { get; set; } = null!;
        public virtual DbSet<VwErkenCikanIzinli> VwErkenCikanIzinlis { get; set; } = null!;
        public virtual DbSet<VwErkenCikanPersonel> VwErkenCikanPersonels { get; set; } = null!;
        public virtual DbSet<VwErkenCikanlar> VwErkenCikanlars { get; set; } = null!;
        public virtual DbSet<VwFazlaMesaiHesaplaRapor> VwFazlaMesaiHesaplaRapors { get; set; } = null!;
        public virtual DbSet<VwFazlaMesaiRaporu> VwFazlaMesaiRaporus { get; set; } = null!;
        public virtual DbSet<VwFazlaMesaiRaporuOstimOsb> VwFazlaMesaiRaporuOstimOsbs { get; set; } = null!;
        public virtual DbSet<VwFernasGunlukRapor> VwFernasGunlukRapors { get; set; } = null!;
        public virtual DbSet<VwFinansDetayCalisma> VwFinansDetayCalismas { get; set; } = null!;
        public virtual DbSet<VwFmhesapla> VwFmhesaplas { get; set; } = null!;
        public virtual DbSet<VwGecGelenPersonel> VwGecGelenPersonels { get; set; } = null!;
        public virtual DbSet<VwGecGelenler> VwGecGelenlers { get; set; } = null!;
        public virtual DbSet<VwGecGelenlerIzinli> VwGecGelenlerIzinlis { get; set; } = null!;
        public virtual DbSet<VwGecGelenlerToleransli> VwGecGelenlerToleranslis { get; set; } = null!;
        public virtual DbSet<VwGeciciKartGecisListesiOzet> VwGeciciKartGecisListesiOzets { get; set; } = null!;
        public virtual DbSet<VwGecisYogunlugu> VwGecisYogunlugus { get; set; } = null!;
        public virtual DbSet<VwGelenPersonelMail> VwGelenPersonelMails { get; set; } = null!;
        public virtual DbSet<VwGelenPersonelSayisi> VwGelenPersonelSayisis { get; set; } = null!;
        public virtual DbSet<VwGelmeyenPersonel> VwGelmeyenPersonels { get; set; } = null!;
        public virtual DbSet<VwGelmeyenPersonelMail> VwGelmeyenPersonelMails { get; set; } = null!;
        public virtual DbSet<VwGelmeyenler> VwGelmeyenlers { get; set; } = null!;
        public virtual DbSet<VwGelmeyenlerEkAlan> VwGelmeyenlerEkAlans { get; set; } = null!;
        public virtual DbSet<VwGenelPersonelFazlaMesaiRaporu> VwGenelPersonelFazlaMesaiRaporus { get; set; } = null!;
        public virtual DbSet<VwGenericPuantaj> VwGenericPuantajs { get; set; } = null!;
        public virtual DbSet<VwGerceklesenMesaiPuantaj> VwGerceklesenMesaiPuantajs { get; set; } = null!;
        public virtual DbSet<VwGirisCikisIhlalRaporu> VwGirisCikisIhlalRaporus { get; set; } = null!;
        public virtual DbSet<VwGirisCikisMail> VwGirisCikisMails { get; set; } = null!;
        public virtual DbSet<VwGunlukCalismaDurumu> VwGunlukCalismaDurumus { get; set; } = null!;
        public virtual DbSet<VwGunlukGelmeyenlerRaporu> VwGunlukGelmeyenlerRaporus { get; set; } = null!;
        public virtual DbSet<VwGunlukIzinOzetToplam> VwGunlukIzinOzetToplams { get; set; } = null!;
        public virtual DbSet<VwGunlukKapiGirisCikisRaporu> VwGunlukKapiGirisCikisRaporus { get; set; } = null!;
        public virtual DbSet<VwHaftalikCalismaSureleriMail> VwHaftalikCalismaSureleriMails { get; set; } = null!;
        public virtual DbSet<VwHaftalikDevamsizlik> VwHaftalikDevamsizliks { get; set; } = null!;
        public virtual DbSet<VwHaftalikEksikCalisma> VwHaftalikEksikCalismas { get; set; } = null!;
        public virtual DbSet<VwHaftalikErkenCikanlar> VwHaftalikErkenCikanlars { get; set; } = null!;
        public virtual DbSet<VwHaftalikGecGelenler> VwHaftalikGecGelenlers { get; set; } = null!;
        public virtual DbSet<VwHaftalikIlkGirisSonCiki> VwHaftalikIlkGirisSonCikis { get; set; } = null!;
        public virtual DbSet<VwHaftalikTseeksikCalisma> VwHaftalikTseeksikCalismas { get; set; } = null!;
        public virtual DbSet<VwHaftalikYonetimIlkGirisSonCiki> VwHaftalikYonetimIlkGirisSonCikis { get; set; } = null!;
        public virtual DbSet<VwHakedilenveKalanIzin> VwHakedilenveKalanIzins { get; set; } = null!;
        public virtual DbSet<VwHesKoduRaporu> VwHesKoduRaporus { get; set; } = null!;
        public virtual DbSet<VwIcerdekiSure> VwIcerdekiSures { get; set; } = null!;
        public virtual DbSet<VwIcerideGecirdigiSureToplamCalismaSure> VwIcerideGecirdigiSureToplamCalismaSures { get; set; } = null!;
        public virtual DbSet<VwIceridekiPersonel> VwIceridekiPersonels { get; set; } = null!;
        public virtual DbSet<VwIceridekiSureBazliPuantaj> VwIceridekiSureBazliPuantajs { get; set; } = null!;
        public virtual DbSet<VwIceridekiler> VwIceridekilers { get; set; } = null!;
        public virtual DbSet<VwIlBazliArizaliTerminal> VwIlBazliArizaliTerminals { get; set; } = null!;
        public virtual DbSet<VwIlkGirisSonCiki> VwIlkGirisSonCikis { get; set; } = null!;
        public virtual DbSet<VwIlkGirisSonCikisDurumMail> VwIlkGirisSonCikisDurumMails { get; set; } = null!;
        public virtual DbSet<VwIlkGirisSonCikisRaporu> VwIlkGirisSonCikisRaporus { get; set; } = null!;
        public virtual DbSet<VwInterdataNetMesaiRapor> VwInterdataNetMesaiRapors { get; set; } = null!;
        public virtual DbSet<VwIomistanbulHavalimaniPuantaj> VwIomistanbulHavalimaniPuantajs { get; set; } = null!;
        public virtual DbSet<VwIomraporu> VwIomraporus { get; set; } = null!;
        public virtual DbSet<VwIskurPdksmail> VwIskurPdksmails { get; set; } = null!;
        public virtual DbSet<VwIskurPdksmailGunlukTumGecisler> VwIskurPdksmailGunlukTumGecislers { get; set; } = null!;
        public virtual DbSet<VwIzinListesi> VwIzinListesis { get; set; } = null!;
        public virtual DbSet<VwIzinTalepFormuOlustur> VwIzinTalepFormuOlusturs { get; set; } = null!;
        public virtual DbSet<VwIzinTatilFmraporu> VwIzinTatilFmraporus { get; set; } = null!;
        public virtual DbSet<VwIzinliPersonelMail> VwIzinliPersonelMails { get; set; } = null!;
        public virtual DbSet<VwJwMarriottTotalReport> VwJwMarriottTotalReports { get; set; } = null!;
        public virtual DbSet<VwKafeteryaBakiye> VwKafeteryaBakiyes { get; set; } = null!;
        public virtual DbSet<VwKafeteryaHakYuklemeRapor> VwKafeteryaHakYuklemeRapors { get; set; } = null!;
        public virtual DbSet<VwKafeteryaRaporu> VwKafeteryaRaporus { get; set; } = null!;
        public virtual DbSet<VwKafeteryaRaporuSatislar> VwKafeteryaRaporuSatislars { get; set; } = null!;
        public virtual DbSet<VwKarbaPuantaj> VwKarbaPuantajs { get; set; } = null!;
        public virtual DbSet<VwKartKullanmayanSicil> VwKartKullanmayanSicils { get; set; } = null!;
        public virtual DbSet<VwKisiBazliGunlukMesaiOzet> VwKisiBazliGunlukMesaiOzets { get; set; } = null!;
        public virtual DbSet<VwKisiBazliTumGirisCiki> VwKisiBazliTumGirisCikis { get; set; } = null!;
        public virtual DbSet<VwKisiBildirimRaporu> VwKisiBildirimRaporus { get; set; } = null!;
        public virtual DbSet<VwKisiGirisCikisRaporu> VwKisiGirisCikisRaporus { get; set; } = null!;
        public virtual DbSet<VwKisiGirisCikisRaporuGecisler> VwKisiGirisCikisRaporuGecislers { get; set; } = null!;
        public virtual DbSet<VwKisiGirisCikisRaporuJwm> VwKisiGirisCikisRaporuJwms { get; set; } = null!;
        public virtual DbSet<VwKisiGirisCikisRaporuSolar> VwKisiGirisCikisRaporuSolars { get; set; } = null!;
        public virtual DbSet<VwKomutIslemRaporu> VwKomutIslemRaporus { get; set; } = null!;
        public virtual DbSet<VwKonteynerLogRaporu> VwKonteynerLogRaporus { get; set; } = null!;
        public virtual DbSet<VwKpiraporuMefa> VwKpiraporuMefas { get; set; } = null!;
        public virtual DbSet<VwMailIceridekiPersonel> VwMailIceridekiPersonels { get; set; } = null!;
        public virtual DbSet<VwMailRapor> VwMailRapors { get; set; } = null!;
        public virtual DbSet<VwMailReportsAylikPuantaj> VwMailReportsAylikPuantajs { get; set; } = null!;
        public virtual DbSet<VwMailReportsErisilemeyenCihazlar> VwMailReportsErisilemeyenCihazlars { get; set; } = null!;
        public virtual DbSet<VwMailReportsGunlukFazlaMesai> VwMailReportsGunlukFazlaMesais { get; set; } = null!;
        public virtual DbSet<VwMailReportsSonGecerlilikYaklasanlarRaporu> VwMailReportsSonGecerlilikYaklasanlarRaporus { get; set; } = null!;
        public virtual DbSet<VwMerkezGunlukCalismaCizelgesi> VwMerkezGunlukCalismaCizelgesis { get; set; } = null!;
        public virtual DbSet<VwMesaiGirisCikisTrm> VwMesaiGirisCikisTrms { get; set; } = null!;
        public virtual DbSet<VwMesaiHesapSaglama> VwMesaiHesapSaglamas { get; set; } = null!;
        public virtual DbSet<VwMesaiHesaplamaIceridekiSure> VwMesaiHesaplamaIceridekiSures { get; set; } = null!;
        public virtual DbSet<VwMesaiHesaplamaKontrol> VwMesaiHesaplamaKontrols { get; set; } = null!;
        public virtual DbSet<VwMobilGecisRaporu> VwMobilGecisRaporus { get; set; } = null!;
        public virtual DbSet<VwMolaSuresiSelect> VwMolaSuresiSelects { get; set; } = null!;
        public virtual DbSet<VwNetsisAktarim> VwNetsisAktarims { get; set; } = null!;
        public virtual DbSet<VwNormalMesaiRaporu> VwNormalMesaiRaporus { get; set; } = null!;
        public virtual DbSet<VwNurdilDisariSureHesapla> VwNurdilDisariSureHesaplas { get; set; } = null!;
        public virtual DbSet<VwNurdilDisariSureHesaplaMain> VwNurdilDisariSureHesaplaMains { get; set; } = null!;
        public virtual DbSet<VwNurdilDisariSureHesaplaWc> VwNurdilDisariSureHesaplaWcs { get; set; } = null!;
        public virtual DbSet<VwNurdilDisariSureHesaplaWcMain> VwNurdilDisariSureHesaplaWcMains { get; set; } = null!;
        public virtual DbSet<VwNurdilFazlaMesaiRaporu> VwNurdilFazlaMesaiRaporus { get; set; } = null!;
        public virtual DbSet<VwNurdilGunlukMesaiDetay> VwNurdilGunlukMesaiDetays { get; set; } = null!;
        public virtual DbSet<VwNurdilKisiBazliDevamsizlikRaporu> VwNurdilKisiBazliDevamsizlikRaporus { get; set; } = null!;
        public virtual DbSet<VwNurolFinalPdksraporu> VwNurolFinalPdksraporus { get; set; } = null!;
        public virtual DbSet<VwNurolSapaktarimRapor> VwNurolSapaktarimRapors { get; set; } = null!;
        public virtual DbSet<VwOdaBazliGecisListesi> VwOdaBazliGecisListesis { get; set; } = null!;
        public virtual DbSet<VwOdaKalinanSure> VwOdaKalinanSures { get; set; } = null!;
        public virtual DbSet<VwOdaKalinanSureToplam> VwOdaKalinanSureToplams { get; set; } = null!;
        public virtual DbSet<VwOdavePuantaj> VwOdavePuantajs { get; set; } = null!;
        public virtual DbSet<VwOdtuMemsNetSureveGeci> VwOdtuMemsNetSureveGecis { get; set; } = null!;
        public virtual DbSet<VwOgunBazliYemekRaporu> VwOgunBazliYemekRaporus { get; set; } = null!;
        public virtual DbSet<VwOgunBazliYemekhaneRaporu> VwOgunBazliYemekhaneRaporus { get; set; } = null!;
        public virtual DbSet<VwOkumanArgeAylikCalisma> VwOkumanArgeAylikCalismas { get; set; } = null!;
        public virtual DbSet<VwOnayliIzin> VwOnayliIzins { get; set; } = null!;
        public virtual DbSet<VwOrtalamaliCalismaSure> VwOrtalamaliCalismaSures { get; set; } = null!;
        public virtual DbSet<VwOverTimeReportJw> VwOverTimeReportJws { get; set; } = null!;
        public virtual DbSet<VwOzlukBilgiler> VwOzlukBilgilers { get; set; } = null!;
        public virtual DbSet<VwPagoGecisselect> VwPagoGecisselects { get; set; } = null!;
        public virtual DbSet<VwPagoResimselect> VwPagoResimselects { get; set; } = null!;
        public virtual DbSet<VwPanelsanPuantaj> VwPanelsanPuantajs { get; set; } = null!;
        public virtual DbSet<VwPdksilkGirisSonCikisaGore> VwPdksilkGirisSonCikisaGores { get; set; } = null!;
        public virtual DbSet<VwPersonelHareketRaporu> VwPersonelHareketRaporus { get; set; } = null!;
        public virtual DbSet<VwPersonelHataliGeci> VwPersonelHataliGecis { get; set; } = null!;
        public virtual DbSet<VwPersonelPdk> VwPersonelPdks { get; set; } = null!;
        public virtual DbSet<VwPersonelPdksmail> VwPersonelPdksmails { get; set; } = null!;
        public virtual DbSet<VwPersonelYetkiDurum> VwPersonelYetkiDurums { get; set; } = null!;
        public virtual DbSet<VwPuantajAktarimCeka> VwPuantajAktarimCekas { get; set; } = null!;
        public virtual DbSet<VwPuantajDetayRapor> VwPuantajDetayRapors { get; set; } = null!;
        public virtual DbSet<VwPuantajveGeci> VwPuantajveGecis { get; set; } = null!;
        public virtual DbSet<VwResimliIlkGirisSonCikisIzinRaporu> VwResimliIlkGirisSonCikisIzinRaporus { get; set; } = null!;
        public virtual DbSet<VwRfidGecisKayitlari> VwRfidGecisKayitlaris { get; set; } = null!;
        public virtual DbSet<VwRfidilkGirisSonCiki> VwRfidilkGirisSonCikis { get; set; } = null!;
        public virtual DbSet<VwRonesansKartBaskiReadSicil> VwRonesansKartBaskiReadSicils { get; set; } = null!;
        public virtual DbSet<VwSaatlikIzinCizelgesi> VwSaatlikIzinCizelgesis { get; set; } = null!;
        public virtual DbSet<VwSaintGobainPersonelGunlukMesaiTakip> VwSaintGobainPersonelGunlukMesaiTakips { get; set; } = null!;
        public virtual DbSet<VwSaintGobainPuantaj> VwSaintGobainPuantajs { get; set; } = null!;
        public virtual DbSet<VwSanayiGelmeyenler> VwSanayiGelmeyenlers { get; set; } = null!;
        public virtual DbSet<VwSdtizinRapor> VwSdtizinRapors { get; set; } = null!;
        public virtual DbSet<VwSelectBirimRfidevent> VwSelectBirimRfidevents { get; set; } = null!;
        public virtual DbSet<VwSelectCiftAyPdk> VwSelectCiftAyPdks { get; set; } = null!;
        public virtual DbSet<VwSelectDetayMesaiHesaplama> VwSelectDetayMesaiHesaplamas { get; set; } = null!;
        public virtual DbSet<VwSelectDetayliIzinRaporu> VwSelectDetayliIzinRaporus { get; set; } = null!;
        public virtual DbSet<VwSelectEvent> VwSelectEvents { get; set; } = null!;
        public virtual DbSet<VwSelectGeci> VwSelectGecis { get; set; } = null!;
        public virtual DbSet<VwSelectGecisOlanTarihler> VwSelectGecisOlanTarihlers { get; set; } = null!;
        public virtual DbSet<VwSelectGecisTerminalBazli> VwSelectGecisTerminalBazlis { get; set; } = null!;
        public virtual DbSet<VwSelectGeciswithTerminal> VwSelectGeciswithTerminals { get; set; } = null!;
        public virtual DbSet<VwSelectGenelPersonelBordroMerck> VwSelectGenelPersonelBordroMercks { get; set; } = null!;
        public virtual DbSet<VwSelectGunlukMesaiOzet> VwSelectGunlukMesaiOzets { get; set; } = null!;
        public virtual DbSet<VwSelectGunlukMesaiOzetElsan> VwSelectGunlukMesaiOzetElsans { get; set; } = null!;
        public virtual DbSet<VwSelectGunlukMesaiOzetGerceklesenMesai> VwSelectGunlukMesaiOzetGerceklesenMesais { get; set; } = null!;
        public virtual DbSet<VwSelectGunlukMesaiOzetGirisCikisCcn> VwSelectGunlukMesaiOzetGirisCikisCcns { get; set; } = null!;
        public virtual DbSet<VwSelectGunlukMesaiOzetGirisCikisEgo> VwSelectGunlukMesaiOzetGirisCikisEgos { get; set; } = null!;
        public virtual DbSet<VwSelectGunlukMesaiOzetGirisCikisMefa> VwSelectGunlukMesaiOzetGirisCikisMefas { get; set; } = null!;
        public virtual DbSet<VwSelectGunlukMesaiOzetMefa> VwSelectGunlukMesaiOzetMefas { get; set; } = null!;
        public virtual DbSet<VwSelectHataliGecisler> VwSelectHataliGecislers { get; set; } = null!;
        public virtual DbSet<VwSelectIdealRaporu> VwSelectIdealRaporus { get; set; } = null!;
        public virtual DbSet<VwSelectIdealRaporuEx> VwSelectIdealRaporuices { get; set; } = null!;
        public virtual DbSet<VwSelectIzin> VwSelectIzins { get; set; } = null!;
        public virtual DbSet<VwSelectIzinAki> VwSelectIzinAkis { get; set; } = null!;
        public virtual DbSet<VwSelectIzinAkisDetay> VwSelectIzinAkisDetays { get; set; } = null!;
        public virtual DbSet<VwSelectKameraEvent> VwSelectKameraEvents { get; set; } = null!;
        public virtual DbSet<VwSelectKampOdaKalanRapor> VwSelectKampOdaKalanRapors { get; set; } = null!;
        public virtual DbSet<VwSelectKisiselDetayliPuantaj> VwSelectKisiselDetayliPuantajs { get; set; } = null!;
        public virtual DbSet<VwSelectLedPanelEvent> VwSelectLedPanelEvents { get; set; } = null!;
        public virtual DbSet<VwSelectMail1> VwSelectMails1 { get; set; } = null!;
        public virtual DbSet<VwSelectMailIzinliKisiler> VwSelectMailIzinliKisilers { get; set; } = null!;
        public virtual DbSet<VwSelectMevcutPersonel> VwSelectMevcutPersonels { get; set; } = null!;
        public virtual DbSet<VwSelectMobilPanelGirisCiki> VwSelectMobilPanelGirisCikis { get; set; } = null!;
        public virtual DbSet<VwSelectOdalardakiSiciller> VwSelectOdalardakiSicillers { get; set; } = null!;
        public virtual DbSet<VwSelectOffgunler> VwSelectOffgunlers { get; set; } = null!;
        public virtual DbSet<VwSelectPdk> VwSelectPdks { get; set; } = null!;
        public virtual DbSet<VwSelectPdk1> VwSelectPdks1 { get; set; } = null!;
        public virtual DbSet<VwSelectPdksIssYozgat> VwSelectPdksIssYozgats { get; set; } = null!;
        public virtual DbSet<VwSelectPdksMeteksanSavunma> VwSelectPdksMeteksanSavunmas { get; set; } = null!;
        public virtual DbSet<VwSelectPdkshataliHareket> VwSelectPdkshataliHarekets { get; set; } = null!;
        public virtual DbSet<VwSelectPdksostimOsb> VwSelectPdksostimOsbs { get; set; } = null!;
        public virtual DbSet<VwSelectPersonelGirisCikisSure> VwSelectPersonelGirisCikisSures { get; set; } = null!;
        public virtual DbSet<VwSelectPersonelGunSure> VwSelectPersonelGunSures { get; set; } = null!;
        public virtual DbSet<VwSelectPool> VwSelectPools { get; set; } = null!;
        public virtual DbSet<VwSelectPuantajAktarimAstor> VwSelectPuantajAktarimAstors { get; set; } = null!;
        public virtual DbSet<VwSelectRfidevent> VwSelectRfidevents { get; set; } = null!;
        public virtual DbSet<VwSelectSicilAll> VwSelectSicilAlls { get; set; } = null!;
        public virtual DbSet<VwSelectSicilDetayRapor> VwSelectSicilDetayRapors { get; set; } = null!;
        public virtual DbSet<VwSelectSicilIzinKural> VwSelectSicilIzinKurals { get; set; } = null!;
        public virtual DbSet<VwSelectSicilOzlukRapor> VwSelectSicilOzlukRapors { get; set; } = null!;
        public virtual DbSet<VwSelectTanimsizMesaiOdaSure> VwSelectTanimsizMesaiOdaSures { get; set; } = null!;
        public virtual DbSet<VwSelectTerminalAlarmStatus> VwSelectTerminalAlarmStatuses { get; set; } = null!;
        public virtual DbSet<VwSelectTerminalErisim> VwSelectTerminalErisims { get; set; } = null!;
        public virtual DbSet<VwSelectTerminalYetki> VwSelectTerminalYetkis { get; set; } = null!;
        public virtual DbSet<VwSelectTumSicilListesiRaporu> VwSelectTumSicilListesiRaporus { get; set; } = null!;
        public virtual DbSet<VwSelectUser> VwSelectUsers { get; set; } = null!;
        public virtual DbSet<VwSelectUserLog> VwSelectUserLogs { get; set; } = null!;
        public virtual DbSet<VwSelectUsersAndRole> VwSelectUsersAndRoles { get; set; } = null!;
        public virtual DbSet<VwSelectVardiyaliVardiyasizGirisCikisSure> VwSelectVardiyaliVardiyasizGirisCikisSures { get; set; } = null!;
        public virtual DbSet<VwSelectYemekhaneGeci> VwSelectYemekhaneGecis { get; set; } = null!;
        public virtual DbSet<VwSelectYemekhaneSayi> VwSelectYemekhaneSayis { get; set; } = null!;
        public virtual DbSet<VwSelectgecisresim> VwSelectgecisresims { get; set; } = null!;
        public virtual DbSet<VwSelectmail> VwSelectmails { get; set; } = null!;
        public virtual DbSet<VwSelectsize> VwSelectsizes { get; set; } = null!;
        public virtual DbSet<VwSicilAracListesi> VwSicilAracListesis { get; set; } = null!;
        public virtual DbSet<VwSicilDetayRapor> VwSicilDetayRapors { get; set; } = null!;
        public virtual DbSet<VwSicilGecisGrupsuz> VwSicilGecisGrupsuzs { get; set; } = null!;
        public virtual DbSet<VwSicilGirisCikisDinlenmeCalismaCizelge> VwSicilGirisCikisDinlenmeCalismaCizelges { get; set; } = null!;
        public virtual DbSet<VwSicilOzlukRaporuMefa> VwSicilOzlukRaporuMefas { get; set; } = null!;
        public virtual DbSet<VwSicilSonGeci> VwSicilSonGecis { get; set; } = null!;
        public virtual DbSet<VwSicilSonGecisRaporu> VwSicilSonGecisRaporus { get; set; } = null!;
        public virtual DbSet<VwSicilVeAracBilgileri> VwSicilVeAracBilgileris { get; set; } = null!;
        public virtual DbSet<VwSicilYetkiGrubuwithTerminal> VwSicilYetkiGrubuwithTerminals { get; set; } = null!;
        public virtual DbSet<VwSirketBazliYemekhaneRaporu> VwSirketBazliYemekhaneRaporus { get; set; } = null!;
        public virtual DbSet<VwSodexoHesap> VwSodexoHesaps { get; set; } = null!;
        public virtual DbSet<VwSodexoHesapOld> VwSodexoHesapOlds { get; set; } = null!;
        public virtual DbSet<VwStgArgePersonelBazliAraGeci> VwStgArgePersonelBazliAraGecis { get; set; } = null!;
        public virtual DbSet<VwStm2018arge> VwStm2018arges { get; set; } = null!;
        public virtual DbSet<VwTableSize> VwTableSizes { get; set; } = null!;
        public virtual DbSet<VwTasnifAragecisDetaylari> VwTasnifAragecisDetaylaris { get; set; } = null!;
        public virtual DbSet<VwTasnifDisiGecisler> VwTasnifDisiGecislers { get; set; } = null!;
        public virtual DbSet<VwTerminalErisim> VwTerminalErisims { get; set; } = null!;
        public virtual DbSet<VwTest> VwTests { get; set; } = null!;
        public virtual DbSet<VwTimeSheetReport> VwTimeSheetReports { get; set; } = null!;
        public virtual DbSet<VwToleransliOdaIcerideDisaridum> VwToleransliOdaIcerideDisarida { get; set; } = null!;
        public virtual DbSet<VwToplamOdalardakiSicilSayisi> VwToplamOdalardakiSicilSayisis { get; set; } = null!;
        public virtual DbSet<VwTpicozelRaporField> VwTpicozelRaporFields { get; set; } = null!;
        public virtual DbSet<VwTumGirisCikisRaporu> VwTumGirisCikisRaporus { get; set; } = null!;
        public virtual DbSet<VwTumIzinListesi> VwTumIzinListesis { get; set; } = null!;
        public virtual DbSet<VwUnauthorizedCardAccess> VwUnauthorizedCardAccesses { get; set; } = null!;
        public virtual DbSet<VwUnauthorizedCardAccessGateIo> VwUnauthorizedCardAccessGateIos { get; set; } = null!;
        public virtual DbSet<VwUsersInrole> VwUsersInroles { get; set; } = null!;
        public virtual DbSet<VwUygunKartlar> VwUygunKartlars { get; set; } = null!;
        public virtual DbSet<VwVakoAylikPuantaj> VwVakoAylikPuantajs { get; set; } = null!;
        public virtual DbSet<VwVardiyaSelect> VwVardiyaSelects { get; set; } = null!;
        public virtual DbSet<VwVardiyasizMesaiOzet> VwVardiyasizMesaiOzets { get; set; } = null!;
        public virtual DbSet<VwWcgecisler> VwWcgecislers { get; set; } = null!;
        public virtual DbSet<VwYemekHaneDetayliRapor> VwYemekHaneDetayliRapors { get; set; } = null!;
        public virtual DbSet<VwYemekhaneFirma> VwYemekhaneFirmas { get; set; } = null!;
        public virtual DbSet<VwYemekhaneOgunRaporlari> VwYemekhaneOgunRaporlaris { get; set; } = null!;
        public virtual DbSet<VwYemekhaneOgunRaporu0421> VwYemekhaneOgunRaporu0421s { get; set; } = null!;
        public virtual DbSet<VwYillikDetayliFazlaMesai> VwYillikDetayliFazlaMesais { get; set; } = null!;
        public virtual DbSet<VwYillikDetayliFm> VwYillikDetayliFms { get; set; } = null!;
        public virtual DbSet<VwYillikHakedilenveKalanIzin> VwYillikHakedilenveKalanIzins { get; set; } = null!;
        public virtual DbSet<VwYolUcretiRaporu> VwYolUcretiRaporus { get; set; } = null!;
        public virtual DbSet<VwZiyaretciHareketleri> VwZiyaretciHareketleris { get; set; } = null!;
        public virtual DbSet<VwZiyaretciListesi> VwZiyaretciListesis { get; set; } = null!;
        public virtual DbSet<VwZiyaretciListesiLokasyon> VwZiyaretciListesiLokasyons { get; set; } = null!;
        public virtual DbSet<VwZiyaretciRapor> VwZiyaretciRapors { get; set; } = null!;
        public virtual DbSet<WebpagesMembership> WebpagesMemberships { get; set; } = null!;
        public virtual DbSet<WebpagesOauthMembership> WebpagesOauthMemberships { get; set; } = null!;
        public virtual DbSet<WebpagesRole> WebpagesRoles { get; set; } = null!;
        public virtual DbSet<YapilacakFazlaMesaiOnaylar> YapilacakFazlaMesaiOnaylars { get; set; } = null!;
        public virtual DbSet<YapilacakFazlaMesailer> YapilacakFazlaMesailers { get; set; } = null!;
        public virtual DbSet<Yasaklar> Yasaklars { get; set; } = null!;
        public virtual DbSet<Yemekhane> Yemekhanes { get; set; } = null!;
        public virtual DbSet<YemekhaneDuty> YemekhaneDuties { get; set; } = null!;
        public virtual DbSet<Yetki> Yetkis { get; set; } = null!;
        public virtual DbSet<YetkiLog> YetkiLogs { get; set; } = null!;
        public virtual DbSet<Yuvarlamalar> Yuvarlamalars { get; set; } = null!;
        public virtual DbSet<Ziyaretci> Ziyaretcis { get; set; } = null!;
        public virtual DbSet<ZiyaretciListesi> ZiyaretciListesis { get; set; } = null!;
        public virtual DbSet<ZiyaretciLog> ZiyaretciLogs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-8B6JRIV\\SQLEXPRESS;Database=DEVELOP_MEYER;User ID=sa;Password=1878;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Turkish_CI_AS");

            modelBuilder.Entity<Access>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Access");

                entity.Property(e => e.End).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Owner)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.RecordDate).HasColumnType("datetime");

                entity.Property(e => e.Start).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userID")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Activation>(entity =>
            {
                entity.ToTable("Activation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Tarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<Aktarim>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("aktarim");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Kodu).HasMaxLength(50);
            });

            modelBuilder.Entity<Aktarimhr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("aktarimhr");

                entity.Property(e => e.Sid).HasColumnName("SID");
            });

            modelBuilder.Entity<AnketSonuc>(entity =>
            {
                entity.ToTable("AnketSonuc");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnketId).HasColumnName("AnketID");

                entity.Property(e => e.CevapId).HasColumnName("CevapID");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SoruId).HasColumnName("SoruID");

                entity.Property(e => e.Tarih).HasColumnType("datetime");

                entity.HasOne(d => d.Anket)
                    .WithMany(p => p.AnketSonucs)
                    .HasForeignKey(d => d.AnketId)
                    .HasConstraintName("FK_Anket_Sonuc_Anket_Tanim");

                entity.HasOne(d => d.Cevap)
                    .WithMany(p => p.AnketSonucs)
                    .HasForeignKey(d => d.CevapId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Anket_Sonuc_Anket_Cevap");

                entity.HasOne(d => d.Sicil)
                    .WithMany(p => p.AnketSonucs)
                    .HasForeignKey(d => d.SicilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Anket_Sonuc_Sicil");

                entity.HasOne(d => d.Soru)
                    .WithMany(p => p.AnketSonucs)
                    .HasForeignKey(d => d.SoruId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Anket_Sonuc_Anket_Soru");
            });

            modelBuilder.Entity<AnketSoru>(entity =>
            {
                entity.ToTable("AnketSoru");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AnketId).HasColumnName("AnketID");

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.SoruMetni).HasColumnType("ntext");

                entity.HasOne(d => d.Anket)
                    .WithMany(p => p.AnketSorus)
                    .HasForeignKey(d => d.AnketId)
                    .HasConstraintName("FK_Anket_Soru_Anket_Tanim");
            });

            modelBuilder.Entity<AnketSoruCevap>(entity =>
            {
                entity.ToTable("AnketSoruCevap");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CevapMetni).HasColumnType("ntext");

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.SoruId).HasColumnName("SoruID");

                entity.HasOne(d => d.Soru)
                    .WithMany(p => p.AnketSoruCevaps)
                    .HasForeignKey(d => d.SoruId)
                    .HasConstraintName("FK_Anket_Cevap_Anket_Soru");
            });

            modelBuilder.Entity<AnketTamamlanan>(entity =>
            {
                entity.ToTable("AnketTamamlanan");

                entity.Property(e => e.Zaman).HasColumnType("datetime");
            });

            modelBuilder.Entity<AnketTanim>(entity =>
            {
                entity.ToTable("AnketTanim");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BaslanticTarihi).HasColumnType("datetime");

                entity.Property(e => e.BitisTarihi).HasColumnType("datetime");

                entity.Property(e => e.Lokasyon)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");
            });

            modelBuilder.Entity<AraKayitlar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AraKAyitlar");

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.Fsure).HasColumnName("fsure");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.TasnifId).HasColumnName("TasnifID");
            });

            modelBuilder.Entity<Arac>(entity =>
            {
                entity.ToTable("Arac");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(20);

                entity.Property(e => e.Bilgi).HasColumnType("ntext");

                entity.Property(e => e.Cikis).HasColumnType("smalldatetime");

                entity.Property(e => e.CikisKm).HasDefaultValueSql("((0))");

                entity.Property(e => e.Firma).HasMaxLength(50);

                entity.Property(e => e.GeldigiBolum).HasDefaultValueSql("((0))");

                entity.Property(e => e.GidecegiYer).HasMaxLength(50);

                entity.Property(e => e.Giris).HasColumnType("smalldatetime");

                entity.Property(e => e.GirisKm).HasDefaultValueSql("((0))");

                entity.Property(e => e.Plaka).HasMaxLength(50);

                entity.Property(e => e.Soyad).HasMaxLength(20);

                entity.Property(e => e.Tur).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.CinsNavigation)
                    .WithMany(p => p.Aracs)
                    .HasForeignKey(d => d.Cins)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Arac_cbo_AracCinsi");

                entity.HasOne(d => d.GorevliNavigation)
                    .WithMany(p => p.Aracs)
                    .HasForeignKey(d => d.Gorevli)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Arac_cbo_Gorevli");
            });

            modelBuilder.Entity<AuthLog>(entity =>
            {
                entity.ToTable("AuthLog");

                entity.Property(e => e.CardId).HasMaxLength(50);

                entity.Property(e => e.CardIdHex).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(50);
            });

            modelBuilder.Entity<BakiyeGuncelleIslem>(entity =>
            {
                entity.ToTable("BakiyeGuncelleIslem");

                entity.Property(e => e.BaslangicTarih).HasColumnType("datetime");

                entity.Property(e => e.GuncellenecekBakiye).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GuncellenecekIcecekBakiye).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GuncellenecekYiyecekBakiye).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IslemTarih).HasColumnType("datetime");

                entity.Property(e => e.Tarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<BioPlu>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Gmt)
                    .HasColumnType("datetime")
                    .HasColumnName("gmt");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");
            });

            modelBuilder.Entity<BioPlusServer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BioPlusServer");

                entity.Property(e => e.StatusTime).HasColumnType("datetime");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");
            });

            modelBuilder.Entity<Bordro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Bordro");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Ba)
                    .HasColumnName("BA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.Tarih)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tutar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0.00')");
            });

            modelBuilder.Entity<CariIslemler>(entity =>
            {
                entity.ToTable("CariIslemler");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Aktif)
                    .IsRequired()
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Ba)
                    .HasColumnName("BA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IslemNo).HasMaxLength(50);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.Tarih).HasColumnType("smalldatetime");

                entity.Property(e => e.Tutar).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Sicil)
                    .WithMany(p => p.CariIslemlers)
                    .HasForeignKey(d => d.SicilId)
                    .HasConstraintName("FK_CariIslemler_Sicil");
            });

            modelBuilder.Entity<CboAltFirma>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cbo_AltFirma");

                entity.Property(e => e.Ad).HasMaxLength(50);
            });

            modelBuilder.Entity<CboAracCinsi>(entity =>
            {
                entity.ToTable("cbo_AracCinsi");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);
            });

            modelBuilder.Entity<CboBolum>(entity =>
            {
                entity.ToTable("cbo_Bolum");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(500);

                entity.Property(e => e.EntegrasyonKod).HasMaxLength(25);

                entity.Property(e => e.Okod1).HasColumnName("OKod1");

                entity.Property(e => e.PeriyodId).HasColumnName("PeriyodID");
            });

            modelBuilder.Entity<CboCalismaTip>(entity =>
            {
                entity.ToTable("cbo_CalismaTip");

                entity.Property(e => e.Adi).HasMaxLength(50);

                entity.Property(e => e.Kodu).HasMaxLength(50);
            });

            modelBuilder.Entity<CboDirektorluk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cbo_Direktorluk");

                entity.Property(e => e.Ad).HasMaxLength(50);
            });

            modelBuilder.Entity<CboEkOdeme>(entity =>
            {
                entity.ToTable("cbo_EkOdeme");

                entity.Property(e => e.Ad)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CboFirma>(entity =>
            {
                entity.ToTable("cbo_Firma");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(500);

                entity.Property(e => e.FirmaKodu).HasMaxLength(200);

                entity.Property(e => e.GlobalSicilIdgerekli).HasColumnName("GlobalSicilIDGerekli");

                entity.Property(e => e.Logo).HasColumnType("image");
            });

            modelBuilder.Entity<CboFmnedenleri>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cbo_FMNedenleri");

                entity.Property(e => e.Ad).HasMaxLength(50);
            });

            modelBuilder.Entity<CboGercekKategori>(entity =>
            {
                entity.ToTable("cbo_GercekKategori");

                entity.Property(e => e.Ad)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CboGorev>(entity =>
            {
                entity.ToTable("cbo_Gorev");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(500);

                entity.Property(e => e.Aksam).HasColumnName("aksam");

                entity.Property(e => e.Baslangic)
                    .HasColumnType("datetime")
                    .HasColumnName("baslangic");

                entity.Property(e => e.Bitis)
                    .HasColumnType("datetime")
                    .HasColumnName("bitis");

                entity.Property(e => e.EntegrasyonKod).HasMaxLength(25);

                entity.Property(e => e.Gece).HasColumnName("gece");

                entity.Property(e => e.Oglen).HasColumnName("oglen");

                entity.Property(e => e.Sabah).HasColumnName("sabah");

                entity.Property(e => e.Toplam).HasColumnName("toplam");

                entity.Property(e => e.TopluAlim).HasColumnName("toplu_alim");

                entity.Property(e => e.Ziyaretci).HasColumnName("ziyaretci");
            });

            modelBuilder.Entity<CboGorevli>(entity =>
            {
                entity.ToTable("cbo_Gorevli");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);
            });

            modelBuilder.Entity<CboIsCikisNedeni>(entity =>
            {
                entity.ToTable("cbo_IsCikisNedeni");

                entity.Property(e => e.Aciklama).HasMaxLength(500);

                entity.Property(e => e.Adi).HasMaxLength(50);

                entity.Property(e => e.Kodu).HasMaxLength(50);
            });

            modelBuilder.Entity<CboIsCikisNedeniSgk>(entity =>
            {
                entity.ToTable("cbo_IsCikisNedeniSGK");

                entity.Property(e => e.Aciklama).HasMaxLength(500);

                entity.Property(e => e.Adi).HasMaxLength(50);

                entity.Property(e => e.Kodu).HasMaxLength(50);
            });

            modelBuilder.Entity<CboIzinHakki>(entity =>
            {
                entity.ToTable("cbo_IzinHakki");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ad)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Kod)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CboKimlik>(entity =>
            {
                entity.ToTable("cbo_Kimlik");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);
            });

            modelBuilder.Entity<CboOzlukAlan>(entity =>
            {
                entity.ToTable("cbo_OzlukAlan");

                entity.Property(e => e.Ad).HasMaxLength(250);
            });

            modelBuilder.Entity<CboOzlukBolum>(entity =>
            {
                entity.ToTable("cbo_OzlukBolum");

                entity.Property(e => e.Ad).HasMaxLength(250);
            });

            modelBuilder.Entity<CboOzlukGorev>(entity =>
            {
                entity.ToTable("cbo_OzlukGorev");

                entity.Property(e => e.Ad).HasMaxLength(250);
            });

            modelBuilder.Entity<CboOzlukGorevYeri>(entity =>
            {
                entity.ToTable("cbo_OzlukGorevYeri");

                entity.Property(e => e.Ad).HasMaxLength(250);
            });

            modelBuilder.Entity<CboOzlukHizmetGorev>(entity =>
            {
                entity.ToTable("cbo_OzlukHizmetGorev");

                entity.Property(e => e.Ad).HasMaxLength(250);
            });

            modelBuilder.Entity<CboOzlukHizmetKadro>(entity =>
            {
                entity.ToTable("cbo_OzlukHizmetKadro");

                entity.Property(e => e.Ad).HasMaxLength(250);
            });

            modelBuilder.Entity<CboOzlukKadro>(entity =>
            {
                entity.ToTable("cbo_OzlukKadro");

                entity.Property(e => e.Ad).HasMaxLength(250);
            });

            modelBuilder.Entity<CboOzlukOkul>(entity =>
            {
                entity.ToTable("cbo_OzlukOkul");

                entity.Property(e => e.Ad).HasMaxLength(250);
            });

            modelBuilder.Entity<CboPozisyon>(entity =>
            {
                entity.ToTable("cbo_Pozisyon");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(500);

                entity.Property(e => e.EntegrasyonKod).HasMaxLength(25);
            });

            modelBuilder.Entity<CboPuantaj>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cbo_Puantaj");

                entity.Property(e => e.Ad).HasMaxLength(50);
            });

            modelBuilder.Entity<CboSaglikRapor>(entity =>
            {
                entity.ToTable("cbo_SaglikRapor");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ad)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Kod)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CboSendikaUnvan>(entity =>
            {
                entity.ToTable("cbo_SendikaUnvan");

                entity.Property(e => e.Ad).HasMaxLength(200);
            });

            modelBuilder.Entity<CboSgkbilgi>(entity =>
            {
                entity.ToTable("cbo_SGKBilgi");

                entity.Property(e => e.Aciklama).HasMaxLength(200);

                entity.Property(e => e.Adi).HasMaxLength(100);

                entity.Property(e => e.Kodu).HasMaxLength(50);
            });

            modelBuilder.Entity<CboSicil>(entity =>
            {
                entity.ToTable("cbo_Sicil");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);
            });

            modelBuilder.Entity<CboSirket>(entity =>
            {
                entity.ToTable("cbo_Sirket");

                entity.Property(e => e.Adi).HasMaxLength(50);
            });

            modelBuilder.Entity<CboSirketArac>(entity =>
            {
                entity.ToTable("cbo_SirketArac");

                entity.Property(e => e.Kasko)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Marka)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ModelYili)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MuayeneTarihi).HasColumnType("datetime");

                entity.Property(e => e.Plaka)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sigorta)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tip)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CboSirketBilgisayar>(entity =>
            {
                entity.ToTable("cbo_SirketBilgisayar");

                entity.Property(e => e.Marka)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SeriNo)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CboSirketTelefonCihaz>(entity =>
            {
                entity.ToTable("cbo_SirketTelefonCihaz");

                entity.Property(e => e.Imei)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("IMEI");

                entity.Property(e => e.Marka)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CboStatu>(entity =>
            {
                entity.ToTable("cbo_Statu");

                entity.Property(e => e.Aciklama).HasMaxLength(100);

                entity.Property(e => e.Adi).HasMaxLength(50);
            });

            modelBuilder.Entity<CboTaseronFirma>(entity =>
            {
                entity.ToTable("cbo_TaseronFirma");

                entity.Property(e => e.Aciklama).HasMaxLength(100);

                entity.Property(e => e.Adi).HasMaxLength(200);
            });

            modelBuilder.Entity<CboTimezone>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("cbo_timezone");

                entity.Property(e => e.Ad).HasMaxLength(24);
            });

            modelBuilder.Entity<CboUcakBiletHakki>(entity =>
            {
                entity.ToTable("cbo_UcakBiletHakki");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ad)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Kod)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CboUnvan>(entity =>
            {
                entity.ToTable("cbo_Unvan");

                entity.Property(e => e.Adi).HasMaxLength(50);

                entity.Property(e => e.Kodu).HasMaxLength(50);
            });

            modelBuilder.Entity<CboVizeKategori>(entity =>
            {
                entity.ToTable("cbo_VizeKategori");

                entity.Property(e => e.Ad)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CboYaka>(entity =>
            {
                entity.ToTable("cbo_Yaka");

                entity.Property(e => e.Ad).HasMaxLength(50);
            });

            modelBuilder.Entity<Checkup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("checkup");

                entity.Property(e => e.Zaman).HasColumnType("datetime");
            });

            modelBuilder.Entity<CiftayDetayliFazlaMesaiRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CiftayDetayliFazlaMesaiRaporu");

                entity.Property(e => e.Fm1).HasColumnName("FM1");

                entity.Property(e => e.Fm2).HasColumnName("FM2");

                entity.Property(e => e.GunIcerik).HasMaxLength(5);

                entity.Property(e => e._1)
                    .HasMaxLength(10)
                    .HasColumnName("1")
                    .IsFixedLength();

                entity.Property(e => e._10)
                    .HasMaxLength(10)
                    .HasColumnName("10")
                    .IsFixedLength();

                entity.Property(e => e._11)
                    .HasMaxLength(10)
                    .HasColumnName("11")
                    .IsFixedLength();

                entity.Property(e => e._12)
                    .HasMaxLength(10)
                    .HasColumnName("12")
                    .IsFixedLength();

                entity.Property(e => e._13)
                    .HasMaxLength(10)
                    .HasColumnName("13")
                    .IsFixedLength();

                entity.Property(e => e._14)
                    .HasMaxLength(10)
                    .HasColumnName("14")
                    .IsFixedLength();

                entity.Property(e => e._15)
                    .HasMaxLength(10)
                    .HasColumnName("15")
                    .IsFixedLength();

                entity.Property(e => e._16)
                    .HasMaxLength(10)
                    .HasColumnName("16")
                    .IsFixedLength();

                entity.Property(e => e._17)
                    .HasMaxLength(10)
                    .HasColumnName("17")
                    .IsFixedLength();

                entity.Property(e => e._18)
                    .HasMaxLength(10)
                    .HasColumnName("18")
                    .IsFixedLength();

                entity.Property(e => e._19)
                    .HasMaxLength(10)
                    .HasColumnName("19")
                    .IsFixedLength();

                entity.Property(e => e._2)
                    .HasMaxLength(10)
                    .HasColumnName("2")
                    .IsFixedLength();

                entity.Property(e => e._20)
                    .HasMaxLength(10)
                    .HasColumnName("20")
                    .IsFixedLength();

                entity.Property(e => e._21)
                    .HasMaxLength(10)
                    .HasColumnName("21")
                    .IsFixedLength();

                entity.Property(e => e._22)
                    .HasMaxLength(10)
                    .HasColumnName("22")
                    .IsFixedLength();

                entity.Property(e => e._23)
                    .HasMaxLength(10)
                    .HasColumnName("23")
                    .IsFixedLength();

                entity.Property(e => e._24)
                    .HasMaxLength(10)
                    .HasColumnName("24")
                    .IsFixedLength();

                entity.Property(e => e._25)
                    .HasMaxLength(10)
                    .HasColumnName("25")
                    .IsFixedLength();

                entity.Property(e => e._26)
                    .HasMaxLength(10)
                    .HasColumnName("26")
                    .IsFixedLength();

                entity.Property(e => e._27)
                    .HasMaxLength(10)
                    .HasColumnName("27")
                    .IsFixedLength();

                entity.Property(e => e._28)
                    .HasMaxLength(10)
                    .HasColumnName("28")
                    .IsFixedLength();

                entity.Property(e => e._29)
                    .HasMaxLength(10)
                    .HasColumnName("29")
                    .IsFixedLength();

                entity.Property(e => e._3)
                    .HasMaxLength(10)
                    .HasColumnName("3")
                    .IsFixedLength();

                entity.Property(e => e._30)
                    .HasMaxLength(10)
                    .HasColumnName("30")
                    .IsFixedLength();

                entity.Property(e => e._31)
                    .HasMaxLength(10)
                    .HasColumnName("31")
                    .IsFixedLength();

                entity.Property(e => e._4)
                    .HasMaxLength(10)
                    .HasColumnName("4")
                    .IsFixedLength();

                entity.Property(e => e._5)
                    .HasMaxLength(10)
                    .HasColumnName("5")
                    .IsFixedLength();

                entity.Property(e => e._6)
                    .HasMaxLength(10)
                    .HasColumnName("6")
                    .IsFixedLength();

                entity.Property(e => e._7)
                    .HasMaxLength(10)
                    .HasColumnName("7")
                    .IsFixedLength();

                entity.Property(e => e._8)
                    .HasMaxLength(10)
                    .HasColumnName("8")
                    .IsFixedLength();

                entity.Property(e => e._9)
                    .HasMaxLength(10)
                    .HasColumnName("9")
                    .IsFixedLength();
            });

            modelBuilder.Entity<CihazDurum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CihazDurum");

                entity.Property(e => e.Durum)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("durum");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Port).HasMaxLength(15);

                entity.Property(e => e.Zaman).HasColumnType("datetime");
            });

            modelBuilder.Entity<ClockworkBellControl>(entity =>
            {
                entity.HasKey(e => new { e.TerminalId, e.ClockworkBellId });

                entity.ToTable("ClockworkBellControl");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.ClockworkBellId).HasColumnName("ClockworkBellID");

                entity.Property(e => e.BellTimeTypeId)
                    .HasColumnName("BellTimeTypeID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.TimeSecond).HasDefaultValueSql("((3))");

                entity.HasOne(d => d.BellTimeType)
                    .WithMany(p => p.ClockworkBellControls)
                    .HasForeignKey(d => d.BellTimeTypeId)
                    .HasConstraintName("FK_ClockworkBellControl_sys_BellTimeType");

                entity.HasOne(d => d.Terminal)
                    .WithMany(p => p.ClockworkBellControls)
                    .HasForeignKey(d => d.TerminalId)
                    .HasConstraintName("FK_ClockworkBellControl_Terminaller");
            });

            modelBuilder.Entity<CompanyInfo>(entity =>
            {
                entity.HasKey(e => e.Kod);

                entity.ToTable("CompanyInfo");

                entity.Property(e => e.Kod).HasMaxLength(20);

                entity.Property(e => e.Adres).HasMaxLength(100);

                entity.Property(e => e.Bilgi).HasColumnType("text");

                entity.Property(e => e.Fax).HasMaxLength(15);

                entity.Property(e => e.Il)
                    .HasMaxLength(20)
                    .HasColumnName("IL");

                entity.Property(e => e.Ilce)
                    .HasMaxLength(20)
                    .HasColumnName("ILce");

                entity.Property(e => e.Kroki).HasColumnType("image");

                entity.Property(e => e.Logo).HasColumnType("image");

                entity.Property(e => e.PostaKodu).HasMaxLength(10);

                entity.Property(e => e.Telefon1).HasMaxLength(15);

                entity.Property(e => e.Telefon2).HasMaxLength(15);

                entity.Property(e => e.Unvan).HasMaxLength(50);

                entity.Property(e => e.VergiDairesi).HasMaxLength(50);

                entity.Property(e => e.VergiNo).HasMaxLength(50);
            });

            modelBuilder.Entity<Creport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("creport");

                entity.Property(e => e.Ad).HasMaxLength(50);
            });

            modelBuilder.Entity<CustomReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CustomReport");

                entity.Property(e => e.Ad).HasMaxLength(50);
            });

            modelBuilder.Entity<DayLight>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DayLight");

                entity.Property(e => e.ChangeTimeE).HasColumnType("smalldatetime");

                entity.Property(e => e.ChangeTimeS).HasColumnType("smalldatetime");

                entity.Property(e => e.RestoreTimeE).HasColumnType("smalldatetime");

                entity.Property(e => e.RestoreTimeS).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<DebugmoniTor>(entity =>
            {
                entity.ToTable("DEBUGMONiTOR");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Message).HasColumnName("MESSAGE");

                entity.Property(e => e.TiMe)
                    .HasColumnType("datetime")
                    .HasColumnName("TiME")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Denied>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Denied");

                entity.Property(e => e.AccessDate).HasColumnType("datetime");

                entity.Property(e => e.CardId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CardID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FacilityCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Reader)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeviceYetki>(entity =>
            {
                entity.ToTable("DeviceYetki");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuthLimitCountx).HasColumnName("authLimitCountx");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.TimedAntiPassbackx).HasColumnName("timedAntiPassbackx");

                entity.Property(e => e.TimezoneId).HasColumnName("TimezoneID");

                entity.Property(e => e.YetkiId).HasColumnName("YetkiID");
            });

            modelBuilder.Entity<DeviceYetkiLog>(entity =>
            {
                entity.ToTable("DeviceYetki_Log");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuthLimitCountx).HasColumnName("authLimitCountx");

                entity.Property(e => e.IslemDateTime).HasColumnType("datetime");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.TimedAntiPassbackx).HasColumnName("timedAntiPassbackx");

                entity.Property(e => e.TimezoneId).HasColumnName("TimezoneID");

                entity.Property(e => e.YetkiId).HasColumnName("YetkiID");
            });

            modelBuilder.Entity<DinamikLokasyon>(entity =>
            {
                entity.ToTable("DinamikLokasyon");

                entity.Property(e => e.Ad).HasMaxLength(500);
            });

            modelBuilder.Entity<DinamikRaporJoin>(entity =>
            {
                entity.ToTable("DinamikRaporJoin");
            });

            modelBuilder.Entity<DinamikRaporKolon>(entity =>
            {
                entity.ToTable("DinamikRaporKolon");

                entity.HasOne(d => d.Join)
                    .WithMany(p => p.DinamikRaporKolons)
                    .HasForeignKey(d => d.JoinId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DinamikRaporKolon_DinamikRaporJoin");

                entity.HasOne(d => d.RaporTipNavigation)
                    .WithMany(p => p.DinamikRaporKolons)
                    .HasForeignKey(d => d.RaporTip)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DinamikRaporKolon_DinamikRaporTip");
            });

            modelBuilder.Entity<DinamikRaporSearchParam>(entity =>
            {
                entity.Property(e => e.BaslangicTarihi).HasColumnType("datetime");

                entity.Property(e => e.BirimId).HasMaxLength(4000);

                entity.Property(e => e.BitisTarihi).HasColumnType("datetime");

                entity.Property(e => e.BolumId).HasMaxLength(4000);

                entity.Property(e => e.FirmaId).HasMaxLength(4000);

                entity.Property(e => e.GorevId).HasMaxLength(4000);

                entity.Property(e => e.PozisyonId).HasMaxLength(4000);

                entity.Property(e => e.SicilId)
                    .HasMaxLength(4000)
                    .HasColumnName("SicilID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DinamikRaporSearchParams)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DinamikRaporSearchParams_UserTables");
            });

            modelBuilder.Entity<DinamikRaporSecim>(entity =>
            {
                entity.ToTable("DinamikRaporSecim");

                entity.HasOne(d => d.RaporKolon)
                    .WithMany(p => p.DinamikRaporSecims)
                    .HasForeignKey(d => d.RaporKolonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DinamikRaporSecim_DinamikRaporKolon");

                entity.HasOne(d => d.RaporTanim)
                    .WithMany(p => p.DinamikRaporSecims)
                    .HasForeignKey(d => d.RaporTanimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DinamikRaporSecim_DinamikRaporlar");
            });

            modelBuilder.Entity<DinamikRaporTip>(entity =>
            {
                entity.ToTable("DinamikRaporTip");
            });

            modelBuilder.Entity<DinamikRaporlar>(entity =>
            {
                entity.ToTable("DinamikRaporlar");

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.HasOne(d => d.RaporTipNavigation)
                    .WithMany(p => p.DinamikRaporlars)
                    .HasForeignKey(d => d.RaporTip)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DinamikRaporlar_DinamikRaporTip");
            });

            modelBuilder.Entity<DinlenmeAtamalari>(entity =>
            {
                entity.HasKey(e => new { e.MesaiId, e.DinlenmeId });

                entity.ToTable("DinlenmeAtamalari");

                entity.HasIndex(e => e.Id, "IX_DinlenmeAtamalari")
                    .IsUnique();

                entity.Property(e => e.MesaiId).HasColumnName("MesaiID");

                entity.Property(e => e.DinlenmeId).HasColumnName("DinlenmeID");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.HasOne(d => d.Dinlenme)
                    .WithMany(p => p.DinlenmeAtamalaris)
                    .HasForeignKey(d => d.DinlenmeId)
                    .HasConstraintName("FK_DinlenmeAtamalari_Dinlenmeler");

                entity.HasOne(d => d.Mesai)
                    .WithMany(p => p.DinlenmeAtamalaris)
                    .HasForeignKey(d => d.MesaiId)
                    .HasConstraintName("FK_DinlenmeAtamalari_Mesailer");
            });

            modelBuilder.Entity<Dinlenmeler>(entity =>
            {
                entity.ToTable("Dinlenmeler");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Duzensiz)
                    .IsRequired()
                    .HasDefaultValueSql("((-1))");
            });

            modelBuilder.Entity<DoorControl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DoorControl");

                entity.Property(e => e.Acildi).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Kapandi).HasColumnType("datetime");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");
            });

            modelBuilder.Entity<Doorduty>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("doorduty");

                entity.Property(e => e.Controllerno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Port)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("port");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.RecordDate).HasColumnType("datetime");

                entity.Property(e => e.Time).HasColumnName("time");
            });

            modelBuilder.Entity<Duty>(entity =>
            {
                entity.ToTable("Duty");

                entity.Property(e => e.DeviceMessage).HasMaxLength(500);

                entity.Property(e => e.Owner)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Process)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.RecordDate).HasColumnType("datetime");

                entity.Property(e => e.TargetDevice)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeZoneId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TimeZoneID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userID")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DutyOther>(entity =>
            {
                entity.ToTable("DutyOther");

                entity.Property(e => e.ProcessCode).HasMaxLength(50);

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.RecordDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<DuyuruTanim>(entity =>
            {
                entity.ToTable("DuyuruTanim");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Aciklama).HasColumnType("ntext");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BaslanticTarihi).HasColumnType("datetime");

                entity.Property(e => e.BitisTarihi).HasColumnType("datetime");

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");
            });

            modelBuilder.Entity<EgitimKatilimcilar>(entity =>
            {
                entity.ToTable("EgitimKatilimcilar");

                entity.HasOne(d => d.Egitim)
                    .WithMany(p => p.EgitimKatilimcilars)
                    .HasForeignKey(d => d.EgitimId)
                    .HasConstraintName("FK_EgitimKatilimcilar_Egitimler");

                entity.HasOne(d => d.Sicil)
                    .WithMany(p => p.EgitimKatilimcilars)
                    .HasForeignKey(d => d.SicilId)
                    .HasConstraintName("FK_EgitimKatilimcilar_Sicil");
            });

            modelBuilder.Entity<Egitimler>(entity =>
            {
                entity.ToTable("Egitimler");

                entity.Property(e => e.Aciklama).HasMaxLength(500);

                entity.Property(e => e.Ad).HasMaxLength(500);

                entity.Property(e => e.BaslangicZamani).HasColumnType("datetime");

                entity.Property(e => e.BitisZamani).HasColumnType("datetime");

                entity.Property(e => e.EgitimTipi).HasMaxLength(50);

                entity.Property(e => e.EgitimiVerenKurum).HasMaxLength(50);

                entity.Property(e => e.EgitmenDis).HasMaxLength(150);

                entity.Property(e => e.FinansTipi).HasMaxLength(50);

                entity.Property(e => e.Lokasyon).HasMaxLength(50);

                entity.Property(e => e.Organizator).HasMaxLength(50);

                entity.HasOne(d => d.EgitmenSicil)
                    .WithMany(p => p.Egitimlers)
                    .HasForeignKey(d => d.EgitmenSicilId)
                    .HasConstraintName("FK_Egitimler_Sicil");
            });

            modelBuilder.Entity<EkYetkiler>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EkYetkiler");

                entity.Property(e => e.SicilId).HasColumnName("sicilID");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.TimeZoneId).HasColumnName("TimeZoneID");

                entity.Property(e => e.Zaman)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Email>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Email");

                entity.Property(e => e.Data)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.Rcptto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecordDate).HasColumnType("datetime");

                entity.Property(e => e.SicilId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("sicilID");

                entity.Property(e => e.Subject)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<Export>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Export");

                entity.Property(e => e.SourceActive)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.SourceAd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SourceCardId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SourceCardID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SourceCodeValue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SourceDatabase)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SourceFacilityCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SourceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SourceID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SourceIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SourceIP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SourceLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SourcePass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SourceSicilId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SourceSicilID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SourceSoyad)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SourceTable1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SourceTable2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SourceTable3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SourceTerminalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SourceTerminalID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SourceTerminalIdx)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SourceTerminalIDX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SourceTerminalname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SourceUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SourceUserID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sourcebolum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TargetDatabase)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TargetFunccode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TargetIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TargetIP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TargetLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TargetPass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TargetReaderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TargetReaderID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TargetSicilId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TargetSicilID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TargetTable)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TargetTerminalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TargetTerminalID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TargetUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TargetUserID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Targetactive)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Targeteventtime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<FirmaBilgisi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FirmaBilgisi");

                entity.Property(e => e.Ad).HasMaxLength(30);

                entity.Property(e => e.Adres).HasMaxLength(200);

                entity.Property(e => e.Bilgi).HasColumnType("text");

                entity.Property(e => e.Fax).HasMaxLength(15);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Il)
                    .HasMaxLength(20)
                    .HasColumnName("IL");

                entity.Property(e => e.Ilce).HasMaxLength(20);

                entity.Property(e => e.Logo).HasColumnType("image");

                entity.Property(e => e.Posta).HasMaxLength(10);

                entity.Property(e => e.Semt).HasMaxLength(20);

                entity.Property(e => e.Telefon1).HasMaxLength(15);

                entity.Property(e => e.Telefon2).HasMaxLength(15);

                entity.Property(e => e.Unvan).HasMaxLength(100);
            });

            modelBuilder.Entity<Fmplanlari>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FMPlanlari");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.BelgeNo).HasMaxLength(50);

                entity.Property(e => e.CalisanSicilId).HasColumnName("CalisanSicilID");

                entity.Property(e => e.Fm).HasColumnName("FM");

                entity.Property(e => e.FmnedenleriId).HasColumnName("FMNedenleriID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IzinliSicilId).HasColumnName("IzinliSicilID");

                entity.Property(e => e.SaatlikUcret).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tarih).HasColumnType("smalldatetime");

                entity.HasOne(d => d.CalisanSicil)
                    .WithMany()
                    .HasForeignKey(d => d.CalisanSicilId)
                    .HasConstraintName("FK_FMPlanlari_Sicil");

                entity.HasOne(d => d.Fmnedenleri)
                    .WithMany()
                    .HasForeignKey(d => d.FmnedenleriId)
                    .HasConstraintName("FK_FMPlanlari_IzinTipleri");
            });

            modelBuilder.Entity<Forceddoor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("forceddoor");

                entity.Property(e => e.Description).HasMaxLength(90);

                entity.Property(e => e.Eventtime).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Fotograf>(entity =>
            {
                entity.ToTable("Fotograf");

                entity.Property(e => e.DosyaYol).HasMaxLength(255);

                entity.Property(e => e.EventTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Function>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(4);
            });

            modelBuilder.Entity<GeciciKartGecisListesi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GeciciKartGecisListesi");

                entity.Property(e => e.Bolum).HasMaxLength(500);

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.Firma).HasMaxLength(500);

                entity.Property(e => e.GeciciKartAd).HasMaxLength(101);

                entity.Property(e => e.GeciciKartIslemBitisTarihi).HasColumnType("datetime");

                entity.Property(e => e.GeciciKartUserId).HasMaxLength(8);

                entity.Property(e => e.GeciciKartVerilmeTarih).HasColumnType("datetime");

                entity.Property(e => e.Gorev).HasMaxLength(500);

                entity.Property(e => e.Isim).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.Pozisyon).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SonGecerlilikTarih).HasColumnType("datetime");

                entity.Property(e => e.Soyisim).HasMaxLength(50);

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.Yon).HasMaxLength(50);
            });

            modelBuilder.Entity<GorevlendirmeTipler>(entity =>
            {
                entity.ToTable("GorevlendirmeTipler");

                entity.Property(e => e.Ad).HasMaxLength(150);

                entity.Property(e => e.Kod).HasMaxLength(4);
            });

            modelBuilder.Entity<Gorevlendirmeler>(entity =>
            {
                entity.ToTable("Gorevlendirmeler");

                entity.Property(e => e.Aciklama).HasMaxLength(500);

                entity.Property(e => e.Baslangic).HasColumnType("datetime");

                entity.Property(e => e.Bitis).HasColumnType("datetime");

                entity.Property(e => e.EntegrasyonKod).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<Guncelleme>(entity =>
            {
                entity.ToTable("Guncelleme");

                entity.Property(e => e.ScriptDate).HasColumnType("datetime");

                entity.Property(e => e.SelectedUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.TableorViewName).HasMaxLength(200);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<HbysAktarim>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HBYS_Aktarim");

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.MesaiBaslangic).HasColumnType("datetime");

                entity.Property(e => e.MesaiBitis).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.ToplamCalisma).HasMaxLength(5);
            });

            modelBuilder.Entity<HesaplamaTipleri>(entity =>
            {
                entity.ToTable("HesaplamaTipleri");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.HesaplamaTip).HasMaxLength(50);
            });

            modelBuilder.Entity<HesaplayiciIstisnalar>(entity =>
            {
                entity.ToTable("HesaplayiciIstisnalar");

                entity.Property(e => e.IstisnaAdi).HasMaxLength(50);
            });

            modelBuilder.Entity<Holiday>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DayId)
                    .HasColumnName("DayID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.HolidayName).HasMaxLength(50);

                entity.Property(e => e.MonthId)
                    .HasColumnName("MonthID")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<HysTblGorevler>(entity =>
            {
                entity.ToTable("HYS_Tbl_Gorevler");

                entity.Property(e => e.Ad).HasMaxLength(150);
            });

            modelBuilder.Entity<HysTblKullaniciRolleri>(entity =>
            {
                entity.ToTable("HYS_Tbl_KullaniciRolleri");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Rol).HasMaxLength(50);
            });

            modelBuilder.Entity<HysTblKullanicilar>(entity =>
            {
                entity.ToTable("HYS_Tbl_Kullanicilar");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.KullaniciAdi).HasMaxLength(100);

                entity.Property(e => e.Parola).HasMaxLength(250);

                entity.HasOne(d => d.RolNavigation)
                    .WithMany(p => p.HysTblKullanicilars)
                    .HasForeignKey(d => d.Rol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HYS_Tbl_Kullanicilar_HYS_Tbl_KullaniciRolleri");

                entity.HasOne(d => d.Sicil)
                    .WithMany(p => p.HysTblKullanicilars)
                    .HasForeignKey(d => d.SicilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HYS_Tbl_Kullanicilar_Sicil");
            });

            modelBuilder.Entity<HysTblKullaniciyaAtananSurecler>(entity =>
            {
                entity.ToTable("HYS_Tbl_KullaniciyaAtananSurecler");

                entity.HasOne(d => d.Sicil)
                    .WithMany(p => p.HysTblKullaniciyaAtananSureclers)
                    .HasForeignKey(d => d.SicilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HYS_Tbl_KullaniciyaAtananSurecler_Sicil");

                entity.HasOne(d => d.Surec0)
                    .WithMany(p => p.HysTblKullaniciyaAtananSureclerSurec0s)
                    .HasForeignKey(d => d.Surec0Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HYS_Tbl_KullaniciyaAtananSurecler_HYS_Tbl_OnaySurecleri");

                entity.HasOne(d => d.Surec1)
                    .WithMany(p => p.HysTblKullaniciyaAtananSureclerSurec1s)
                    .HasForeignKey(d => d.Surec1Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HYS_Tbl_KullaniciyaAtananSurecler_HYS_Tbl_OnaySurecleri1");
            });

            modelBuilder.Entity<HysTblMasrafOnaylari>(entity =>
            {
                entity.ToTable("HYS_Tbl_MasrafOnaylari");

                entity.Property(e => e.OnayZamani).HasColumnType("datetime");

                entity.HasOne(d => d.OnayciNavigation)
                    .WithMany(p => p.HysTblMasrafOnaylaris)
                    .HasForeignKey(d => d.Onayci)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HYS_Tbl_MasrafOnaylari_HYS_Tbl_Kullanicilar");

                entity.HasOne(d => d.Talep)
                    .WithMany(p => p.HysTblMasrafOnaylaris)
                    .HasForeignKey(d => d.TalepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HYS_Tbl_MasrafOnaylari_HYS_Tbl_MasrafTalepleri");
            });

            modelBuilder.Entity<HysTblMasrafTalepleri>(entity =>
            {
                entity.ToTable("HYS_Tbl_MasrafTalepleri");

                entity.Property(e => e.RedMesaji).HasMaxLength(300);

                entity.Property(e => e.TalepZamani).HasColumnType("datetime");

                entity.Property(e => e.Unvan).HasMaxLength(150);

                entity.HasOne(d => d.Sicil)
                    .WithMany(p => p.HysTblMasrafTalepleris)
                    .HasForeignKey(d => d.SicilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HYS_Tbl_MasrafTalepleri_Sicil");
            });

            modelBuilder.Entity<HysTblMasrafTuru>(entity =>
            {
                entity.ToTable("HYS_Tbl_MasrafTuru");

                entity.Property(e => e.Ad).HasMaxLength(150);
            });

            modelBuilder.Entity<HysTblMasraflar>(entity =>
            {
                entity.ToTable("HYS_Tbl_Masraflar");

                entity.Property(e => e.Aciklama).HasMaxLength(250);

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1900)-(1))-(1))");

                entity.Property(e => e.Tutar).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.MasrafTuruNavigation)
                    .WithMany(p => p.HysTblMasraflars)
                    .HasForeignKey(d => d.MasrafTuru)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HYS_Tbl_Masraflar_HYS_Tbl_MasrafTuru");

                entity.HasOne(d => d.OdemeSekliNavigation)
                    .WithMany(p => p.HysTblMasraflars)
                    .HasForeignKey(d => d.OdemeSekli)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HYS_Tbl_Masraflar_HYS_Tbl_OdemeSekli");

                entity.HasOne(d => d.Talep)
                    .WithMany(p => p.HysTblMasraflars)
                    .HasForeignKey(d => d.TalepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HYS_Tbl_Masraflar_HYS_Tbl_MasrafTalepleri");
            });

            modelBuilder.Entity<HysTblOdemeSekli>(entity =>
            {
                entity.ToTable("HYS_Tbl_OdemeSekli");

                entity.Property(e => e.Ad).HasMaxLength(150);
            });

            modelBuilder.Entity<HysTblOnaySurecleri>(entity =>
            {
                entity.ToTable("HYS_Tbl_OnaySurecleri");

                entity.Property(e => e.Ad).HasMaxLength(250);
            });

            modelBuilder.Entity<HysTblOnaycilar>(entity =>
            {
                entity.ToTable("HYS_Tbl_Onaycilar");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.HysTblOnaycilars)
                    .HasForeignKey(d => d.KullaniciId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HYS_Tbl_Onaycilar_HYS_Tbl_Kullanicilar");

                entity.HasOne(d => d.Surec)
                    .WithMany(p => p.HysTblOnaycilars)
                    .HasForeignKey(d => d.SurecId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HYS_Tbl_Onaycilar_HYS_Tbl_OnaySurecleri");
            });

            modelBuilder.Entity<HysTblSeyahatIstekleri>(entity =>
            {
                entity.ToTable("HYS_Tbl_SeyahatIstekleri");

                entity.Property(e => e.RedMesaji).HasMaxLength(300);

                entity.Property(e => e.TalepZamani).HasColumnType("datetime");

                entity.Property(e => e.Unvan).HasMaxLength(150);

                entity.HasOne(d => d.Sicil)
                    .WithMany(p => p.HysTblSeyahatIstekleris)
                    .HasForeignKey(d => d.SicilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HYS_Tbl_SeyahatIstekleri_Sicil");
            });

            modelBuilder.Entity<HysTblSeyahatOnaylari>(entity =>
            {
                entity.ToTable("HYS_Tbl_SeyahatOnaylari");

                entity.Property(e => e.OnayZamani).HasColumnType("datetime");

                entity.HasOne(d => d.Istek)
                    .WithMany(p => p.HysTblSeyahatOnaylaris)
                    .HasForeignKey(d => d.IstekId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HYS_Tbl_SeyahatOnaylari_HYS_Tbl_SeyahatIstekleri");

                entity.HasOne(d => d.OnayciNavigation)
                    .WithMany(p => p.HysTblSeyahatOnaylaris)
                    .HasForeignKey(d => d.Onayci)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HYS_Tbl_SeyahatOnaylari_HYS_Tbl_Kullanicilar");
            });

            modelBuilder.Entity<HysTblSeyahatler>(entity =>
            {
                entity.ToTable("HYS_Tbl_Seyahatler");

                entity.Property(e => e.Aciklama).HasMaxLength(250);

                entity.Property(e => e.Nereden).HasMaxLength(150);

                entity.Property(e => e.Nereye).HasMaxLength(150);

                entity.Property(e => e.Otel).HasMaxLength(250);

                entity.Property(e => e.Tarih).HasColumnType("date");

                entity.HasOne(d => d.GorevNavigation)
                    .WithMany(p => p.HysTblSeyahatlers)
                    .HasForeignKey(d => d.Gorev)
                    .HasConstraintName("FK_HYS_Tbl_Seyahatler_HYS_Tbl_Gorevler");

                entity.HasOne(d => d.Talep)
                    .WithMany(p => p.HysTblSeyahatlers)
                    .HasForeignKey(d => d.TalepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HYS_Tbl_Seyahatler_HYS_Tbl_SeyahatIstekleri");

                entity.HasOne(d => d.Ulasim)
                    .WithMany(p => p.HysTblSeyahatlers)
                    .HasForeignKey(d => d.UlasimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HYS_Tbl_Seyahatler_HYS_Tbl_UlasimAraclari");
            });

            modelBuilder.Entity<HysTblUlasimAraclari>(entity =>
            {
                entity.ToTable("HYS_Tbl_UlasimAraclari");

                entity.Property(e => e.Ad).HasMaxLength(150);
            });

            modelBuilder.Entity<HysVwSicilListesi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HYS_vw_SicilListesi");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Surec0Adi).HasMaxLength(250);

                entity.Property(e => e.Surec1Adi).HasMaxLength(250);
            });

            modelBuilder.Entity<IsGorevTanim>(entity =>
            {
                entity.ToTable("IsGorevTanim");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Aciklama).HasColumnType("ntext");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BaslanticTarihi).HasColumnType("datetime");

                entity.Property(e => e.BitisTarihi).HasColumnType("datetime");

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.HasOne(d => d.MobilKullanici)
                    .WithMany(p => p.IsGorevTanims)
                    .HasForeignKey(d => d.MobilKullaniciId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IsGorevTanim_MobilKullanici");
            });

            modelBuilder.Entity<IzinGirisFormu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("IzinGirisFormu");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Adres).HasMaxLength(100);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.IseBaslamaTarih).HasColumnType("datetime");

                entity.Property(e => e.IseGirisTar).HasColumnType("smalldatetime");

                entity.Property(e => e.IzinAd).HasMaxLength(50);

                entity.Property(e => e.IzinBaslangicTar).HasColumnType("datetime");

                entity.Property(e => e.IzinBitisTar).HasColumnType("datetime");

                entity.Property(e => e.IzinId).HasColumnName("IzinID");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tcno)
                    .HasMaxLength(20)
                    .HasColumnName("TCNo");

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<IzinTalepBakiye>(entity =>
            {
                entity.ToTable("IzinTalepBakiye");

                entity.Property(e => e.BakiyeFarkiGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DevredenBakiye).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.EkIzinGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IzinBakiye).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.KalanIzinGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SonHesaplamaTarihi).HasColumnType("datetime");
            });

            modelBuilder.Entity<IzinTipleri>(entity =>
            {
                entity.ToTable("IzinTipleri");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.EntegrasyonKod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Kod).HasMaxLength(3);
            });

            modelBuilder.Entity<Izinler>(entity =>
            {
                entity.ToTable("Izinler");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AnlikSira).HasDefaultValueSql("((1))");

                entity.Property(e => e.BasTarih).HasColumnType("datetime");

                entity.Property(e => e.BitTarih).HasColumnType("datetime");

                entity.Property(e => e.Gun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GuncellemeZamani).HasColumnType("datetime");

                entity.Property(e => e.IseBaslamaTarih).HasColumnType("datetime");

                entity.Property(e => e.IzinTalepDosyasi).HasMaxLength(1000);

                entity.Property(e => e.KarsiAktarimIdTcSicil)
                    .HasMaxLength(150)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.TalepEdenUserId).HasColumnName("TalepEdenUserID");

                entity.Property(e => e.Tarih).HasColumnType("smalldatetime");

                entity.Property(e => e.TipId).HasColumnName("TipID");

                entity.HasOne(d => d.Sicil)
                    .WithMany(p => p.Izinlers)
                    .HasForeignKey(d => d.SicilId)
                    .HasConstraintName("FK_Izinler_Sicil");

                entity.HasOne(d => d.Tip)
                    .WithMany(p => p.Izinlers)
                    .HasForeignKey(d => d.TipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Izinler_IzinTipleri");
            });

            modelBuilder.Entity<IzinlerLog>(entity =>
            {
                entity.ToTable("Izinler_Log");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnlikSira).HasDefaultValueSql("((1))");

                entity.Property(e => e.BasTarih).HasColumnType("datetime");

                entity.Property(e => e.BitTarih).HasColumnType("datetime");

                entity.Property(e => e.Gun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IseBaslamaTarih).HasColumnType("datetime");

                entity.Property(e => e.IslemDatetime).HasColumnType("datetime");

                entity.Property(e => e.IzinTalepDosyasi).HasMaxLength(1000);

                entity.Property(e => e.KarsiAktarimIdTcSicil).HasMaxLength(150);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.Tarih).HasColumnType("smalldatetime");

                entity.Property(e => e.TipId).HasColumnName("TipID");
            });

            modelBuilder.Entity<JsonLog>(entity =>
            {
                entity.ToTable("JsonLog");

                entity.Property(e => e.Json).HasColumnType("ntext");

                entity.Property(e => e.Zaman).HasColumnType("datetime");
            });

            modelBuilder.Entity<KafeteryaHarcamaLimit>(entity =>
            {
                entity.ToTable("KafeteryaHarcamaLimit");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AylikLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GunlukLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.YakaTip).HasMaxLength(10);
            });

            modelBuilder.Entity<KafeteryaKalanHakLog>(entity =>
            {
                entity.ToTable("KafeteryaKalanHakLog");

                entity.Property(e => e.Aciklama).HasMaxLength(500);

                entity.Property(e => e.Zaman).HasColumnType("datetime");
            });

            modelBuilder.Entity<KafeteryaLog>(entity =>
            {
                entity.ToTable("KafeteryaLog");

                entity.Property(e => e.Aciklama).HasMaxLength(500);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");
            });

            modelBuilder.Entity<KafeteryaOnaysizFazlaMesai>(entity =>
            {
                entity.ToTable("KafeteryaOnaysizFazlaMesai");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IcecekDusum).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tarih).HasColumnType("datetime");

                entity.Property(e => e.YiyecekDusum).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<KrediTakip>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KrediTakip");

                entity.Property(e => e.Islem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("islem");

                entity.Property(e => e.SicilId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sicilID");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("tarih");

                entity.Property(e => e.TerminalId)
                    .HasColumnName("terminalID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tutar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tutar");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userID");
            });

            modelBuilder.Entity<KullaniciRolTanimlari>(entity =>
            {
                entity.HasKey(e => e.RolId);

                entity.ToTable("KullaniciRolTanimlari");

                entity.Property(e => e.RolId).ValueGeneratedNever();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.SecilenModuller).HasColumnType("ntext");

                entity.HasOne(d => d.Rol)
                    .WithOne(p => p.KullaniciRolTanimlari)
                    .HasForeignKey<KullaniciRolTanimlari>(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KullaniciRolTanimlari_webpages_Roles1");
            });

            modelBuilder.Entity<Licence>(entity =>
            {
                entity.ToTable("Licence");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<LiftTemplate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LiftTemplate");

                entity.Property(e => e.MyDevice)
                    .HasMaxLength(100)
                    .HasColumnName("myDevice");

                entity.Property(e => e.MyTemplate)
                    .HasMaxLength(100)
                    .HasColumnName("myTemplate");

                entity.Property(e => e.MyValue).HasColumnName("myValue");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.ToTable("Login");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AltFirma).HasDefaultValueSql("((0))");

                entity.Property(e => e.Kademe).HasDefaultValueSql("((0))");

                entity.Property(e => e.LoginName).HasMaxLength(30);

                entity.Property(e => e.Password).HasMaxLength(30);

                entity.Property(e => e.Pcip)
                    .HasMaxLength(15)
                    .HasColumnName("PCIP");

                entity.Property(e => e.TerminalGrubu).HasDefaultValueSql("((1))");

                entity.Property(e => e.XSicilId)
                    .HasColumnName("xSicilID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.YetkiGrubu)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MailDuty>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MailDuty");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Recorddate).HasColumnType("datetime");

                entity.Property(e => e.Result).HasMaxLength(150);

                entity.Property(e => e.SendTime).HasColumnType("datetime");

                entity.Property(e => e.Subject).HasMaxLength(500);

                entity.Property(e => e.To).HasMaxLength(500);
            });

            modelBuilder.Entity<MailRapor>(entity =>
            {
                entity.ToTable("MailRapor");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.HasKey(e => new { e.Login, e.Program });

                entity.ToTable("Menu");

                entity.HasIndex(e => e.Id, "IX_Menu")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.LoginNavigation)
                    .WithMany(p => p.Menus)
                    .HasForeignKey(d => d.Login)
                    .HasConstraintName("FK_Menu_Login");
            });

            modelBuilder.Entity<MesaiGruplari>(entity =>
            {
                entity.ToTable("MesaiGruplari");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.OncelikliBirimAdi).HasMaxLength(50);

                entity.HasOne(d => d.MesaiYakalama)
                    .WithMany(p => p.MesaiGruplaris)
                    .HasForeignKey(d => d.MesaiYakalamaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MesaiGruplari_MesaiYakalamaTipleri");
            });

            modelBuilder.Entity<MesaiGruplariUyeleri>(entity =>
            {
                entity.HasKey(e => new { e.GrupId, e.MesaiId });

                entity.ToTable("MesaiGruplariUyeleri");

                entity.HasIndex(e => e.Id, "IX_MesaiGruplariUyeleri")
                    .IsUnique();

                entity.Property(e => e.GrupId).HasColumnName("GrupID");

                entity.Property(e => e.MesaiId).HasColumnName("MesaiID");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.HasOne(d => d.Grup)
                    .WithMany(p => p.MesaiGruplariUyeleris)
                    .HasForeignKey(d => d.GrupId)
                    .HasConstraintName("FK_MesaiGruplariUyeleri_MesaiGruplari");

                entity.HasOne(d => d.Mesai)
                    .WithMany(p => p.MesaiGruplariUyeleris)
                    .HasForeignKey(d => d.MesaiId)
                    .HasConstraintName("FK_MesaiGruplariUyeleri_Mesailer");
            });

            modelBuilder.Entity<MesaiPeriyodlari>(entity =>
            {
                entity.ToTable("MesaiPeriyodlari");

                entity.HasIndex(e => e.Id, "IX_MesaiPeriyodlari")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.EntegrasyonKod).HasMaxLength(30);

                entity.Property(e => e.OtomatikTatilGunler).HasMaxLength(100);
            });

            modelBuilder.Entity<MesaiPeriyodlariUyeleri>(entity =>
            {
                entity.HasKey(e => new { e.PeriyodId, e.GrupId, e.SiraNo });

                entity.ToTable("MesaiPeriyodlariUyeleri");

                entity.HasIndex(e => e.Id, "IX_MesaiPeriyodlariUyeleri")
                    .IsUnique();

                entity.Property(e => e.PeriyodId).HasColumnName("PeriyodID");

                entity.Property(e => e.GrupId).HasColumnName("GrupID");

                entity.Property(e => e.Aciklama).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.HasOne(d => d.Grup)
                    .WithMany(p => p.MesaiPeriyodlariUyeleris)
                    .HasForeignKey(d => d.GrupId)
                    .HasConstraintName("FK_MesaiPeriyodlariUyeleri_MesaiGruplari");

                entity.HasOne(d => d.Periyod)
                    .WithMany(p => p.MesaiPeriyodlariUyeleris)
                    .HasForeignKey(d => d.PeriyodId)
                    .HasConstraintName("FK_MesaiPeriyodlariUyeleri_MesaiPeriyodlari");
            });

            modelBuilder.Entity<MesaiYakalamaTipleri>(entity =>
            {
                entity.ToTable("MesaiYakalamaTipleri");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Tip).HasMaxLength(250);
            });

            modelBuilder.Entity<Mesailer>(entity =>
            {
                entity.ToTable("Mesailer");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Artiek)
                    .HasColumnName("artiek")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Eksiek)
                    .HasColumnName("eksiek")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FazlaMesaiHassasiyeti).HasDefaultValueSql("((1))");

                entity.Property(e => e.FmesikSuresi).HasColumnName("FMEsikSuresi");

                entity.Property(e => e.FmhesapTipi).HasColumnName("FMHesapTipi");

                entity.Property(e => e.GeceMesaiBaslangic).HasColumnName("geceMesaiBaslangic");

                entity.Property(e => e.GeceMesaiBitis).HasColumnName("geceMesaiBitis");

                entity.Property(e => e.Kod).HasMaxLength(3);

                entity.Property(e => e.SerbestMesaiHassasiyeti).HasDefaultValueSql("((1))");

                entity.Property(e => e.Tatilgunu)
                    .HasColumnName("tatilgunu")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Xfm1basi)
                    .HasColumnName("XFM1Basi")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Xfm1oran)
                    .HasColumnName("XFM1Oran")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Xfm1sonu)
                    .HasColumnName("XFM1Sonu")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Xfm2basi)
                    .HasColumnName("XFM2Basi")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Xfm2oran)
                    .HasColumnName("XFM2Oran")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Xfm2sonu)
                    .HasColumnName("XFM2Sonu")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.HesaplamaTip)
                    .WithMany(p => p.Mesailers)
                    .HasForeignKey(d => d.HesaplamaTipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mesailer_HesaplamaTipleri");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.HasKey(e => e.SicilId);

                entity.ToTable("Message");

                entity.Property(e => e.SicilId)
                    .ValueGeneratedNever()
                    .HasColumnName("SicilID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Message1)
                    .HasMaxLength(32)
                    .HasColumnName("Message");

                entity.Property(e => e.MessageCount).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Sicil)
                    .WithOne(p => p.Message)
                    .HasForeignKey<Message>(d => d.SicilId)
                    .HasConstraintName("FK_Message_Sicil");
            });

            modelBuilder.Entity<MeyerExport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Meyer_Export");

                entity.HasIndex(e => e.SicilId2, "UQ__Meyer_Ex__6255D2C46BAB0742")
                    .IsUnique();

                entity.Property(e => e.Avans2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.AylikCalismaSaati2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('00:00')");

                entity.Property(e => e.BrutMaas2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.CalisilanResmiTatil2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CalismaSaati2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('00:00')");

                entity.Property(e => e.CocukYardimi2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.Departman2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Devamsız2).HasDefaultValueSql("((0))");

                entity.Property(e => e.DigerAlacaklar2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.DvmszKesinti2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.Em20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EM20")
                    .HasDefaultValueSql("('00:00')");

                entity.Property(e => e.Emt20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMT20")
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.Firma2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fm20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FM20")
                    .HasDefaultValueSql("('00:00')");

                entity.Property(e => e.Fmt20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FMT20")
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.Gayri2).HasDefaultValueSql("((0))");

                entity.Property(e => e.GeceZammi2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('00:00')");

                entity.Property(e => e.GelinenGun2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GelinmeyenGun2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GercekCalismaSaati2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('00:00')");

                entity.Property(e => e.GirisTarihi2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gunsayisi2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HaftaTatili2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id2).HasColumnName("ID2");

                entity.Property(e => e.Ikramiye2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.Kesintiler2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.NetMaas2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.Periyod2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeriyodikYardim2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.Personel2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pozisyon2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResmiTatil2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Saatucreti2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.SicilId2).HasColumnName("sicilID2");

                entity.Property(e => e.SicilNo2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sicilNo2");

                entity.Property(e => e.Sskgunsayisi2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SSKGunsayisi2");

                entity.Property(e => e.SskraporluGun2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SSKRaporluGun2");

                entity.Property(e => e.ToplamBakiye2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Toplam_Bakiye2")
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.UcretliIzin2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UcretsizIzin2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.YakacakYardimi2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.YillikIzin2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.YolYardimi2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0.00')");
            });

            modelBuilder.Entity<MeyerExportIstek>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Meyer_Export_Istek");

                entity.Property(e => e.Tarih1).HasColumnType("smalldatetime");

                entity.Property(e => e.Tarih2).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<MobilGirisCiki>(entity =>
            {
                entity.Property(e => e.AdSoyad).HasMaxLength(255);

                entity.Property(e => e.CikisZamani).HasColumnType("datetime");

                entity.Property(e => e.GirisZamani).HasColumnType("datetime");

                entity.Property(e => e.GrupAdi).HasMaxLength(80);

                entity.Property(e => e.MobilKomutAdi).HasMaxLength(255);

                entity.Property(e => e.Tarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<MobilKomut>(entity =>
            {
                entity.ToTable("MobilKomut");

                entity.Property(e => e.Adi).HasMaxLength(100);

                entity.Property(e => e.Baslik).HasMaxLength(100);

                entity.HasOne(d => d.MobilKomutGrup)
                    .WithMany(p => p.MobilKomuts)
                    .HasForeignKey(d => d.MobilKomutGrupId)
                    .HasConstraintName("FK__MobilKomu__Mobil__4DAA618B");

                entity.HasOne(d => d.Terminal)
                    .WithMany(p => p.MobilKomuts)
                    .HasForeignKey(d => d.TerminalId)
                    .HasConstraintName("FK__MobilKomu__Termi__4E9E85C4");
            });

            modelBuilder.Entity<MobilKomutGrup>(entity =>
            {
                entity.ToTable("MobilKomutGrup");

                entity.Property(e => e.Ad).HasMaxLength(100);
            });

            modelBuilder.Entity<MobilKullanici>(entity =>
            {
                entity.ToTable("MobilKullanici");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.KullaniciAdi).HasMaxLength(100);

                entity.Property(e => e.Sifre).HasMaxLength(100);

                entity.Property(e => e.Token).HasMaxLength(100);

                entity.Property(e => e.UserId).HasMaxLength(50);
            });

            modelBuilder.Entity<MobilTur>(entity =>
            {
                entity.ToTable("MobilTur");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateEnded).HasColumnType("datetime");

                entity.Property(e => e.DateStarted).HasColumnType("datetime");

                entity.Property(e => e.FormenFullName).HasMaxLength(100);

                entity.Property(e => e.Guid).HasMaxLength(50);

                entity.Property(e => e.Latitude).HasMaxLength(100);

                entity.Property(e => e.Longitude).HasMaxLength(100);

                entity.Property(e => e.PhotoUrl).HasMaxLength(255);

                entity.Property(e => e.PhotoUrlFinish).HasMaxLength(255);
            });

            modelBuilder.Entity<MobilTurDetay>(entity =>
            {
                entity.ToTable("MobilTurDetay");

                entity.Property(e => e.BolumAdi).HasMaxLength(100);

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.LaborFullName).HasMaxLength(100);

                entity.Property(e => e.Latitude).HasMaxLength(100);

                entity.Property(e => e.LokasyonAdi).HasMaxLength(1000);

                entity.Property(e => e.Longitude).HasMaxLength(100);

                entity.Property(e => e.PhotoUrl).HasMaxLength(255);
            });

            modelBuilder.Entity<MobileAppUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MobileAppUser");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.RefreshToken).HasMaxLength(250);

                entity.Property(e => e.SicilNo).HasMaxLength(250);
            });

            modelBuilder.Entity<MobileDeviceLog>(entity =>
            {
                entity.ToTable("MobileDeviceLog");

                entity.Property(e => e.AdSoyad).HasMaxLength(50);

                entity.Property(e => e.CardNumber).HasMaxLength(100);

                entity.Property(e => e.DeviceId).HasMaxLength(100);

                entity.Property(e => e.Direction).HasMaxLength(50);

                entity.Property(e => e.EventTime).HasMaxLength(50);
            });

            modelBuilder.Entity<Moduller>(entity =>
            {
                entity.ToTable("Moduller");

                entity.Property(e => e.ModulAdi).HasMaxLength(150);

                entity.Property(e => e.ModulKodu).HasMaxLength(30);

                entity.Property(e => e.ParentId).HasMaxLength(30);
            });

            modelBuilder.Entity<Monitor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Monitor");

                entity.Property(e => e.LastAction).HasColumnType("datetime");
            });

            modelBuilder.Entity<Monitoring>(entity =>
            {
                entity.ToTable("monitoring");

                entity.HasIndex(e => e.Id, "IX_monitoring")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.EventCode).HasMaxLength(50);

                entity.Property(e => e.Eventtime).HasColumnType("datetime");

                entity.Property(e => e.GateIomessage)
                    .HasMaxLength(150)
                    .HasColumnName("GateIOMessage");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<NetsisFbutonGirisCiki>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("NetsisFButonGirisCikis");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(20);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.FirmaAd).HasMaxLength(500);

                entity.Property(e => e.GorevAd).HasMaxLength(500);

                entity.Property(e => e.IzinBaslangic).HasColumnType("datetime");

                entity.Property(e => e.IzinBitis).HasColumnType("datetime");

                entity.Property(e => e.IzinTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.IzinlerId).HasColumnName("Izinler_ID");

                entity.Property(e => e.PozisyonAd).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(20);
            });

            modelBuilder.Entity<NetsisIlkGirisSonCiki>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("NetsisIlkGirisSonCikis");

                entity.Property(e => e.Ad).HasMaxLength(20);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAd).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAd).HasMaxLength(500);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAd).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(20);

                entity.Property(e => e.TasnislemeId).HasColumnName("tasnisleme_id");
            });

            modelBuilder.Entity<NetsisOglenGirisCiki>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("NetsisOglenGirisCikis");

                entity.Property(e => e.Ad).HasMaxLength(20);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.FirmaAd).HasMaxLength(500);

                entity.Property(e => e.GorevAd).HasMaxLength(500);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.OglenCikis).HasColumnType("datetime");

                entity.Property(e => e.OglenGiris).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAd).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(20);

                entity.Property(e => e.TasnislemeId).HasColumnName("tasnisleme_id");
            });

            modelBuilder.Entity<NetworkInfo>(entity =>
            {
                entity.ToTable("NetworkInfo");

                entity.HasIndex(e => e.Id, "IX_NetworkInfo")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.SonGecisZamani).HasColumnType("datetime");

                entity.Property(e => e.SonPingZamani).HasColumnType("datetime");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.Zaman).HasColumnType("datetime");
            });

            modelBuilder.Entity<OglenUyumsuzGecisler>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OglenUyumsuzGecisler");

                entity.Property(e => e.Ad).HasMaxLength(20);

                entity.Property(e => e.BirimId).HasColumnName("BirimID");

                entity.Property(e => e.BolumId).HasColumnName("BolumID");

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MesaiTarih).HasColumnType("date");

                entity.Property(e => e.PeventTime)
                    .HasColumnType("datetime")
                    .HasColumnName("PEventTime");

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.PterminalAd)
                    .HasMaxLength(50)
                    .HasColumnName("PTerminalAd");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(20);

                entity.Property(e => e.TterminalIo).HasColumnName("TTerminalIO");

                entity.Property(e => e.TterminalPdks).HasColumnName("TTerminalPDKS");
            });

            modelBuilder.Entity<OneTowerAktarim>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OneTowerAktarim");

                entity.Property(e => e.Bastar)
                    .HasColumnType("datetime")
                    .HasColumnName("bastar");

                entity.Property(e => e.Bittar)
                    .HasColumnType("datetime")
                    .HasColumnName("bittar");

                entity.Property(e => e.PeriyodId).HasColumnName("periyodId");
            });

            modelBuilder.Entity<OtomatikTransfer>(entity =>
            {
                entity.ToTable("OtomatikTransfer");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ActionType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InsertTime).HasColumnType("datetime");

                entity.Property(e => e.RefId).HasColumnName("RefID");

                entity.Property(e => e.ResultTime).HasColumnType("datetime");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.Statement).HasColumnType("text");

                entity.Property(e => e.TerminalGroup).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Sicil)
                    .WithMany(p => p.OtomatikTransfers)
                    .HasForeignKey(d => d.SicilId)
                    .HasConstraintName("FK_OtomatikTransfer_Sicil");
            });

            modelBuilder.Entity<Otopark>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Otopark");
            });

            modelBuilder.Entity<OzelKodTanim>(entity =>
            {
                entity.ToTable("OzelKodTanim");

                entity.Property(e => e.OzelKod1).HasMaxLength(100);

                entity.Property(e => e.OzelKod2).HasMaxLength(100);

                entity.Property(e => e.OzelKod3).HasMaxLength(100);

                entity.Property(e => e.OzelKod4).HasMaxLength(100);

                entity.Property(e => e.OzelKod5).HasMaxLength(100);

                entity.Property(e => e.OzelKod6).HasMaxLength(100);
            });

            modelBuilder.Entity<ParaBirimleri>(entity =>
            {
                entity.ToTable("ParaBirimleri");

                entity.Property(e => e.Ad).HasMaxLength(50);
            });

            modelBuilder.Entity<Parameter>(entity =>
            {
                entity.HasKey(e => e.Ad);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Deger).HasMaxLength(200);
            });

            modelBuilder.Entity<Pass24>(entity =>
            {
                entity.ToTable("Pass24");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.Tarih).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Sicil)
                    .WithMany(p => p.Pass24s)
                    .HasForeignKey(d => d.SicilId)
                    .HasConstraintName("FK_Pass24_Sicil");
            });

            modelBuilder.Entity<PeriyodikOdemeler>(entity =>
            {
                entity.ToTable("PeriyodikOdemeler");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Avans).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Cocuksayisi).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Ikramiye).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PeriyodikYardim).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.YakacakYardimi).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.YolYardimi).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Sicil)
                    .WithMany(p => p.PeriyodikOdemelers)
                    .HasForeignKey(d => d.SicilId)
                    .HasConstraintName("FK_PeriyodikOdemeler_Sicil");
            });

            modelBuilder.Entity<PersonelBilgileri>(entity =>
            {
                entity.HasKey(e => e.SicilNo);

                entity.ToTable("PersonelBilgileri");

                entity.Property(e => e.SicilNo).HasMaxLength(8);

                entity.Property(e => e.Ad).HasMaxLength(40);

                entity.Property(e => e.CalisanAltGrubu).HasMaxLength(2);

                entity.Property(e => e.CalisanGrubu).HasMaxLength(1);

                entity.Property(e => e.CardId).HasMaxLength(10);

                entity.Property(e => e.GorevKodu).HasMaxLength(8);

                entity.Property(e => e.IseGirisTarihi).HasMaxLength(10);

                entity.Property(e => e.IstenCikisTarihi).HasMaxLength(10);

                entity.Property(e => e.IstihdamDurumu).HasMaxLength(1);

                entity.Property(e => e.OrganizasyonKodu).HasMaxLength(8);

                entity.Property(e => e.PersonelAlani).HasMaxLength(4);

                entity.Property(e => e.PersonelAltAlani).HasMaxLength(4);

                entity.Property(e => e.PozisyonKodu).HasMaxLength(8);

                entity.Property(e => e.SirketKodu).HasMaxLength(4);

                entity.Property(e => e.Soyad).HasMaxLength(40);

                entity.Property(e => e.YetkiGrubuAdi)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PersonelGeriBildirim>(entity =>
            {
                entity.ToTable("PersonelGeriBildirim");

                entity.Property(e => e.Aciklama).HasColumnType("ntext");

                entity.Property(e => e.ImgPath).HasColumnType("ntext");

                entity.Property(e => e.Konu).HasMaxLength(50);

                entity.Property(e => e.OlusturmaTarihi).HasColumnType("datetime");

                entity.Property(e => e.TerminTarihi).HasColumnType("datetime");
            });

            modelBuilder.Entity<PersonelGirisCikisRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PersonelGirisCikisRaporu");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BasTarih).HasColumnType("datetime");

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BitTarih).HasColumnType("datetime");

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisZamani).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Fm).HasColumnName("FM");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisZamani).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IzinAdi).HasMaxLength(100);

                entity.Property(e => e.IzinKodu).HasMaxLength(3);

                entity.Property(e => e.MesaiAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAd).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<PersonelItiraz>(entity =>
            {
                entity.ToTable("PersonelItiraz");

                entity.Property(e => e.Aciklama).HasMaxLength(1000);

                entity.Property(e => e.Konu).HasMaxLength(200);

                entity.Property(e => e.Tarih).HasColumnType("datetime");

                entity.Property(e => e.Yanit).HasMaxLength(1000);

                entity.Property(e => e.YanitTarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<Pool>(entity =>
            {
                entity.HasKey(e => new { e.SicilId, e.UserId, e.TerminalId, e.EventTime, e.Deleted });

                entity.ToTable("Pool");

                entity.HasIndex(e => e.Id, "IX_Pool")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.HasIndex(e => e.EventTime, "IX_Pool_EventTime");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(16)
                    .HasColumnName("UserID");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.Automatic)
                    .IsRequired()
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.EventCode)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ForeignId)
                    .HasColumnName("ForeignID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Pdks).HasColumnName("PDKS");

                entity.Property(e => e.Pdksx).HasColumnName("pdksx");

                entity.Property(e => e.ReaderId).HasColumnName("ReaderID");

                entity.Property(e => e.RecordedTime).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.Property(e => e.UnDelete)
                    .IsRequired()
                    .HasDefaultValueSql("('1')");
            });

            modelBuilder.Entity<PoolSuspect>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Pool_Suspect");

                entity.Property(e => e.EventCode).HasMaxLength(50);

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.ForeignId).HasColumnName("ForeignID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Pdks).HasColumnName("PDKS");

                entity.Property(e => e.Pdksx).HasColumnName("pdksx");

                entity.Property(e => e.ReaderId).HasColumnName("ReaderID");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(16)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<Poolgunler>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("POOLGUNLER");

                entity.Property(e => e.Tarih)
                    .HasColumnType("date")
                    .HasColumnName("TARIH");
            });

            modelBuilder.Entity<ProcessedDuty>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProcessedDuty");

                entity.Property(e => e.DeviceMessage).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Owner)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Process)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.RecordDate).HasColumnType("datetime");

                entity.Property(e => e.TargetDevice)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeZoneId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TimeZoneID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userID");
            });

            modelBuilder.Entity<RawDataOzet>(entity =>
            {
                entity.ToTable("RawDataOzet");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EventCode)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Eventtime).HasColumnType("datetime");

                entity.Property(e => e.FuncCode)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Image).HasColumnType("image");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ip)
                    .HasMaxLength(15)
                    .HasColumnName("IP");

                entity.Property(e => e.ReaderId)
                    .HasColumnName("ReaderID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.Property(e => e.UserIdfixed)
                    .HasMaxLength(10)
                    .HasColumnName("UserIDFixed");
            });

            modelBuilder.Entity<RawDatum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EventCode)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Eventtime).HasColumnType("datetime");

                entity.Property(e => e.FuncCode)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Image).HasColumnType("image");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ip)
                    .HasMaxLength(15)
                    .HasColumnName("IP");

                entity.Property(e => e.ReaderId)
                    .HasColumnName("ReaderID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<Recovery>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Recovery");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Owner)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Process)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.RecordDate).HasColumnType("datetime");

                entity.Property(e => e.TargetDevice)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userID")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<RepairLog>(entity =>
            {
                entity.ToTable("RepairLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Zaman)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Report");

                entity.Property(e => e.Ad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ReportID");
            });

            modelBuilder.Entity<Report1>(entity =>
            {
                entity.ToTable("Reports");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(150);

                entity.Property(e => e.OutputFileName).HasMaxLength(100);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<ReportsSetting>(entity =>
            {
                entity.ToTable("Reports_Settings");

                entity.Property(e => e.EmailAttach).HasColumnName("EMailAttach");

                entity.Property(e => e.EmailContent).HasColumnName("EMailContent");

                entity.Property(e => e.EmailIntroText)
                    .HasColumnType("ntext")
                    .HasColumnName("EMailIntroText");

                entity.Property(e => e.Kod).HasMaxLength(50);
            });

            modelBuilder.Entity<Sablonlar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sablonlar");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Kind).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SablonlarDetay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SablonlarDetay");

                entity.Property(e => e.Alan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.SablonId).HasColumnName("SablonID");
            });

            modelBuilder.Entity<SdtuserAktarim>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SDTUserAktarim");

                entity.Property(e => e.BirimId)
                    .HasMaxLength(10)
                    .HasColumnName("BirimID")
                    .IsFixedLength();

                entity.Property(e => e.PozisyonBilgi).HasMaxLength(90);

                entity.Property(e => e.SicilNo)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SelectIzinSuresiRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("select_IzinSuresiRaporu");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.IzinKodu).HasMaxLength(3);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<SelectIzinSuresiRaporu2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("select_IzinSuresiRaporu2");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.IzinKodu).HasMaxLength(3);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<SelectPdk>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SelectPDKS");

                entity.Property(e => e.Ad).HasMaxLength(20);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.Soyad).HasMaxLength(20);
            });

            modelBuilder.Entity<SelectSicilOzelYetki>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("select_SicilOzelYetki");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Adres).HasMaxLength(100);

                entity.Property(e => e.AmirAdi).HasMaxLength(101);

                entity.Property(e => e.Bilgi).HasColumnType("ntext");

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BirimKodu).HasColumnName("birimKodu");

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.BolumId).HasColumnName("BolumID");

                entity.Property(e => e.CardId).HasMaxLength(15);

                entity.Property(e => e.CepTelefon).HasMaxLength(20);

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.GorevId).HasColumnName("GorevID");

                entity.Property(e => e.MesaiPeriyodu).HasMaxLength(50);

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.Okod2)
                    .HasMaxLength(50)
                    .HasColumnName("OKod2");

                entity.Property(e => e.Okod3)
                    .HasMaxLength(50)
                    .HasColumnName("OKod3");

                entity.Property(e => e.Okod4)
                    .HasMaxLength(50)
                    .HasColumnName("OKod4");

                entity.Property(e => e.Okod5)
                    .HasMaxLength(50)
                    .HasColumnName("OKod5");

                entity.Property(e => e.Okod6)
                    .HasMaxLength(50)
                    .HasColumnName("OKod6");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PictureId).HasMaxLength(500);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Telefon1).HasMaxLength(20);

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<SelectSicilUserList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("select_SicilUserList");

                entity.Property(e => e.AcilDurumIrtibatKisisi).HasMaxLength(100);

                entity.Property(e => e.AcilDurumIrtibatKisisiEvTel).HasMaxLength(100);

                entity.Property(e => e.AcilDurumIrtibatKisisiIsTel).HasMaxLength(100);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Adres).HasMaxLength(100);

                entity.Property(e => e.AmirAdi).HasMaxLength(101);

                entity.Property(e => e.Bilgi).HasColumnType("ntext");

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BirimKodu).HasColumnName("birimKodu");

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.BolumId).HasColumnName("BolumID");

                entity.Property(e => e.CardId).HasMaxLength(15);

                entity.Property(e => e.CepTelefon).HasMaxLength(20);

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.DogumTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("EMail");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.FacilityCode).HasMaxLength(8);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.GorevId).HasColumnName("GorevID");

                entity.Property(e => e.HesCode).HasMaxLength(50);

                entity.Property(e => e.Iban).HasMaxLength(100);

                entity.Property(e => e.IstenAyrilisNedeni).HasMaxLength(500);

                entity.Property(e => e.KanGrubu).HasMaxLength(50);

                entity.Property(e => e.MesaiAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiPeriyodu).HasMaxLength(50);

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.Okod2)
                    .HasMaxLength(50)
                    .HasColumnName("OKod2");

                entity.Property(e => e.Okod3)
                    .HasMaxLength(50)
                    .HasColumnName("OKod3");

                entity.Property(e => e.Okod4)
                    .HasMaxLength(50)
                    .HasColumnName("OKod4");

                entity.Property(e => e.Okod5)
                    .HasMaxLength(50)
                    .HasColumnName("OKod5");

                entity.Property(e => e.Okod6)
                    .HasMaxLength(50)
                    .HasColumnName("OKod6");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PictureId).HasMaxLength(500);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TaseronFirmaAdi).HasMaxLength(200);

                entity.Property(e => e.Telefon1).HasMaxLength(20);

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<SelectTumGeci>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("select_TumGecis");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(90);

                entity.Property(e => e.Event).HasMaxLength(150);

                entity.Property(e => e.EventCode).HasMaxLength(50);

                entity.Property(e => e.Eventtime).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Lokasyon).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.UrunGrubu).HasMaxLength(150);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<SelectTumGeci1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SelectTumGecis");

                entity.Property(e => e.Ad).HasMaxLength(20);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(20);
            });

            modelBuilder.Entity<SelectYetkİ>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SELECT_YETKİ");

                entity.Property(e => e.Ad).HasMaxLength(20);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.LokasyonAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.Soyad).HasMaxLength(20);

                entity.Property(e => e.TerminalAdi).HasMaxLength(50);

                entity.Property(e => e.YetkiAdi).HasMaxLength(50);
            });

            modelBuilder.Entity<SerbestMesaiBilgisi>(entity =>
            {
                entity.ToTable("SerbestMesaiBilgisi");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Mesaibasi).HasColumnType("smalldatetime");

                entity.Property(e => e.Mesaisonu).HasColumnType("smalldatetime");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.HasOne(d => d.Sicil)
                    .WithMany(p => p.SerbestMesaiBilgisis)
                    .HasForeignKey(d => d.SicilId)
                    .HasConstraintName("FK_SerbestMesaiBilgisi_Sicil");
            });

            modelBuilder.Entity<Sicil>(entity =>
            {
                entity.ToTable("Sicil");

                entity.HasIndex(e => e.Id, "IX_Sicil")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AcilDurumIrtibatKisisi).HasMaxLength(100);

                entity.Property(e => e.AcilDurumIrtibatKisisiEvTel).HasMaxLength(100);

                entity.Property(e => e.AcilDurumIrtibatKisisiIsTel).HasMaxLength(100);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Adres).HasMaxLength(100);

                entity.Property(e => e.AltFirma).HasDefaultValueSql("((0))");

                entity.Property(e => e.AylikCalismaSaati).HasDefaultValueSql("((225))");

                entity.Property(e => e.Bilgi).HasColumnType("ntext");

                entity.Property(e => e.Bitistarih)
                    .HasColumnType("datetime")
                    .HasColumnName("bitistarih");

                entity.Property(e => e.Bolum).HasDefaultValueSql("((0))");

                entity.Property(e => e.CepTelefon).HasMaxLength(20);

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.Cinsiyet).HasDefaultValueSql("((0))");

                entity.Property(e => e.Direktorluk).HasDefaultValueSql("((0))");

                entity.Property(e => e.DogumTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.EksikMesaiFm).HasColumnName("EksikMesai_FM");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("EMail");

                entity.Property(e => e.ExpireDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('2000-01-03')");

                entity.Property(e => e.Firma).HasDefaultValueSql("((0))");

                entity.Property(e => e.FmEm).HasColumnName("FM_EM");

                entity.Property(e => e.FotoImage).HasColumnType("image");

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.GlobalSicilId)
                    .HasMaxLength(50)
                    .HasColumnName("GlobalSicilID");

                entity.Property(e => e.Gorev).HasDefaultValueSql("((0))");

                entity.Property(e => e.HesCode).HasMaxLength(50);

                entity.Property(e => e.Iban).HasMaxLength(100);

                entity.Property(e => e.Il)
                    .HasMaxLength(20)
                    .HasColumnName("IL");

                entity.Property(e => e.Ilce).HasMaxLength(20);

                entity.Property(e => e.IstenAyrilisNedeni).HasMaxLength(500);

                entity.Property(e => e.KanGrubu).HasDefaultValueSql("((0))");

                entity.Property(e => e.KidemTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.MaasTipi).HasDefaultValueSql("((1))");

                entity.Property(e => e.MesaiPeriyodu).HasDefaultValueSql("((1))");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.Okod10)
                    .HasMaxLength(50)
                    .HasColumnName("OKod10");

                entity.Property(e => e.Okod2)
                    .HasMaxLength(50)
                    .HasColumnName("OKod2");

                entity.Property(e => e.Okod3)
                    .HasMaxLength(50)
                    .HasColumnName("OKod3");

                entity.Property(e => e.Okod4)
                    .HasMaxLength(50)
                    .HasColumnName("OKod4");

                entity.Property(e => e.Okod5).HasColumnName("OKod5");

                entity.Property(e => e.Okod6)
                    .HasMaxLength(50)
                    .HasColumnName("OKod6");

                entity.Property(e => e.Okod7)
                    .HasMaxLength(50)
                    .HasColumnName("OKod7");

                entity.Property(e => e.Okod8).HasColumnName("OKod8");

                entity.Property(e => e.Okod9)
                    .HasMaxLength(50)
                    .HasColumnName("OKod9");

                entity.Property(e => e.PeriyodBaslangici)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("('2000-01-03')");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PictureId).HasMaxLength(500);

                entity.Property(e => e.Pozisyon).HasDefaultValueSql("((0))");

                entity.Property(e => e.Puantaj).HasDefaultValueSql("((0))");

                entity.Property(e => e.SicilKilit).HasDefaultValueSql("((0))");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonTasnifId).HasColumnName("SonTasnifID");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Telefon1).HasMaxLength(20);

                entity.Property(e => e.Telefon2).HasMaxLength(20);

                entity.Property(e => e.TerminalGrubu).HasDefaultValueSql("((1))");

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .HasColumnName("UserID");

                entity.Property(e => e.Yaka).HasDefaultValueSql("((0))");

                entity.Property(e => e.YetkiStr).HasMaxLength(150);

                entity.HasOne(d => d.BolumNavigation)
                    .WithMany(p => p.Sicils)
                    .HasForeignKey(d => d.Bolum)
                    .HasConstraintName("FK_Sicil_cbo_Bolum");

                entity.HasOne(d => d.FirmaNavigation)
                    .WithMany(p => p.Sicils)
                    .HasForeignKey(d => d.Firma)
                    .HasConstraintName("FK_Sicil_cbo_Firma");

                entity.HasOne(d => d.GorevNavigation)
                    .WithMany(p => p.Sicils)
                    .HasForeignKey(d => d.Gorev)
                    .HasConstraintName("FK_Sicil_cbo_Gorev");

                entity.HasOne(d => d.PozisyonNavigation)
                    .WithMany(p => p.Sicils)
                    .HasForeignKey(d => d.Pozisyon)
                    .HasConstraintName("FK_Sicil_cbo_Pozisyon");

                entity.HasOne(d => d.TerminalGrubuNavigation)
                    .WithMany(p => p.Sicils)
                    .HasForeignKey(d => d.TerminalGrubu)
                    .HasConstraintName("FK_Sicil_TerminalGroup");
            });

            modelBuilder.Entity<Sicil017>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SICIL017");

                entity.Property(e => e.Ad).HasMaxLength(20);

                entity.Property(e => e.Adres).HasMaxLength(100);

                entity.Property(e => e.Bilgi).HasColumnType("ntext");

                entity.Property(e => e.Bitistarih)
                    .HasColumnType("datetime")
                    .HasColumnName("bitistarih");

                entity.Property(e => e.CepTelefon).HasMaxLength(20);

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.DogumTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.EksikMesaiFm).HasColumnName("EksikMesai_FM");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("EMail");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.FmEm).HasColumnName("FM_EM");

                entity.Property(e => e.FotoImage).HasColumnType("image");

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Il)
                    .HasMaxLength(20)
                    .HasColumnName("IL");

                entity.Property(e => e.Ilce).HasMaxLength(20);

                entity.Property(e => e.KidemTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.Okod10)
                    .HasMaxLength(50)
                    .HasColumnName("OKod10");

                entity.Property(e => e.Okod2)
                    .HasMaxLength(50)
                    .HasColumnName("OKod2");

                entity.Property(e => e.Okod3)
                    .HasMaxLength(50)
                    .HasColumnName("OKod3");

                entity.Property(e => e.Okod4)
                    .HasMaxLength(50)
                    .HasColumnName("OKod4");

                entity.Property(e => e.Okod5)
                    .HasMaxLength(50)
                    .HasColumnName("OKod5");

                entity.Property(e => e.Okod6)
                    .HasMaxLength(50)
                    .HasColumnName("OKod6");

                entity.Property(e => e.Okod7)
                    .HasMaxLength(50)
                    .HasColumnName("OKod7");

                entity.Property(e => e.Okod8)
                    .HasMaxLength(50)
                    .HasColumnName("OKod8");

                entity.Property(e => e.Okod9)
                    .HasMaxLength(50)
                    .HasColumnName("OKod9");

                entity.Property(e => e.PeriyodBaslangici).HasColumnType("smalldatetime");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PictureId).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonTasnifId).HasColumnName("SonTasnifID");

                entity.Property(e => e.Soyad).HasMaxLength(20);

                entity.Property(e => e.Telefon1).HasMaxLength(20);

                entity.Property(e => e.Telefon2).HasMaxLength(20);

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<SicilAttach>(entity =>
            {
                entity.HasKey(e => new { e.SicilId, e.SicilAddFieldId });

                entity.ToTable("SicilAttach");

                entity.HasIndex(e => e.Id, "IX_SicilAttach")
                    .IsUnique();

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilAddFieldId).HasColumnName("SicilAddFieldID");

                entity.Property(e => e.Deger).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.HasOne(d => d.SicilAddField)
                    .WithMany(p => p.SicilAttaches)
                    .HasForeignKey(d => d.SicilAddFieldId)
                    .HasConstraintName("FK_SicilAttach_cbo_Sicil");

                entity.HasOne(d => d.Sicil)
                    .WithMany(p => p.SicilAttaches)
                    .HasForeignKey(d => d.SicilId)
                    .HasConstraintName("FK_SicilAttach_Sicil");
            });

            modelBuilder.Entity<SicilEkParametrikIzin>(entity =>
            {
                entity.ToTable("SicilEkParametrikIzin");
            });

            modelBuilder.Entity<SicilFoto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SicilFoto");

                entity.Property(e => e.Compressed)
                    .HasColumnName("compressed")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Fotoimage)
                    .HasColumnType("image")
                    .HasColumnName("fotoimage");

                entity.Property(e => e.Level)
                    .HasMaxLength(50)
                    .HasColumnName("level")
                    .HasDefaultValueSql("((50))");

                entity.Property(e => e.Recorddate)
                    .HasColumnType("datetime")
                    .HasColumnName("recorddate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sicilid).HasColumnName("sicilid");

                entity.Property(e => e.Xsicilid).HasColumnName("xsicilid");
            });

            modelBuilder.Entity<SicilGroup>(entity =>
            {
                entity.ToTable("SicilGroup");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);
            });

            modelBuilder.Entity<SicilGroupMember>(entity =>
            {
                entity.HasKey(e => new { e.SicilGroupId, e.SicilId });

                entity.ToTable("SicilGroupMember");

                entity.HasIndex(e => e.Id, "IX_SicilGroupMember")
                    .IsUnique();

                entity.Property(e => e.SicilGroupId).HasColumnName("SicilGroupID");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.HasOne(d => d.SicilGroup)
                    .WithMany(p => p.SicilGroupMembers)
                    .HasForeignKey(d => d.SicilGroupId)
                    .HasConstraintName("FK_SicilGroupMember_SicilGroup");

                entity.HasOne(d => d.Sicil)
                    .WithMany(p => p.SicilGroupMembers)
                    .HasForeignKey(d => d.SicilId)
                    .HasConstraintName("FK_SicilGroupMember_Sicil");
            });

            modelBuilder.Entity<SicilHaftaTatili>(entity =>
            {
                entity.HasKey(e => new { e.SicilId, e.Gun });

                entity.ToTable("SicilHaftaTatili");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.Gun).HasDefaultValueSql("((7))");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MesaiGruplariId).HasColumnName("MesaiGruplariID");

                entity.Property(e => e.MesailerId).HasColumnName("MesailerID");

                entity.HasOne(d => d.MesaiGruplari)
                    .WithMany(p => p.SicilHaftaTatilis)
                    .HasForeignKey(d => d.MesaiGruplariId)
                    .HasConstraintName("FK_SicilHaftaTatili_MesaiGruplari");

                entity.HasOne(d => d.Mesailer)
                    .WithMany(p => p.SicilHaftaTatilis)
                    .HasForeignKey(d => d.MesailerId)
                    .HasConstraintName("FK_SicilHaftaTatili_Mesailer");

                entity.HasOne(d => d.Sicil)
                    .WithMany(p => p.SicilHaftaTatilis)
                    .HasForeignKey(d => d.SicilId)
                    .HasConstraintName("FK_SicilHaftaTatili_Sicil");
            });

            modelBuilder.Entity<SicilLog>(entity =>
            {
                entity.ToTable("Sicil_log");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(120);

                entity.Property(e => e.Adres).HasMaxLength(100);

                entity.Property(e => e.Bilgi).HasColumnType("ntext");

                entity.Property(e => e.Bitistarih)
                    .HasColumnType("datetime")
                    .HasColumnName("bitistarih");

                entity.Property(e => e.CepTelefon).HasMaxLength(20);

                entity.Property(e => e.CikisTarih).HasColumnType("datetime");

                entity.Property(e => e.DogumTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.EksikMesaiFm).HasColumnName("EksikMesai_FM");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("EMail");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.FmEm).HasColumnName("FM_EM");

                entity.Property(e => e.FotoImage).HasColumnType("image");

                entity.Property(e => e.GirisTarih).HasColumnType("datetime");

                entity.Property(e => e.Il)
                    .HasMaxLength(20)
                    .HasColumnName("IL");

                entity.Property(e => e.Ilce).HasMaxLength(20);

                entity.Property(e => e.IslemDatetime).HasColumnType("datetime");

                entity.Property(e => e.KidemTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.Okod10)
                    .HasMaxLength(50)
                    .HasColumnName("OKod10");

                entity.Property(e => e.Okod2)
                    .HasMaxLength(50)
                    .HasColumnName("OKod2");

                entity.Property(e => e.Okod3)
                    .HasMaxLength(50)
                    .HasColumnName("OKod3");

                entity.Property(e => e.Okod4)
                    .HasMaxLength(50)
                    .HasColumnName("OKod4");

                entity.Property(e => e.Okod5)
                    .HasMaxLength(50)
                    .HasColumnName("OKod5");

                entity.Property(e => e.Okod6)
                    .HasMaxLength(50)
                    .HasColumnName("OKod6");

                entity.Property(e => e.Okod7)
                    .HasMaxLength(50)
                    .HasColumnName("OKod7");

                entity.Property(e => e.Okod8)
                    .HasMaxLength(50)
                    .HasColumnName("OKod8");

                entity.Property(e => e.Okod9)
                    .HasMaxLength(50)
                    .HasColumnName("OKod9");

                entity.Property(e => e.PeriyodBaslangici).HasColumnType("smalldatetime");

                entity.Property(e => e.PersonelNo).HasMaxLength(120);

                entity.Property(e => e.PictureId).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonTasnifId).HasColumnName("SonTasnifID");

                entity.Property(e => e.Soyad).HasMaxLength(120);

                entity.Property(e => e.Telefon1).HasMaxLength(20);

                entity.Property(e => e.Telefon2).HasMaxLength(20);

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<SicilRescue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SicilRescue");

                entity.Property(e => e.Ad).HasMaxLength(20);

                entity.Property(e => e.Adres).HasMaxLength(100);

                entity.Property(e => e.Bilgi).HasColumnType("ntext");

                entity.Property(e => e.CepTelefon).HasMaxLength(20);

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.DogumTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.EksikMesaiFm).HasColumnName("EksikMesai_FM");

                entity.Property(e => e.Enddate).HasColumnType("datetime");

                entity.Property(e => e.ExpireDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FmEm).HasColumnName("FM_EM");

                entity.Property(e => e.FotoImage).HasColumnType("image");

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Il)
                    .HasMaxLength(20)
                    .HasColumnName("IL");

                entity.Property(e => e.Ilce).HasMaxLength(20);

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.Okod10)
                    .HasMaxLength(50)
                    .HasColumnName("OKod10");

                entity.Property(e => e.Okod2)
                    .HasMaxLength(50)
                    .HasColumnName("OKod2");

                entity.Property(e => e.Okod3)
                    .HasMaxLength(50)
                    .HasColumnName("OKod3");

                entity.Property(e => e.Okod4)
                    .HasMaxLength(50)
                    .HasColumnName("OKod4");

                entity.Property(e => e.Okod5)
                    .HasMaxLength(50)
                    .HasColumnName("OKod5");

                entity.Property(e => e.Okod6)
                    .HasMaxLength(50)
                    .HasColumnName("OKod6");

                entity.Property(e => e.Okod7)
                    .HasMaxLength(50)
                    .HasColumnName("OKod7");

                entity.Property(e => e.Okod8)
                    .HasMaxLength(50)
                    .HasColumnName("OKod8");

                entity.Property(e => e.Okod9)
                    .HasMaxLength(50)
                    .HasColumnName("OKod9");

                entity.Property(e => e.PeriyodBaslangici).HasColumnType("smalldatetime");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonTasnifId).HasColumnName("SonTasnifID");

                entity.Property(e => e.Soyad).HasMaxLength(20);

                entity.Property(e => e.Telefon1).HasMaxLength(20);

                entity.Property(e => e.Telefon2).HasMaxLength(20);

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<Sicilfromsap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sicilfromsap");

                entity.Property(e => e.Ad).HasMaxLength(150);

                entity.Property(e => e.AltFirmaAd)
                    .HasMaxLength(150)
                    .HasColumnName("AltFirmaAD");

                entity.Property(e => e.AltFirmaId)
                    .HasMaxLength(150)
                    .HasColumnName("AltFirmaID");

                entity.Property(e => e.BolumAd)
                    .HasMaxLength(150)
                    .HasColumnName("BolumAD");

                entity.Property(e => e.BolumId)
                    .HasMaxLength(150)
                    .HasColumnName("BolumID");

                entity.Property(e => e.CikisTarih).HasMaxLength(150);

                entity.Property(e => e.DirektorAd)
                    .HasMaxLength(150)
                    .HasColumnName("DirektorAD");

                entity.Property(e => e.DirektorId)
                    .HasMaxLength(150)
                    .HasColumnName("DirektorID");

                entity.Property(e => e.DogumTarih).HasMaxLength(150);

                entity.Property(e => e.FirmaAd)
                    .HasMaxLength(150)
                    .HasColumnName("FirmaAD");

                entity.Property(e => e.FirmaId)
                    .HasMaxLength(150)
                    .HasColumnName("FirmaID");

                entity.Property(e => e.GirisTarih).HasMaxLength(150);

                entity.Property(e => e.GorevAd)
                    .HasMaxLength(150)
                    .HasColumnName("GorevAD");

                entity.Property(e => e.GorevId)
                    .HasMaxLength(150)
                    .HasColumnName("GorevID");

                entity.Property(e => e.PozisyonAd)
                    .HasMaxLength(150)
                    .HasColumnName("PozisyonAD");

                entity.Property(e => e.PozisyonId)
                    .HasMaxLength(150)
                    .HasColumnName("PozisyonID");

                entity.Property(e => e.SicilNo).HasMaxLength(150);

                entity.Property(e => e.Soyad).HasMaxLength(150);
            });

            modelBuilder.Entity<Sifre>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sifre");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.NewUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NewUserID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OldUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OldUserID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.RecordDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SonGuncellemeZamani>(entity =>
            {
                entity.ToTable("SonGuncellemeZamani");

                entity.Property(e => e.Zaman).HasColumnType("datetime");
            });

            modelBuilder.Entity<Srintegration>(entity =>
            {
                entity.ToTable("SRIntegrations");

                entity.Property(e => e.Data).HasColumnType("ntext");

                entity.Property(e => e.Event).HasMaxLength(100);

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<StmargeicerdeKalmaSuresi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("STMARGEIcerdeKalmaSuresi");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Gun).HasColumnName("gun");

                entity.Property(e => e.Hafta).HasColumnName("hafta");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<Summertime>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("summertime");

                entity.Property(e => e.Durum)
                    .HasColumnName("DURUM")
                    .HasDefaultValueSql("((3))");
            });

            modelBuilder.Entity<SysAccessType>(entity =>
            {
                entity.ToTable("sys_AccessType");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AdArabic).HasMaxLength(50);

                entity.Property(e => e.AdChinese).HasMaxLength(50);

                entity.Property(e => e.AdEnglish).HasMaxLength(50);

                entity.Property(e => e.AdFrench).HasMaxLength(50);

                entity.Property(e => e.AdGerman).HasMaxLength(50);

                entity.Property(e => e.AdItalian).HasMaxLength(50);

                entity.Property(e => e.AdKorean).HasMaxLength(50);

                entity.Property(e => e.AdMalaysia).HasMaxLength(50);

                entity.Property(e => e.AdPortuguese).HasMaxLength(50);

                entity.Property(e => e.AdRussian).HasMaxLength(50);

                entity.Property(e => e.AdSpanish).HasMaxLength(50);

                entity.Property(e => e.AdThiland).HasMaxLength(50);

                entity.Property(e => e.AdVietnam).HasMaxLength(50);
            });

            modelBuilder.Entity<SysAracTuru>(entity =>
            {
                entity.ToTable("sys_AracTuru");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AdArabic).HasMaxLength(50);

                entity.Property(e => e.AdChinese).HasMaxLength(50);

                entity.Property(e => e.AdEnglish).HasMaxLength(50);

                entity.Property(e => e.AdFrench).HasMaxLength(50);

                entity.Property(e => e.AdGerman).HasMaxLength(50);

                entity.Property(e => e.AdItalian).HasMaxLength(50);

                entity.Property(e => e.AdKorean).HasMaxLength(50);

                entity.Property(e => e.AdMalaysia).HasMaxLength(50);

                entity.Property(e => e.AdPortuguese).HasMaxLength(50);

                entity.Property(e => e.AdRussian).HasMaxLength(50);

                entity.Property(e => e.AdSpanish).HasMaxLength(50);

                entity.Property(e => e.AdThiland).HasMaxLength(50);

                entity.Property(e => e.AdVietnam).HasMaxLength(50);
            });

            modelBuilder.Entity<SysBellTimeType>(entity =>
            {
                entity.ToTable("sys_BellTimeType");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AdArabic).HasMaxLength(50);

                entity.Property(e => e.AdChinese).HasMaxLength(50);

                entity.Property(e => e.AdEnglish).HasMaxLength(50);

                entity.Property(e => e.AdFrench).HasMaxLength(50);

                entity.Property(e => e.AdGerman).HasMaxLength(50);

                entity.Property(e => e.AdItalian).HasMaxLength(50);

                entity.Property(e => e.AdKorean).HasMaxLength(50);

                entity.Property(e => e.AdMalaysia).HasMaxLength(50);

                entity.Property(e => e.AdPortuguese).HasMaxLength(50);

                entity.Property(e => e.AdRussian).HasMaxLength(50);

                entity.Property(e => e.AdSpanish).HasMaxLength(50);

                entity.Property(e => e.AdThiland).HasMaxLength(50);

                entity.Property(e => e.AdVietnam).HasMaxLength(50);
            });

            modelBuilder.Entity<SysCardAttribute>(entity =>
            {
                entity.ToTable("sys_CardAttribute");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AdArabic).HasMaxLength(50);

                entity.Property(e => e.AdChinese).HasMaxLength(50);

                entity.Property(e => e.AdEnglish).HasMaxLength(50);

                entity.Property(e => e.AdFrench).HasMaxLength(50);

                entity.Property(e => e.AdGerman).HasMaxLength(50);

                entity.Property(e => e.AdItalian).HasMaxLength(50);

                entity.Property(e => e.AdKorean).HasMaxLength(50);

                entity.Property(e => e.AdMalaysia).HasMaxLength(50);

                entity.Property(e => e.AdPortuguese).HasMaxLength(50);

                entity.Property(e => e.AdRussian).HasMaxLength(50);

                entity.Property(e => e.AdSpanish).HasMaxLength(50);

                entity.Property(e => e.AdThiland).HasMaxLength(50);

                entity.Property(e => e.AdVietnam).HasMaxLength(50);
            });

            modelBuilder.Entity<SysCardFormat>(entity =>
            {
                entity.ToTable("sys_CardFormat");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);
            });

            modelBuilder.Entity<SysCardType>(entity =>
            {
                entity.ToTable("sys_CardType");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AdArabic).HasMaxLength(50);

                entity.Property(e => e.AdChinese).HasMaxLength(50);

                entity.Property(e => e.AdEnglish).HasMaxLength(50);

                entity.Property(e => e.AdFrench).HasMaxLength(50);

                entity.Property(e => e.AdGerman).HasMaxLength(50);

                entity.Property(e => e.AdItalian).HasMaxLength(50);

                entity.Property(e => e.AdKorean).HasMaxLength(50);

                entity.Property(e => e.AdMalaysia).HasMaxLength(50);

                entity.Property(e => e.AdPortuguese).HasMaxLength(50);

                entity.Property(e => e.AdRussian).HasMaxLength(50);

                entity.Property(e => e.AdSpanish).HasMaxLength(50);

                entity.Property(e => e.AdThiland).HasMaxLength(50);

                entity.Property(e => e.AdVietnam).HasMaxLength(50);
            });

            modelBuilder.Entity<SysCinsiyet>(entity =>
            {
                entity.ToTable("sys_Cinsiyet");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Ad).HasMaxLength(50);
            });

            modelBuilder.Entity<SysCommandType>(entity =>
            {
                entity.ToTable("sys_CommandType");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AdArabic).HasMaxLength(50);

                entity.Property(e => e.AdChinese).HasMaxLength(50);

                entity.Property(e => e.AdEnglish).HasMaxLength(50);

                entity.Property(e => e.AdFrench).HasMaxLength(50);

                entity.Property(e => e.AdGerman).HasMaxLength(50);

                entity.Property(e => e.AdItalian).HasMaxLength(50);

                entity.Property(e => e.AdKorean).HasMaxLength(50);

                entity.Property(e => e.AdMalaysia).HasMaxLength(50);

                entity.Property(e => e.AdPortuguese).HasMaxLength(50);

                entity.Property(e => e.AdRussian).HasMaxLength(50);

                entity.Property(e => e.AdSpanish).HasMaxLength(50);

                entity.Property(e => e.AdThiland).HasMaxLength(50);

                entity.Property(e => e.AdVietnam).HasMaxLength(50);
            });

            modelBuilder.Entity<SysEventCode>(entity =>
            {
                entity.ToTable("sys_EventCode");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AdArabic).HasMaxLength(50);

                entity.Property(e => e.AdChinese).HasMaxLength(50);

                entity.Property(e => e.AdEnglish).HasMaxLength(50);

                entity.Property(e => e.AdFrench).HasMaxLength(50);

                entity.Property(e => e.AdGerman).HasMaxLength(50);

                entity.Property(e => e.AdItalian).HasMaxLength(50);

                entity.Property(e => e.AdKorean).HasMaxLength(50);

                entity.Property(e => e.AdMalaysia).HasMaxLength(50);

                entity.Property(e => e.AdPortuguese).HasMaxLength(50);

                entity.Property(e => e.AdRussian).HasMaxLength(50);

                entity.Property(e => e.AdSpanish).HasMaxLength(50);

                entity.Property(e => e.AdThiland).HasMaxLength(50);

                entity.Property(e => e.AdVietnam).HasMaxLength(50);
            });

            modelBuilder.Entity<SysIo>(entity =>
            {
                entity.ToTable("sys_IO");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AdArabic).HasMaxLength(50);

                entity.Property(e => e.AdChinese).HasMaxLength(50);

                entity.Property(e => e.AdEnglish).HasMaxLength(50);

                entity.Property(e => e.AdFrench).HasMaxLength(50);

                entity.Property(e => e.AdGerman).HasMaxLength(50);

                entity.Property(e => e.AdItalian).HasMaxLength(50);

                entity.Property(e => e.AdKorean).HasMaxLength(50);

                entity.Property(e => e.AdMalaysia).HasMaxLength(50);

                entity.Property(e => e.AdPortuguese).HasMaxLength(50);

                entity.Property(e => e.AdRussian).HasMaxLength(50);

                entity.Property(e => e.AdSpanish).HasMaxLength(50);

                entity.Property(e => e.AdThiland).HasMaxLength(50);

                entity.Property(e => e.AdVietnam).HasMaxLength(50);
            });

            modelBuilder.Entity<SysKanGrubu>(entity =>
            {
                entity.ToTable("sys_KanGrubu");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AdArabic).HasMaxLength(50);

                entity.Property(e => e.AdChinese).HasMaxLength(50);

                entity.Property(e => e.AdEnglish).HasMaxLength(50);

                entity.Property(e => e.AdFrench).HasMaxLength(50);

                entity.Property(e => e.AdGerman).HasMaxLength(50);

                entity.Property(e => e.AdItalian).HasMaxLength(50);

                entity.Property(e => e.AdKorean).HasMaxLength(50);

                entity.Property(e => e.AdMalaysia).HasMaxLength(50);

                entity.Property(e => e.AdPortuguese).HasMaxLength(50);

                entity.Property(e => e.AdRussian).HasMaxLength(50);

                entity.Property(e => e.AdSpanish).HasMaxLength(50);

                entity.Property(e => e.AdThiland).HasMaxLength(50);

                entity.Property(e => e.AdVietnam).HasMaxLength(50);
            });

            modelBuilder.Entity<SysLanguage>(entity =>
            {
                entity.HasKey(e => new { e.Form, e.Kind, e.Name, e.Index });

                entity.ToTable("sys_Language");

                entity.Property(e => e.Form).HasMaxLength(50);

                entity.Property(e => e.Kind).HasMaxLength(20);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Index).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Ad).HasColumnType("ntext");

                entity.Property(e => e.AdArabic).HasColumnType("ntext");

                entity.Property(e => e.AdChinese).HasColumnType("ntext");

                entity.Property(e => e.AdEnglish).HasColumnType("ntext");

                entity.Property(e => e.AdFrench).HasColumnType("ntext");

                entity.Property(e => e.AdGerman).HasColumnType("ntext");

                entity.Property(e => e.AdItalian).HasColumnType("ntext");

                entity.Property(e => e.AdKorean).HasColumnType("ntext");

                entity.Property(e => e.AdMalaysia).HasColumnType("ntext");

                entity.Property(e => e.AdPortuguese).HasColumnType("ntext");

                entity.Property(e => e.AdRussian).HasColumnType("ntext");

                entity.Property(e => e.AdSpanish).HasColumnType("ntext");

                entity.Property(e => e.AdThiland).HasColumnType("ntext");

                entity.Property(e => e.AdVietnam).HasColumnType("ntext");
            });

            modelBuilder.Entity<SysLanguageStmt>(entity =>
            {
                entity.ToTable("sys_LanguageStmt");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasColumnType("ntext");

                entity.Property(e => e.AdArabic).HasColumnType("ntext");

                entity.Property(e => e.AdChinese).HasColumnType("ntext");

                entity.Property(e => e.AdEnglish).HasColumnType("ntext");

                entity.Property(e => e.AdFrench).HasColumnType("ntext");

                entity.Property(e => e.AdGerman).HasColumnType("ntext");

                entity.Property(e => e.AdItalian).HasColumnType("ntext");

                entity.Property(e => e.AdKorean).HasColumnType("ntext");

                entity.Property(e => e.AdMalaysia).HasColumnType("ntext");

                entity.Property(e => e.AdPortuguese).HasColumnType("ntext");

                entity.Property(e => e.AdRussian).HasColumnType("ntext");

                entity.Property(e => e.AdSpanish).HasColumnType("ntext");

                entity.Property(e => e.AdThiland).HasColumnType("ntext");

                entity.Property(e => e.AdVietnam).HasColumnType("ntext");
            });

            modelBuilder.Entity<SysMaasTipi>(entity =>
            {
                entity.ToTable("sys_MaasTipi");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AdArabic).HasMaxLength(50);

                entity.Property(e => e.AdChinese).HasMaxLength(50);

                entity.Property(e => e.AdEnglish).HasMaxLength(50);

                entity.Property(e => e.AdFrench).HasMaxLength(50);

                entity.Property(e => e.AdGerman).HasMaxLength(50);

                entity.Property(e => e.AdItalian).HasMaxLength(50);

                entity.Property(e => e.AdKorean).HasMaxLength(50);

                entity.Property(e => e.AdMalaysia).HasMaxLength(50);

                entity.Property(e => e.AdPortuguese).HasMaxLength(50);

                entity.Property(e => e.AdRussian).HasMaxLength(50);

                entity.Property(e => e.AdSpanish).HasMaxLength(50);

                entity.Property(e => e.AdThiland).HasMaxLength(50);

                entity.Property(e => e.AdVietnam).HasMaxLength(50);
            });

            modelBuilder.Entity<SysMedeniHali>(entity =>
            {
                entity.ToTable("sys_MedeniHali");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AdArabic).HasMaxLength(50);

                entity.Property(e => e.AdChinese).HasMaxLength(50);

                entity.Property(e => e.AdEnglish).HasMaxLength(50);

                entity.Property(e => e.AdFrench).HasMaxLength(50);

                entity.Property(e => e.AdGerman).HasMaxLength(50);

                entity.Property(e => e.AdItalian).HasMaxLength(50);

                entity.Property(e => e.AdKorean).HasMaxLength(50);

                entity.Property(e => e.AdMalaysia).HasMaxLength(50);

                entity.Property(e => e.AdPortuguese).HasMaxLength(50);

                entity.Property(e => e.AdRussian).HasMaxLength(50);

                entity.Property(e => e.AdSpanish).HasMaxLength(50);

                entity.Property(e => e.AdThiland).HasMaxLength(50);

                entity.Property(e => e.AdVietnam).HasMaxLength(50);
            });

            modelBuilder.Entity<SysMonth>(entity =>
            {
                entity.ToTable("sys_Month");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AdArabic).HasMaxLength(50);

                entity.Property(e => e.AdChinese).HasMaxLength(50);

                entity.Property(e => e.AdEnglish).HasMaxLength(50);

                entity.Property(e => e.AdFrench).HasMaxLength(50);

                entity.Property(e => e.AdGerman).HasMaxLength(50);

                entity.Property(e => e.AdItalian).HasMaxLength(50);

                entity.Property(e => e.AdKorean).HasMaxLength(50);

                entity.Property(e => e.AdMalaysia).HasMaxLength(50);

                entity.Property(e => e.AdPortuguese).HasMaxLength(50);

                entity.Property(e => e.AdRussian).HasMaxLength(50);

                entity.Property(e => e.AdSpanish).HasMaxLength(50);

                entity.Property(e => e.AdThiland).HasMaxLength(50);

                entity.Property(e => e.AdVietnam).HasMaxLength(50);
            });

            modelBuilder.Entity<SysOperator>(entity =>
            {
                entity.ToTable("sys_Operators");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AdArabic).HasMaxLength(50);

                entity.Property(e => e.AdChinese).HasMaxLength(50);

                entity.Property(e => e.AdEnglish).HasMaxLength(50);

                entity.Property(e => e.AdFrench).HasMaxLength(50);

                entity.Property(e => e.AdGerman).HasMaxLength(50);

                entity.Property(e => e.AdItalian).HasMaxLength(50);

                entity.Property(e => e.AdKorean).HasMaxLength(50);

                entity.Property(e => e.AdMalaysia).HasMaxLength(50);

                entity.Property(e => e.AdPortuguese).HasMaxLength(50);

                entity.Property(e => e.AdRussian).HasMaxLength(50);

                entity.Property(e => e.AdSpanish).HasMaxLength(50);

                entity.Property(e => e.AdThiland).HasMaxLength(50);

                entity.Property(e => e.AdVietnam).HasMaxLength(50);
            });

            modelBuilder.Entity<SysProgram>(entity =>
            {
                entity.ToTable("sys_Program");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AdArabic).HasMaxLength(50);

                entity.Property(e => e.AdChinese).HasMaxLength(50);

                entity.Property(e => e.AdEnglish).HasMaxLength(50);

                entity.Property(e => e.AdFrench).HasMaxLength(50);

                entity.Property(e => e.AdGerman).HasMaxLength(50);

                entity.Property(e => e.AdItalian).HasMaxLength(50);

                entity.Property(e => e.AdKorean).HasMaxLength(50);

                entity.Property(e => e.AdMalaysia).HasMaxLength(50);

                entity.Property(e => e.AdPortuguese).HasMaxLength(50);

                entity.Property(e => e.AdRussian).HasMaxLength(50);

                entity.Property(e => e.AdSpanish).HasMaxLength(50);

                entity.Property(e => e.AdThiland).HasMaxLength(50);

                entity.Property(e => e.AdVietnam).HasMaxLength(50);
            });

            modelBuilder.Entity<SysReport>(entity =>
            {
                entity.HasKey(e => new { e.GroupCode, e.ReportCode, e.Id, e.Kind });

                entity.ToTable("sys_Report");

                entity.Property(e => e.ReportCode).HasMaxLength(20);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AdArabic).HasMaxLength(50);

                entity.Property(e => e.AdChinese).HasMaxLength(50);

                entity.Property(e => e.AdEnglish).HasMaxLength(50);

                entity.Property(e => e.AdFrench).HasMaxLength(50);

                entity.Property(e => e.AdGerman).HasMaxLength(50);

                entity.Property(e => e.AdItalian).HasMaxLength(50);

                entity.Property(e => e.AdKorean).HasMaxLength(50);

                entity.Property(e => e.AdMalaysia).HasMaxLength(50);

                entity.Property(e => e.AdPortuguese).HasMaxLength(50);

                entity.Property(e => e.AdRussian).HasMaxLength(50);

                entity.Property(e => e.AdSpanish).HasMaxLength(50);

                entity.Property(e => e.AdThiland).HasMaxLength(50);

                entity.Property(e => e.AdVietnam).HasMaxLength(50);

                entity.Property(e => e.FieldName).HasMaxLength(50);

                entity.Property(e => e.ObjectIndex).HasDefaultValueSql("((1))");

                entity.Property(e => e.Sqlstring)
                    .HasColumnType("ntext")
                    .HasColumnName("SQLString");

                entity.HasOne(d => d.ReportCodeNavigation)
                    .WithMany(p => p.SysReports)
                    .HasForeignKey(d => d.ReportCode)
                    .HasConstraintName("FK_sys_Report_sys_Reports");
            });

            modelBuilder.Entity<SysReport1>(entity =>
            {
                entity.ToTable("sys_Reports");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AdArabic).HasMaxLength(50);

                entity.Property(e => e.AdChinese).HasMaxLength(50);

                entity.Property(e => e.AdEnglish).HasMaxLength(50);

                entity.Property(e => e.AdFrench).HasMaxLength(50);

                entity.Property(e => e.AdGerman).HasMaxLength(50);

                entity.Property(e => e.AdItalian).HasMaxLength(50);

                entity.Property(e => e.AdKorean).HasMaxLength(50);

                entity.Property(e => e.AdMalaysia).HasMaxLength(50);

                entity.Property(e => e.AdPortuguese).HasMaxLength(50);

                entity.Property(e => e.AdRussian).HasMaxLength(50);

                entity.Property(e => e.AdSpanish).HasMaxLength(50);

                entity.Property(e => e.AdThiland).HasMaxLength(50);

                entity.Property(e => e.AdVietnam).HasMaxLength(50);

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.SysReport1s)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_sys_Reports_sys_ReportGroup");
            });

            modelBuilder.Entity<SysReportGroup>(entity =>
            {
                entity.ToTable("sys_ReportGroup");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AdArabic).HasMaxLength(50);

                entity.Property(e => e.AdChinese).HasMaxLength(50);

                entity.Property(e => e.AdEnglish).HasMaxLength(50);

                entity.Property(e => e.AdFrench).HasMaxLength(50);

                entity.Property(e => e.AdGerman).HasMaxLength(50);

                entity.Property(e => e.AdItalian).HasMaxLength(50);

                entity.Property(e => e.AdKorean).HasMaxLength(50);

                entity.Property(e => e.AdMalaysia).HasMaxLength(50);

                entity.Property(e => e.AdPortuguese).HasMaxLength(50);

                entity.Property(e => e.AdRussian).HasMaxLength(50);

                entity.Property(e => e.AdSpanish).HasMaxLength(50);

                entity.Property(e => e.AdThiland).HasMaxLength(50);

                entity.Property(e => e.AdVietnam).HasMaxLength(50);
            });

            modelBuilder.Entity<SysTerminalKind>(entity =>
            {
                entity.ToTable("sys_TerminalKind");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AdArabic).HasMaxLength(50);

                entity.Property(e => e.AdChinese).HasMaxLength(50);

                entity.Property(e => e.AdEnglish).HasMaxLength(50);

                entity.Property(e => e.AdFrench).HasMaxLength(50);

                entity.Property(e => e.AdGerman).HasMaxLength(50);

                entity.Property(e => e.AdItalian).HasMaxLength(50);

                entity.Property(e => e.AdKorean).HasMaxLength(50);

                entity.Property(e => e.AdMalaysia).HasMaxLength(50);

                entity.Property(e => e.AdPortuguese).HasMaxLength(50);

                entity.Property(e => e.AdRussian).HasMaxLength(50);

                entity.Property(e => e.AdSpanish).HasMaxLength(50);

                entity.Property(e => e.AdThiland).HasMaxLength(50);

                entity.Property(e => e.AdVietnam).HasMaxLength(50);
            });

            modelBuilder.Entity<SysTerminalMode>(entity =>
            {
                entity.ToTable("sys_TerminalMode");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AdArabic).HasMaxLength(50);

                entity.Property(e => e.AdChinese).HasMaxLength(50);

                entity.Property(e => e.AdEnglish).HasMaxLength(50);

                entity.Property(e => e.AdFrench).HasMaxLength(50);

                entity.Property(e => e.AdGerman).HasMaxLength(50);

                entity.Property(e => e.AdItalian).HasMaxLength(50);

                entity.Property(e => e.AdKorean).HasMaxLength(50);

                entity.Property(e => e.AdMalaysia).HasMaxLength(50);

                entity.Property(e => e.AdPortuguese).HasMaxLength(50);

                entity.Property(e => e.AdRussian).HasMaxLength(50);

                entity.Property(e => e.AdSpanish).HasMaxLength(50);

                entity.Property(e => e.AdThiland).HasMaxLength(50);

                entity.Property(e => e.AdVietnam).HasMaxLength(50);
            });

            modelBuilder.Entity<SysTerminalModel>(entity =>
            {
                entity.ToTable("sys_TerminalModel");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);
            });

            modelBuilder.Entity<SysTerminalType>(entity =>
            {
                entity.ToTable("sys_TerminalType");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AdArabic).HasMaxLength(50);

                entity.Property(e => e.AdChinese).HasMaxLength(50);

                entity.Property(e => e.AdEnglish).HasMaxLength(50);

                entity.Property(e => e.AdFrench).HasMaxLength(50);

                entity.Property(e => e.AdGerman).HasMaxLength(50);

                entity.Property(e => e.AdItalian).HasMaxLength(50);

                entity.Property(e => e.AdKorean).HasMaxLength(50);

                entity.Property(e => e.AdMalaysia).HasMaxLength(50);

                entity.Property(e => e.AdPortuguese).HasMaxLength(50);

                entity.Property(e => e.AdRussian).HasMaxLength(50);

                entity.Property(e => e.AdSpanish).HasMaxLength(50);

                entity.Property(e => e.AdThiland).HasMaxLength(50);

                entity.Property(e => e.AdVietnam).HasMaxLength(50);
            });

            modelBuilder.Entity<SysUserDef>(entity =>
            {
                entity.ToTable("sys_UserDef");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AdArabic).HasMaxLength(50);

                entity.Property(e => e.AdChinese).HasMaxLength(50);

                entity.Property(e => e.AdEnglish).HasMaxLength(50);

                entity.Property(e => e.AdFrench).HasMaxLength(50);

                entity.Property(e => e.AdGerman).HasMaxLength(50);

                entity.Property(e => e.AdItalian).HasMaxLength(50);

                entity.Property(e => e.AdKorean).HasMaxLength(50);

                entity.Property(e => e.AdMalaysia).HasMaxLength(50);

                entity.Property(e => e.AdPortuguese).HasMaxLength(50);

                entity.Property(e => e.AdRussian).HasMaxLength(50);

                entity.Property(e => e.AdSpanish).HasMaxLength(50);

                entity.Property(e => e.AdThiland).HasMaxLength(50);

                entity.Property(e => e.AdVietnam).HasMaxLength(50);
            });

            modelBuilder.Entity<SysUserLevel>(entity =>
            {
                entity.ToTable("sys_UserLevel");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AdArabic).HasMaxLength(50);

                entity.Property(e => e.AdChinese).HasMaxLength(50);

                entity.Property(e => e.AdEnglish).HasMaxLength(50);

                entity.Property(e => e.AdFrench).HasMaxLength(50);

                entity.Property(e => e.AdGerman).HasMaxLength(50);

                entity.Property(e => e.AdItalian).HasMaxLength(50);

                entity.Property(e => e.AdKorean).HasMaxLength(50);

                entity.Property(e => e.AdMalaysia).HasMaxLength(50);

                entity.Property(e => e.AdPortuguese).HasMaxLength(50);

                entity.Property(e => e.AdRussian).HasMaxLength(50);

                entity.Property(e => e.AdSpanish).HasMaxLength(50);

                entity.Property(e => e.AdThiland).HasMaxLength(50);

                entity.Property(e => e.AdVietnam).HasMaxLength(50);
            });

            modelBuilder.Entity<TalepSebepleri>(entity =>
            {
                entity.ToTable("TalepSebepleri");

                entity.Property(e => e.Sebep).HasMaxLength(100);
            });

            modelBuilder.Entity<Tasnifleme>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("Tasnifleme");

                entity.HasIndex(e => e.MesaiTarih, "IX_Tasnifleme_MesaiTarih");

                entity.HasIndex(e => e.Id, "IX_Tasnifleme")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AraSure).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisId).HasColumnName("CikisID");

                entity.Property(e => e.FaraSure).HasColumnName("FAraSure");

                entity.Property(e => e.FazlaMesaiNedeni).HasMaxLength(500);

                entity.Property(e => e.Fmneden)
                    .HasColumnName("fmneden")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Gcikis)
                    .HasColumnType("datetime")
                    .HasColumnName("gcikis");

                entity.Property(e => e.Ggiris)
                    .HasColumnType("datetime")
                    .HasColumnName("ggiris");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisId).HasColumnName("GirisID");

                entity.Property(e => e.Index).HasColumnType("datetime");

                entity.Property(e => e.Itfaciklama)
                    .HasMaxLength(500)
                    .HasColumnName("ITFAciklama");

                entity.Property(e => e.IzinId).HasColumnName("IzinID");

                entity.Property(e => e.IzinIdList).HasMaxLength(250);

                entity.Property(e => e.MesaiAciklama).HasMaxLength(500);

                entity.Property(e => e.MesaiOzetAciklama).HasMaxLength(4000);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Sgfaciklama)
                    .HasMaxLength(500)
                    .HasColumnName("SGFAciklama");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.TalepEdilenFmsure).HasColumnName("TalepEdilenFMSure");

                entity.Property(e => e.Xfm1)
                    .HasColumnName("xfm1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Xfm1Oran)
                    .HasColumnName("xfm1Oran")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Xfm2)
                    .HasColumnName("xfm2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Xfm2Oran)
                    .HasColumnName("xfm2Oran")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e._24pass).HasColumnName("24pass");

                entity.HasOne(d => d.Sicil)
                    .WithMany(p => p.Tasniflemes)
                    .HasForeignKey(d => d.SicilId)
                    .HasConstraintName("FK_Tasnifleme_Sicil");
            });

            modelBuilder.Entity<TasniflemeRescue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TasniflemeRescue");

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisId).HasColumnName("CikisID");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisId).HasColumnName("GirisID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MesaiAciklama).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e._24pass).HasColumnName("24pass");
            });

            modelBuilder.Entity<TasniflemeSonEventList>(entity =>
            {
                entity.ToTable("TasniflemeSonEventList");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.SonEventTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TatilTipleri>(entity =>
            {
                entity.ToTable("TatilTipleri");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Bassaat).HasDefaultValueSql("((0))");

                entity.Property(e => e.Gun).HasColumnType("date");

                entity.Property(e => e.Kod).HasMaxLength(50);

                entity.Property(e => e.Tamgun)
                    .IsRequired()
                    .HasDefaultValueSql("((-1))");
            });

            modelBuilder.Entity<Tatiller>(entity =>
            {
                entity.ToTable("Tatiller");

                entity.HasIndex(e => e.Id, "IX_Tatiller")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Tarih).HasColumnType("smalldatetime");

                entity.Property(e => e.TatilId).HasColumnName("TatilID");

                entity.HasOne(d => d.Tatil)
                    .WithMany(p => p.Tatillers)
                    .HasForeignKey(d => d.TatilId)
                    .HasConstraintName("FK_Tatiller_TatilTipleri");
            });

            modelBuilder.Entity<TblAcEtkin>(entity =>
            {
                entity.ToTable("Tbl_AcEtkin");

                entity.Property(e => e.Acetkin).HasColumnName("ACEtkin");

                entity.Property(e => e.DomainName).HasMaxLength(150);

                entity.Property(e => e.DomainPath).HasMaxLength(150);
            });

            modelBuilder.Entity<TblAktarim>(entity =>
            {
                entity.ToTable("Tbl_Aktarim");

                entity.Property(e => e.Adi).HasMaxLength(50);

                entity.Property(e => e.Bolum).HasMaxLength(500);

                entity.Property(e => e.CardId).HasMaxLength(50);

                entity.Property(e => e.CikisTar).HasColumnType("datetime");

                entity.Property(e => e.FacilityCode).HasMaxLength(50);

                entity.Property(e => e.Firma).HasMaxLength(500);

                entity.Property(e => e.GirisTar).HasColumnType("datetime");

                entity.Property(e => e.Gorev).HasMaxLength(500);

                entity.Property(e => e.Pozisyon).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcKimlikNo).HasMaxLength(50);
            });

            modelBuilder.Entity<TblAnfaAktarimBilgileri>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_AnfaAktarimBilgileri");

                entity.Property(e => e.Adi).HasMaxLength(50);

                entity.Property(e => e.Adres).HasMaxLength(4000);

                entity.Property(e => e.BabaAdi).HasMaxLength(50);

                entity.Property(e => e.Birimi).HasMaxLength(150);

                entity.Property(e => e.BrutMaas).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Cinsiyet).HasMaxLength(50);

                entity.Property(e => e.DogumTarihi).HasColumnType("datetime");

                entity.Property(e => e.DogumYeri).HasMaxLength(50);

                entity.Property(e => e.Ehliyet).HasMaxLength(50);

                entity.Property(e => e.EhliyetveBelgeTarih).HasMaxLength(150);

                entity.Property(e => e.Engelli).HasMaxLength(50);

                entity.Property(e => e.FiilenYapılanIs).HasMaxLength(150);

                entity.Property(e => e.GeciciDaimi).HasMaxLength(150);

                entity.Property(e => e.GorevYeri).HasMaxLength(350);

                entity.Property(e => e.GorevlendirildigiYer).HasMaxLength(450);

                entity.Property(e => e.Ilce).HasMaxLength(50);

                entity.Property(e => e.IseGiris).HasColumnType("datetime");

                entity.Property(e => e.Kadrosu).HasMaxLength(50);

                entity.Property(e => e.Khkdurumu)
                    .HasMaxLength(50)
                    .HasColumnName("KHKDurumu");

                entity.Property(e => e.KhkgecisKadro)
                    .HasMaxLength(150)
                    .HasColumnName("KHKGecisKadro");

                entity.Property(e => e.MeslekAdi).HasMaxLength(350);

                entity.Property(e => e.MezunOlduguAlan).HasMaxLength(250);

                entity.Property(e => e.MezunOlduguBolum).HasMaxLength(450);

                entity.Property(e => e.MezunOlduguOkul).HasMaxLength(350);

                entity.Property(e => e.Mezuniyet).HasMaxLength(50);

                entity.Property(e => e.MezuniyetTarihi).HasColumnType("datetime");

                entity.Property(e => e.NetMaas).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Referansı).HasMaxLength(350);

                entity.Property(e => e.Sertifika).HasMaxLength(4000);

                entity.Property(e => e.Soyadi).HasMaxLength(50);

                entity.Property(e => e.Tcno)
                    .HasMaxLength(50)
                    .HasColumnName("TCNO");

                entity.Property(e => e.Telefon).HasMaxLength(50);

                entity.Property(e => e.UcretTipi).HasMaxLength(150);
            });

            modelBuilder.Entity<TblAraGeci>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_AraGecis");

                entity.Property(e => e.AdSoyad).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisId)
                    .HasMaxLength(30)
                    .HasColumnName("CikisID");

                entity.Property(e => e.CikisTerminalAd)
                    .HasMaxLength(70)
                    .HasColumnName("CikisTerminalAD");

                entity.Property(e => e.CikisTerminalId)
                    .HasMaxLength(8)
                    .HasColumnName("CikisTerminalID");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisId)
                    .HasMaxLength(30)
                    .HasColumnName("GirisID");

                entity.Property(e => e.GirisTerminalAd)
                    .HasMaxLength(70)
                    .HasColumnName("GirisTerminalAD");

                entity.Property(e => e.GirisTerminalId)
                    .HasMaxLength(8)
                    .HasColumnName("GirisTerminalID");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.MesaiGunu).HasColumnType("datetime");

                entity.Property(e => e.SicilId)
                    .HasMaxLength(30)
                    .HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);
            });

            modelBuilder.Entity<TblAraGecisHareketleri>(entity =>
            {
                entity.ToTable("Tbl_AraGecisHareketleri");
            });

            modelBuilder.Entity<TblAsansor>(entity =>
            {
                entity.ToTable("Tbl_Asansor");

                entity.Property(e => e.Adi).HasMaxLength(500);
            });

            modelBuilder.Entity<TblAsansorDuty>(entity =>
            {
                entity.ToTable("Tbl_AsansorDuty");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.RecordDate).HasColumnType("datetime");

                entity.Property(e => e.Result).HasMaxLength(1000);

                entity.Property(e => e.UserId).HasMaxLength(8);
            });

            modelBuilder.Entity<TblAsansorKat>(entity =>
            {
                entity.ToTable("Tbl_AsansorKat");

                entity.Property(e => e.KatEtiket).HasMaxLength(500);
            });

            modelBuilder.Entity<TblAylikPdk>(entity =>
            {
                entity.ToTable("Tbl_AylikPDKS");

                entity.Property(e => e.AyAd).HasMaxLength(50);

                entity.Property(e => e.C1)
                    .HasMaxLength(5)
                    .HasColumnName("C_1");

                entity.Property(e => e.C10)
                    .HasMaxLength(5)
                    .HasColumnName("C_10");

                entity.Property(e => e.C11)
                    .HasMaxLength(5)
                    .HasColumnName("C_11");

                entity.Property(e => e.C12)
                    .HasMaxLength(5)
                    .HasColumnName("C_12");

                entity.Property(e => e.C13)
                    .HasMaxLength(5)
                    .HasColumnName("C_13");

                entity.Property(e => e.C14)
                    .HasMaxLength(5)
                    .HasColumnName("C_14");

                entity.Property(e => e.C15)
                    .HasMaxLength(5)
                    .HasColumnName("C_15");

                entity.Property(e => e.C16)
                    .HasMaxLength(5)
                    .HasColumnName("C_16");

                entity.Property(e => e.C17)
                    .HasMaxLength(5)
                    .HasColumnName("C_17");

                entity.Property(e => e.C18)
                    .HasMaxLength(5)
                    .HasColumnName("C_18");

                entity.Property(e => e.C19)
                    .HasMaxLength(5)
                    .HasColumnName("C_19");

                entity.Property(e => e.C2)
                    .HasMaxLength(5)
                    .HasColumnName("C_2");

                entity.Property(e => e.C20)
                    .HasMaxLength(5)
                    .HasColumnName("C_20");

                entity.Property(e => e.C21)
                    .HasMaxLength(5)
                    .HasColumnName("C_21");

                entity.Property(e => e.C22)
                    .HasMaxLength(5)
                    .HasColumnName("C_22");

                entity.Property(e => e.C23)
                    .HasMaxLength(5)
                    .HasColumnName("C_23");

                entity.Property(e => e.C24)
                    .HasMaxLength(5)
                    .HasColumnName("C_24");

                entity.Property(e => e.C25)
                    .HasMaxLength(5)
                    .HasColumnName("C_25");

                entity.Property(e => e.C26)
                    .HasMaxLength(5)
                    .HasColumnName("C_26");

                entity.Property(e => e.C27)
                    .HasMaxLength(5)
                    .HasColumnName("C_27");

                entity.Property(e => e.C28)
                    .HasMaxLength(5)
                    .HasColumnName("C_28");

                entity.Property(e => e.C29)
                    .HasMaxLength(5)
                    .HasColumnName("C_29");

                entity.Property(e => e.C3)
                    .HasMaxLength(5)
                    .HasColumnName("C_3");

                entity.Property(e => e.C30)
                    .HasMaxLength(5)
                    .HasColumnName("C_30");

                entity.Property(e => e.C31)
                    .HasMaxLength(5)
                    .HasColumnName("C_31");

                entity.Property(e => e.C4)
                    .HasMaxLength(5)
                    .HasColumnName("C_4");

                entity.Property(e => e.C5)
                    .HasMaxLength(5)
                    .HasColumnName("C_5");

                entity.Property(e => e.C6)
                    .HasMaxLength(5)
                    .HasColumnName("C_6");

                entity.Property(e => e.C7)
                    .HasMaxLength(5)
                    .HasColumnName("C_7");

                entity.Property(e => e.C8)
                    .HasMaxLength(5)
                    .HasColumnName("C_8");

                entity.Property(e => e.C9)
                    .HasMaxLength(5)
                    .HasColumnName("C_9");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.ToplamFm)
                    .HasMaxLength(5)
                    .HasColumnName("ToplamFM")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblAyrilanSiciller>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_AyrilanSiciller");

                entity.Property(e => e.GlobalSicilNo).HasMaxLength(50);

                entity.Property(e => e.SicilNo).HasMaxLength(50);
            });

            modelBuilder.Entity<TblBilet>(entity =>
            {
                entity.ToTable("Tbl_Bilet");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BiletAlisTarih).HasColumnType("datetime");

                entity.Property(e => e.DonusTarih).HasColumnType("datetime");

                entity.Property(e => e.DosyaYolu)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.UcusTarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblBiletIzinTip>(entity =>
            {
                entity.ToTable("Tbl_BiletIzinTip");

                entity.Property(e => e.Ad)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBirimler>(entity =>
            {
                entity.ToTable("Tbl_Birimler");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.CihazId)
                    .HasMaxLength(100)
                    .HasColumnName("CihazID");

                entity.Property(e => e.CihazUstBirimId).HasMaxLength(100);

                entity.Property(e => e.EntegrasyonKod).HasMaxLength(25);
            });

            modelBuilder.Entity<TblBosSifre>(entity =>
            {
                entity.ToTable("Tbl_BosSifre");

                entity.Property(e => e.BosSifre).HasMaxLength(50);
            });

            modelBuilder.Entity<TblDaireTanimlari>(entity =>
            {
                entity.ToTable("Tbl_DaireTanimlari");

                entity.Property(e => e.DaireAdi).HasMaxLength(250);
            });

            modelBuilder.Entity<TblDetailedLog>(entity =>
            {
                entity.ToTable("Tbl_DetailedLogs");

                entity.Property(e => e.AlanAdi).HasMaxLength(150);

                entity.Property(e => e.Ed)
                    .HasMaxLength(2000)
                    .HasColumnName("ED");

                entity.Property(e => e.EkranAdi).HasMaxLength(150);

                entity.Property(e => e.Tablo).HasMaxLength(150);

                entity.Property(e => e.Yd)
                    .HasMaxLength(2000)
                    .HasColumnName("YD");

                entity.Property(e => e.Zaman).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblDinlenmeGecisleri>(entity =>
            {
                entity.ToTable("Tbl_DinlenmeGecisleri");

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisId)
                    .HasMaxLength(50)
                    .HasColumnName("CikisID");

                entity.Property(e => e.CikisTerminalId)
                    .HasMaxLength(10)
                    .HasColumnName("CikisTerminalID")
                    .IsFixedLength();

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisId)
                    .HasMaxLength(50)
                    .HasColumnName("GirisID");

                entity.Property(e => e.GirisTerminalId)
                    .HasMaxLength(10)
                    .HasColumnName("GirisTerminalID")
                    .IsFixedLength();

                entity.Property(e => e.MesaiTarih).HasColumnType("date");

                entity.Property(e => e.SicilId)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblEventKey>(entity =>
            {
                entity.ToTable("Tbl_EventKeys");

                entity.Property(e => e.Event).HasMaxLength(150);
            });

            modelBuilder.Entity<TblExcel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Excel");

                entity.Property(e => e.HexCardNo).HasMaxLength(16);

                entity.Property(e => e.SicilNo).HasMaxLength(50);
            });

            modelBuilder.Entity<TblFizin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_FIzin");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.SicilId)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblGateIodoorDuty>(entity =>
            {
                entity.ToTable("Tbl_GateIODoorDuty");

                entity.Property(e => e.PanelIp).HasMaxLength(50);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.RecordDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblGeciciKartIslem>(entity =>
            {
                entity.ToTable("Tbl_GeciciKartIslem");

                entity.Property(e => e.GeciciKartIslemBitisTarihi).HasColumnType("datetime");

                entity.Property(e => e.GeciciKartUserId).HasMaxLength(8);

                entity.Property(e => e.GeciciKartVerilmeTarih).HasColumnType("datetime");

                entity.Property(e => e.SonGecerlilikTarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblGonderilenMailIcerik>(entity =>
            {
                entity.ToTable("Tbl_GonderilenMailIcerik");

                entity.Property(e => e.GondermeTarihi).HasColumnType("datetime");

                entity.Property(e => e.MailAdres).HasMaxLength(150);

                entity.Property(e => e.RaporAdi).HasMaxLength(150);
            });

            modelBuilder.Entity<TblGunlukIzinOzeti>(entity =>
            {
                entity.ToTable("Tbl_GunlukIzinOzeti");
            });

            modelBuilder.Entity<TblHakDusenIzinTip>(entity =>
            {
                entity.ToTable("Tbl_HakDusenIzinTip");
            });

            modelBuilder.Entity<TblHaritaKonum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_HaritaKonum");

                entity.Property(e => e.Ad).HasMaxLength(200);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<TblHaritaMarker>(entity =>
            {
                entity.ToTable("Tbl_HaritaMarker");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.HaritaId).HasColumnName("HaritaID");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");
            });

            modelBuilder.Entity<TblHaritaSubeMarker>(entity =>
            {
                entity.ToTable("Tbl_HaritaSubeMarker");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");
            });

            modelBuilder.Entity<TblHaritum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Harita");

                entity.Property(e => e.Ad).HasMaxLength(150);

                entity.Property(e => e.BinaAdi).HasMaxLength(150);

                entity.Property(e => e.Bolge).HasMaxLength(250);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Kat)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Zemin')");

                entity.Property(e => e.KesifTarih).HasColumnType("datetime");

                entity.Property(e => e.KonumId).HasColumnName("KonumID");

                entity.Property(e => e.SonGuncelleyen).HasMaxLength(50);

                entity.Property(e => e.SonguncellemeZamani).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblHataliGecisler>(entity =>
            {
                entity.ToTable("Tbl_HataliGecisler");

                entity.Property(e => e.HataliGecisYonu).HasMaxLength(50);
            });

            modelBuilder.Entity<TblHesaplayiciAyar>(entity =>
            {
                entity.ToTable("Tbl_HesaplayiciAyar");

                entity.Property(e => e.MailSure).HasDefaultValueSql("((30))");
            });

            modelBuilder.Entity<TblHesaplayiciZaman>(entity =>
            {
                entity.ToTable("Tbl_HesaplayiciZaman");

                entity.Property(e => e.BaslangicZamani).HasColumnType("datetime");

                entity.Property(e => e.BitisZamani).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblIlaveYetki>(entity =>
            {
                entity.ToTable("Tbl_IlaveYetki");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .HasColumnName("UserID");

                entity.Property(e => e.YetkiId).HasColumnName("YetkiID");
            });

            modelBuilder.Entity<TblIlaveYetkiLog>(entity =>
            {
                entity.ToTable("Tbl_IlaveYetki_Log");

                entity.Property(e => e.IslemDatetime).HasColumnType("datetime");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .HasColumnName("UserID");

                entity.Property(e => e.YetkiId).HasColumnName("YetkiID");
            });

            modelBuilder.Entity<TblIller>(entity =>
            {
                entity.ToTable("Tbl_Iller");

                entity.Property(e => e.IlAd)
                    .HasMaxLength(50)
                    .HasColumnName("ilAd");

                entity.Property(e => e.IlBolgeKodu)
                    .HasMaxLength(50)
                    .HasColumnName("ilBolgeKodu");

                entity.Property(e => e.IlHaritaKod)
                    .HasMaxLength(50)
                    .HasColumnName("ilHaritaKod");

                entity.Property(e => e.IlKodu).HasColumnName("ilKodu");
            });

            modelBuilder.Entity<TblIzinAki>(entity =>
            {
                entity.ToTable("Tbl_IzinAkis");

                entity.Property(e => e.Aciklama).HasMaxLength(500);
            });

            modelBuilder.Entity<TblIzinAkisSicil>(entity =>
            {
                entity.ToTable("Tbl_IzinAkisSicil");
            });

            modelBuilder.Entity<TblIzinAkisSicilOnay>(entity =>
            {
                entity.ToTable("Tbl_IzinAkisSicilOnay");

                entity.Property(e => e.DosyaYolu).HasMaxLength(1000);

                entity.Property(e => e.IslemNotu).HasMaxLength(4000);

                entity.Property(e => e.IslemTarih).HasColumnType("datetime");

                entity.Property(e => e.KayitTarih).HasColumnType("datetime");

                entity.HasOne(d => d.Izin)
                    .WithMany(p => p.TblIzinAkisSicilOnays)
                    .HasForeignKey(d => d.IzinId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_IzinAkisSicilOnay_Izinler");

                entity.HasOne(d => d.IzinOnayIslemDurum)
                    .WithMany(p => p.TblIzinAkisSicilOnays)
                    .HasForeignKey(d => d.IzinOnayIslemDurumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_IzinAkisSicilOnay_Tbl_sys_IzinOnayIslemDurum");

                entity.HasOne(d => d.Sicil)
                    .WithMany(p => p.TblIzinAkisSicilOnays)
                    .HasForeignKey(d => d.SicilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_IzinAkisSicilOnay_Sicil");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblIzinAkisSicilOnays)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Tbl_IzinAkisSicilOnay_UserTables");
            });

            modelBuilder.Entity<TblIzinKidemKurali>(entity =>
            {
                entity.ToTable("Tbl_IzinKidemKurali");

                entity.HasOne(d => d.IzinKural)
                    .WithMany(p => p.TblIzinKidemKuralis)
                    .HasForeignKey(d => d.IzinKuralId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_IzinKidemKurali_Tbl_IzinTanimKurali");

                entity.HasOne(d => d.IzinTip)
                    .WithMany(p => p.TblIzinKidemKuralis)
                    .HasForeignKey(d => d.IzinTipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_IzinKidemKurali_IzinTipleri");
            });

            modelBuilder.Entity<TblIzinLimitKurali>(entity =>
            {
                entity.ToTable("Tbl_IzinLimitKurali");

                entity.Property(e => e.MaxGunSayisi).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinGunSayisi).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IzinKural)
                    .WithMany(p => p.TblIzinLimitKuralis)
                    .HasForeignKey(d => d.IzinKuralId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_IzinLimitKurali_Tbl_IzinTanimKurali");

                entity.HasOne(d => d.IzinTip)
                    .WithMany(p => p.TblIzinLimitKuralis)
                    .HasForeignKey(d => d.IzinTipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_IzinLimitKurali_IzinTipleri");
            });

            modelBuilder.Entity<TblIzinTanimKurali>(entity =>
            {
                entity.ToTable("Tbl_IzinTanimKurali");

                entity.Property(e => e.KuralAdi).HasMaxLength(50);

                entity.HasOne(d => d.IzinHesaplamaTip)
                    .WithMany(p => p.TblIzinTanimKuralis)
                    .HasForeignKey(d => d.IzinHesaplamaTipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_IzinTanimKurali_Tbl_sys_IzinHesaplamaTipi");
            });

            modelBuilder.Entity<TblIzinYasKurali>(entity =>
            {
                entity.ToTable("Tbl_IzinYasKurali");

                entity.HasOne(d => d.IzinKural)
                    .WithMany(p => p.TblIzinYasKuralis)
                    .HasForeignKey(d => d.IzinKuralId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_IzinYasKurali_Tbl_IzinTanimKurali");

                entity.HasOne(d => d.IzinTip)
                    .WithMany(p => p.TblIzinYasKuralis)
                    .HasForeignKey(d => d.IzinTipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_IzinYasKurali_IzinTipleri");
            });

            modelBuilder.Entity<TblKameraDuty>(entity =>
            {
                entity.ToTable("Tbl_KameraDuty");

                entity.Property(e => e.ProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblKameraEvent>(entity =>
            {
                entity.ToTable("Tbl_KameraEvents");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.ResimYolu).HasMaxLength(4000);
            });

            modelBuilder.Entity<TblKameraTanim>(entity =>
            {
                entity.ToTable("Tbl_KameraTanim");

                entity.Property(e => e.KameraAdi).HasMaxLength(150);

                entity.Property(e => e.KameraIp).HasMaxLength(250);

                entity.Property(e => e.KameraPass).HasMaxLength(50);

                entity.Property(e => e.KameraUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblKameraTerminal>(entity =>
            {
                entity.ToTable("Tbl_KameraTerminal");
            });

            modelBuilder.Entity<TblKartNoCevirmeTipi>(entity =>
            {
                entity.ToTable("Tbl_KartNoCevirmeTipi");

                entity.Property(e => e.KartCevirmeTipi).HasMaxLength(50);
            });

            modelBuilder.Entity<TblKroki>(entity =>
            {
                entity.ToTable("Tbl_Kroki");

                entity.Property(e => e.KrokiAdi).HasMaxLength(250);

                entity.Property(e => e.KrokiImage).HasMaxLength(250);
            });

            modelBuilder.Entity<TblKurulu>(entity =>
            {
                entity.ToTable("Tbl_Kurulus");

                entity.Property(e => e.KurulusAdi).HasMaxLength(250);
            });

            modelBuilder.Entity<TblLanguageLabel>(entity =>
            {
                entity.ToTable("Tbl_LanguageLabels");

                entity.Property(e => e.LabelName).HasMaxLength(50);

                entity.Property(e => e.LabelText).HasMaxLength(150);
            });

            modelBuilder.Entity<TblLastMailSendTime>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_LastMailSendTime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastMailSendTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblLedPanel>(entity =>
            {
                entity.ToTable("Tbl_LedPanel");

                entity.HasIndex(e => e.Id, "IX_Tbl_LedPanel")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.HosgeldinMesaji).HasMaxLength(20);

                entity.Property(e => e.Islemdate).HasColumnType("datetime");

                entity.Property(e => e.LedPanelAdi).HasMaxLength(500);

                entity.Property(e => e.LedPanelIp).HasMaxLength(100);

                entity.HasOne(d => d.Terminal)
                    .WithMany(p => p.TblLedPanels)
                    .HasForeignKey(d => d.TerminalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_LedPanel_Terminaller");
            });

            modelBuilder.Entity<TblLedPanelBeklemeMesaji>(entity =>
            {
                entity.ToTable("Tbl_LedPanelBeklemeMesaji");

                entity.HasIndex(e => e.Id, "IX_Tbl_PanelBeklemeMesaji")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.MesajBir).HasMaxLength(20);

                entity.Property(e => e.MesajDort).HasMaxLength(20);

                entity.Property(e => e.MesajIki).HasMaxLength(20);

                entity.Property(e => e.MesajUc).HasMaxLength(20);
            });

            modelBuilder.Entity<TblLedPanelBeklemeMesajiLog>(entity =>
            {
                entity.ToTable("Tbl_LedPanelBeklemeMesaji_Log");

                entity.HasIndex(e => e.Id, "IX_Tbl_LedPanelBeklemeMesaji_Log")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.IslemZamani).HasColumnType("datetime");

                entity.Property(e => e.MesajBir).HasMaxLength(20);

                entity.Property(e => e.MesajDort).HasMaxLength(20);

                entity.Property(e => e.MesajIki).HasMaxLength(20);

                entity.Property(e => e.MesajUc).HasMaxLength(20);
            });

            modelBuilder.Entity<TblLedPanelHatakodlari>(entity =>
            {
                entity.ToTable("Tbl_LedPanelHatakodlari");

                entity.Property(e => e.KullaniciAciklama).HasMaxLength(250);

                entity.Property(e => e.LedPanelAciklama).HasMaxLength(20);
            });

            modelBuilder.Entity<TblLedPanelTatilMesaji>(entity =>
            {
                entity.ToTable("Tbl_LedPanelTatilMesaji");

                entity.HasIndex(e => e.Id, "IX_Tbl_PanelTatilMesaji")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.BasTar).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.MesajBir).HasMaxLength(20);

                entity.Property(e => e.MesajDort).HasMaxLength(20);

                entity.Property(e => e.MesajIki).HasMaxLength(20);

                entity.Property(e => e.MesajUc).HasMaxLength(20);

                entity.Property(e => e.SonTar).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblLedPanelYaziIslem>(entity =>
            {
                entity.ToTable("Tbl_LedPanelYaziIslem");
            });

            modelBuilder.Entity<TblLog>(entity =>
            {
                entity.ToTable("Tbl_Logs");

                entity.Property(e => e.IslemAciklama).HasMaxLength(500);

                entity.Property(e => e.Tarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblLogType>(entity =>
            {
                entity.ToTable("Tbl_LogTypes");

                entity.Property(e => e.IslemAdi).HasMaxLength(50);
            });

            modelBuilder.Entity<TblLoginFirmaYetki>(entity =>
            {
                entity.ToTable("Tbl_LoginFirmaYetki");
            });

            modelBuilder.Entity<TblLoginLokasyonYetki>(entity =>
            {
                entity.ToTable("Tbl_LoginLokasyonYetki");
            });

            modelBuilder.Entity<TblLoginRaporYetki>(entity =>
            {
                entity.ToTable("Tbl_LoginRaporYetki");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<TblLoginTerminalYetki>(entity =>
            {
                entity.ToTable("Tbl_LoginTerminalYetki");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<TblLoginYetkiGrubu>(entity =>
            {
                entity.ToTable("Tbl_LoginYetkiGrubu");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<TblLoginYetkiliPeriyodlar>(entity =>
            {
                entity.ToTable("Tbl_LoginYetkiliPeriyodlar");
            });

            modelBuilder.Entity<TblLogo>(entity =>
            {
                entity.ToTable("Tbl_Logo");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblMailAliciTerminal>(entity =>
            {
                entity.ToTable("Tbl_MailAliciTerminal");
            });

            modelBuilder.Entity<TblMailAlicilar>(entity =>
            {
                entity.ToTable("Tbl_MailAlicilar");

                entity.Property(e => e.Aktif).HasDefaultValueSql("((1))");

                entity.Property(e => e.MailAdresi).HasMaxLength(250);
            });

            modelBuilder.Entity<TblMailAylik>(entity =>
            {
                entity.ToTable("Tbl_MailAylik");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AylikSonMailAtmaTarih).HasColumnType("datetime");

                entity.Property(e => e.SonrakiAyTarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblMailHaftalik>(entity =>
            {
                entity.ToTable("Tbl_MailHaftalik");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.SonMailAtmaTarih).HasColumnType("datetime");

                entity.Property(e => e.SonrakiHaftaTarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblMailSistem>(entity =>
            {
                entity.ToTable("Tbl_MailSistem");

                entity.Property(e => e.Attachment).HasColumnName("attachment");

                entity.Property(e => e.Carsamba).HasColumnName("carsamba");

                entity.Property(e => e.Cuma).HasColumnName("cuma");

                entity.Property(e => e.Cumartesi).HasColumnName("cumartesi");

                entity.Property(e => e.GonderimAraBeklemeSuresiSn).HasColumnName("gonderimAraBeklemeSuresiSn");

                entity.Property(e => e.MainMail).HasMaxLength(250);

                entity.Property(e => e.MainPass).HasMaxLength(250);

                entity.Property(e => e.Pazar).HasColumnName("pazar");

                entity.Property(e => e.Pazartesi).HasColumnName("pazartesi");

                entity.Property(e => e.Persembe).HasColumnName("persembe");

                entity.Property(e => e.Port)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Saat1)
                    .HasColumnType("datetime")
                    .HasColumnName("saat1");

                entity.Property(e => e.Saat1Aktif).HasColumnName("saat1Aktif");

                entity.Property(e => e.Saat2)
                    .HasColumnType("datetime")
                    .HasColumnName("saat2");

                entity.Property(e => e.Saat2Aktif).HasColumnName("saat2Aktif");

                entity.Property(e => e.Saat3)
                    .HasColumnType("datetime")
                    .HasColumnName("saat3");

                entity.Property(e => e.Saat3Aktif).HasColumnName("saat3Aktif");

                entity.Property(e => e.Sali).HasColumnName("sali");

                entity.Property(e => e.Smtp).HasMaxLength(500);
            });

            modelBuilder.Entity<TblMailYetkiliRaporlar>(entity =>
            {
                entity.ToTable("Tbl_MailYetkiliRaporlar");

                entity.HasOne(d => d.MailRapor)
                    .WithMany(p => p.TblMailYetkiliRaporlars)
                    .HasForeignKey(d => d.MailRaporId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_MailYetkiliRaporlar_Tbl_sys_MailRaporlar");
            });

            modelBuilder.Entity<TblMesaiSapma>(entity =>
            {
                entity.ToTable("Tbl_MesaiSapma");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<TblMesaiTanimsizOdaKalinanSure>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_MesaiTanimsizOdaKalinanSure");

                entity.HasIndex(e => e.Id, "IX_Tbl_MesaiTanimsizOdaKalinanSure")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Sure).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tarih).HasColumnType("date");

                entity.Property(e => e.ToplamSure).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TblMolaHesapTablosu>(entity =>
            {
                entity.ToTable("Tbl_MolaHesapTablosu");

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.OglenBaslangic).HasColumnType("datetime");

                entity.Property(e => e.OglenBitis).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblOdaIcerisindekiSiciller>(entity =>
            {
                entity.ToTable("Tbl_OdaIcerisindekiSiciller");
            });

            modelBuilder.Entity<TblOdaKalinanSure>(entity =>
            {
                entity.ToTable("Tbl_OdaKalinanSure");

                entity.Property(e => e.Sure).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TblOdaKalinanSureToplam>(entity =>
            {
                entity.ToTable("Tbl_OdaKalinanSureToplam");

                entity.Property(e => e.HesaplamaTarih).HasColumnType("datetime");

                entity.Property(e => e.ToplamSure).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TblOdaTanim>(entity =>
            {
                entity.ToTable("Tbl_OdaTanim");

                entity.Property(e => e.OdaAdi).HasMaxLength(150);
            });

            modelBuilder.Entity<TblOdaTerminalTanim>(entity =>
            {
                entity.ToTable("Tbl_OdaTerminalTanim");
            });

            modelBuilder.Entity<TblOgunSayilari>(entity =>
            {
                entity.ToTable("Tbl_OgunSayilari");

                entity.Property(e => e.Tarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblOnaylananFazlaMesai>(entity =>
            {
                entity.ToTable("Tbl_OnaylananFazlaMesai");
            });

            modelBuilder.Entity<TblOzlukGorevDetay>(entity =>
            {
                entity.ToTable("Tbl_OzlukGorevDetay");

                entity.Property(e => e.CalismaIzniBaslangicTarihi).HasColumnType("datetime");

                entity.Property(e => e.CalismaIzniBitisTarihi).HasColumnType("datetime");

                entity.Property(e => e.CalismaIzniNo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EkOdemeParaBirimi)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GayriResmiUcretParaBirimi)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GorevYeri).HasMaxLength(255);

                entity.Property(e => e.HarcirahHesaplansin).HasMaxLength(50);

                entity.Property(e => e.HarcirahParaBirimi)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HarcirahTipi)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IkinciUcretParaBirimi)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IsciStatu)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.KaldigiYer).HasMaxLength(255);

                entity.Property(e => e.MaaliyetMerkezi)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MasrafMerkezAltKod)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MasrafMerkezUstKod)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OturumIzniBaslangicTarihi).HasColumnType("datetime");

                entity.Property(e => e.OturumIzniBitisTarihi).HasColumnType("datetime");

                entity.Property(e => e.OturumIzniNo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PasaportBaslangicTarihi).HasColumnType("datetime");

                entity.Property(e => e.PasaportBitisTarihi).HasColumnType("datetime");

                entity.Property(e => e.PasaportNo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ResmiUcretParaBirimi)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SaglikRaporBaslangicTarihi).HasColumnType("datetime");

                entity.Property(e => e.SaglikRaporBitisTarihi).HasColumnType("datetime");

                entity.Property(e => e.SirketTelefonHatti)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UcretOdeme)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UcretTipi)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VizeYeri)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOzlukGorevIkamet>(entity =>
            {
                entity.ToTable("Tbl_OzlukGorevIkamet");

                entity.Property(e => e.Ad)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Adres)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AidatTutari)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ElektrikAboneNo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Il)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ilce)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.KiraBaslangicTarihi).HasColumnType("datetime");

                entity.Property(e => e.KiraTutari)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SuAboneNo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonAboneNo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tip)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOzlukGorevlendirme>(entity =>
            {
                entity.ToTable("Tbl_OzlukGorevlendirme");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BaslangicTarih).HasColumnType("datetime");

                entity.Property(e => e.BitisTarih).HasColumnType("datetime");

                entity.Property(e => e.Dosya)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.KonaklamaTipi)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOzlukKadro>(entity =>
            {
                entity.ToTable("Tbl_OzlukKadro");

                entity.Property(e => e.Baslangic).HasColumnType("datetime");

                entity.Property(e => e.Bitis).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblOzlukMezuniyet>(entity =>
            {
                entity.ToTable("Tbl_OzlukMezuniyet");

                entity.Property(e => e.DiplomaNotu).HasMaxLength(100);

                entity.Property(e => e.MezuniyetTarih).HasMaxLength(200);
            });

            modelBuilder.Entity<TblOzlukSendika>(entity =>
            {
                entity.ToTable("Tbl_OzlukSendika");

                entity.Property(e => e.BaslangicTarih).HasColumnType("datetime");

                entity.Property(e => e.BitisTarih).HasColumnType("datetime");

                entity.Property(e => e.CikisNeden).HasMaxLength(1000);
            });

            modelBuilder.Entity<TblOzlukVekalet>(entity =>
            {
                entity.ToTable("Tbl_OzlukVekalet");

                entity.Property(e => e.Aciklama).HasMaxLength(500);

                entity.Property(e => e.Baslangic).HasColumnType("datetime");

                entity.Property(e => e.Bitis).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblPanelAsansor>(entity =>
            {
                entity.ToTable("Tbl_PanelAsansor");
            });

            modelBuilder.Entity<TblPanelKapiDurum>(entity =>
            {
                entity.ToTable("Tbl_PanelKapiDurum");
            });

            modelBuilder.Entity<TblPanelTimeZone>(entity =>
            {
                entity.ToTable("Tbl_PanelTimeZone");

                entity.Property(e => e.GonderimZamani).HasColumnType("datetime");

                entity.Property(e => e.TimeZoneName).HasMaxLength(250);
            });

            modelBuilder.Entity<TblPanelTimeZoneDetaylari>(entity =>
            {
                entity.ToTable("Tbl_PanelTimeZoneDetaylari");
            });

            modelBuilder.Entity<TblPanelTimezoneDuty>(entity =>
            {
                entity.ToTable("Tbl_PanelTimezoneDuty");

                entity.Property(e => e.GonderimeZamani).HasColumnType("datetime");

                entity.Property(e => e.OlusturmaZamani).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblPanelUsersTimeZone>(entity =>
            {
                entity.ToTable("Tbl_PanelUsersTimeZone");

                entity.Property(e => e.UserId).HasMaxLength(8);
            });

            modelBuilder.Entity<TblPaneller>(entity =>
            {
                entity.ToTable("Tbl_Paneller");

                entity.Property(e => e.Aktif)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PanelIp).HasMaxLength(50);

                entity.Property(e => e.PanelName).HasMaxLength(250);
            });

            modelBuilder.Entity<TblParameter>(entity =>
            {
                entity.ToTable("Tbl_Parameter");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BelirliGunYasakla).HasDefaultValueSql("((60))");

                entity.Property(e => e.IzinTalepTip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kvkk).HasColumnName("KVKK");

                entity.Property(e => e.Kvkkformat).HasColumnName("KVKKFormat");

                entity.Property(e => e.TcNoZorunlu)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.YenilemeZamani)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ZiyaretNedeniSorma)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ZiyaretciKartBasim)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TblPermissionRequestForm>(entity =>
            {
                entity.ToTable("Tbl_PermissionRequestForm");

                entity.Property(e => e.Efolderid)
                    .HasMaxLength(150)
                    .HasColumnName("EFOLDERID");

                entity.Property(e => e.EndDate).HasMaxLength(50);

                entity.Property(e => e.ExcuseLeaveEndDate).HasMaxLength(50);

                entity.Property(e => e.ExcuseLeaveStartDate).HasMaxLength(50);

                entity.Property(e => e.FormNumber).HasMaxLength(150);

                entity.Property(e => e.PermissionSubTypeDefinition).HasMaxLength(500);

                entity.Property(e => e.PermissionSubTypeDetailCode).HasMaxLength(50);

                entity.Property(e => e.PermissionSubTypeDetailDefinition).HasMaxLength(50);

                entity.Property(e => e.PermissionSubTypeDetailExplanation).HasMaxLength(50);

                entity.Property(e => e.PermissionSubTypeDetailExplanationCode).HasMaxLength(50);

                entity.Property(e => e.PermissionTypeCode).HasMaxLength(150);

                entity.Property(e => e.PermissionTypeDefinition).HasMaxLength(50);

                entity.Property(e => e.PersonelNameSurname).HasMaxLength(150);

                entity.Property(e => e.PersonnelAdaccount)
                    .HasMaxLength(150)
                    .HasColumnName("PersonnelADAccount");

                entity.Property(e => e.RequestDateParam).HasColumnType("date");

                entity.Property(e => e.RequestDatetime).HasColumnType("datetime");

                entity.Property(e => e.ReturnToWorkDate).HasMaxLength(50);

                entity.Property(e => e.SappersonnelNumber)
                    .HasMaxLength(150)
                    .HasColumnName("SAPPersonnelNumber");

                entity.Property(e => e.StartDate).HasMaxLength(50);

                entity.Property(e => e.StatusCode).HasMaxLength(50);

                entity.Property(e => e.StatusDefinition).HasMaxLength(50);
            });

            modelBuilder.Entity<TblPoolHataliGecisler>(entity =>
            {
                entity.ToTable("Tbl_PoolHataliGecisler");

                entity.Property(e => e.HataInsertDate).HasColumnType("datetime");

                entity.Property(e => e.IslemPoolId).HasColumnName("IslemPoolID");

                entity.Property(e => e.IslemYapildi).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoolId1).HasColumnName("PoolID1");

                entity.Property(e => e.PoolId2).HasColumnName("PoolID2");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");
            });

            modelBuilder.Entity<TblPuantajTablosu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_PuantajTablosu");

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Tarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblRandevu>(entity =>
            {
                entity.ToTable("Tbl_Randevu");

                entity.Property(e => e.RandevuZamani).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblReCheckEventsDuty>(entity =>
            {
                entity.ToTable("Tbl_ReCheckEventsDuty");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.RecordDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblRonesansElazigBirimEnt>(entity =>
            {
                entity.ToTable("Tbl_RonesansElazigBirimEnt");

                entity.Property(e => e.Birim).HasMaxLength(500);

                entity.Property(e => e.Kurum).HasMaxLength(500);

                entity.Property(e => e.MeyerBirim).HasMaxLength(500);
            });

            modelBuilder.Entity<TblRonesansPozisyonAktarimi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_RonesansPozisyonAktarimi");

                entity.Property(e => e.BolumAdi).HasMaxLength(250);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(250);

                entity.Property(e => e.Statu).HasMaxLength(250);
            });

            modelBuilder.Entity<TblRonesansSirketGorevYeriAktarim>(entity =>
            {
                entity.ToTable("Tbl_RonesansSirket_GorevYeriAktarim");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.GorevYeri).HasMaxLength(250);

                entity.Property(e => e.SirketAdi).HasMaxLength(250);
            });

            modelBuilder.Entity<TblRoom>(entity =>
            {
                entity.ToTable("Tbl_Room");

                entity.Property(e => e.Adi).HasMaxLength(150);

                entity.Property(e => e.GunlukUcret).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TblRoomContainer>(entity =>
            {
                entity.ToTable("Tbl_RoomContainer");

                entity.Property(e => e.Adi).HasMaxLength(150);
            });

            modelBuilder.Entity<TblRoomContainerLog>(entity =>
            {
                entity.ToTable("Tbl_RoomContainer_Log");

                entity.Property(e => e.Adi).HasMaxLength(150);

                entity.Property(e => e.IslemTarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblRoomLog>(entity =>
            {
                entity.ToTable("Tbl_Room_Log");

                entity.Property(e => e.Adi).HasMaxLength(150);

                entity.Property(e => e.GunlukUcret).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IslemTarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblRoomSicil>(entity =>
            {
                entity.ToTable("Tbl_RoomSicil");

                entity.Property(e => e.BaslangicTarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblRoomSicilHareket>(entity =>
            {
                entity.ToTable("Tbl_RoomSicilHareket");

                entity.Property(e => e.GunlukUcret).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TblRoomSicilHareketLog>(entity =>
            {
                entity.ToTable("Tbl_RoomSicilHareket_Log");

                entity.Property(e => e.GunlukUcret).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IslemTarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblRoomSicilLog>(entity =>
            {
                entity.ToTable("Tbl_RoomSicil_Log");

                entity.Property(e => e.BaslangicTarih).HasColumnType("datetime");

                entity.Property(e => e.IslemTarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblSaatlikIzinAsimSure>(entity =>
            {
                entity.ToTable("Tbl_SaatlikIzinAsimSure");

                entity.Property(e => e.SonGuncelleme).HasColumnType("datetime");

                entity.HasOne(d => d.SaatlikIzinBakiye)
                    .WithMany(p => p.TblSaatlikIzinAsimSures)
                    .HasForeignKey(d => d.SaatlikIzinBakiyeId)
                    .HasConstraintName("FK_Tbl_SaatlikIzinAsimSure_Tbl_SaatlikIzinBakiye");
            });

            modelBuilder.Entity<TblSaatlikIzinBakiye>(entity =>
            {
                entity.ToTable("Tbl_SaatlikIzinBakiye");

                entity.Property(e => e.SonGuncelleme).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblServisGuzergah>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_ServisGuzergah");

                entity.Property(e => e.Adi).HasMaxLength(200);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TblSicilAdre>(entity =>
            {
                entity.ToTable("Tbl_SicilAdres");

                entity.Property(e => e.CepTelefon).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .HasColumnName("EMail");

                entity.Property(e => e.EvMulkiyet).HasMaxLength(50);

                entity.Property(e => e.EvTelefon).HasMaxLength(50);

                entity.Property(e => e.Il).HasMaxLength(50);

                entity.Property(e => e.Ilce).HasMaxLength(50);

                entity.Property(e => e.IsTelefon).HasMaxLength(50);

                entity.Property(e => e.Semt).HasMaxLength(50);
            });

            modelBuilder.Entity<TblSicilArac>(entity =>
            {
                entity.ToTable("Tbl_SicilArac");

                entity.Property(e => e.Aciklama).HasMaxLength(500);

                entity.Property(e => e.AracPlaka).HasMaxLength(15);

                entity.Property(e => e.CepTelefonu).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Marka).HasMaxLength(250);

                entity.Property(e => e.Model).HasMaxLength(300);

                entity.Property(e => e.RuhsatNo).HasMaxLength(50);
            });

            modelBuilder.Entity<TblSicilAracLog>(entity =>
            {
                entity.ToTable("Tbl_SicilArac_Log");

                entity.Property(e => e.Aciklama).HasMaxLength(500);

                entity.Property(e => e.AracPlaka).HasMaxLength(15);

                entity.Property(e => e.CepTelefonu).HasMaxLength(50);

                entity.Property(e => e.IslemDatetime).HasColumnType("datetime");

                entity.Property(e => e.Marka).HasMaxLength(250);

                entity.Property(e => e.Model).HasMaxLength(300);

                entity.Property(e => e.RuhsatNo).HasMaxLength(50);
            });

            modelBuilder.Entity<TblSicilBakiyeHareket>(entity =>
            {
                entity.ToTable("Tbl_SicilBakiyeHareket");

                entity.Property(e => e.EklenenIcecekBakiye).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EklenenYiyecekBakiye).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblSicilBirim>(entity =>
            {
                entity.ToTable("Tbl_SicilBirim");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BirimAdi).HasMaxLength(500);
            });

            modelBuilder.Entity<TblSicilBirimLog>(entity =>
            {
                entity.ToTable("Tbl_SicilBirim_Log");

                entity.HasIndex(e => e.Id, "IX_Tbl_SicilBirim_Log")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.IslemDatetime).HasColumnType("datetime");

                entity.HasOne(d => d.Sicil)
                    .WithMany(p => p.TblSicilBirimLogs)
                    .HasForeignKey(d => d.SicilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_SicilBirim_Log_Sicil");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblSicilBirimLogs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_SicilBirim_Log_UserTables");
            });

            modelBuilder.Entity<TblSicilBolge>(entity =>
            {
                entity.ToTable("Tbl_SicilBolge");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BolgeAdi).HasMaxLength(200);
            });

            modelBuilder.Entity<TblSicilCocuk>(entity =>
            {
                entity.ToTable("Tbl_SicilCocuk");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.DogumTarihi).HasColumnType("date");

                entity.Property(e => e.EgitimDurumu).HasMaxLength(50);

                entity.Property(e => e.MedeniDurum).HasMaxLength(50);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<TblSicilDetay>(entity =>
            {
                entity.ToTable("Tbl_SicilDetay");

                entity.Property(e => e.AcilDurum).HasMaxLength(150);

                entity.Property(e => e.AcilDurumTel).HasMaxLength(50);

                entity.Property(e => e.Cinsiyet).HasMaxLength(10);

                entity.Property(e => e.DogumYeri).HasMaxLength(50);

                entity.Property(e => e.Egitim).HasMaxLength(200);

                entity.Property(e => e.Gorev).HasMaxLength(50);

                entity.Property(e => e.GorevTuru).HasMaxLength(50);

                entity.Property(e => e.IsCikisNedeniSgk).HasColumnName("IsCikisNedeniSGK");

                entity.Property(e => e.KanGrubu).HasMaxLength(50);

                entity.Property(e => e.Sgkid).HasColumnName("SGKId");
            });

            modelBuilder.Entity<TblSicilDosyalar>(entity =>
            {
                entity.ToTable("Tbl_SicilDosyalar");

                entity.Property(e => e.DosyaTipi).HasMaxLength(50);
            });

            modelBuilder.Entity<TblSicilE>(entity =>
            {
                entity.ToTable("Tbl_SicilEs");

                entity.Property(e => e.Adi).HasMaxLength(50);

                entity.Property(e => e.CalistigiKurum).HasMaxLength(200);

                entity.Property(e => e.CepTelefonu).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .HasColumnName("EMail");

                entity.Property(e => e.IsTelefonu).HasMaxLength(50);

                entity.Property(e => e.KimlikNo).HasMaxLength(50);

                entity.Property(e => e.KimlikSeri).HasMaxLength(50);

                entity.Property(e => e.Soyadi).HasMaxLength(50);

                entity.Property(e => e.TckimlikNo)
                    .HasMaxLength(50)
                    .HasColumnName("TCKimlikNo");
            });

            modelBuilder.Entity<TblSicilEgitimKur>(entity =>
            {
                entity.ToTable("Tbl_SicilEgitimKurs");

                entity.Property(e => e.BaslangicTarih).HasColumnType("date");

                entity.Property(e => e.BitisTarih).HasColumnType("date");

                entity.Property(e => e.EgitimKurs).HasMaxLength(500);

                entity.Property(e => e.EgitimKursYeri).HasMaxLength(50);

                entity.Property(e => e.Notu).HasMaxLength(50);
            });

            modelBuilder.Entity<TblSicilGorev>(entity =>
            {
                entity.ToTable("Tbl_SicilGorev");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GorevAdi).HasMaxLength(200);
            });

            modelBuilder.Entity<TblSicilGunlukMesaiOzeti>(entity =>
            {
                entity.ToTable("Tbl_SicilGunlukMesaiOzeti");

                entity.HasIndex(e => e.Id, "IX_Tbl_SicilGunlukMesaiOzeti")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.GeceDinlenmeCalismaSure).HasColumnName("geceDinlenmeCalismaSure");

                entity.Property(e => e.GeceDinlenmeToplamSure).HasColumnName("geceDinlenmeToplamSure");

                entity.Property(e => e.GeceFazlaMesai).HasColumnName("geceFazlaMesai");

                entity.Property(e => e.GeceMesaiIciCalisma).HasColumnName("geceMesaiIciCalisma");

                entity.Property(e => e.GeceMesaiSure).HasColumnName("geceMesaiSure");

                entity.Property(e => e.GorevlendirmeKod).HasMaxLength(4);

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.MesaiBasSonrasiIlkGiris).HasColumnType("datetime");

                entity.Property(e => e.MesaiBitOncesiSonCikis).HasColumnType("datetime");

                entity.Property(e => e.OglenDurum).HasMaxLength(150);

                entity.Property(e => e.Ozet).HasMaxLength(150);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblSicilHesCodeLog>(entity =>
            {
                entity.ToTable("Tbl_SicilHesCode_log");

                entity.Property(e => e.HesCode).HasMaxLength(50);

                entity.Property(e => e.Tarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblSicilIlceler>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_SicilIlceler");

                entity.Property(e => e.IlNo).HasColumnName("il_no");

                entity.Property(e => e.IlceNo).HasColumnName("ilce_no");

                entity.Property(e => e.Isim)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("isim");

                entity.HasOne(d => d.IlNoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IlNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_il_no");
            });

            modelBuilder.Entity<TblSicilIller>(entity =>
            {
                entity.HasKey(e => e.IlNo)
                    .HasName("PK__Tbl_Sici__ACA8AD70052412EF");

                entity.ToTable("Tbl_SicilIller");

                entity.Property(e => e.IlNo)
                    .ValueGeneratedNever()
                    .HasColumnName("il_no");

                entity.Property(e => e.Isim)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("isim");
            });

            modelBuilder.Entity<TblSicilIsBilgileri>(entity =>
            {
                entity.ToTable("Tbl_SicilIsBilgileri");

                entity.Property(e => e.AylikBrutUcret).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AylikNetUcret).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AyrilmaNedeni).HasMaxLength(500);

                entity.Property(e => e.AyrilmaTarih).HasColumnType("date");

                entity.Property(e => e.IsBaslangicTarihi).HasColumnType("date");

                entity.Property(e => e.IsBasvuruDurumu).HasMaxLength(50);

                entity.Property(e => e.IseBasvuruTarih).HasColumnType("date");

                entity.Property(e => e.KullanmadigiYillikIzinTutari).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NetIhbarTazminat).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NetKidemTazminat).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SozlesmeTur).HasMaxLength(50);

                entity.Property(e => e.Sskno)
                    .HasMaxLength(50)
                    .HasColumnName("SSKNo");

                entity.Property(e => e.UcretTip).HasMaxLength(50);
            });

            modelBuilder.Entity<TblSicilIzinDetail>(entity =>
            {
                entity.ToTable("Tbl_SicilIzinDetails");
            });

            modelBuilder.Entity<TblSicilIzinKural>(entity =>
            {
                entity.ToTable("Tbl_SicilIzinKural");

                entity.HasIndex(e => e.Id, "IX_Tbl_SicilIzinKural")
                    .IsUnique();

                entity.HasOne(d => d.Izinkural)
                    .WithMany(p => p.TblSicilIzinKurals)
                    .HasForeignKey(d => d.IzinkuralId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_SicilIzinKural_Tbl_IzinTanimKurali");

                entity.HasOne(d => d.Sicil)
                    .WithMany(p => p.TblSicilIzinKurals)
                    .HasForeignKey(d => d.SicilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_SicilIzinKural_Sicil");
            });

            modelBuilder.Entity<TblSicilIzinMaster>(entity =>
            {
                entity.ToTable("Tbl_SicilIzinMaster");

                entity.Property(e => e.MesaiTarihi).HasColumnType("datetime");

                entity.HasOne(d => d.IzinDetail)
                    .WithMany(p => p.TblSicilIzinMasters)
                    .HasForeignKey(d => d.IzinDetailId)
                    .HasConstraintName("FK_Tbl_SicilIzinMaster_Tbl_SicilIzinDetails");

                entity.HasOne(d => d.Sicil)
                    .WithMany(p => p.TblSicilIzinMasters)
                    .HasForeignKey(d => d.SicilId)
                    .HasConstraintName("FK_Tbl_SicilIzinMaster_Sicil");
            });

            modelBuilder.Entity<TblSicilKalanHak>(entity =>
            {
                entity.ToTable("Tbl_SicilKalanHak");

                entity.Property(e => e.IcecekBakiye)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.YiyecekBakiye)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Sicil)
                    .WithMany(p => p.TblSicilKalanHaks)
                    .HasForeignKey(d => d.SicilId)
                    .HasConstraintName("FK_Tbl_SicilKalanHak_Sicil");
            });

            modelBuilder.Entity<TblSicilKalanHakGecmi>(entity =>
            {
                entity.ToTable("Tbl_SicilKalanHak_Gecmis");

                entity.Property(e => e.EskiIcecekBakiye).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EskiYiyecekBakiye).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SifirlamaTarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblSicilKalanKullanilanIzin>(entity =>
            {
                entity.ToTable("Tbl_SicilKalanKullanilanIzin");

                entity.HasIndex(e => e.Id, "IX_Tbl_SicilKalanKullanilanIzin")
                    .IsUnique();

                entity.Property(e => e.AktarilanDevirGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BakiyeFarkiGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ToplamHakEdilenIzinGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ToplamKalanIzinGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ToplamKullanilanIzinGun).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IzinKural)
                    .WithMany(p => p.TblSicilKalanKullanilanIzins)
                    .HasForeignKey(d => d.IzinKuralId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_SicilKalanKullanilanIzin_Tbl_IzinTanimKurali");

                entity.HasOne(d => d.Sicil)
                    .WithMany(p => p.TblSicilKalanKullanilanIzins)
                    .HasForeignKey(d => d.SicilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_SicilKalanKullanilanIzin_Sicil");
            });

            modelBuilder.Entity<TblSicilKimlik>(entity =>
            {
                entity.ToTable("Tbl_SicilKimlik");

                entity.Property(e => e.Ad)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AileSiraNo).HasMaxLength(50);

                entity.Property(e => e.AnneAdi).HasMaxLength(50);

                entity.Property(e => e.AnneYasamDurumu).HasMaxLength(50);

                entity.Property(e => e.AskerlikDurumu).HasMaxLength(50);

                entity.Property(e => e.BabaAdi).HasMaxLength(50);

                entity.Property(e => e.BabaYasamDurumu).HasMaxLength(50);

                entity.Property(e => e.CalismaDurumu).HasMaxLength(50);

                entity.Property(e => e.Cinsiyet).HasMaxLength(50);

                entity.Property(e => e.CuzdaninKayitNo).HasMaxLength(50);

                entity.Property(e => e.CuzdaninVerildigiYer).HasMaxLength(50);

                entity.Property(e => e.CuzdaninVerilisNedeni).HasMaxLength(50);

                entity.Property(e => e.CuzdaninVerilisTarihi).HasColumnType("date");

                entity.Property(e => e.Din).HasMaxLength(50);

                entity.Property(e => e.DogumTarihi).HasColumnType("date");

                entity.Property(e => e.DogumYeri).HasMaxLength(50);

                entity.Property(e => e.EgitimDurumu).HasMaxLength(50);

                entity.Property(e => e.Ehliyet).HasMaxLength(50);

                entity.Property(e => e.EhliyetTarih).HasMaxLength(2000);

                entity.Property(e => e.KanGrubu).HasMaxLength(50);

                entity.Property(e => e.KayitliOlduguCiltNo).HasMaxLength(50);

                entity.Property(e => e.KayitliOlduguIl).HasMaxLength(50);

                entity.Property(e => e.KayitliOlduguIlce).HasMaxLength(50);

                entity.Property(e => e.KayitliOlduguMahalle).HasMaxLength(50);

                entity.Property(e => e.KimlikNo).HasMaxLength(50);

                entity.Property(e => e.KimlikSeri).HasMaxLength(50);

                entity.Property(e => e.MedeniHal).HasMaxLength(50);

                entity.Property(e => e.OncekiSoyad).HasMaxLength(50);

                entity.Property(e => e.PantolonBeden).HasMaxLength(50);

                entity.Property(e => e.ServisDurak).HasMaxLength(50);

                entity.Property(e => e.SgkSicilNo).HasColumnType("datetime");

                entity.Property(e => e.SiraNo).HasMaxLength(50);

                entity.Property(e => e.Soyad)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TC");

                entity.Property(e => e.TecilTarih).HasColumnType("datetime");

                entity.Property(e => e.TisortBeden).HasMaxLength(50);

                entity.Property(e => e.YabanciDil1).HasMaxLength(50);

                entity.Property(e => e.YabanciDil1Durum).HasMaxLength(50);

                entity.Property(e => e.YabanciDil2).HasMaxLength(50);

                entity.Property(e => e.YabanciDil2Durum).HasMaxLength(50);

                entity.Property(e => e.YabanciDil3).HasMaxLength(50);

                entity.Property(e => e.YabanciDil3Durum).HasMaxLength(50);
            });

            modelBuilder.Entity<TblSicilKurum>(entity =>
            {
                entity.ToTable("Tbl_SicilKurum");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.KurumAd).HasMaxLength(500);
            });

            modelBuilder.Entity<TblSicilLoginInfo>(entity =>
            {
                entity.ToTable("Tbl_SicilLoginInfo");

                entity.Property(e => e.Aktiflik)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsCikisNedeniSgk).HasColumnName("IsCikisNedeniSGK");

                entity.Property(e => e.KisitlaMesaiIzinAktarim)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.SgkbilgiTanim).HasColumnName("SGKBilgiTanim");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.UserLoginId).HasColumnName("UserLoginID");

                entity.Property(e => e.UserPassword).HasMaxLength(100);
            });

            modelBuilder.Entity<TblSicilLoginInfoLog>(entity =>
            {
                entity.ToTable("Tbl_SicilLoginInfo_Log");

                entity.Property(e => e.IsCikisNedeniSgk).HasColumnName("IsCikisNedeniSGK");

                entity.Property(e => e.IslemDatetime).HasColumnType("datetime");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.SgkbilgiTanim).HasColumnName("SGKBilgiTanim");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.UserLoginId).HasColumnName("UserLoginID");
            });

            modelBuilder.Entity<TblSicilOdulCeza>(entity =>
            {
                entity.ToTable("Tbl_SicilOdulCeza");

                entity.Property(e => e.Miktari).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tarih).HasColumnType("date");

                entity.Property(e => e.Tipi).HasMaxLength(50);

                entity.Property(e => e.Turu).HasMaxLength(50);
            });

            modelBuilder.Entity<TblSicilOzelBilgileri>(entity =>
            {
                entity.ToTable("Tbl_SicilOzelBilgileri");

                entity.Property(e => e.AiledekiEngelliKisi).HasMaxLength(50);

                entity.Property(e => e.EvlilikDurumu).HasMaxLength(50);

                entity.Property(e => e.EvlilikTarihi).HasColumnType("date");

                entity.Property(e => e.KalitsalHastalikTanisi).HasMaxLength(500);

                entity.Property(e => e.OzurHali).HasMaxLength(500);
            });

            modelBuilder.Entity<TblSicilOzluk>(entity =>
            {
                entity.ToTable("Tbl_SicilOzluk");

                entity.Property(e => e.SendikaUyelikBaslangic).HasColumnType("datetime");

                entity.Property(e => e.SendikaUyelikBitis).HasColumnType("datetime");

                entity.Property(e => e.SgkmeslekKoduId).HasColumnName("SGKMeslekKoduId");
            });

            modelBuilder.Entity<TblSicilReferan>(entity =>
            {
                entity.ToTable("Tbl_SicilReferans");

                entity.Property(e => e.ReferansAdi).HasMaxLength(150);

                entity.Property(e => e.ReferansAdres).HasMaxLength(500);

                entity.Property(e => e.ReferansSoyadi).HasMaxLength(150);

                entity.Property(e => e.ReferansTarihi).HasColumnType("date");

                entity.Property(e => e.ReferansTel).HasMaxLength(50);

                entity.Property(e => e.ReferansUnvani).HasMaxLength(150);
            });

            modelBuilder.Entity<TblSicilResimKayit>(entity =>
            {
                entity.ToTable("Tbl_SicilResimKayit");

                entity.Property(e => e.Resim).HasColumnType("image");
            });

            modelBuilder.Entity<TblSicilYemekhane>(entity =>
            {
                entity.ToTable("Tbl_SicilYemekhane");

                entity.Property(e => e.BaslangicTarih).HasColumnType("datetime");

                entity.Property(e => e.BitisTarih).HasColumnType("datetime");

                entity.HasOne(d => d.Sicil)
                    .WithMany(p => p.TblSicilYemekhanes)
                    .HasForeignKey(d => d.SicilId)
                    .HasConstraintName("FK__SicilYeme__Sicil__16252277");

                entity.HasOne(d => d.Terminal)
                    .WithMany(p => p.TblSicilYemekhanes)
                    .HasForeignKey(d => d.TerminalId)
                    .HasConstraintName("FK__Tbl_Sicil__Termi__25676607");

                entity.HasOne(d => d.YemekhaneBilgi)
                    .WithMany(p => p.TblSicilYemekhanes)
                    .HasForeignKey(d => d.YemekhaneBilgiId)
                    .HasConstraintName("FK__SicilYeme__Yemek__171946B0");
            });

            modelBuilder.Entity<TblSicilYolUcret>(entity =>
            {
                entity.ToTable("Tbl_SicilYolUcret");

                entity.Property(e => e.BitisTarih).HasColumnType("datetime");

                entity.Property(e => e.DonusYolUcret).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tarih).HasColumnType("datetime");

                entity.Property(e => e.YolUcret).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TblSilinecekMesaiOzetler>(entity =>
            {
                entity.ToTable("Tbl_SilinecekMesaiOzetler");
            });

            modelBuilder.Entity<TblSilinecekSicilNo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_SilinecekSicilNo");

                entity.Property(e => e.SicilNo).HasMaxLength(50);
            });

            modelBuilder.Entity<TblSonBaglantiDurum>(entity =>
            {
                entity.ToTable("Tbl_SonBaglantiDurum");

                entity.Property(e => e.CihazBagli).HasDefaultValueSql("((0))");

                entity.Property(e => e.SonBaglantiOlayi).HasMaxLength(150);

                entity.Property(e => e.SonBaglantiZamani).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblSonGeci>(entity =>
            {
                entity.ToTable("Tbl_SonGecis");

                entity.Property(e => e.Ad).HasMaxLength(150);

                entity.Property(e => e.Eventtime).HasColumnType("datetime");

                entity.Property(e => e.KapiDurum).HasMaxLength(50);

                entity.Property(e => e.KapiOlayZamani).HasColumnType("datetime");

                entity.Property(e => e.SicilNo).HasMaxLength(150);

                entity.Property(e => e.Soyad).HasMaxLength(150);

                entity.Property(e => e.TerminalAdi).HasMaxLength(250);

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");
            });

            modelBuilder.Entity<TblSonKapiDurum>(entity =>
            {
                entity.ToTable("Tbl_SonKapiDurum");

                entity.Property(e => e.KapiAcik).HasDefaultValueSql("((0))");

                entity.Property(e => e.SonKapiDurumu).HasMaxLength(50);

                entity.Property(e => e.SonKapiIslemi).HasColumnType("datetime");

                entity.Property(e => e.UzunSureAcikKaldi).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblSonOdaHareketi>(entity =>
            {
                entity.ToTable("Tbl_SonOdaHareketi");

                entity.Property(e => e.SonEventTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblSonTerminalSokulmeIslemi>(entity =>
            {
                entity.ToTable("Tbl_SonTerminalSokulmeIslemi");

                entity.Property(e => e.CihazSokulmeDurum).HasMaxLength(150);

                entity.Property(e => e.CihazSonIslemZamani).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblSube>(entity =>
            {
                entity.ToTable("Tbl_Sube");

                entity.Property(e => e.SubeAdi).HasMaxLength(150);
            });

            modelBuilder.Entity<TblSubeKroki>(entity =>
            {
                entity.ToTable("Tbl_SubeKroki");

                entity.Property(e => e.KrokiAdi).HasMaxLength(250);

                entity.Property(e => e.KrokiImage).HasMaxLength(250);
            });

            modelBuilder.Entity<TblSysGateIoEventName>(entity =>
            {
                entity.ToTable("Tbl_sys_GateIoEventNames");

                entity.Property(e => e.EnEventName)
                    .HasMaxLength(150)
                    .HasColumnName("En_EventName");

                entity.Property(e => e.TrEventName)
                    .HasMaxLength(150)
                    .HasColumnName("Tr_EventName");
            });

            modelBuilder.Entity<TblSysIzinHesaplamaTipi>(entity =>
            {
                entity.ToTable("Tbl_sys_IzinHesaplamaTipi");

                entity.Property(e => e.HesaplamaTipAdi).HasMaxLength(20);
            });

            modelBuilder.Entity<TblSysIzinLimitTipi>(entity =>
            {
                entity.ToTable("Tbl_sys_IzinLimitTipi");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.LimitTipi).HasMaxLength(50);
            });

            modelBuilder.Entity<TblSysIzinOnayIslemDurum>(entity =>
            {
                entity.ToTable("Tbl_sys_IzinOnayIslemDurum");

                entity.Property(e => e.IzinIslemDurumAdi).HasMaxLength(50);
            });

            modelBuilder.Entity<TblSysLanguage>(entity =>
            {
                entity.ToTable("Tbl_sys_Languages");

                entity.Property(e => e.LangCode).HasMaxLength(5);

                entity.Property(e => e.LanguageName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblSysLedPanelIdleTime>(entity =>
            {
                entity.ToTable("Tbl_sys_LedPanelIdleTime");
            });

            modelBuilder.Entity<TblSysLoggedTable>(entity =>
            {
                entity.ToTable("Tbl_sys_logged_Tables");

                entity.Property(e => e.ModuleName).HasMaxLength(150);

                entity.Property(e => e.SqltableName)
                    .HasMaxLength(50)
                    .HasColumnName("SQLTableName");

                entity.Property(e => e.TableName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblSysMailRaporlar>(entity =>
            {
                entity.ToTable("Tbl_sys_MailRaporlar");

                entity.Property(e => e.Filtreleme).HasDefaultValueSql("((1))");

                entity.Property(e => e.MailKonuSablonu).HasMaxLength(200);

                entity.Property(e => e.MesaiTarihineGoreFiltreleme).HasDefaultValueSql("((1))");

                entity.Property(e => e.RaporAdi).HasMaxLength(100);

                entity.Property(e => e.RaporDosyaAdi).HasMaxLength(50);

                entity.Property(e => e.RaporKodu).HasMaxLength(50);
            });

            modelBuilder.Entity<TblSysMailYetkiAdlari>(entity =>
            {
                entity.ToTable("Tbl_sys_MailYetkiAdlari");

                entity.Property(e => e.MailYetkiAdi).HasMaxLength(50);
            });

            modelBuilder.Entity<TblSysMesaiHesaplamaTipleri>(entity =>
            {
                entity.ToTable("Tbl_sys_MesaiHesaplamaTipleri");

                entity.Property(e => e.MesaiHesaplamaAciklamalar).HasMaxLength(4000);

                entity.Property(e => e.MesaiHesaplamaAdi).HasMaxLength(500);
            });

            modelBuilder.Entity<TblSysProcess>(entity =>
            {
                entity.ToTable("Tbl_sys_Process");

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProcessNo)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblSysReport>(entity =>
            {
                entity.ToTable("Tbl_sys_Reports");

                entity.Property(e => e.Method).HasMaxLength(150);

                entity.Property(e => e.PartialView).HasMaxLength(150);

                entity.Property(e => e.RaporAdi).HasMaxLength(150);

                entity.Property(e => e.RaporKodu).HasMaxLength(40);

                entity.Property(e => e.RaporModulu).HasMaxLength(50);

                entity.Property(e => e.RptFile).HasMaxLength(150);
            });

            modelBuilder.Entity<TblSysTerminalUrunGrubu>(entity =>
            {
                entity.ToTable("Tbl_sys_TerminalUrunGrubu");

                entity.Property(e => e.UrunGrubu).HasMaxLength(150);
            });

            modelBuilder.Entity<TblSysYetkiKey>(entity =>
            {
                entity.ToTable("Tbl_sys_YetkiKeys");

                entity.Property(e => e.TimeZoneId).HasColumnName("TimeZoneID");

                entity.Property(e => e.YetkiAdi).HasMaxLength(50);
            });

            modelBuilder.Entity<TblTasnifLog>(entity =>
            {
                entity.ToTable("Tbl_TasnifLog");

                entity.Property(e => e.IslemAciklama).HasMaxLength(500);

                entity.Property(e => e.IslemDate).HasColumnType("datetime");

                entity.Property(e => e.TasnifId).HasColumnName("TasnifID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<TblTerminalAlertEvent>(entity =>
            {
                entity.ToTable("Tbl_TerminalAlertEvents");

                entity.HasIndex(e => e.Id, "IX_Tbl_TerminalAlertEvents")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.EventName).HasMaxLength(150);

                entity.Property(e => e.Eventtime).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(8);
            });

            modelBuilder.Entity<TblTerminalGrubu>(entity =>
            {
                entity.ToTable("Tbl_TerminalGrubu");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");
            });

            modelBuilder.Entity<TblTerminalGrup>(entity =>
            {
                entity.ToTable("Tbl_TerminalGrup");

                entity.Property(e => e.GrupAdi).HasMaxLength(50);
            });

            modelBuilder.Entity<TblTerminalUrunGrubu>(entity =>
            {
                entity.ToTable("Tbl_TerminalUrunGrubu");

                entity.HasOne(d => d.Terminal)
                    .WithMany(p => p.TblTerminalUrunGrubus)
                    .HasForeignKey(d => d.TerminalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_TerminalUrunGrubu_Tbl_TerminalUrunGrubu");

                entity.HasOne(d => d.UrunGrup)
                    .WithMany(p => p.TblTerminalUrunGrubus)
                    .HasForeignKey(d => d.UrunGrupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_TerminalUrunGrubu_Tbl_sys_TerminalUrunGrubu");
            });

            modelBuilder.Entity<TblTestPlakaKontrol>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_TestPlakaKontrol");

                entity.Property(e => e.PlakaNo).HasMaxLength(50);
            });

            modelBuilder.Entity<TblTravelRequestResult>(entity =>
            {
                entity.ToTable("Tbl_TravelRequestResult");

                entity.Property(e => e.Efolderid)
                    .HasMaxLength(150)
                    .HasColumnName("EFOLDERID");

                entity.Property(e => e.FormNumber).HasMaxLength(150);

                entity.Property(e => e.PersonellUniqueNumber).HasMaxLength(150);

                entity.Property(e => e.PersonnelAdaccount)
                    .HasMaxLength(200)
                    .HasColumnName("PersonnelADAccount");

                entity.Property(e => e.RequestDateParam).HasColumnType("date");

                entity.Property(e => e.RequestDatetime).HasColumnType("datetime");

                entity.Property(e => e.SappersonelNumber)
                    .HasMaxLength(150)
                    .HasColumnName("SAPPersonelNumber");

                entity.Property(e => e.StatusCode).HasMaxLength(50);

                entity.Property(e => e.StatusDefinition).HasMaxLength(50);

                entity.Property(e => e.TravelEndDate).HasMaxLength(200);

                entity.Property(e => e.TravelStartDate).HasMaxLength(200);

                entity.Property(e => e.TravelTypeCode).HasMaxLength(250);

                entity.Property(e => e.TravelTypeDefinition).HasMaxLength(250);
            });

            modelBuilder.Entity<TblUserAsansorYetki>(entity =>
            {
                entity.ToTable("Tbl_UserAsansorYetki");

                entity.Property(e => e.UserId).HasMaxLength(50);
            });

            modelBuilder.Entity<TblUserSearchParam>(entity =>
            {
                entity.ToTable("Tbl_UserSearchParams");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BasTar).HasColumnType("datetime");

                entity.Property(e => e.BirimId).HasMaxLength(4000);

                entity.Property(e => e.BitTar).HasColumnType("datetime");

                entity.Property(e => e.BolumId).HasMaxLength(4000);

                entity.Property(e => e.FirmaId).HasMaxLength(4000);

                entity.Property(e => e.GorevId).HasMaxLength(4000);

                entity.Property(e => e.GorevTuru).HasMaxLength(4000);

                entity.Property(e => e.IzinTipId).HasMaxLength(4000);

                entity.Property(e => e.KartSicilId).HasMaxLength(4000);

                entity.Property(e => e.ManErkenTolerans).HasDefaultValueSql("((0))");

                entity.Property(e => e.ManGecTolerans).HasDefaultValueSql("((0))");

                entity.Property(e => e.MesaiId).HasMaxLength(4000);

                entity.Property(e => e.Okod1).HasMaxLength(50);

                entity.Property(e => e.Okod2).HasMaxLength(50);

                entity.Property(e => e.Okod3)
                    .HasMaxLength(50)
                    .HasColumnName("OKod3");

                entity.Property(e => e.Okod4).HasMaxLength(50);

                entity.Property(e => e.Okod5).HasMaxLength(50);

                entity.Property(e => e.PozisyonId).HasMaxLength(4000);

                entity.Property(e => e.SicilId)
                    .HasMaxLength(4000)
                    .HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(50);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TaseronFirmaId).HasMaxLength(4000);

                entity.Property(e => e.TcNo).HasMaxLength(50);

                entity.Property(e => e.TekTar).HasColumnType("datetime");

                entity.Property(e => e.TerminalGrupId).HasMaxLength(250);

                entity.Property(e => e.TerminalId).HasMaxLength(350);

                entity.Property(e => e.TerminalLokasyonId).HasMaxLength(250);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.YetkiId).HasMaxLength(4000);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblUserSearchParams)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tbl_UserSearchParams_UserTables");
            });

            modelBuilder.Entity<TblUyruk>(entity =>
            {
                entity.ToTable("Tbl_Uyruk");

                entity.Property(e => e.Ad)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblVardiyasizMesaiOzeti>(entity =>
            {
                entity.ToTable("Tbl_VardiyasizMesaiOzeti");

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");
            });

            modelBuilder.Entity<TblWcgeci>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_WCGecis");

                entity.Property(e => e.AdSoyad).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisId)
                    .HasMaxLength(30)
                    .HasColumnName("CikisID");

                entity.Property(e => e.CikisTerminalAd)
                    .HasMaxLength(70)
                    .HasColumnName("CikisTerminalAD");

                entity.Property(e => e.CikisTerminalId)
                    .HasMaxLength(8)
                    .HasColumnName("CikisTerminalID");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisId)
                    .HasMaxLength(30)
                    .HasColumnName("GirisID");

                entity.Property(e => e.GirisTerminalAd)
                    .HasMaxLength(70)
                    .HasColumnName("GirisTerminalAD");

                entity.Property(e => e.GirisTerminalId)
                    .HasMaxLength(8)
                    .HasColumnName("GirisTerminalID");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.MesaiGunu).HasColumnType("datetime");

                entity.Property(e => e.SicilId)
                    .HasMaxLength(30)
                    .HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);
            });

            modelBuilder.Entity<TblWcgirisCiki>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_WCGirisCikis");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.TerminalAdiCikis).HasMaxLength(50);

                entity.Property(e => e.TerminalAdiGiris).HasMaxLength(50);

                entity.Property(e => e.Wccikis)
                    .HasColumnType("datetime")
                    .HasColumnName("WCCikis");

                entity.Property(e => e.Wcgiris)
                    .HasColumnType("datetime")
                    .HasColumnName("WCGiris");
            });

            modelBuilder.Entity<TblYasakliZiyaretci>(entity =>
            {
                entity.ToTable("Tbl_YasakliZiyaretci");

                entity.Property(e => e.ZiyaretciAd).HasMaxLength(50);

                entity.Property(e => e.ZiyaretciSoyad).HasMaxLength(50);

                entity.Property(e => e.ZiyaretciTcNo).HasMaxLength(50);
            });

            modelBuilder.Entity<TblYemekhaneBilgi>(entity =>
            {
                entity.ToTable("Tbl_YemekhaneBilgi");

                entity.Property(e => e.Ad).HasMaxLength(200);
            });

            modelBuilder.Entity<TblYemekhaneKapaliSaatTanim>(entity =>
            {
                entity.ToTable("Tbl_YemekhaneKapaliSaatTanim");

                entity.Property(e => e.Aciklama).HasMaxLength(150);

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblYemekhaneOgunTanim>(entity =>
            {
                entity.ToTable("Tbl_YemekhaneOgunTanim");

                entity.Property(e => e.OgunAdi).HasMaxLength(150);
            });

            modelBuilder.Entity<TblYillikHakEdilenIzin>(entity =>
            {
                entity.ToTable("Tbl_YillikHakEdilenIzin");

                entity.Property(e => e.HakEdilenTarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblYillikPdk>(entity =>
            {
                entity.ToTable("Tbl_YillikPDKS");

                entity.Property(e => e.Agustos).HasMaxLength(10);

                entity.Property(e => e.Aralik).HasMaxLength(10);

                entity.Property(e => e.Ekim).HasMaxLength(10);

                entity.Property(e => e.Eylul).HasMaxLength(10);

                entity.Property(e => e.Haziran).HasMaxLength(10);

                entity.Property(e => e.Kasim).HasMaxLength(10);

                entity.Property(e => e.Mart).HasMaxLength(10);

                entity.Property(e => e.Mayis).HasMaxLength(10);

                entity.Property(e => e.Nisan).HasMaxLength(10);

                entity.Property(e => e.Ocak).HasMaxLength(10);

                entity.Property(e => e.Subat).HasMaxLength(10);

                entity.Property(e => e.Temmuz).HasMaxLength(10);

                entity.Property(e => e.Toplam).HasMaxLength(10);
            });

            modelBuilder.Entity<TblZiyaretciRandevu>(entity =>
            {
                entity.ToTable("Tbl_ZiyaretciRandevu");

                entity.Property(e => e.KayitTarihi).HasColumnType("datetime");

                entity.Property(e => e.RandevuTarihi).HasColumnType("datetime");

                entity.Property(e => e.RandevuTcKimlik).HasMaxLength(11);

                entity.Property(e => e.ZiyaretciAdi).HasMaxLength(50);

                entity.Property(e => e.ZiyaretciSoyadi).HasMaxLength(50);

                entity.Property(e => e.ZiyaretciTcno)
                    .HasMaxLength(11)
                    .HasColumnName("ZiyaretciTCNo");
            });

            modelBuilder.Entity<TblZiyaretciSearchParam>(entity =>
            {
                entity.ToTable("Tbl_ZiyaretciSearchParams");

                entity.Property(e => e.Aciklamalar).HasMaxLength(450);

                entity.Property(e => e.BasTar).HasColumnType("datetime");

                entity.Property(e => e.Firma).HasMaxLength(150);

                entity.Property(e => e.HesCode).HasMaxLength(50);

                entity.Property(e => e.KartNo).HasMaxLength(15);

                entity.Property(e => e.Lokasyon).HasMaxLength(50);

                entity.Property(e => e.Sicil1).HasMaxLength(120);

                entity.Property(e => e.Sicil2).HasMaxLength(120);

                entity.Property(e => e.SonTar).HasColumnType("datetime");

                entity.Property(e => e.TekTar).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.ZiyaretciAd).HasMaxLength(50);

                entity.Property(e => e.ZiyaretciKartInfo).HasMaxLength(150);

                entity.Property(e => e.ZiyaretciPlaka).HasMaxLength(50);

                entity.Property(e => e.ZiyaretciSoyad).HasMaxLength(50);

                entity.Property(e => e.ZiyaretciTcNo).HasMaxLength(50);
            });

            modelBuilder.Entity<TblZiyaretciTerminalYetkiDurum>(entity =>
            {
                entity.ToTable("Tbl_ZiyaretciTerminalYetkiDurum");

                entity.Property(e => e.IslemTarihi).HasColumnType("datetime");
            });

            modelBuilder.Entity<TerminalAcu121>(entity =>
            {
                entity.HasKey(e => new { e.TerminalId, e.UserId });

                entity.ToTable("TerminalACU121");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .HasColumnName("UserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.Terminal)
                    .WithMany(p => p.TerminalAcu121s)
                    .HasForeignKey(d => d.TerminalId)
                    .HasConstraintName("FK_TerminalACU121_Terminaller");
            });

            modelBuilder.Entity<TerminalFonksiyon>(entity =>
            {
                entity.ToTable("TerminalFonksiyon");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<TerminalGroup>(entity =>
            {
                entity.ToTable("TerminalGroup");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Alarm).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lastaccounted)
                    .HasColumnType("datetime")
                    .HasColumnName("lastaccounted")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TerminalPort>(entity =>
            {
                entity.HasKey(e => e.Port);

                entity.ToTable("TerminalPort");

                entity.Property(e => e.Port)
                    .HasMaxLength(15)
                    .HasColumnName("PORT");

                entity.Property(e => e.Flag).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TerminalRelation>(entity =>
            {
                entity.HasKey(e => new { e.TerminalGrubu, e.Terminal });

                entity.ToTable("TerminalRelation");

                entity.HasIndex(e => e.Id, "IX_TerminalRelation")
                    .IsUnique();

                entity.Property(e => e.TerminalGrubu).HasDefaultValueSql("((1))");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.TerminalNavigation)
                    .WithMany(p => p.TerminalRelations)
                    .HasForeignKey(d => d.Terminal)
                    .HasConstraintName("FK_TerminalRelation_Terminaller");

                entity.HasOne(d => d.TerminalGrubuNavigation)
                    .WithMany(p => p.TerminalRelations)
                    .HasForeignKey(d => d.TerminalGrubu)
                    .HasConstraintName("FK_TerminalRelation_TerminalGroup");
            });

            modelBuilder.Entity<TerminalTimeZone>(entity =>
            {
                entity.HasKey(e => new { e.TerminalId, e.TerminalTimeZoneId });

                entity.ToTable("TerminalTimeZone");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.TerminalTimeZoneId).HasColumnName("TerminalTimeZoneID");

                entity.Property(e => e.BellTimeTypeId)
                    .HasColumnName("BellTimeTypeID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Edakika).HasColumnName("EDakika");

                entity.Property(e => e.Esaat).HasColumnName("ESaat");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Sdakika).HasColumnName("SDakika");

                entity.Property(e => e.Ssaat).HasColumnName("SSaat");

                entity.HasOne(d => d.BellTimeType)
                    .WithMany(p => p.TerminalTimeZones)
                    .HasForeignKey(d => d.BellTimeTypeId)
                    .HasConstraintName("FK_TerminalTimeZone_sys_BellTimeType1");

                entity.HasOne(d => d.TerminalModeNavigation)
                    .WithMany(p => p.TerminalTimeZones)
                    .HasForeignKey(d => d.TerminalMode)
                    .HasConstraintName("FK_TerminalTimeZone_sys_TerminalMode");
            });

            modelBuilder.Entity<TerminalYetkiDurum>(entity =>
            {
                entity.ToTable("TerminalYetkiDurum");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.TerminalAdi).HasMaxLength(50);

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.YetkiAdi).HasMaxLength(50);

                entity.Property(e => e.YetkiDurum).HasMaxLength(50);
            });

            modelBuilder.Entity<Terminaller>(entity =>
            {
                entity.ToTable("Terminaller");

                entity.HasIndex(e => e.Id, "IX_Terminaller")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aciklama).HasMaxLength(200);

                entity.Property(e => e.CardFormat)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'32HH')");

                entity.Property(e => e.ConnectionTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ControllerNo).HasDefaultValueSql("((1))");

                entity.Property(e => e.Debug).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeviceType).HasColumnName("deviceType");

                entity.Property(e => e.Door).HasMaxLength(50);

                entity.Property(e => e.DoorStatusTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.Io)
                    .HasColumnName("IO")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Kind).HasDefaultValueSql("((1))");

                entity.Property(e => e.LastAccounted).HasColumnType("datetime");

                entity.Property(e => e.LastEventTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastId).HasColumnName("LastID");

                entity.Property(e => e.Latitude).HasMaxLength(100);

                entity.Property(e => e.LedPanoIp)
                    .HasMaxLength(15)
                    .HasColumnName("LedPanoIP");

                entity.Property(e => e.Lokasyon).HasMaxLength(50);

                entity.Property(e => e.LongLogPeriod).HasDefaultValueSql("((1))");

                entity.Property(e => e.Longitude).HasMaxLength(100);

                entity.Property(e => e.MobilCihazKimlikNo).HasMaxLength(150);

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.OpMode).HasDefaultValueSql("((12))");

                entity.Property(e => e.OtoparkMesaj).HasMaxLength(100);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PingCheck).HasDefaultValueSql("((0))");

                entity.Property(e => e.Port).HasMaxLength(15);

                entity.Property(e => e.RelayId).HasColumnName("RelayID");

                entity.Property(e => e.RelayTime).HasDefaultValueSql("((3))");

                entity.Property(e => e.ShortLogPeriod).HasDefaultValueSql("((1))");

                entity.Property(e => e.SonGecen).HasMaxLength(50);

                entity.Property(e => e.SonGelenKayitZamani)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((2014)-(1))-(1))");

                entity.Property(e => e.SonTarih).HasColumnType("datetime");

                entity.Property(e => e.SourceDeviceId)
                    .HasMaxLength(20)
                    .HasColumnName("SourceDeviceID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SourceName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'AYZ-KART')");

                entity.Property(e => e.TimeSend).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.X).HasDefaultValueSql("((999999999))");

                entity.Property(e => e.ZamanKontrol).HasColumnType("datetime");

                entity.HasOne(d => d.PortNavigation)
                    .WithMany(p => p.Terminallers)
                    .HasForeignKey(d => d.Port)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Terminaller_TerminalPort");
            });

            modelBuilder.Entity<TerminallerLog>(entity =>
            {
                entity.ToTable("Terminaller_Log");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CardFormat).HasMaxLength(50);

                entity.Property(e => e.ConnectionTime).HasColumnType("datetime");

                entity.Property(e => e.Door).HasMaxLength(50);

                entity.Property(e => e.DoorStatusTime).HasColumnType("datetime");

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.Io).HasColumnName("IO");

                entity.Property(e => e.IslemDatetime).HasColumnType("datetime");

                entity.Property(e => e.LastAccounted).HasColumnType("datetime");

                entity.Property(e => e.LastEventTime).HasColumnType("datetime");

                entity.Property(e => e.LastId).HasColumnName("LastID");

                entity.Property(e => e.Lokasyon).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Port).HasMaxLength(15);

                entity.Property(e => e.SonGecen).HasMaxLength(50);

                entity.Property(e => e.SonGelenKayitZamani).HasColumnType("datetime");

                entity.Property(e => e.SonTarih).HasColumnType("datetime");

                entity.Property(e => e.SourceName).HasMaxLength(50);

                entity.Property(e => e.ZamanKontrol).HasColumnType("datetime");
            });

            modelBuilder.Entity<TimeZone>(entity =>
            {
                entity.ToTable("TimeZone");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Baslama).HasColumnType("datetime");

                entity.Property(e => e.Bitme).HasColumnType("datetime");

                entity.Property(e => e.TimeZoneId).HasColumnName("TimeZoneID");

                entity.Property(e => e.TimeZoneName).HasMaxLength(20);
            });

            modelBuilder.Entity<UnauthorizedCardAccess>(entity =>
            {
                entity.ToTable("UnauthorizedCardAccess");

                entity.Property(e => e.CardNumber).HasMaxLength(100);

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(10);
            });

            modelBuilder.Entity<UrunFiyatGuncelleIslem>(entity =>
            {
                entity.ToTable("UrunFiyatGuncelleIslem");

                entity.Property(e => e.BaslangicTarih).HasColumnType("datetime");

                entity.Property(e => e.Fiyat).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IslemTarih).HasColumnType("datetime");

                entity.Property(e => e.Tarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<UrunKategori>(entity =>
            {
                entity.ToTable("UrunKategori");

                entity.Property(e => e.Ad).HasMaxLength(50);
            });

            modelBuilder.Entity<UrunSicilHakedi>(entity =>
            {
                entity.HasOne(d => d.Sicil)
                    .WithMany(p => p.UrunSicilHakedis)
                    .HasForeignKey(d => d.SicilId)
                    .HasConstraintName("FK_UrunSicilHakedis_Sicil");
            });

            modelBuilder.Entity<UrunSipari>(entity =>
            {
                entity.Property(e => e.Zaman).HasColumnType("datetime");

                entity.HasOne(d => d.Sicil)
                    .WithMany(p => p.UrunSiparis)
                    .HasForeignKey(d => d.SicilId)
                    .HasConstraintName("FK_UrunSiparis_Sicil");
            });

            modelBuilder.Entity<UrunSiparisDetay>(entity =>
            {
                entity.ToTable("UrunSiparisDetay");

                entity.Property(e => e.Fiyat).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OnayTarih).HasColumnType("datetime");

                entity.HasOne(d => d.Sicil)
                    .WithMany(p => p.UrunSiparisDetays)
                    .HasForeignKey(d => d.SicilId)
                    .HasConstraintName("FK_UrunSiparisDetay_Sicil");

                entity.HasOne(d => d.UrunSiparis)
                    .WithMany(p => p.UrunSiparisDetays)
                    .HasForeignKey(d => d.UrunSiparisId)
                    .HasConstraintName("FK_UrunSiparisDetay_UrunSiparis");

                entity.HasOne(d => d.UrunTur)
                    .WithMany(p => p.UrunSiparisDetays)
                    .HasForeignKey(d => d.UrunTurId)
                    .HasConstraintName("FK_UrunSiparisDetay_UrunTur");
            });

            modelBuilder.Entity<UrunTur>(entity =>
            {
                entity.ToTable("UrunTur");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Fiyat).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FmAylikTutarLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FmGunlukTutarLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IslemTarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<UrunTurLog>(entity =>
            {
                entity.ToTable("UrunTurLog");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Fiyat).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FmAylikTutarLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FmGunlukTutarLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IslemTarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserAuthStatus>(entity =>
            {
                entity.ToTable("UserAuthStatus");

                entity.Property(e => e.UserId).HasMaxLength(50);
            });

            modelBuilder.Entity<UserCardHistory>(entity =>
            {
                entity.ToTable("UserCardHistory");

                entity.Property(e => e.CardIdHex).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<UserFinger>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("UserFinger");

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .HasColumnName("UserID");

                entity.Property(e => e.AnvizFpdata1)
                    .HasColumnType("image")
                    .HasColumnName("AnvizFPData1");

                entity.Property(e => e.AnvizFpdata2)
                    .HasColumnType("image")
                    .HasColumnName("AnvizFPData2");

                entity.Property(e => e.B2faceData1)
                    .HasColumnType("image")
                    .HasColumnName("B2FaceData1");

                entity.Property(e => e.B2faceData2)
                    .HasColumnType("image")
                    .HasColumnName("B2FaceData2");

                entity.Property(e => e.FaceData1).HasColumnType("text");

                entity.Property(e => e.FaceData10).HasColumnType("text");

                entity.Property(e => e.FaceData11).HasColumnType("text");

                entity.Property(e => e.FaceData12).HasColumnType("text");

                entity.Property(e => e.FaceData13).HasColumnType("text");

                entity.Property(e => e.FaceData14).HasColumnType("text");

                entity.Property(e => e.FaceData15).HasColumnType("text");

                entity.Property(e => e.FaceData16).HasColumnType("text");

                entity.Property(e => e.FaceData17).HasColumnType("text");

                entity.Property(e => e.FaceData18).HasColumnType("text");

                entity.Property(e => e.FaceData19).HasColumnType("text");

                entity.Property(e => e.FaceData2).HasColumnType("text");

                entity.Property(e => e.FaceData20).HasColumnType("text");

                entity.Property(e => e.FaceData21).HasColumnType("text");

                entity.Property(e => e.FaceData22).HasColumnType("text");

                entity.Property(e => e.FaceData23).HasColumnType("text");

                entity.Property(e => e.FaceData24).HasColumnType("text");

                entity.Property(e => e.FaceData25).HasColumnType("text");

                entity.Property(e => e.FaceData3).HasColumnType("text");

                entity.Property(e => e.FaceData4).HasColumnType("text");

                entity.Property(e => e.FaceData5).HasColumnType("text");

                entity.Property(e => e.FaceData6).HasColumnType("text");

                entity.Property(e => e.FaceData7).HasColumnType("text");

                entity.Property(e => e.FaceData8).HasColumnType("text");

                entity.Property(e => e.FaceData9).HasColumnType("text");

                entity.Property(e => e.FaceExData1).HasColumnType("image");

                entity.Property(e => e.FaceExData2).HasColumnType("image");

                entity.Property(e => e.Fpdata1)
                    .HasColumnType("text")
                    .HasColumnName("FPData1");

                entity.Property(e => e.Fpdata10)
                    .HasColumnType("text")
                    .HasColumnName("FPData10");

                entity.Property(e => e.Fpdata2)
                    .HasColumnType("text")
                    .HasColumnName("FPData2");

                entity.Property(e => e.Fpdata3)
                    .HasColumnType("text")
                    .HasColumnName("FPData3");

                entity.Property(e => e.Fpdata4)
                    .HasColumnType("text")
                    .HasColumnName("FPData4");

                entity.Property(e => e.Fpdata5)
                    .HasColumnType("text")
                    .HasColumnName("FPData5");

                entity.Property(e => e.Fpdata6)
                    .HasColumnType("text")
                    .HasColumnName("FPData6");

                entity.Property(e => e.Fpdata7)
                    .HasColumnType("text")
                    .HasColumnName("FPData7");

                entity.Property(e => e.Fpdata8)
                    .HasColumnType("text")
                    .HasColumnName("FPData8");

                entity.Property(e => e.Fpdata9)
                    .HasColumnType("text")
                    .HasColumnName("FPData9");

                entity.Property(e => e.FpimgData1)
                    .HasColumnType("image")
                    .HasColumnName("FPImgData1");

                entity.Property(e => e.FpimgData2)
                    .HasColumnType("image")
                    .HasColumnName("FPImgData2");

                entity.Property(e => e.Fpq1)
                    .HasColumnName("FPQ1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Fpq10)
                    .HasColumnName("FPQ10")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Fpq2)
                    .HasColumnName("FPQ2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Fpq3)
                    .HasColumnName("FPQ3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Fpq4)
                    .HasColumnName("FPQ4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Fpq5)
                    .HasColumnName("FPQ5")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Fpq6)
                    .HasColumnName("FPQ6")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Fpq7)
                    .HasColumnName("FPQ7")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Fpq8)
                    .HasColumnName("FPQ8")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Fpq9)
                    .HasColumnName("FPQ9")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserPinNumber).HasMaxLength(8);
            });

            modelBuilder.Entity<UserList>(entity =>
            {
                entity.ToTable("UserList");

                entity.HasIndex(e => e.Id, "IX_UserList")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Aciklama).HasMaxLength(500);

                entity.Property(e => e.BypassCard).HasDefaultValueSql("((1))");

                entity.Property(e => e.CardId)
                    .HasMaxLength(15)
                    .HasColumnName("CardID");

                entity.Property(e => e.CardId26)
                    .HasMaxLength(50)
                    .HasColumnName("CardID26");

                entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Enddate)
                    .HasColumnType("datetime")
                    .HasColumnName("enddate");

                entity.Property(e => e.EskiCardId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EskiCardID");

                entity.Property(e => e.FacilityCode)
                    .HasMaxLength(8)
                    .HasDefaultValueSql("('000100')");

                entity.Property(e => e.FingerId1)
                    .HasMaxLength(4)
                    .HasColumnName("FingerID1");

                entity.Property(e => e.FingerId2)
                    .HasMaxLength(4)
                    .HasColumnName("FingerID2");

                entity.Property(e => e.Fpdata)
                    .HasColumnType("ntext")
                    .HasColumnName("FPData");

                entity.Property(e => e.IsApb)
                    .HasColumnName("isAPB")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Startdate)
                    .HasColumnType("datetime")
                    .HasColumnName("startdate");

                entity.Property(e => e.UserDef).HasDefaultValueSql("((1))");

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .HasColumnName("UserID");

                entity.Property(e => e.Zyrt).HasColumnName("zyrt");
            });

            modelBuilder.Entity<UserListIndex>(entity =>
            {
                entity.HasKey(e => new { e.TerminalId, e.UserId });

                entity.ToTable("UserListIndex");

                entity.HasIndex(e => e.Id, "IX_UserListIndex")
                    .IsUnique();

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .HasColumnName("UserID");

                entity.Property(e => e.AuthLimitCount).HasColumnName("authLimitCount");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.TimeZoneNo1).HasDefaultValueSql("((255))");

                entity.Property(e => e.TimeZoneNo2).HasDefaultValueSql("((255))");

                entity.Property(e => e.TimedAntiPassback).HasColumnName("timedAntiPassback");

                entity.Property(e => e.UserLevel).HasDefaultValueSql("((2))");

                entity.Property(e => e.UserMode)
                    .IsRequired()
                    .HasDefaultValueSql("((-1))");

                entity.HasOne(d => d.Terminal)
                    .WithMany(p => p.UserListIndices)
                    .HasForeignKey(d => d.TerminalId)
                    .HasConstraintName("FK_UserListIndex_Terminaller");
            });

            modelBuilder.Entity<UserListLog>(entity =>
            {
                entity.ToTable("UserList_Log");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aciklama).HasMaxLength(500);

                entity.Property(e => e.CardId)
                    .HasMaxLength(15)
                    .HasColumnName("CardID");

                entity.Property(e => e.CardId26)
                    .HasMaxLength(50)
                    .HasColumnName("CardID26");

                entity.Property(e => e.Enddate)
                    .HasColumnType("datetime")
                    .HasColumnName("enddate");

                entity.Property(e => e.FacilityCode).HasMaxLength(8);

                entity.Property(e => e.FingerId1)
                    .HasMaxLength(4)
                    .HasColumnName("FingerID1");

                entity.Property(e => e.FingerId2)
                    .HasMaxLength(4)
                    .HasColumnName("FingerID2");

                entity.Property(e => e.Fpdata)
                    .HasColumnType("ntext")
                    .HasColumnName("FPData");

                entity.Property(e => e.IslemDatetime).HasColumnType("datetime");

                entity.Property(e => e.Startdate)
                    .HasColumnType("datetime")
                    .HasColumnName("startdate");

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .HasColumnName("UserID");

                entity.Property(e => e.UserListId).HasMaxLength(8);
            });

            modelBuilder.Entity<UserListTmp>(entity =>
            {
                entity.HasKey(e => e.TmpUserId);

                entity.ToTable("UserListTmp");

                entity.HasIndex(e => e.Id, "IX_UserListTmp")
                    .IsUnique();

                entity.Property(e => e.TmpUserId)
                    .HasMaxLength(8)
                    .HasColumnName("TmpUserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.Sicil)
                    .WithMany(p => p.UserListTmps)
                    .HasForeignKey(d => d.SicilId)
                    .HasConstraintName("FK_UserListTmp_Sicil");
            });

            modelBuilder.Entity<UserTable>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__UserTabl__1788CC4C3E7471B1");

                entity.HasIndex(e => e.UserName, "UQ__UserTabl__C9F28456F2797413")
                    .IsUnique();

                entity.Property(e => e.UserName).HasMaxLength(56);

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "WebpagesUsersInRole",
                        l => l.HasOne<WebpagesRole>().WithMany().HasForeignKey("RoleId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_RoleId"),
                        r => r.HasOne<UserTable>().WithMany().HasForeignKey("UserId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_UserId"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId").HasName("PK__webpages__AF2760AD1F4D23F4");

                            j.ToTable("webpages_UsersInRoles");
                        });
            });

            modelBuilder.Entity<UserYetki>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("userYetki");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.YetkiId).HasColumnName("YetkiID");
            });

            modelBuilder.Entity<Userlimit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("userlimit");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Limit).HasColumnName("limit");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("terminalID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userID");
            });

            modelBuilder.Entity<Version>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Version");

                entity.Property(e => e.Meyer).HasMaxLength(9);

                entity.Property(e => e.Pool).HasMaxLength(50);
            });

            modelBuilder.Entity<Vw0200101>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_02_001_01");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.KimlikNo).HasMaxLength(20);

                entity.Property(e => e.LokasyonAdi).HasMaxLength(500);

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.Okod2).HasMaxLength(50);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Zaman).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwAaGecisler>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aaGecisler");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.GecisTarih).HasColumnType("date");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TerminalAdi).HasMaxLength(250);
            });

            modelBuilder.Entity<VwAaIlkGirisSonCiki>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aaIlkGirisSonCikis");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tarih).HasColumnType("date");
            });

            modelBuilder.Entity<VwAllViewsName>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_allViewsNames");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<VwArgeAraGeci>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ArgeAraGecis");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAd).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.CikisTerminal).HasMaxLength(250);

                entity.Property(e => e.FirmaAd).HasMaxLength(500);

                entity.Property(e => e.GirisTerminal).HasMaxLength(250);

                entity.Property(e => e.GorevAd).HasMaxLength(500);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PoolCikis).HasColumnType("datetime");

                entity.Property(e => e.PoolGiris).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAd).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tcno)
                    .HasMaxLength(20)
                    .HasColumnName("TCNo");
            });

            modelBuilder.Entity<VwArgeAraGecisStg>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ArgeAraGecis_STG");

                entity.Property(e => e.AdSoyad).HasMaxLength(101);

                entity.Property(e => e.BirimAd).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.Departman).HasMaxLength(500);

                entity.Property(e => e.FirmaAd).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAd).HasMaxLength(500);

                entity.Property(e => e.Gun)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.PozisyonAd).HasMaxLength(500);

                entity.Property(e => e.Sicil).HasMaxLength(20);

                entity.Property(e => e.Tarih).HasColumnType("datetime");

                entity.Property(e => e.Tcno)
                    .HasMaxLength(20)
                    .HasColumnName("TCNo");
            });

            modelBuilder.Entity<VwArgeRapor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ArgeRapor");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.Gun).HasColumnName("gun");

                entity.Property(e => e.Hafta).HasColumnName("hafta");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("tarih");
            });

            modelBuilder.Entity<VwAselsanRapor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_AselsanRapor");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.IzinKod).HasMaxLength(3);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwAssanselectGunlukMesaiOzet>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ASSANSelectGunlukMesaiOzet");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GlobalSicilId)
                    .HasMaxLength(50)
                    .HasColumnName("GlobalSicilID");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.Itfaciklama)
                    .HasMaxLength(500)
                    .HasColumnName("ITFAciklama");

                entity.Property(e => e.Kod).HasMaxLength(3);

                entity.Property(e => e.MesaiBasSonrasiIlkGiris).HasColumnType("datetime");

                entity.Property(e => e.MesaiBitOncesiSonCikis).HasColumnType("datetime");

                entity.Property(e => e.MesaiOzetAciklama).HasMaxLength(4000);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.OglenCikisTerminali).HasMaxLength(50);

                entity.Property(e => e.OglenCikisZamani).HasColumnType("datetime");

                entity.Property(e => e.OglenDurum).HasMaxLength(150);

                entity.Property(e => e.OglenGirisTerminali).HasMaxLength(50);

                entity.Property(e => e.OglenGirisZamani).HasColumnType("datetime");

                entity.Property(e => e.Ozet).HasMaxLength(150);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.Sgfaciklama)
                    .HasMaxLength(500)
                    .HasColumnName("SGFAciklama");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwAstorPuantaj2023>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_AstorPuantaj2023");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.IzinAdi).HasMaxLength(50);

                entity.Property(e => e.IzinDetayAciklama).HasMaxLength(500);

                entity.Property(e => e.IzinDurumu).HasMaxLength(50);

                entity.Property(e => e.IzinSureGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IzinTipKodu).HasMaxLength(3);

                entity.Property(e => e.MesaiAciklama)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.Okod2)
                    .HasMaxLength(50)
                    .HasColumnName("OKod2");

                entity.Property(e => e.Okod3)
                    .HasMaxLength(50)
                    .HasColumnName("OKod3");

                entity.Property(e => e.Okod4)
                    .HasMaxLength(50)
                    .HasColumnName("OKod4");

                entity.Property(e => e.Okod5).HasColumnName("OKod5");

                entity.Property(e => e.Okod6)
                    .HasMaxLength(50)
                    .HasColumnName("OKod6");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.ResmiTatilKodu).HasMaxLength(50);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwAylikCalismaVeIzinRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_AylikCalismaVeIzinRaporu");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.CardId).HasMaxLength(15);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.FirmaAd).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IzinAciklama).HasMaxLength(50);

                entity.Property(e => e.IzinKodu).HasMaxLength(3);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAd).HasMaxLength(500);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwAylikCalismaVeIzinRaporuBarkom>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_AylikCalismaVeIzinRaporu_BARKOM");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.CardId).HasMaxLength(15);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.FirmaAd).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IzinAciklama).HasMaxLength(50);

                entity.Property(e => e.IzinGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IzinKodu).HasMaxLength(3);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAd).HasMaxLength(500);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tcno)
                    .HasMaxLength(20)
                    .HasColumnName("TCNO");

                entity.Property(e => e.ToplamHakEdilenIzinGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ToplamKalanIzinGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ToplamKullanilanIzinGun).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VwAylikDetayliFm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_AylikDetayliFM");

                entity.Property(e => e.Ad).HasMaxLength(20);

                entity.Property(e => e.AyAd).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.C1)
                    .HasMaxLength(5)
                    .HasColumnName("C_1");

                entity.Property(e => e.C10)
                    .HasMaxLength(5)
                    .HasColumnName("C_10");

                entity.Property(e => e.C11)
                    .HasMaxLength(5)
                    .HasColumnName("C_11");

                entity.Property(e => e.C12)
                    .HasMaxLength(5)
                    .HasColumnName("C_12");

                entity.Property(e => e.C13)
                    .HasMaxLength(5)
                    .HasColumnName("C_13");

                entity.Property(e => e.C14)
                    .HasMaxLength(5)
                    .HasColumnName("C_14");

                entity.Property(e => e.C15)
                    .HasMaxLength(5)
                    .HasColumnName("C_15");

                entity.Property(e => e.C16)
                    .HasMaxLength(5)
                    .HasColumnName("C_16");

                entity.Property(e => e.C17)
                    .HasMaxLength(5)
                    .HasColumnName("C_17");

                entity.Property(e => e.C18)
                    .HasMaxLength(5)
                    .HasColumnName("C_18");

                entity.Property(e => e.C19)
                    .HasMaxLength(5)
                    .HasColumnName("C_19");

                entity.Property(e => e.C2)
                    .HasMaxLength(5)
                    .HasColumnName("C_2");

                entity.Property(e => e.C20)
                    .HasMaxLength(5)
                    .HasColumnName("C_20");

                entity.Property(e => e.C21)
                    .HasMaxLength(5)
                    .HasColumnName("C_21");

                entity.Property(e => e.C22)
                    .HasMaxLength(5)
                    .HasColumnName("C_22");

                entity.Property(e => e.C23)
                    .HasMaxLength(5)
                    .HasColumnName("C_23");

                entity.Property(e => e.C24)
                    .HasMaxLength(5)
                    .HasColumnName("C_24");

                entity.Property(e => e.C25)
                    .HasMaxLength(5)
                    .HasColumnName("C_25");

                entity.Property(e => e.C26)
                    .HasMaxLength(5)
                    .HasColumnName("C_26");

                entity.Property(e => e.C27)
                    .HasMaxLength(5)
                    .HasColumnName("C_27");

                entity.Property(e => e.C28)
                    .HasMaxLength(5)
                    .HasColumnName("C_28");

                entity.Property(e => e.C29)
                    .HasMaxLength(5)
                    .HasColumnName("C_29");

                entity.Property(e => e.C3)
                    .HasMaxLength(5)
                    .HasColumnName("C_3");

                entity.Property(e => e.C30)
                    .HasMaxLength(5)
                    .HasColumnName("C_30");

                entity.Property(e => e.C31)
                    .HasMaxLength(5)
                    .HasColumnName("C_31");

                entity.Property(e => e.C4)
                    .HasMaxLength(5)
                    .HasColumnName("C_4");

                entity.Property(e => e.C5)
                    .HasMaxLength(5)
                    .HasColumnName("C_5");

                entity.Property(e => e.C6)
                    .HasMaxLength(5)
                    .HasColumnName("C_6");

                entity.Property(e => e.C7)
                    .HasMaxLength(5)
                    .HasColumnName("C_7");

                entity.Property(e => e.C8)
                    .HasMaxLength(5)
                    .HasColumnName("C_8");

                entity.Property(e => e.C9)
                    .HasMaxLength(5)
                    .HasColumnName("C_9");

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.ResmiTatilFm).HasColumnName("ResmiTatilFM");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(20);

                entity.Property(e => e.TcNo).HasMaxLength(20);

                entity.Property(e => e.ToplamFm)
                    .HasMaxLength(5)
                    .HasColumnName("ToplamFM");
            });

            modelBuilder.Entity<VwAylikDetayliFmCrossTab>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_AylikDetayliFM_CrossTab");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAd).HasMaxLength(150);

                entity.Property(e => e.BirimId).HasColumnName("BirimID");

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.BolumId).HasColumnName("BolumID");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Kod).HasMaxLength(3);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwAylikDetayliPdk>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_AylikDetayliPDKS");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GeceDinlenmeCalismaSure).HasColumnName("geceDinlenmeCalismaSure");

                entity.Property(e => e.GeceDinlenmeToplamSure).HasColumnName("geceDinlenmeToplamSure");

                entity.Property(e => e.GeceFazlaMesai).HasColumnName("geceFazlaMesai");

                entity.Property(e => e.GeceMesaiSure).HasColumnName("geceMesaiSure");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Mesai).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.OdaSure).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Pdü).HasColumnName("PDÜ");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SgkraporSendika).HasColumnName("SGKRaporSendika");

                entity.Property(e => e.Sgkraporlu).HasColumnName("SGKRaporlu");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwAylikDevam>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_AylikDevam");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimId).HasColumnName("Birim_ID");

                entity.Property(e => e.BolumAd)
                    .HasMaxLength(500)
                    .HasColumnName("Bolum_Ad");

                entity.Property(e => e.BolumId).HasColumnName("Bolum_ID");

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.IzinAciklama).HasMaxLength(50);

                entity.Property(e => e.IzınId)
                    .HasMaxLength(250)
                    .HasColumnName("Izın_ID");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.SicilId).HasColumnName("Sicil_ID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TasniflemeId).HasColumnName("Tasnifleme_ID");
            });

            modelBuilder.Entity<VwAylikDevamDetay>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_AylikDevamDetay");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis)
                    .HasColumnType("datetime")
                    .HasColumnName("cikis");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris)
                    .HasColumnType("datetime")
                    .HasColumnName("giris");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IzinIdList).HasMaxLength(250);

                entity.Property(e => e.MesaiBas).HasMaxLength(33);

                entity.Property(e => e.MesaiBit).HasMaxLength(33);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Pozisyon)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("pozisyon");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TasnifId).HasColumnName("tasnifId");
            });

            modelBuilder.Entity<VwAylikDevamDetayCizelge>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_AylikDevamDetayCizelge");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis)
                    .HasColumnType("datetime")
                    .HasColumnName("cikis");

                entity.Property(e => e.Giris)
                    .HasColumnType("datetime")
                    .HasColumnName("giris");

                entity.Property(e => e.IzinIdList).HasMaxLength(250);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TasnifId).HasColumnName("tasnifId");
            });

            modelBuilder.Entity<VwAylikFazlaMesaiListesi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_AylikFazlaMesaiListesi");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BirimId).HasColumnName("birimID");

                entity.Property(e => e.BolumAdi)
                    .HasMaxLength(500)
                    .HasColumnName("bolumAdi");

                entity.Property(e => e.BolumId).HasColumnName("bolumID");

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi)
                    .HasMaxLength(500)
                    .HasColumnName("firmaAdi");

                entity.Property(e => e.FirmaId).HasColumnName("firmaID");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.GorevId).HasColumnName("GorevID");

                entity.Property(e => e.MesaiAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("date");

                entity.Property(e => e.PozisyonAdi)
                    .HasMaxLength(500)
                    .HasColumnName("pozisyonAdi");

                entity.Property(e => e.PozisyonId).HasColumnName("pozisyonID");

                entity.Property(e => e.SicilId).HasColumnName("sicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TasniflemeId).HasColumnName("TasniflemeID");

                entity.Property(e => e.YakaKodu).HasMaxLength(50);
            });

            modelBuilder.Entity<VwAylikFirmaBazliGelenPersonelRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_AylikFirmaBazliGelenPersonelRaporu");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BasTar).HasColumnType("date");

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BitTar).HasColumnType("date");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.MesaiTarih).HasColumnType("date");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);

                entity.Property(e => e.UniqueC).HasColumnName("uniqueC");
            });

            modelBuilder.Entity<VwAylikNetPuantajSonucRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_AylikNetPuantajSonucRaporu");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.GerceklesenMesai).HasMaxLength(50);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.IzinDurumu).HasMaxLength(50);

                entity.Property(e => e.MesaiKod).HasMaxLength(3);

                entity.Property(e => e.MesaiOzetAciklama).HasMaxLength(4000);

                entity.Property(e => e.MesaiPeriyodu).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Ozet).HasMaxLength(150);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TanimliMesai).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwAylikNetPuantajSonucRaporuNurdil>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_AylikNetPuantajSonucRaporu_Nurdil");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.GerceklesenMesai).HasMaxLength(50);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.IzinDurumu).HasMaxLength(50);

                entity.Property(e => e.MesaiKod).HasMaxLength(3);

                entity.Property(e => e.MesaiOzetAciklama).HasMaxLength(4000);

                entity.Property(e => e.MesaiPeriyodu).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.OdaKalinanSureToplam).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ozet).HasMaxLength(150);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TanimliMesai).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwAylikVardiyaListesi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_AylikVardiyaListesi");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Gerceklesen).HasMaxLength(50);

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TanimliMesai).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwAylikYemekYiyenPersonel>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_AylikYemekYiyenPersonel");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Departman).HasMaxLength(150);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tarih).HasColumnType("datetime");

                entity.Property(e => e.Vardiya).HasMaxLength(50);

                entity.Property(e => e.YemekhaneNumarasi).HasMaxLength(50);
            });

            modelBuilder.Entity<VwBastugSapAktarimCsv>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_BastugSapAktarimCsv");

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Kayittipi).HasColumnName("kayittipi");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.Saat)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Tarih)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Yon)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwBeyazYakaOglenHesaplama>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_BeyazYakaOglenHesaplama");

                entity.Property(e => e.Ad).HasMaxLength(20);

                entity.Property(e => e.AdSoyad).HasMaxLength(41);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.MesaiSuresi1).HasColumnName("Mesai Suresi");

                entity.Property(e => e.OglenCikis).HasColumnName("Oglen Cikis");

                entity.Property(e => e.OglenGiris).HasColumnName("Oglen Giris");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.Soyad).HasMaxLength(20);

                entity.Property(e => e.Tarih).HasColumnType("datetime");

                entity.Property(e => e.Tcnumarasi)
                    .HasMaxLength(20)
                    .HasColumnName("TCNumarasi");

                entity.Property(e => e.YakaAdi).HasMaxLength(50);
            });

            modelBuilder.Entity<VwBeyazYakaOglenHesaplamaHataliKayit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_BeyazYakaOglenHesaplamaHataliKayit");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwCalismaPlani>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_CalismaPlani");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BaslangicTarihSaat).HasColumnType("datetime");

                entity.Property(e => e.BitisTarihSaat).HasColumnType("datetime");

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GunAdi).HasMaxLength(30);

                entity.Property(e => e.MesaiAciklama).HasMaxLength(50);

                entity.Property(e => e.MesaiAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiGrupAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiPeriyodu).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.ResmiTatilAciklama).HasMaxLength(50);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TasnifId).HasColumnName("TasnifID");
            });

            modelBuilder.Entity<VwCalismaSure>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_CalismaSure");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAd).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAd).HasMaxLength(500);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAd).HasMaxLength(500);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tcno)
                    .HasMaxLength(20)
                    .HasColumnName("TCNo");
            });

            modelBuilder.Entity<VwCalismaSuresi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_CalismaSuresi");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAd).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.FirmaAd).HasMaxLength(500);

                entity.Property(e => e.MesaiSuresi).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.ToplamCalisilanSure)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwCalismaVeMolaSuresi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_CalismaVeMolaSuresi");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(50);

                entity.Property(e => e.BolumAdiText).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisTarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisTarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.GorevTuru).HasMaxLength(50);

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.IzinDurumu).HasMaxLength(50);

                entity.Property(e => e.IzinIdList).HasColumnName("izinIdList");

                entity.Property(e => e.IzinKodu).HasMaxLength(3);

                entity.Property(e => e.KartNo).HasMaxLength(15);

                entity.Property(e => e.MesaiAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiBasSonrasiIlkGiris).HasColumnType("datetime");

                entity.Property(e => e.MesaiBitOncesiSonCikis).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.ResmiTatilAdi).HasMaxLength(50);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwCaniasPdksaktarim>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_CaniasPDKSAktarim");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.IzinAdi).HasMaxLength(50);

                entity.Property(e => e.IzinDetayAciklama).HasMaxLength(500);

                entity.Property(e => e.IzinDurumu).HasMaxLength(50);

                entity.Property(e => e.IzinSureGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IzinTipKodu).HasMaxLength(3);

                entity.Property(e => e.MesaiAciklama)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.ResmiTatilKodu).HasMaxLength(50);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwCaniasPuantajAktarim>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_CaniasPuantajAktarim");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.BordroKodu)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.MesaiKodu).HasMaxLength(3);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwCekirdekCalismaliEsnekMesaiCalismaRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_CekirdekCalismaliEsnekMesaiCalismaRaporu");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.Devamsiz).HasMaxLength(50);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GeceDinlenmeCalismaSure).HasColumnName("geceDinlenmeCalismaSure");

                entity.Property(e => e.GeceDinlenmeToplamSure).HasColumnName("geceDinlenmeToplamSure");

                entity.Property(e => e.GeceFazlaMesai).HasColumnName("geceFazlaMesai");

                entity.Property(e => e.GeceMesaiIciCalisma).HasColumnName("geceMesaiIciCalisma");

                entity.Property(e => e.GeceMesaiSure).HasColumnName("geceMesaiSure");

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.GorevlendirmeKod).HasMaxLength(4);

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.IzinAdi).HasMaxLength(50);

                entity.Property(e => e.IzinDetayAciklama).HasMaxLength(500);

                entity.Property(e => e.IzinDurumu).HasMaxLength(50);

                entity.Property(e => e.IzinSureGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IzinTipKodu).HasMaxLength(3);

                entity.Property(e => e.MesaiAciklama)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.MesaiKodu).HasMaxLength(3);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.Okod2)
                    .HasMaxLength(50)
                    .HasColumnName("OKod2");

                entity.Property(e => e.Okod3)
                    .HasMaxLength(50)
                    .HasColumnName("OKod3");

                entity.Property(e => e.Okod4)
                    .HasMaxLength(50)
                    .HasColumnName("OKod4");

                entity.Property(e => e.Okod5).HasColumnName("OKod5");

                entity.Property(e => e.Okod6)
                    .HasMaxLength(50)
                    .HasColumnName("OKod6");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.ResmiTatilKodu).HasMaxLength(50);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwCesOnaylananFazlaMesaiRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_CesOnaylananFazlaMesaiRaporu");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwCihazDurumRapor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_CihazDurumRapor");

                entity.Property(e => e.Durum)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("durum");

                entity.Property(e => e.LastEventTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Port).HasMaxLength(15);

                entity.Property(e => e.SourceName).HasMaxLength(50);

                entity.Property(e => e.Zaman).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwDetayYemekhaneRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_DetayYemekhaneRaporu");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.EventTime).HasColumnType("date");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TerminalAdi).HasMaxLength(250);

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");
            });

            modelBuilder.Entity<VwDinamikGelmeyenPersonel>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_DinamikGelmeyenPersonel");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.FirmaAd).HasMaxLength(500);

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.GorevAd).HasMaxLength(500);

                entity.Property(e => e.MesaiAciklama).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAd).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TasnifId).HasColumnName("TasnifID");
            });

            modelBuilder.Entity<VwDsimesaiHesapla>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_DSIMesaiHesapla");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IzinAciklama).HasMaxLength(100);

                entity.Property(e => e.IzinBaslangic).HasColumnType("datetime");

                entity.Property(e => e.IzinBitis).HasColumnType("datetime");

                entity.Property(e => e.MesaiAciklama).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tc)
                    .HasMaxLength(20)
                    .HasColumnName("TC");
            });

            modelBuilder.Entity<VwEgitimKatilimciSure>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_EgitimKatilimciSure");

                entity.Property(e => e.BaslangicZamani).HasColumnType("datetime");

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BitisZamani).HasColumnType("datetime");

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.EgitimAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilAd).HasMaxLength(50);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SicilSoyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwEgitimRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_EgitimRaporu");

                entity.Property(e => e.Aciklama).HasMaxLength(500);

                entity.Property(e => e.Ad).HasMaxLength(500);

                entity.Property(e => e.BaslangicZamani).HasColumnType("datetime");

                entity.Property(e => e.BitisZamani).HasColumnType("datetime");

                entity.Property(e => e.EgitimTipi).HasMaxLength(50);

                entity.Property(e => e.EgitimiVerenKurum).HasMaxLength(50);

                entity.Property(e => e.EgitmenAdi).HasMaxLength(150);

                entity.Property(e => e.FinansTipi).HasMaxLength(50);

                entity.Property(e => e.Lokasyon).HasMaxLength(50);

                entity.Property(e => e.Organizator).HasMaxLength(50);

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.SicilAd).HasMaxLength(50);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SicilSoyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwEgitimRaporuSicilBazli>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_EgitimRaporuSicilBazli");

                entity.Property(e => e.Aciklama).HasMaxLength(500);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BaslangicZamani).HasColumnType("datetime");

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BitisZamani).HasColumnType("datetime");

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.EgitimAdi).HasMaxLength(500);

                entity.Property(e => e.EgitimTipi).HasMaxLength(50);

                entity.Property(e => e.EgitimiVerenKurum).HasMaxLength(50);

                entity.Property(e => e.EgitmenAdi).HasMaxLength(150);

                entity.Property(e => e.FinansTipi).HasMaxLength(50);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Lokasyon).HasMaxLength(50);

                entity.Property(e => e.Organizator).HasMaxLength(50);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwErkenCikanIzinli>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_ErkenCikanIzinli");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.ErkenIzinDurum).HasMaxLength(65);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MesaiBaslangic).HasColumnType("datetime");

                entity.Property(e => e.MesaiBitis).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwErkenCikanPersonel>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ErkenCikanPersonel");

                entity.Property(e => e.Ad).HasMaxLength(20);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.BolumId).HasColumnName("BolumID");

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.Mbas)
                    .HasColumnType("datetime")
                    .HasColumnName("MBas");

                entity.Property(e => e.Mbit)
                    .HasColumnType("datetime")
                    .HasColumnName("MBit");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(20);
            });

            modelBuilder.Entity<VwErkenCikanlar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_ErkenCikanlar");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MesaiBaslangic).HasColumnType("datetime");

                entity.Property(e => e.MesaiBitis).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwFazlaMesaiHesaplaRapor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_FazlaMesaiHesaplaRapor");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.MesaiAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tc)
                    .HasMaxLength(20)
                    .HasColumnName("TC");
            });

            modelBuilder.Entity<VwFazlaMesaiRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_fazlaMesaiRaporu");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.MesaiAdi)
                    .HasMaxLength(50)
                    .HasColumnName("mesaiAdi");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.SicilId).HasMaxLength(8);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwFazlaMesaiRaporuOstimOsb>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_fazlaMesaiRaporuOstimOsb");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.MesaiAdi)
                    .HasMaxLength(50)
                    .HasColumnName("mesaiAdi");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.ResmiTatilAciklama).HasMaxLength(50);

                entity.Property(e => e.RtbasSaat).HasColumnName("RTBasSaat");

                entity.Property(e => e.Rttamgun).HasColumnName("RTTamgun");

                entity.Property(e => e.SicilId).HasMaxLength(8);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwFernasGunlukRapor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_FernasGunlukRapor");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisTerminalAdi).HasMaxLength(50);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.GirisTerminalAdi).HasMaxLength(50);

                entity.Property(e => e.IzinBaslangic).HasColumnType("datetime");

                entity.Property(e => e.IzinBitis).HasColumnType("datetime");

                entity.Property(e => e.IzinDurum).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.MolaCikisZamani).HasColumnType("datetime");

                entity.Property(e => e.MolaGirisZamani).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcKimlikNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwFinansDetayCalisma>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_FinansDetayCalisma");

                entity.Property(e => e.Ad).HasMaxLength(20);

                entity.Property(e => e.AdSoyad).HasMaxLength(41);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.Soyad).HasMaxLength(20);

                entity.Property(e => e.Tarih).HasColumnType("datetime");

                entity.Property(e => e.Tcnumarasi)
                    .HasMaxLength(20)
                    .HasColumnName("TCNumarasi");

                entity.Property(e => e.YakaAdi).HasMaxLength(50);
            });

            modelBuilder.Entity<VwFmhesapla>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_FMHesapla");

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilAdi).HasMaxLength(50);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyadi).HasMaxLength(50);
            });

            modelBuilder.Entity<VwGecGelenPersonel>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_GecGelenPersonel");

                entity.Property(e => e.Ad).HasMaxLength(20);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.BolumId).HasColumnName("BolumID");

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.Mbas)
                    .HasColumnType("datetime")
                    .HasColumnName("MBas");

                entity.Property(e => e.Mbit)
                    .HasColumnType("datetime")
                    .HasColumnName("MBit");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(20);
            });

            modelBuilder.Entity<VwGecGelenler>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_GecGelenler");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IzinAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiBaslangic).HasColumnType("datetime");

                entity.Property(e => e.MesaiBitis).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwGecGelenlerIzinli>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_GecGelenlerIzinli");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GecIzinDurum).HasMaxLength(65);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MesaiBaslangic).HasColumnType("datetime");

                entity.Property(e => e.MesaiBitis).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwGecGelenlerToleransli>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_GecGelenlerToleransli");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MesaiBaslangic).HasColumnType("datetime");

                entity.Property(e => e.MesaiBitis).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwGeciciKartGecisListesiOzet>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_GeciciKartGecisListesiOzet");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GeciciKartAdi).HasMaxLength(50);

                entity.Property(e => e.GeciciKartIslemBitisTarihi).HasColumnType("datetime");

                entity.Property(e => e.GeciciKartNo).HasMaxLength(50);

                entity.Property(e => e.GeciciKartVerilmeTarih).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwGecisYogunlugu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_GecisYogunlugu");

                entity.Property(e => e.Tarih).HasColumnType("date");
            });

            modelBuilder.Entity<VwGelenPersonelMail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_GelenPersonelMail");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TasnifId).HasColumnName("TasnifID");
            });

            modelBuilder.Entity<VwGelenPersonelSayisi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_GelenPersonelSayisi");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwGelmeyenPersonel>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_GelmeyenPersonel");

                entity.Property(e => e.Ad).HasMaxLength(20);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.BolumId).HasColumnName("BolumID");

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.Mbas)
                    .HasColumnType("datetime")
                    .HasColumnName("MBas");

                entity.Property(e => e.Mbit)
                    .HasColumnType("datetime")
                    .HasColumnName("MBit");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(20);
            });

            modelBuilder.Entity<VwGelmeyenPersonelMail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_GelmeyenPersonelMail");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TasnifId).HasColumnName("TasnifID");
            });

            modelBuilder.Entity<VwGelmeyenler>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Gelmeyenler");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IzinDurum).HasMaxLength(50);

                entity.Property(e => e.MesaiBaslangic).HasColumnType("datetime");

                entity.Property(e => e.MesaiBitis).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwGelmeyenlerEkAlan>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_GelmeyenlerEkAlan");

                entity.Property(e => e.Ad)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BirimAdi)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BolumAdi)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FirmaAdi)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GorevAdi)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MesaiAdi)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MesaiTarih)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PozisyonAdi)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SicilNo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Soyad)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TcNo)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwGenelPersonelFazlaMesaiRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_genelPersonelFazlaMesaiRaporu");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.MesaiAdi)
                    .HasMaxLength(50)
                    .HasColumnName("mesaiAdi");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.SicilId).HasMaxLength(8);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwGenericPuantaj>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_genericPuantaj");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.Devamsiz).HasMaxLength(50);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GeceDinlenmeCalismaSure).HasColumnName("geceDinlenmeCalismaSure");

                entity.Property(e => e.GeceDinlenmeToplamSure).HasColumnName("geceDinlenmeToplamSure");

                entity.Property(e => e.GeceFazlaMesai).HasColumnName("geceFazlaMesai");

                entity.Property(e => e.GeceMesaiIciCalisma).HasColumnName("geceMesaiIciCalisma");

                entity.Property(e => e.GeceMesaiSure).HasColumnName("geceMesaiSure");

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.IzinAdi).HasMaxLength(50);

                entity.Property(e => e.IzinDetayAciklama).HasMaxLength(500);

                entity.Property(e => e.IzinDurumu).HasMaxLength(50);

                entity.Property(e => e.IzinSureGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IzinTipKodu).HasMaxLength(3);

                entity.Property(e => e.MesaiAciklama)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.MesaiBaslangic).HasColumnType("datetime");

                entity.Property(e => e.MesaiBitis).HasColumnType("datetime");

                entity.Property(e => e.MesaiCikis).HasColumnType("datetime");

                entity.Property(e => e.MesaiGiris).HasColumnType("datetime");

                entity.Property(e => e.MesaiKodu).HasMaxLength(3);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.Okod2)
                    .HasMaxLength(50)
                    .HasColumnName("OKod2");

                entity.Property(e => e.Okod3)
                    .HasMaxLength(50)
                    .HasColumnName("OKod3");

                entity.Property(e => e.Okod4)
                    .HasMaxLength(50)
                    .HasColumnName("OKod4");

                entity.Property(e => e.Okod5).HasColumnName("OKod5");

                entity.Property(e => e.Okod6)
                    .HasMaxLength(50)
                    .HasColumnName("OKod6");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.ResmiTatilKodu).HasMaxLength(50);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwGerceklesenMesaiPuantaj>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_GerceklesenMesaiPuantaj");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IzinAciklama).HasMaxLength(500);

                entity.Property(e => e.IzinBasTarih).HasColumnType("datetime");

                entity.Property(e => e.IzinBitTarih).HasColumnType("datetime");

                entity.Property(e => e.IzinGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IzinKod).HasMaxLength(3);

                entity.Property(e => e.IzinTipAciklama).HasMaxLength(50);

                entity.Property(e => e.MesaiAciklama).HasMaxLength(500);

                entity.Property(e => e.MesaiKod).HasMaxLength(3);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.Okod2)
                    .HasMaxLength(50)
                    .HasColumnName("OKod2");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.ResmiTatilAdi).HasMaxLength(50);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tcno)
                    .HasMaxLength(20)
                    .HasColumnName("TCNo");
            });

            modelBuilder.Entity<VwGirisCikisIhlalRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_GirisCikisIhlalRaporu");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.OglenGirisZamani).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwGirisCikisMail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_GirisCikisMail");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BaslangicTarih).HasColumnType("datetime");

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BitisTarih).HasColumnType("datetime");

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAd).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IzinAciklama).HasMaxLength(500);

                entity.Property(e => e.IzinAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwGunlukCalismaDurumu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_GunlukCalismaDurumu");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tcno)
                    .HasMaxLength(20)
                    .HasColumnName("TCNo");
            });

            modelBuilder.Entity<VwGunlukGelmeyenlerRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_GunlukGelmeyenlerRaporu");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwGunlukIzinOzetToplam>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_GunlukIzinOzetToplam");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<VwGunlukKapiGirisCikisRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_GunlukKapiGirisCikisRaporu");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilOkod6).HasMaxLength(50);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwHaftalikCalismaSureleriMail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_HaftalikCalismaSureleriMail");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimId).HasColumnName("birimId");

                entity.Property(e => e.BolumId).HasColumnName("bolumId");

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaId).HasColumnName("firmaId");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.IzinAciklama).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwHaftalikDevamsizlik>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_HaftalikDevamsizlik");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.DevamsizText)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FirmaAd).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IzinAciklama).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAd).HasMaxLength(500);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwHaftalikEksikCalisma>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_HaftalikEksikCalisma");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAd).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IzinAciklama).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAd).HasMaxLength(500);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwHaftalikErkenCikanlar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_HaftalikErkenCikanlar");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAd).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisId).HasColumnName("CikisID");

                entity.Property(e => e.FirmaAd).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisId).HasColumnName("GirisID");

                entity.Property(e => e.GorevAd).HasMaxLength(500);

                entity.Property(e => e.IzinAciklama).HasMaxLength(50);

                entity.Property(e => e.IzinId).HasColumnName("IzinID");

                entity.Property(e => e.MesaiBaslangic).HasColumnType("datetime");

                entity.Property(e => e.MesaiBitis).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAd).HasMaxLength(500);

                entity.Property(e => e.ResmiTatilAdi).HasMaxLength(50);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tatil)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwHaftalikGecGelenler>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_HaftalikGecGelenler");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAd).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IzinAciklama).HasMaxLength(50);

                entity.Property(e => e.MesaiBaslangic).HasColumnType("datetime");

                entity.Property(e => e.MesaiBitis).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAd).HasMaxLength(500);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwHaftalikIlkGirisSonCiki>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_HaftalikIlkGirisSonCikis");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAd).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisId).HasColumnName("CikisID");

                entity.Property(e => e.CikisStr).HasMaxLength(30);

                entity.Property(e => e.FirmaAd).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisId).HasColumnName("GirisID");

                entity.Property(e => e.GirisStr).HasMaxLength(30);

                entity.Property(e => e.GorevAd).HasMaxLength(500);

                entity.Property(e => e.IzinAciklama).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAd).HasMaxLength(500);

                entity.Property(e => e.ResmiTatilAdi).HasMaxLength(50);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tatil)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TolCikis).HasColumnType("datetime");

                entity.Property(e => e.TolGiris).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwHaftalikTseeksikCalisma>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_HaftalikTSEEksikCalisma");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.Dinlenme).HasColumnName("dinlenme");

                entity.Property(e => e.FirmaAd).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Izin).HasColumnName("izin");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAd).HasMaxLength(500);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwHaftalikYonetimIlkGirisSonCiki>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_HaftalikYonetimIlkGirisSonCikis");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAd).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisBilgisi)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CikisStr).HasMaxLength(30);

                entity.Property(e => e.FirmaAd).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisBilgisi)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.GirisId).HasColumnName("GirisID");

                entity.Property(e => e.GirisStr).HasMaxLength(30);

                entity.Property(e => e.GorevAd).HasMaxLength(500);

                entity.Property(e => e.IzinAciklama).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAd).HasMaxLength(500);

                entity.Property(e => e.ResmiTatilAdi).HasMaxLength(50);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tatil)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwHakedilenveKalanIzin>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_HakedilenveKalanIzin");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BakiyeFarkiGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BirimAd).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.DogumTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.FirmaAd).HasMaxLength(500);

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAd).HasMaxLength(500);

                entity.Property(e => e.HakEdilenGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IzinKuralAd).HasMaxLength(50);

                entity.Property(e => e.KalanIzinGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAd).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.ToplamKullanilanIzinGun).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VwHesKoduRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_HesKoduRaporu");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.HesKodu).HasMaxLength(50);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SorguTarih).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tckn).HasMaxLength(20);
            });

            modelBuilder.Entity<VwIcerdekiSure>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_IcerdekiSure");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BirimId).HasColumnName("birimID");

                entity.Property(e => e.BolumAdi)
                    .HasMaxLength(500)
                    .HasColumnName("bolumAdi");

                entity.Property(e => e.BolumId).HasColumnName("bolumID");

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi)
                    .HasMaxLength(500)
                    .HasColumnName("firmaAdi");

                entity.Property(e => e.FirmaId).HasColumnName("firmaID");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("date");

                entity.Property(e => e.SicilId).HasColumnName("sicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TasniflemeId).HasColumnName("TasniflemeID");
            });

            modelBuilder.Entity<VwIcerideGecirdigiSureToplamCalismaSure>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_IcerideGecirdigiSureToplamCalismaSure");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.Izin).HasMaxLength(96);

                entity.Property(e => e.LokasyonAdi).HasMaxLength(500);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tc)
                    .HasMaxLength(20)
                    .HasColumnName("TC");
            });

            modelBuilder.Entity<VwIceridekiPersonel>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_IceridekiPersonel");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasMaxLength(281);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwIceridekiSureBazliPuantaj>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_IceridekiSureBazliPuantaj");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.Devamsiz).HasMaxLength(50);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.IzinAdi).HasMaxLength(50);

                entity.Property(e => e.IzinBasTarih).HasColumnType("datetime");

                entity.Property(e => e.IzinBitTarih).HasColumnType("datetime");

                entity.Property(e => e.IzinDetayAciklama).HasMaxLength(50);

                entity.Property(e => e.IzinDurumu).HasMaxLength(500);

                entity.Property(e => e.MesaiAciklama).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwIceridekiler>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Iceridekiler");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GecisZamani).HasColumnType("datetime");

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ioid).HasColumnName("IOID");

                entity.Property(e => e.LokasyonAdi).HasMaxLength(500);

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TerminalAdi).HasMaxLength(50);

                entity.Property(e => e.YonAd).HasMaxLength(50);
            });

            modelBuilder.Entity<VwIlBazliArizaliTerminal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ilBazliArizaliTerminal");

                entity.Property(e => e.IlHaritaKod)
                    .HasMaxLength(50)
                    .HasColumnName("ilHaritaKod");
            });

            modelBuilder.Entity<VwIlkGirisSonCiki>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_IlkGirisSonCikis");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.MesaiTarih).HasColumnType("date");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tcno)
                    .HasMaxLength(20)
                    .HasColumnName("TCNO");
            });

            modelBuilder.Entity<VwIlkGirisSonCikisDurumMail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_IlkGirisSonCikisDurumMail");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BaslangicTarih).HasColumnType("datetime");

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BitisTarih).HasColumnType("datetime");

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAd).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IzinAciklama).HasMaxLength(500);

                entity.Property(e => e.IzinAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwIlkGirisSonCikisRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_IlkGirisSonCikisRaporu");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAd).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.FirmaAd).HasMaxLength(500);

                entity.Property(e => e.GorevAd).HasMaxLength(500);

                entity.Property(e => e.IlkCikis).HasColumnType("datetime");

                entity.Property(e => e.IlkCikisTerminal).HasMaxLength(250);

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.IlkGirisTerminal).HasMaxLength(250);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAd).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tcno)
                    .HasMaxLength(20)
                    .HasColumnName("TCNo");
            });

            modelBuilder.Entity<VwInterdataNetMesaiRapor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_InterdataNetMesaiRapor");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwIomistanbulHavalimaniPuantaj>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_IOMIstanbulHavalimaniPuantaj");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwIomraporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_IOMRaporu");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AraCikisTerminal)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AraCikisZaman).HasColumnType("date");

                entity.Property(e => e.AraGirisTerminal)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AraGirisZaman).HasColumnType("date");

                entity.Property(e => e.Bolum).HasMaxLength(500);

                entity.Property(e => e.BolumId).HasColumnName("BolumID");

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.Firma).HasMaxLength(500);

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.Gorev).HasMaxLength(500);

                entity.Property(e => e.GorevId).HasColumnName("GorevID");

                entity.Property(e => e.IsBaslangic).HasColumnType("smalldatetime");

                entity.Property(e => e.IzinBaslangic).HasColumnType("datetime");

                entity.Property(e => e.IzinBitis).HasColumnType("datetime");

                entity.Property(e => e.IzinDurum).HasMaxLength(50);

                entity.Property(e => e.MesaiBas)
                    .HasColumnType("datetime")
                    .HasColumnName("mesaiBas");

                entity.Property(e => e.MesaiBit)
                    .HasColumnType("datetime")
                    .HasColumnName("mesaiBit");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.OglenCikis).HasColumnType("datetime");

                entity.Property(e => e.OglenGiris).HasColumnType("datetime");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.Okod2)
                    .HasMaxLength(50)
                    .HasColumnName("OKod2");

                entity.Property(e => e.Okod3)
                    .HasMaxLength(50)
                    .HasColumnName("OKod3");

                entity.Property(e => e.Okod4)
                    .HasMaxLength(50)
                    .HasColumnName("OKod4");

                entity.Property(e => e.Okod5).HasColumnName("OKod5");

                entity.Property(e => e.Okod6)
                    .HasMaxLength(50)
                    .HasColumnName("OKod6");

                entity.Property(e => e.Pozisyon).HasMaxLength(500);

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwIskurPdksmail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_IskurPDKSMail");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BaslangicTarih).HasColumnType("datetime");

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BitisTarih).HasColumnType("datetime");

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IzinAciklama).HasMaxLength(500);

                entity.Property(e => e.IzinTipAciklama).HasMaxLength(50);

                entity.Property(e => e.MesaiAdi).HasMaxLength(500);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.ResmiTatilAdi).HasMaxLength(50);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwIskurPdksmailGunlukTumGecisler>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_IskurPDKSMailGunlukTumGecisler");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BaslangicTarih).HasColumnType("datetime");

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BitisTarih).HasColumnType("datetime");

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IzinAciklama).HasMaxLength(500);

                entity.Property(e => e.IzinTipAciklama).HasMaxLength(50);

                entity.Property(e => e.MesaiAdi).HasMaxLength(500);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.ResmiTatilAdi).HasMaxLength(50);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwIzinListesi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_IzinListesi");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Gun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IseBaslamaTarih).HasColumnType("datetime");

                entity.Property(e => e.IzinAciklama).HasMaxLength(500);

                entity.Property(e => e.IzinBaslangic).HasColumnType("datetime");

                entity.Property(e => e.IzinBitis).HasColumnType("datetime");

                entity.Property(e => e.IzinTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.IzinTipAdi).HasMaxLength(50);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcKimlikNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwIzinTalepFormuOlustur>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_IzinTalepFormuOlustur");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BakiyeFarkiGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BasTarih).HasColumnType("datetime");

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BitTarih).HasColumnType("datetime");

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.GunSure).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IseBaslamaTarih).HasColumnType("datetime");

                entity.Property(e => e.IseGirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.IzinAciklama).HasMaxLength(500);

                entity.Property(e => e.IzinTuru).HasMaxLength(50);

                entity.Property(e => e.OnayAdSoyad).HasMaxLength(101);

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.ToplamHakEdilenIzinGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ToplamKalanIzinGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ToplamKullanilanIzinGun).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VwIzinTatilFmraporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_IzinTatilFMRaporu");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.IzinAciklama).HasMaxLength(50);

                entity.Property(e => e.IzinKod).HasMaxLength(3);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tcno)
                    .HasMaxLength(20)
                    .HasColumnName("TCNo");
            });

            modelBuilder.Entity<VwIzinliPersonelMail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_IzinliPersonelMail");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BaslangicTarih).HasColumnType("datetime");

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BitisTarih).HasColumnType("datetime");

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IzinTipAciklama).HasMaxLength(50);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwJwMarriottTotalReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_JwMarriottTotalReport");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.MesaiAciklama).HasMaxLength(500);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwKafeteryaBakiye>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_KafeteryaBakiye");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwKafeteryaHakYuklemeRapor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_KafeteryaHakYuklemeRapor");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwKafeteryaRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_KafeteryaRaporu");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SiparisTarih).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.UrunAdi).HasMaxLength(50);
            });

            modelBuilder.Entity<VwKafeteryaRaporuSatislar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_KafeteryaRaporu_Satislar");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Fiyat).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IcecekBakiye).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SiparisTarih).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.UrunAdi).HasMaxLength(50);

                entity.Property(e => e.YiyecekBakiye).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VwKarbaPuantaj>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_KarbaPuantaj");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.CardId).HasMaxLength(15);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IzinAciklama).HasMaxLength(500);

                entity.Property(e => e.IzinBasTarih).HasColumnType("datetime");

                entity.Property(e => e.IzinBitTarih).HasColumnType("datetime");

                entity.Property(e => e.IzinGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IzinKod).HasMaxLength(3);

                entity.Property(e => e.IzinTipAciklama).HasMaxLength(50);

                entity.Property(e => e.MesaiAciklama).HasMaxLength(500);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tcno)
                    .HasMaxLength(20)
                    .HasColumnName("TCNo");
            });

            modelBuilder.Entity<VwKartKullanmayanSicil>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_KartKullanmayanSicil");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwKisiBazliGunlukMesaiOzet>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_KisiBazliGunlukMesaiOzet");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwKisiBazliTumGirisCiki>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_KisiBazliTumGirisCikis");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GecisYonu).HasMaxLength(50);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.MesaiTarih).HasColumnType("date");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TerminalAdi).HasMaxLength(50);
            });

            modelBuilder.Entity<VwKisiBildirimRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_KisiBildirimRaporu");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BabaAdi).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.CikisTarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.Cinsiyet).HasMaxLength(10);

                entity.Property(e => e.DogumTarihi).HasColumnType("date");

                entity.Property(e => e.DogumYeri).HasMaxLength(50);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.GorevTuru).HasMaxLength(50);

                entity.Property(e => e.IseGirisTarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.KayitDurumu)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tckn).HasMaxLength(20);
            });

            modelBuilder.Entity<VwKisiGirisCikisRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_KisiGirisCikisRaporu");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BasTarih).HasColumnType("datetime");

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BitTarih).HasColumnType("datetime");

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisTar).HasColumnType("smalldatetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisTar).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IsBaslama).HasColumnType("smalldatetime");

                entity.Property(e => e.IsBitis).HasColumnType("smalldatetime");

                entity.Property(e => e.IzinAdi).HasMaxLength(50);

                entity.Property(e => e.Kod).HasMaxLength(3);

                entity.Property(e => e.MesaiBaslangic).HasColumnType("datetime");

                entity.Property(e => e.MesaiBitis).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PersonelKimlikNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.ResmiTatilAciklama).HasMaxLength(50);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TasnifId).HasColumnName("TasnifID");

                entity.Property(e => e.TcNo)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwKisiGirisCikisRaporuGecisler>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_KisiGirisCikisRaporu_Gecisler");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BasTarih).HasColumnType("datetime");

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BitTarih).HasColumnType("datetime");

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.BolumId).HasColumnName("BolumID");

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.IsBitis).HasColumnType("smalldatetime");

                entity.Property(e => e.IseBaslama).HasColumnType("smalldatetime");

                entity.Property(e => e.IzinAciklama).HasMaxLength(50);

                entity.Property(e => e.IzinKodu).HasMaxLength(3);

                entity.Property(e => e.LokasyonAdi).HasMaxLength(500);

                entity.Property(e => e.MesaiAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiBaslangic).HasColumnType("datetime");

                entity.Property(e => e.MesaiBitis).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.ResmiTatilAdi).HasMaxLength(50);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TasnifId).HasColumnName("TasnifID");

                entity.Property(e => e.TcKimlikNoNew)
                    .HasMaxLength(20)
                    .HasColumnName("TcKimlikNo_new");

                entity.Property(e => e.TcNo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalAd).HasMaxLength(301);

                entity.Property(e => e.Zaman).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwKisiGirisCikisRaporuJwm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_KisiGirisCikisRaporuJWM");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BasTarih).HasColumnType("datetime");

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BitTarih).HasColumnType("datetime");

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisTar).HasColumnType("smalldatetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisTar).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IsBaslama).HasColumnType("smalldatetime");

                entity.Property(e => e.IsBitis).HasColumnType("smalldatetime");

                entity.Property(e => e.IzinAdi).HasMaxLength(50);

                entity.Property(e => e.Kod).HasMaxLength(3);

                entity.Property(e => e.MesaiBaslangic).HasColumnType("datetime");

                entity.Property(e => e.MesaiBitis).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PersonelKimlikNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.ResmiTatilAciklama).HasMaxLength(50);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TasnifId).HasColumnName("TasnifID");

                entity.Property(e => e.TcNo)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwKisiGirisCikisRaporuSolar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_KisiGirisCikisRaporu_Solar");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BasTarih).HasColumnType("datetime");

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BitTarih).HasColumnType("datetime");

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisTar).HasColumnType("smalldatetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisTar).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IsBaslama).HasColumnType("smalldatetime");

                entity.Property(e => e.IsBitis).HasColumnType("smalldatetime");

                entity.Property(e => e.IzinAdi).HasMaxLength(50);

                entity.Property(e => e.Kod).HasMaxLength(3);

                entity.Property(e => e.MesaiBaslangic).HasColumnType("datetime");

                entity.Property(e => e.MesaiBitis).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PersonelKimlikNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.ResmiTatilAciklama).HasMaxLength(50);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TasnifId).HasColumnName("TasnifID");

                entity.Property(e => e.TcNo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<VwKomutIslemRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_KomutIslemRaporu");

                entity.Property(e => e.EventCode).HasMaxLength(50);

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.ForeignId).HasColumnName("ForeignID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Pdks).HasColumnName("PDKS");

                entity.Property(e => e.Pdksx).HasColumnName("pdksx");

                entity.Property(e => e.ReaderId).HasColumnName("ReaderID");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(16)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<VwKonteynerLogRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_KonteynerLogRaporu");

                entity.Property(e => e.Adi).HasMaxLength(50);

                entity.Property(e => e.GunlukUcret).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IslemTarih).HasColumnType("datetime");

                entity.Property(e => e.IslemTipAdi).HasMaxLength(50);

                entity.Property(e => e.KonteynerAdi).HasMaxLength(150);

                entity.Property(e => e.KonteynerLogTipi)
                    .HasMaxLength(23)
                    .IsUnicode(false);

                entity.Property(e => e.KullaniciAdi).HasMaxLength(56);

                entity.Property(e => e.OdaAdi).HasMaxLength(150);

                entity.Property(e => e.SantiyeAdi).HasMaxLength(150);

                entity.Property(e => e.Soyadi).HasMaxLength(50);
            });

            modelBuilder.Entity<VwKpiraporuMefa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_KPIRaporu_Mefa");

                entity.Property(e => e.BolumAdi).HasMaxLength(500);
            });

            modelBuilder.Entity<VwMailIceridekiPersonel>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_MailIceridekiPersonel");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GirisStr).HasMaxLength(312);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwMailRapor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_MailRapor");

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisId).HasColumnName("CikisID");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisId).HasColumnName("GirisID");

                entity.Property(e => e.GirisTarih).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IzinBaslangic).HasColumnType("datetime");

                entity.Property(e => e.IzinBitis).HasColumnType("datetime");

                entity.Property(e => e.MesaiBas).HasColumnType("datetime");

                entity.Property(e => e.MesaiBit).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.MolaCikisZamani).HasColumnType("datetime");

                entity.Property(e => e.MolaGirisZamani).HasColumnType("datetime");

                entity.Property(e => e.TasnifId).HasColumnName("TasnifID");

                entity.Property(e => e.Zaman).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwMailReportsAylikPuantaj>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_MailReports_AylikPuantaj");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IzinAciklama).HasMaxLength(500);

                entity.Property(e => e.IzinBaslangic).HasColumnType("datetime");

                entity.Property(e => e.IzinBitis).HasColumnType("datetime");

                entity.Property(e => e.IzinTipAciklama).HasMaxLength(50);

                entity.Property(e => e.MesaiAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.Okod2)
                    .HasMaxLength(50)
                    .HasColumnName("OKod2");

                entity.Property(e => e.Okod3)
                    .HasMaxLength(50)
                    .HasColumnName("OKod3");

                entity.Property(e => e.Okod4)
                    .HasMaxLength(50)
                    .HasColumnName("OKod4");

                entity.Property(e => e.Okod5)
                    .HasMaxLength(50)
                    .HasColumnName("OKod5");

                entity.Property(e => e.Okod6)
                    .HasMaxLength(50)
                    .HasColumnName("OKod6");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TasnifId).HasColumnName("TasnifID");

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwMailReportsErisilemeyenCihazlar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_MailReports_ErisilemeyenCihazlar");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LokasyonAdi).HasMaxLength(50);

                entity.Property(e => e.TerminalAdi).HasMaxLength(250);

                entity.Property(e => e.Zaman).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwMailReportsGunlukFazlaMesai>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_MailReports_GunlukFazlaMesai");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IzinAciklama).HasMaxLength(500);

                entity.Property(e => e.IzinBaslangic).HasColumnType("datetime");

                entity.Property(e => e.IzinBitis).HasColumnType("datetime");

                entity.Property(e => e.IzinTipAciklama).HasMaxLength(50);

                entity.Property(e => e.MesaiAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.Okod2)
                    .HasMaxLength(50)
                    .HasColumnName("OKod2");

                entity.Property(e => e.Okod3)
                    .HasMaxLength(50)
                    .HasColumnName("OKod3");

                entity.Property(e => e.Okod4)
                    .HasMaxLength(50)
                    .HasColumnName("OKod4");

                entity.Property(e => e.Okod5)
                    .HasMaxLength(50)
                    .HasColumnName("OKod5");

                entity.Property(e => e.Okod6)
                    .HasMaxLength(50)
                    .HasColumnName("OKod6");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TasnifId).HasColumnName("TasnifID");

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwMailReportsSonGecerlilikYaklasanlarRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_MailReports_SonGecerlilikYaklasanlarRaporu");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonGecerlilikTarihi).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwMerkezGunlukCalismaCizelgesi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_MerkezGunlukCalismaCizelgesi");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.IzinAciklama).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PersonelCikis).HasColumnType("datetime");

                entity.Property(e => e.PersonelGiris).HasColumnType("datetime");

                entity.Property(e => e.PersonelYemekCikis).HasColumnType("datetime");

                entity.Property(e => e.PersonelYemekGiris).HasColumnType("datetime");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tcno)
                    .HasMaxLength(20)
                    .HasColumnName("TCNo");
            });

            modelBuilder.Entity<VwMesaiGirisCikisTrm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_MesaiGirisCikisTrm");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.CikisTerminal).HasMaxLength(250);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GirisTerminal).HasMaxLength(250);

                entity.Property(e => e.GlobalSicilId)
                    .HasMaxLength(50)
                    .HasColumnName("GlobalSicilID");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.Itfaciklama)
                    .HasMaxLength(500)
                    .HasColumnName("ITFAciklama");

                entity.Property(e => e.IzinDurumu).HasMaxLength(50);

                entity.Property(e => e.MesaiOzetAciklama).HasMaxLength(4000);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.Ozet).HasMaxLength(150);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.ResmiTatilAdi).HasMaxLength(50);

                entity.Property(e => e.Sgfaciklama)
                    .HasMaxLength(500)
                    .HasColumnName("SGFAciklama");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwMesaiHesapSaglama>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_mesaiHesapSaglama");

                entity.Property(e => e.Ad)
                    .HasMaxLength(50)
                    .HasColumnName("ad");

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.Itfaciklama)
                    .HasMaxLength(500)
                    .HasColumnName("ITFAciklama");

                entity.Property(e => e.MesaiBasSonrasiIlkGiris).HasColumnType("datetime");

                entity.Property(e => e.MesaiBitOncesiSonCikis).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Ozet).HasMaxLength(150);

                entity.Property(e => e.PoolIkGiris).HasColumnType("datetime");

                entity.Property(e => e.PoolSonCikis).HasColumnType("datetime");

                entity.Property(e => e.Sgfaciklama)
                    .HasMaxLength(500)
                    .HasColumnName("SGFAciklama");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.Sicilno)
                    .HasMaxLength(20)
                    .HasColumnName("sicilno");

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad)
                    .HasMaxLength(50)
                    .HasColumnName("soyad");
            });

            modelBuilder.Entity<VwMesaiHesaplamaIceridekiSure>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_MesaiHesaplamaIceridekiSure");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.GerceklesenMesai).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwMesaiHesaplamaKontrol>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_MesaiHesaplamaKontrol");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GlobalSicilId).HasColumnName("GlobalSicilID");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.MesaiBasSonrasiIlkGiris).HasColumnType("datetime");

                entity.Property(e => e.MesaiBitOncesiSonCikis).HasColumnType("datetime");

                entity.Property(e => e.MesaiOzetAciklama).HasMaxLength(4000);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.OglenCikisTerminali).HasMaxLength(50);

                entity.Property(e => e.OglenCikisZamani).HasColumnType("datetime");

                entity.Property(e => e.OglenDurum).HasMaxLength(150);

                entity.Property(e => e.OglenGirisTerminali).HasMaxLength(50);

                entity.Property(e => e.OglenGirisZamani).HasColumnType("datetime");

                entity.Property(e => e.Ozet).HasMaxLength(150);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwMobilGecisRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_MobilGecisRaporu");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Boylam).HasMaxLength(100);

                entity.Property(e => e.Enlem).HasMaxLength(100);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.FotografYol).HasMaxLength(255);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.OlayZaman).HasColumnType("datetime");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwMolaSuresiSelect>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_MolaSuresiSelect");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.BolumId).HasColumnName("BolumID");

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.GorevId).HasColumnName("GorevID");

                entity.Property(e => e.MesaiBas)
                    .HasColumnType("datetime")
                    .HasColumnName("mesaiBas");

                entity.Property(e => e.MesaiBit)
                    .HasColumnType("datetime")
                    .HasColumnName("mesaiBit");

                entity.Property(e => e.MesaiCikis).HasColumnType("datetime");

                entity.Property(e => e.MesaiGiris).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.OglenBaslangic).HasColumnType("datetime");

                entity.Property(e => e.OglenBitis).HasColumnType("datetime");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwNetsisAktarim>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_NetsisAktarim");

                entity.Property(e => e.Ad).HasMaxLength(20);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.BolumId).HasColumnName("BolumID");

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAd).HasMaxLength(500);

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAd).HasMaxLength(500);

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(20);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwNormalMesaiRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_NormalMesaiRaporu");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(20);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.Eks).HasColumnName("EKS");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IzinDurum).HasMaxLength(50);

                entity.Property(e => e.MesaiBaslangic).HasColumnType("datetime");

                entity.Property(e => e.MesaiBitis).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(20);
            });

            modelBuilder.Entity<VwNurdilDisariSureHesapla>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_NurdilDisariSureHesapla");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.CikisKapisi).HasMaxLength(250);

                entity.Property(e => e.CikisZamani).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.GirisId).HasColumnName("GirisID");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.GorevId).HasColumnName("GorevID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Io).HasColumnName("IO");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwNurdilDisariSureHesaplaMain>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_NurdilDisariSureHesapla_Main");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.CikisKapisi).HasMaxLength(250);

                entity.Property(e => e.CikisZamani).HasColumnType("datetime");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.GirisId).HasColumnName("GirisID");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.GorevId).HasColumnName("GorevID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwNurdilDisariSureHesaplaWc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_NurdilDisariSureHesaplaWC");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.CikisKapisi).HasMaxLength(250);

                entity.Property(e => e.CikisZamani).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.GirisId).HasColumnName("GirisID");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.GorevId).HasColumnName("GorevID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Io).HasColumnName("IO");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwNurdilDisariSureHesaplaWcMain>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_NurdilDisariSureHesaplaWC_Main");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.CikisKapisi).HasMaxLength(250);

                entity.Property(e => e.CikisZamani).HasColumnType("datetime");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.GirisId).HasColumnName("GirisID");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.GorevId).HasColumnName("GorevID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwNurdilFazlaMesaiRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_NurdilFazlaMesaiRaporu");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.MesaiAciklama).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwNurdilGunlukMesaiDetay>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_NurdilGunlukMesaiDetay");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.Izin)
                    .HasMaxLength(50)
                    .HasColumnName("izin");

                entity.Property(e => e.ResmiTatil).HasMaxLength(50);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwNurdilKisiBazliDevamsizlikRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_NurdilKisiBazliDevamsizlikRaporu");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IzinAciklama).HasMaxLength(500);

                entity.Property(e => e.MesaiAciklama).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.İzinTipAciklama).HasMaxLength(50);
            });

            modelBuilder.Entity<VwNurolFinalPdksraporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_NurolFinalPDKSRaporu");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Devamsiz).HasMaxLength(50);

                entity.Property(e => e.IzinAdi).HasMaxLength(50);

                entity.Property(e => e.IzinDetayAciklama).HasMaxLength(500);

                entity.Property(e => e.IzinSureGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IzinTipKodu).HasMaxLength(3);

                entity.Property(e => e.MesaiAciklama)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.OdaKalinanSure).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.ResmiTatilKodu).HasMaxLength(50);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwNurolSapaktarimRapor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_NurolSAPAktarimRapor");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.GcrlBsl).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);

                entity.Property(e => e.UcretTuru)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwOdaBazliGecisListesi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_OdaBazliGecisListesi");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.OdaAdi).HasMaxLength(150);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TerminalAdi).HasMaxLength(50);
            });

            modelBuilder.Entity<VwOdaKalinanSure>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_OdaKalinanSure");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.CikisTerminalId).HasColumnName("CikisTerminalID");

                entity.Property(e => e.CikisTerminali).HasMaxLength(250);

                entity.Property(e => e.CikisZamani).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GirisTerminalId).HasColumnName("GirisTerminalID");

                entity.Property(e => e.GirisTerminali).HasMaxLength(250);

                entity.Property(e => e.GirisZamani).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.OdaAdi).HasMaxLength(150);

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Sure).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VwOdaKalinanSureToplam>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_OdaKalinanSureToplam");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.HesaplamaTarih).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.OdaAdi).HasMaxLength(150);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.ToplamSure).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VwOdavePuantaj>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_OdavePuantaj");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.CardId).HasMaxLength(15);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IzinAciklama).HasMaxLength(500);

                entity.Property(e => e.IzinBasTarih).HasColumnType("datetime");

                entity.Property(e => e.IzinBitTarih).HasColumnType("datetime");

                entity.Property(e => e.IzinKod).HasMaxLength(3);

                entity.Property(e => e.IzinTipAciklama).HasMaxLength(50);

                entity.Property(e => e.MesaiAciklama).HasMaxLength(500);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.OdaIcerdekiToplam).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tcno)
                    .HasMaxLength(20)
                    .HasColumnName("TCNo");
            });

            modelBuilder.Entity<VwOdtuMemsNetSureveGeci>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_OdtuMemsNetSureveGecis");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IzinBaslangic).HasColumnType("datetime");

                entity.Property(e => e.IzinBitis).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcKimlikNo).HasMaxLength(20);

                entity.Property(e => e.TerminalAdi).HasMaxLength(50);

                entity.Property(e => e.Zaman).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwOgunBazliYemekRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_OgunBazliYemekRaporu");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.GorevId).HasColumnName("GorevID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.Okod2)
                    .HasMaxLength(50)
                    .HasColumnName("OKod2");

                entity.Property(e => e.Port).HasMaxLength(15);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TaseronFirmaAdı).HasMaxLength(200);

                entity.Property(e => e.TcNo).HasMaxLength(20);

                entity.Property(e => e.TerminalAdi).HasMaxLength(250);

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");
            });

            modelBuilder.Entity<VwOgunBazliYemekhaneRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_OgunBazliYemekhaneRaporu");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);

                entity.Property(e => e.TerminalAdi).HasMaxLength(250);

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.Zaman).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwOkumanArgeAylikCalisma>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_OkumanArgeAylikCalisma");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.IzinAdi).HasMaxLength(50);

                entity.Property(e => e.IzinDetayAciklama).HasMaxLength(500);

                entity.Property(e => e.IzinDurumu).HasMaxLength(50);

                entity.Property(e => e.IzinSureGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IzinTipKodu).HasMaxLength(3);

                entity.Property(e => e.MesaiAciklama)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.Okod2)
                    .HasMaxLength(50)
                    .HasColumnName("OKod2");

                entity.Property(e => e.Okod3)
                    .HasMaxLength(50)
                    .HasColumnName("OKod3");

                entity.Property(e => e.Okod4)
                    .HasMaxLength(50)
                    .HasColumnName("OKod4");

                entity.Property(e => e.Okod5).HasColumnName("OKod5");

                entity.Property(e => e.Okod6)
                    .HasMaxLength(50)
                    .HasColumnName("OKod6");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.ResmiTatilKodu).HasMaxLength(50);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwOnayliIzin>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_OnayliIzin");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IzinTipKod).HasMaxLength(3);

                entity.Property(e => e.IzinTipi).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwOrtalamaliCalismaSure>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_OrtalamaliCalismaSure");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.DusulecekGun)
                    .HasColumnType("numeric(2, 1)")
                    .HasColumnName("dusulecekGun");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.IzinAciklama)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwOverTimeReportJw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_OverTimeReportJW");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.IzinDurumu).HasMaxLength(50);

                entity.Property(e => e.IzinKodu).HasMaxLength(3);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.ResmiTatilAdi).HasMaxLength(50);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwOzlukBilgiler>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_OzlukBilgiler");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AnneAdi).HasMaxLength(50);

                entity.Property(e => e.Askerlik).HasMaxLength(50);

                entity.Property(e => e.BabaAdi).HasMaxLength(50);

                entity.Property(e => e.BirimAd).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.CepTel).HasMaxLength(50);

                entity.Property(e => e.Cinsiyet).HasMaxLength(50);

                entity.Property(e => e.CinsiyetId).HasMaxLength(50);

                entity.Property(e => e.DogumTarihi).HasColumnType("date");

                entity.Property(e => e.DogumYeri).HasMaxLength(50);

                entity.Property(e => e.Egitim).HasMaxLength(50);

                entity.Property(e => e.Ehliyet).HasMaxLength(50);

                entity.Property(e => e.FirmaAd).HasMaxLength(500);

                entity.Property(e => e.GorevAd).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.KanGrubu).HasMaxLength(50);

                entity.Property(e => e.KanGrubuId).HasMaxLength(50);

                entity.Property(e => e.KayitliIl)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KayitliIlId).HasMaxLength(50);

                entity.Property(e => e.KayitliIlce)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KayitliIlceId).HasMaxLength(50);

                entity.Property(e => e.KayitliMahalle).HasMaxLength(50);

                entity.Property(e => e.Mail).HasMaxLength(200);

                entity.Property(e => e.MedeniHal).HasMaxLength(50);

                entity.Property(e => e.MedeniHalId).HasMaxLength(50);

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAd).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwPagoGecisselect>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_pago_gecisselect");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BildirimTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("BILDIRIM_TARIHI");

                entity.Property(e => e.CardId)
                    .HasMaxLength(15)
                    .HasColumnName("CardID");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.FacilityCode).HasMaxLength(8);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PdksRecordId).HasColumnName("PDKS_RECORD_ID");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Yon)
                    .HasMaxLength(50)
                    .HasColumnName("YON");
            });

            modelBuilder.Entity<VwPagoResimselect>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_pago_resimselect");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Image).HasColumnType("image");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.RowDataozetId).HasColumnName("RowDataozetID");
            });

            modelBuilder.Entity<VwPanelsanPuantaj>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_PanelsanPuantaj");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.FmesikSuresi).HasColumnName("FMEsikSuresi");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IzinAciklama).HasMaxLength(500);

                entity.Property(e => e.IzinBasTarih).HasColumnType("datetime");

                entity.Property(e => e.IzinBitTarih).HasColumnType("datetime");

                entity.Property(e => e.IzinGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IzinKod).HasMaxLength(3);

                entity.Property(e => e.IzinTipAciklama).HasMaxLength(50);

                entity.Property(e => e.MesaiAciklama).HasMaxLength(500);

                entity.Property(e => e.MesaiKod).HasMaxLength(3);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tcno)
                    .HasMaxLength(20)
                    .HasColumnName("TCNo");
            });

            modelBuilder.Entity<VwPdksilkGirisSonCikisaGore>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_PDKSIlkGirisSonCikisaGore");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IzinAciklama).HasMaxLength(50);

                entity.Property(e => e.Mesaitarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tcno)
                    .HasMaxLength(20)
                    .HasColumnName("TCNO");
            });

            modelBuilder.Entity<VwPersonelHareketRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_PersonelHareketRaporu");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BaslangicTarih).HasColumnType("datetime");

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BitisTarih).HasColumnType("datetime");

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.ErkenDurum).HasMaxLength(90);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.GecDurum).HasMaxLength(90);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IsBaslama).HasColumnType("smalldatetime");

                entity.Property(e => e.IsBitis).HasColumnType("smalldatetime");

                entity.Property(e => e.IzinAdi).HasMaxLength(50);

                entity.Property(e => e.IzinBaslangic).HasColumnType("datetime");

                entity.Property(e => e.IzinBitis).HasColumnType("datetime");

                entity.Property(e => e.IzinGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Kod).HasMaxLength(3);

                entity.Property(e => e.MesaiBas).HasColumnType("datetime");

                entity.Property(e => e.MesaiBit).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PersonelKimlikNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.ResmiTatilAdi).HasMaxLength(50);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TasnifId).HasColumnName("TasnifID");

                entity.Property(e => e.TcNo)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwPersonelHataliGeci>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_PersonelHataliGecis");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.HataliGecisYonu).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Pcikis)
                    .HasColumnType("datetime")
                    .HasColumnName("PCikis");

                entity.Property(e => e.PcikisIki)
                    .HasColumnType("datetime")
                    .HasColumnName("PCikisIki");

                entity.Property(e => e.Pgiris)
                    .HasColumnType("datetime")
                    .HasColumnName("PGiris");

                entity.Property(e => e.PgirisIki)
                    .HasColumnType("datetime")
                    .HasColumnName("PGirisIki");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwPersonelPdk>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_PersonelPDKS");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IzinAciklama).HasMaxLength(500);

                entity.Property(e => e.IzinBasTarih).HasColumnType("datetime");

                entity.Property(e => e.IzinBitTarih).HasColumnType("datetime");

                entity.Property(e => e.IzinGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IzinKod).HasMaxLength(3);

                entity.Property(e => e.IzinTipAciklama).HasMaxLength(50);

                entity.Property(e => e.MesaiAciklama).HasMaxLength(500);

                entity.Property(e => e.MesaiKod).HasMaxLength(3);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.Okod2)
                    .HasMaxLength(50)
                    .HasColumnName("OKod2");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.ResmiTatilAdi).HasMaxLength(50);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tcno)
                    .HasMaxLength(20)
                    .HasColumnName("TCNo");
            });

            modelBuilder.Entity<VwPersonelPdksmail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_PersonelPDKSMail");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BaslangicTarih).HasColumnType("datetime");

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BitisTarih).HasColumnType("datetime");

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IzinAciklama).HasMaxLength(500);

                entity.Property(e => e.IzinTipAciklama).HasMaxLength(50);

                entity.Property(e => e.MesaiAdi).HasMaxLength(500);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.ResmiTatilAdi).HasMaxLength(50);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwPersonelYetkiDurum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_PersonelYetkiDurum");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TerminalAdi).HasMaxLength(250);

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.YetkiAdi).HasMaxLength(90);
            });

            modelBuilder.Entity<VwPuantajAktarimCeka>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_PuantajAktarim_Ceka");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(50);

                entity.Property(e => e.BolumAdiText).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisTarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisTarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.IzinDurumu).HasMaxLength(50);

                entity.Property(e => e.IzinIdList).HasColumnName("izinIdList");

                entity.Property(e => e.IzinKodu).HasMaxLength(3);

                entity.Property(e => e.KartNo).HasMaxLength(15);

                entity.Property(e => e.MesaiAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiBasSonrasiIlkGiris).HasColumnType("datetime");

                entity.Property(e => e.MesaiBitOncesiSonCikis).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.ResmiTatilAdi).HasMaxLength(50);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwPuantajDetayRapor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_PuantajDetayRapor");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.IzinDurumu).HasMaxLength(50);

                entity.Property(e => e.IzinId).HasColumnName("IzinID");

                entity.Property(e => e.IzinIdList).HasMaxLength(250);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwPuantajveGeci>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_PuantajveGecis");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BaslangicTarih).HasColumnType("datetime");

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BitisTarih).HasColumnType("datetime");

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IzinAciklama).HasMaxLength(500);

                entity.Property(e => e.IzinGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IzinTipAciklama).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod4)
                    .HasMaxLength(150)
                    .HasColumnName("OKod4");

                entity.Property(e => e.Okod5)
                    .HasMaxLength(50)
                    .HasColumnName("OKod5");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(50);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);

                entity.Property(e => e.TerminalAdi).HasMaxLength(250);

                entity.Property(e => e.Yon).HasMaxLength(50);
            });

            modelBuilder.Entity<VwResimliIlkGirisSonCikisIzinRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ResimliIlkGirisSonCikisIzinRaporu");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisResim).HasMaxLength(255);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisResim).HasMaxLength(255);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IzinBaslangic).HasColumnType("datetime");

                entity.Property(e => e.IzinBitis).HasColumnType("datetime");

                entity.Property(e => e.IzinTipAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwRfidGecisKayitlari>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_RFID_GecisKayitlari");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AracPlaka).HasMaxLength(15);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.FacilityCode).HasMaxLength(8);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.KartNo).HasMaxLength(15);

                entity.Property(e => e.LokasyonAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TerminalAdi).HasMaxLength(250);

                entity.Property(e => e.TerminalYonu)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwRfidilkGirisSonCiki>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_RFIDIlkGirisSonCikis");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AracPlaka).HasMaxLength(15);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.CardId)
                    .HasMaxLength(15)
                    .HasColumnName("CardID");

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FacilityCode).HasMaxLength(8);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.MesaiTarih).HasColumnType("date");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tcno)
                    .HasMaxLength(20)
                    .HasColumnName("TCNO");
            });

            modelBuilder.Entity<VwRonesansKartBaskiReadSicil>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_RonesansKartBaskiReadSicil");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AmirAd).HasMaxLength(101);

                entity.Property(e => e.AnneAdi).HasMaxLength(50);

                entity.Property(e => e.BabaAdi).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.DogumTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.DogumYeri).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaKodu).HasMaxLength(200);

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Il)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ilce)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KanGrubu).HasMaxLength(50);

                entity.Property(e => e.KartNo).HasMaxLength(15);

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.Okod2)
                    .HasMaxLength(50)
                    .HasColumnName("OKod2");

                entity.Property(e => e.Okod3)
                    .HasMaxLength(50)
                    .HasColumnName("OKod3");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.ResimYol).HasColumnType("image");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tcno)
                    .HasMaxLength(20)
                    .HasColumnName("TCNo");

                entity.Property(e => e.UserId).HasMaxLength(8);
            });

            modelBuilder.Entity<VwSaatlikIzinCizelgesi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SaatlikIzinCizelgesi");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IzinAdi).HasMaxLength(50);

                entity.Property(e => e.IzinBaslangicTarihi).HasColumnType("datetime");

                entity.Property(e => e.IzinBitisTarihi).HasColumnType("datetime");

                entity.Property(e => e.MesaiAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwSaintGobainPersonelGunlukMesaiTakip>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SaintGobainPersonelGunlukMesaiTakip");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Fmbaslangic)
                    .HasColumnType("datetime")
                    .HasColumnName("FMBaslangic");

                entity.Property(e => e.Fmbitis)
                    .HasColumnType("datetime")
                    .HasColumnName("FMBitis");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwSaintGobainPuantaj>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SaintGobainPuantaj");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.Devamsiz).HasMaxLength(50);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GeceDinlenmeCalismaSure).HasColumnName("geceDinlenmeCalismaSure");

                entity.Property(e => e.GeceDinlenmeToplamSure).HasColumnName("geceDinlenmeToplamSure");

                entity.Property(e => e.GeceFazlaMesai).HasColumnName("geceFazlaMesai");

                entity.Property(e => e.GeceMesaiIciCalisma).HasColumnName("geceMesaiIciCalisma");

                entity.Property(e => e.GeceMesaiSure).HasColumnName("geceMesaiSure");

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.IzinAdi).HasMaxLength(50);

                entity.Property(e => e.IzinDetayAciklama).HasMaxLength(500);

                entity.Property(e => e.IzinDurumu).HasMaxLength(50);

                entity.Property(e => e.IzinSureGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IzinTipKodu).HasMaxLength(3);

                entity.Property(e => e.MesaiAciklama)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.MesaiBaslangic).HasColumnType("datetime");

                entity.Property(e => e.MesaiBitis).HasColumnType("datetime");

                entity.Property(e => e.MesaiCikis).HasColumnType("datetime");

                entity.Property(e => e.MesaiGiris).HasColumnType("datetime");

                entity.Property(e => e.MesaiKodu).HasMaxLength(3);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.Okod2)
                    .HasMaxLength(50)
                    .HasColumnName("OKod2");

                entity.Property(e => e.Okod3)
                    .HasMaxLength(50)
                    .HasColumnName("OKod3");

                entity.Property(e => e.Okod4)
                    .HasMaxLength(50)
                    .HasColumnName("OKod4");

                entity.Property(e => e.Okod5).HasColumnName("OKod5");

                entity.Property(e => e.Okod6)
                    .HasMaxLength(50)
                    .HasColumnName("OKod6");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.ResmiTatilKodu).HasMaxLength(50);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);

                entity.Property(e => e.YapilacakFazlaMesaiBaslangic).HasColumnType("datetime");

                entity.Property(e => e.YapilacakFazlaMesaiBitis).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwSanayiGelmeyenler>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SanayiGelmeyenler");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(150);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IzinDurum).HasMaxLength(50);

                entity.Property(e => e.MesaiBaslangic).HasColumnType("datetime");

                entity.Property(e => e.MesaiBitis).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwSdtizinRapor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SDTIzinRapor");

                entity.Property(e => e.Adi).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.CikisId).HasColumnName("CikisID");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GirisId).HasColumnName("GirisID");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsBaslama).HasColumnType("smalldatetime");

                entity.Property(e => e.IsBitis).HasColumnType("smalldatetime");

                entity.Property(e => e.IzinAdi).HasMaxLength(50);

                entity.Property(e => e.Kod).HasMaxLength(3);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAd).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwSelectBirimRfidevent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectBirimRFIDEvents");

                entity.Property(e => e.Aciklama).HasMaxLength(90);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AracId).HasColumnName("AracID");

                entity.Property(e => e.AracPlaka).HasMaxLength(15);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.CardId)
                    .HasMaxLength(15)
                    .HasColumnName("CardID");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.FacilityCode).HasMaxLength(8);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Rfidad)
                    .HasMaxLength(50)
                    .HasColumnName("RFIDAd");

                entity.Property(e => e.Rfidsoyad)
                    .HasMaxLength(50)
                    .HasColumnName("RFIDSoyad");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.Yetki).HasMaxLength(90);

                entity.Property(e => e.Yon).HasMaxLength(50);
            });

            modelBuilder.Entity<VwSelectCiftAyPdk>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectCiftAyPDKS");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.BolumId).HasColumnName("BolumID");

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(50);

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.GorevId).HasColumnName("GorevID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IzinKodu).HasMaxLength(3);

                entity.Property(e => e.IzinTipi).HasMaxLength(50);

                entity.Property(e => e.MesaiAciklama).HasMaxLength(50);

                entity.Property(e => e.MesaiKodu).HasMaxLength(4000);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcKimlikNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwSelectDetayMesaiHesaplama>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SelectDetayMesaiHesaplama");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisTarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(50);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisTarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IzinBaslangic).HasColumnType("datetime");

                entity.Property(e => e.IzinBitis).HasColumnType("datetime");

                entity.Property(e => e.IzinKod).HasMaxLength(3);

                entity.Property(e => e.MesaiAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiBasSonrasiIlkGiris).HasColumnType("datetime");

                entity.Property(e => e.MesaiBitOncesiSonCikis).HasColumnType("datetime");

                entity.Property(e => e.MesaiOzetiId).HasColumnName("MesaiOzetiID");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.ResmiTatilAdi).HasMaxLength(50);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwSelectDetayliIzinRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectDetayliIzinRaporu");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BaslangicTarih).HasColumnType("datetime");

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BitisTarih).HasColumnType("datetime");

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.SureTipi)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwSelectEvent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectEvents");

                entity.Property(e => e.Ad).HasMaxLength(20);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.GorevId).HasColumnName("GorevID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Port).HasMaxLength(15);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(20);

                entity.Property(e => e.Tarih).HasColumnType("date");

                entity.Property(e => e.TerminalAdi).HasMaxLength(50);

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");
            });

            modelBuilder.Entity<VwSelectGeci>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SelectGecis");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.EventCode).HasMaxLength(50);

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.GrupAdi).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.Okod2).HasMaxLength(50);

                entity.Property(e => e.Okod3).HasMaxLength(50);

                entity.Property(e => e.Okod4).HasMaxLength(50);

                entity.Property(e => e.Okod5)
                    .HasMaxLength(50)
                    .HasColumnName("OKod5");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TerminalGrupId).HasColumnName("TerminalGrupID");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.YetkiAdi).HasMaxLength(90);

                entity.Property(e => e.Yon).HasColumnName("yon");
            });

            modelBuilder.Entity<VwSelectGecisOlanTarihler>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectGecisOlanTarihler");

                entity.Property(e => e.MesaiTarih).HasColumnType("date");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");
            });

            modelBuilder.Entity<VwSelectGecisTerminalBazli>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SelectGecisTerminalBazli");

                entity.Property(e => e.Ad).HasMaxLength(20);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.EventCode).HasMaxLength(50);

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.GrupAdi)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.Okod2).HasMaxLength(50);

                entity.Property(e => e.Okod3).HasMaxLength(50);

                entity.Property(e => e.Okod4).HasMaxLength(50);

                entity.Property(e => e.Okod5)
                    .HasMaxLength(50)
                    .HasColumnName("OKod5");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(20);

                entity.Property(e => e.TerminalGrupId).HasColumnName("TerminalGrupID");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.YetkiAdi).HasMaxLength(90);
            });

            modelBuilder.Entity<VwSelectGeciswithTerminal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SelectGeciswithTerminal");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AmirAdi).HasMaxLength(101);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.EventCode).HasMaxLength(20);

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Gorev).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.PoolId).HasColumnName("PoolID");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SirketAdi).HasMaxLength(50);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TaseronFirmaAdi).HasMaxLength(200);

                entity.Property(e => e.TcNo).HasMaxLength(20);

                entity.Property(e => e.TerminalAdi).HasMaxLength(250);

                entity.Property(e => e.TerminalGrupAdi)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Yon).HasMaxLength(50);
            });

            modelBuilder.Entity<VwSelectGenelPersonelBordroMerck>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectGenelPersonelBordro_Merck");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.CardId)
                    .HasMaxLength(15)
                    .HasColumnName("CardID");

                entity.Property(e => e.Fmgun).HasColumnName("FMGun");

                entity.Property(e => e.Fmsaat).HasColumnName("FMSaat");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Ncgun).HasColumnName("NCGun");

                entity.Property(e => e.Ncsaat).HasColumnName("NCSaat");

                entity.Property(e => e.Ncucret).HasColumnName("NCUcret");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwSelectGunlukMesaiOzet>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectGunlukMesaiOzet");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GlobalSicilId)
                    .HasMaxLength(50)
                    .HasColumnName("GlobalSicilID");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.Itfaciklama)
                    .HasMaxLength(500)
                    .HasColumnName("ITFAciklama");

                entity.Property(e => e.IzinDurumu).HasMaxLength(50);

                entity.Property(e => e.MesaiBasSonrasiIlkGiris).HasColumnType("datetime");

                entity.Property(e => e.MesaiBitOncesiSonCikis).HasColumnType("datetime");

                entity.Property(e => e.MesaiOzetAciklama).HasMaxLength(4000);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.OglenCikisTerminali).HasMaxLength(50);

                entity.Property(e => e.OglenCikisZamani).HasColumnType("datetime");

                entity.Property(e => e.OglenDurum).HasMaxLength(150);

                entity.Property(e => e.OglenGirisTerminali).HasMaxLength(50);

                entity.Property(e => e.OglenGirisZamani).HasColumnType("datetime");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.Ozet).HasMaxLength(150);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.ResmiTatilAdi).HasMaxLength(50);

                entity.Property(e => e.Sgfaciklama)
                    .HasMaxLength(500)
                    .HasColumnName("SGFAciklama");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwSelectGunlukMesaiOzetElsan>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectGunlukMesaiOzet_Elsan");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.IzinDurumu).HasMaxLength(50);

                entity.Property(e => e.IzinIdList).HasColumnName("izinIdList");

                entity.Property(e => e.IzinKodu).HasMaxLength(3);

                entity.Property(e => e.MesaiAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiBasSonrasiIlkGiris).HasColumnType("datetime");

                entity.Property(e => e.MesaiBitOncesiSonCikis).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.ResmiTatilAdi).HasMaxLength(50);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwSelectGunlukMesaiOzetGerceklesenMesai>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectGunlukMesaiOzet_GerceklesenMesai");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GerceklesenMesai).HasMaxLength(50);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.IzinDurumu).HasMaxLength(50);

                entity.Property(e => e.MesaiOzetAciklama).HasMaxLength(4000);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.Ozet).HasMaxLength(150);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TanimliMesai).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwSelectGunlukMesaiOzetGirisCikisCcn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectGunlukMesaiOzetGirisCikis_CCN");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisTarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisTarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.IzinDurumu).HasMaxLength(50);

                entity.Property(e => e.IzinIdList).HasColumnName("izinIdList");

                entity.Property(e => e.IzinKodu).HasMaxLength(3);

                entity.Property(e => e.KartNo).HasMaxLength(15);

                entity.Property(e => e.MesaiAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiBasSonrasiIlkGiris).HasColumnType("datetime");

                entity.Property(e => e.MesaiBitOncesiSonCikis).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.ResmiTatilAdi)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwSelectGunlukMesaiOzetGirisCikisEgo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectGunlukMesaiOzetGirisCikis_Ego");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisTarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisTarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.IzinDurumu).HasMaxLength(50);

                entity.Property(e => e.IzinIdList).HasColumnName("izinIdList");

                entity.Property(e => e.IzinKodu).HasMaxLength(3);

                entity.Property(e => e.KartNo).HasMaxLength(15);

                entity.Property(e => e.MesaiAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiBasSonrasiIlkGiris).HasColumnType("datetime");

                entity.Property(e => e.MesaiBitOncesiSonCikis).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.ResmiTatilAdi).HasMaxLength(50);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwSelectGunlukMesaiOzetGirisCikisMefa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectGunlukMesaiOzetGirisCikis_Mefa");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisTarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisTarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.IzinDurumu).HasMaxLength(50);

                entity.Property(e => e.IzinIdList).HasColumnName("izinIdList");

                entity.Property(e => e.IzinKodu).HasMaxLength(3);

                entity.Property(e => e.KartNo).HasMaxLength(15);

                entity.Property(e => e.MesaiAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiBasSonrasiIlkGiris).HasColumnType("datetime");

                entity.Property(e => e.MesaiBitOncesiSonCikis).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.ResmiTatilAdi).HasMaxLength(50);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwSelectGunlukMesaiOzetMefa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectGunlukMesaiOzet_Mefa");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisTarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisTarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.IzinDurumu).HasMaxLength(50);

                entity.Property(e => e.IzinIdList).HasColumnName("izinIdList");

                entity.Property(e => e.IzinKodu).HasMaxLength(3);

                entity.Property(e => e.KartNo).HasMaxLength(15);

                entity.Property(e => e.MesaiAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiBasSonrasiIlkGiris).HasColumnType("datetime");

                entity.Property(e => e.MesaiBitOncesiSonCikis).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.Okod2)
                    .HasMaxLength(50)
                    .HasColumnName("OKod2");

                entity.Property(e => e.Okod3)
                    .HasMaxLength(50)
                    .HasColumnName("OKod3");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.ResmiTatilAdi).HasMaxLength(50);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwSelectHataliGecisler>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectHataliGecisler");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BirimId).HasColumnName("BirimID");

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.MesaiAciklama).HasMaxLength(50);

                entity.Property(e => e.MesaiAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiId).HasColumnName("MesaiID");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1).HasMaxLength(50);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcKimlikNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwSelectIdealRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectIdealRaporu");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisZamani).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Fm).HasColumnName("FM");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisZamani).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IzinAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAd).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TatilAdi).HasMaxLength(50);
            });

            modelBuilder.Entity<VwSelectIdealRaporuEx>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectIdealRaporu_ex");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BasTarih).HasColumnType("datetime");

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BitTarih).HasColumnType("datetime");

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisZamani).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Fm).HasColumnName("FM");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisZamani).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IzinAdi).HasMaxLength(100);

                entity.Property(e => e.IzinKodu).HasMaxLength(3);

                entity.Property(e => e.MesaiAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAd).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TatilAdi).HasMaxLength(50);
            });

            modelBuilder.Entity<VwSelectIzin>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SelectIzin");

                entity.Property(e => e.Aciklama).HasMaxLength(100);

                entity.Property(e => e.Ad).HasMaxLength(20);

                entity.Property(e => e.BasTarih).HasColumnType("datetime");

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BitTarih).HasColumnType("datetime");

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IzinDurum)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.IzinTip).HasMaxLength(50);

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(20);

                entity.Property(e => e.Tarih).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<VwSelectIzinAki>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SelectIzinAkis");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AkisAdi).HasMaxLength(500);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwSelectIzinAkisDetay>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectIzinAkisDetay");

                entity.Property(e => e.Aciklama).HasMaxLength(500);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwSelectKameraEvent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectKameraEvents");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.FotoZamani).HasColumnType("datetime");

                entity.Property(e => e.GecisZamani).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.KameraAdi).HasMaxLength(150);

                entity.Property(e => e.KameraIp).HasMaxLength(250);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.ResimYolu).HasMaxLength(4000);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TerminalAdi).HasMaxLength(250);
            });

            modelBuilder.Entity<VwSelectKampOdaKalanRapor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectKampOdaKalanRapor");

                entity.Property(e => e.BlokAdi).HasMaxLength(150);

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.OdaAdi).HasMaxLength(150);
            });

            modelBuilder.Entity<VwSelectKisiselDetayliPuantaj>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectKisiselDetayliPuantaj");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.Devamsiz).HasMaxLength(50);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.IzinAdi).HasMaxLength(50);

                entity.Property(e => e.IzinDetayAciklama).HasMaxLength(500);

                entity.Property(e => e.IzinDurumu).HasMaxLength(50);

                entity.Property(e => e.MesaiAciklama)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.MesaiBaslangic).HasColumnType("datetime");

                entity.Property(e => e.MesaiBitis).HasColumnType("datetime");

                entity.Property(e => e.MesaiCikis).HasColumnType("datetime");

                entity.Property(e => e.MesaiGiris).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwSelectLedPanelEvent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_select_LedPanelEvents");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AracPlaka).HasMaxLength(15);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.CardId)
                    .HasMaxLength(15)
                    .HasColumnName("CardID");

                entity.Property(e => e.CardId26)
                    .HasMaxLength(50)
                    .HasColumnName("CardID26");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.EnEventName)
                    .HasMaxLength(150)
                    .HasColumnName("En_EventName");

                entity.Property(e => e.Eventtime).HasColumnType("datetime");

                entity.Property(e => e.GuvenlikNotu).HasMaxLength(50);

                entity.Property(e => e.KayitTipi).HasMaxLength(50);

                entity.Property(e => e.KullaniciAciklama).HasMaxLength(250);

                entity.Property(e => e.LedPanelAciklama).HasMaxLength(20);

                entity.Property(e => e.LedPanelAdi).HasMaxLength(500);

                entity.Property(e => e.LedPanelIp).HasMaxLength(100);

                entity.Property(e => e.Marka).HasMaxLength(250);

                entity.Property(e => e.Model).HasMaxLength(300);

                entity.Property(e => e.PictureId).HasMaxLength(500);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TerminalAdi).HasMaxLength(50);

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.TrEventName)
                    .HasMaxLength(150)
                    .HasColumnName("Tr_EventName");
            });

            modelBuilder.Entity<VwSelectMail1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_SelectMails");

                entity.Property(e => e.Ad).HasMaxLength(20);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.MailAdresi).HasMaxLength(250);

                entity.Property(e => e.MailYetkiAdi).HasMaxLength(50);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(20);
            });

            modelBuilder.Entity<VwSelectMailIzinliKisiler>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectMailIzinliKisiler");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.BolumId).HasColumnName("BolumID");

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAd).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.GorevId).HasColumnName("GorevID");

                entity.Property(e => e.IzinAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiBas).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwSelectMevcutPersonel>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectMevcutPersonel");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.BolumId).HasColumnName("BolumID");

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAd).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.GorevId).HasColumnName("GorevID");

                entity.Property(e => e.IzinAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiBas).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwSelectMobilPanelGirisCiki>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectMobilPanelGirisCikis");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.KomutAdi).HasMaxLength(100);

                entity.Property(e => e.KomutGrupAdi).HasMaxLength(100);

                entity.Property(e => e.KomutTarihi).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Yon)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwSelectOdalardakiSiciller>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectOdalardakiSiciller");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.OdaAdi).HasMaxLength(150);

                entity.Property(e => e.OlayZamani).HasColumnType("datetime");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PoolId).HasColumnName("PoolID");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.Sicilno).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TerminalAd).HasMaxLength(50);
            });

            modelBuilder.Entity<VwSelectOffgunler>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectOFFGunler");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.BolumId).HasColumnName("BolumID");

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAd).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.GorevId).HasColumnName("GorevID");

                entity.Property(e => e.IzinAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiBas).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwSelectPdk>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SelectPDKS");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Baslangic).HasColumnType("datetime");

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.Bitis).HasColumnType("datetime");

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasMaxLength(70);

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.ErkenDurum).HasMaxLength(80);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GecDurum).HasMaxLength(78);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IzinAciklama).HasMaxLength(500);

                entity.Property(e => e.IzinDurum).HasMaxLength(50);

                entity.Property(e => e.IzinId).HasColumnName("IzinID");

                entity.Property(e => e.MesaiAciklama).HasMaxLength(500);

                entity.Property(e => e.MesaiGrubAciklama).HasMaxLength(50);

                entity.Property(e => e.MesaiGrubAciklamasi).HasMaxLength(50);

                entity.Property(e => e.MesaiId).HasColumnName("MesaiID");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1).HasMaxLength(50);

                entity.Property(e => e.Okod2).HasMaxLength(50);

                entity.Property(e => e.Okod3).HasMaxLength(50);

                entity.Property(e => e.Okod4).HasMaxLength(50);

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TasnifId).HasColumnName("TasnifID");

                entity.Property(e => e.TatilDurum).HasMaxLength(50);
            });

            modelBuilder.Entity<VwSelectPdk1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SelectPDKS_");

                entity.Property(e => e.Ad).HasMaxLength(20);

                entity.Property(e => e.Baslangic).HasColumnType("datetime");

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.Bitis).HasColumnType("datetime");

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasMaxLength(70);

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.ErkenDurum).HasMaxLength(80);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GecDurum).HasMaxLength(78);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IzinDurum).HasMaxLength(50);

                entity.Property(e => e.IzinId).HasColumnName("IzinID");

                entity.Property(e => e.MesaiAciklama).HasMaxLength(50);

                entity.Property(e => e.MesaiGrubAciklamasi).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1).HasMaxLength(50);

                entity.Property(e => e.Okod2).HasMaxLength(50);

                entity.Property(e => e.Okod3).HasMaxLength(50);

                entity.Property(e => e.Okod4).HasMaxLength(50);

                entity.Property(e => e.Okod5).HasMaxLength(50);

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(20);

                entity.Property(e => e.TasnifId).HasColumnName("TasnifID");

                entity.Property(e => e.TatilDurum).HasMaxLength(50);
            });

            modelBuilder.Entity<VwSelectPdksIssYozgat>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SelectPDKS_IssYozgat");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Baslangic).HasColumnType("datetime");

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.Bitis).HasColumnType("datetime");

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasMaxLength(70);

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.ErkenDurum).HasMaxLength(80);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GecDurum).HasMaxLength(78);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IzinAciklama).HasMaxLength(500);

                entity.Property(e => e.IzinDurum).HasMaxLength(50);

                entity.Property(e => e.IzinId).HasColumnName("IzinID");

                entity.Property(e => e.MesaiAciklama).HasMaxLength(500);

                entity.Property(e => e.MesaiGrubAciklamasi).HasMaxLength(50);

                entity.Property(e => e.MesaiId).HasColumnName("MesaiID");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1).HasMaxLength(50);

                entity.Property(e => e.Okod2).HasMaxLength(50);

                entity.Property(e => e.Okod3).HasMaxLength(50);

                entity.Property(e => e.Okod4).HasMaxLength(50);

                entity.Property(e => e.Okod5).HasMaxLength(50);

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TasnifId).HasColumnName("TasnifID");

                entity.Property(e => e.TatilDurum).HasMaxLength(50);
            });

            modelBuilder.Entity<VwSelectPdksMeteksanSavunma>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SelectPDKS_MeteksanSavunma");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Baslangic).HasColumnType("datetime");

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.Bitis).HasColumnType("datetime");

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasMaxLength(70);

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.ErkenDurum)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GecDurum)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IzinAciklama).HasMaxLength(500);

                entity.Property(e => e.IzinDurum).HasMaxLength(50);

                entity.Property(e => e.IzinId).HasColumnName("IzinID");

                entity.Property(e => e.MesaiAciklama).HasMaxLength(500);

                entity.Property(e => e.MesaiGrubAciklamasi).HasMaxLength(50);

                entity.Property(e => e.MesaiId).HasColumnName("MesaiID");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1).HasMaxLength(50);

                entity.Property(e => e.Okod2).HasMaxLength(50);

                entity.Property(e => e.Okod3).HasMaxLength(50);

                entity.Property(e => e.Okod4).HasMaxLength(50);

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TasnifId).HasColumnName("TasnifID");

                entity.Property(e => e.TatilDurum).HasMaxLength(50);
            });

            modelBuilder.Entity<VwSelectPdkshataliHareket>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SelectPDKSHataliHareket");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Baslangic).HasColumnType("datetime");

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.Bitis).HasColumnType("datetime");

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasMaxLength(70);

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.ErkenDurum).HasMaxLength(80);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GecDurum).HasMaxLength(78);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IzinDurum).HasMaxLength(50);

                entity.Property(e => e.IzinId).HasColumnName("IzinID");

                entity.Property(e => e.MesaiAciklama).HasMaxLength(50);

                entity.Property(e => e.MesaiGrubAciklamasi).HasMaxLength(50);

                entity.Property(e => e.MesaiId).HasColumnName("MesaiID");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1).HasMaxLength(50);

                entity.Property(e => e.Okod2).HasMaxLength(50);

                entity.Property(e => e.Okod3).HasMaxLength(50);

                entity.Property(e => e.Okod4).HasMaxLength(50);

                entity.Property(e => e.Okod5).HasMaxLength(50);

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TasnifId).HasColumnName("TasnifID");

                entity.Property(e => e.TatilDurum).HasMaxLength(50);
            });

            modelBuilder.Entity<VwSelectPdksostimOsb>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SelectPDKSOstimOsb");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Baslangic).HasColumnType("datetime");

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.Bitis).HasColumnType("datetime");

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasMaxLength(70);

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.ErkenDurum).HasMaxLength(80);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GecDurum).HasMaxLength(78);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IzinAciklama).HasMaxLength(500);

                entity.Property(e => e.IzinDurum).HasMaxLength(50);

                entity.Property(e => e.IzinId).HasColumnName("IzinID");

                entity.Property(e => e.MesaiAciklama).HasMaxLength(500);

                entity.Property(e => e.MesaiGrubAciklamasi).HasMaxLength(50);

                entity.Property(e => e.MesaiId).HasColumnName("MesaiID");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1).HasMaxLength(50);

                entity.Property(e => e.Okod2).HasMaxLength(50);

                entity.Property(e => e.Okod3).HasMaxLength(50);

                entity.Property(e => e.Okod4).HasMaxLength(50);

                entity.Property(e => e.Okod5).HasMaxLength(50);

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TasnifId).HasColumnName("TasnifID");

                entity.Property(e => e.TatilDurum).HasMaxLength(50);
            });

            modelBuilder.Entity<VwSelectPersonelGirisCikisSure>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectPersonelGirisCikisSure");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.CikisTerminali).HasMaxLength(50);

                entity.Property(e => e.CikisZamani).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GirisTerminali).HasMaxLength(50);

                entity.Property(e => e.GirisZamani).HasColumnType("datetime");

                entity.Property(e => e.GlobalSicilId)
                    .HasMaxLength(50)
                    .HasColumnName("GlobalSicilID");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.MesaiAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwSelectPersonelGunSure>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectPersonelGunSure");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.CikisTerminali).HasMaxLength(250);

                entity.Property(e => e.CikisZamani).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GirisTerminali).HasMaxLength(250);

                entity.Property(e => e.GirisZamani).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.MesaiAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwSelectPool>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectPool");

                entity.Property(e => e.Ad)
                    .HasMaxLength(50)
                    .HasColumnName("ad");

                entity.Property(e => e.BirimAd).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.FirmaAd).HasMaxLength(500);

                entity.Property(e => e.FixedSicilNo).HasMaxLength(50);

                entity.Property(e => e.GorevAd).HasMaxLength(500);

                entity.Property(e => e.Kod)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PozisyonAd).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tcno)
                    .HasMaxLength(20)
                    .HasColumnName("TCNo");

                entity.Property(e => e.TerminalAd).HasMaxLength(250);

                entity.Property(e => e.TerminalNo).HasMaxLength(50);
            });

            modelBuilder.Entity<VwSelectPuantajAktarimAstor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectPuantajAktarim_Astor");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(500);

                entity.Property(e => e.BolumAdi).HasMaxLength(50);

                entity.Property(e => e.BolumAdiText).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisTarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisTarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.GorevTuru)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.IzinDurumu).HasMaxLength(50);

                entity.Property(e => e.IzinIdList).HasColumnName("izinIdList");

                entity.Property(e => e.IzinKodu).HasMaxLength(3);

                entity.Property(e => e.KartNo).HasMaxLength(15);

                entity.Property(e => e.MesaiAdi).HasMaxLength(500);

                entity.Property(e => e.MesaiBasSonrasiIlkGiris).HasColumnType("datetime");

                entity.Property(e => e.MesaiBitOncesiSonCikis).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.ResmiTatilAdi).HasMaxLength(50);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwSelectRfidevent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectRFIDEvents");

                entity.Property(e => e.Aciklama).HasMaxLength(90);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AracId).HasColumnName("AracID");

                entity.Property(e => e.AracPlaka).HasMaxLength(15);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.CardId)
                    .HasMaxLength(15)
                    .HasColumnName("CardID");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.FacilityCode).HasMaxLength(8);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.LokasyonAdi).HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.Rfidad)
                    .HasMaxLength(50)
                    .HasColumnName("RFIDAd");

                entity.Property(e => e.Rfidsoyad)
                    .HasMaxLength(50)
                    .HasColumnName("RFIDSoyad");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.Yon).HasMaxLength(50);
            });

            modelBuilder.Entity<VwSelectSicilAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectSicilAll");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tc)
                    .HasMaxLength(20)
                    .HasColumnName("TC");
            });

            modelBuilder.Entity<VwSelectSicilDetayRapor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectSicilDetayRapor");

                entity.Property(e => e.AcilDurum).HasMaxLength(150);

                entity.Property(e => e.AcilDurumTel).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Adres).HasMaxLength(100);

                entity.Property(e => e.AmirAdSoyad).HasMaxLength(101);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.Cinsiyet).HasMaxLength(10);

                entity.Property(e => e.DogumTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.DogumYeri).HasMaxLength(50);

                entity.Property(e => e.Egitim).HasMaxLength(200);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.GlobalSicilId)
                    .HasMaxLength(50)
                    .HasColumnName("GlobalSicilID");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.GorevTuru).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsCikisNedeniAdi).HasMaxLength(50);

                entity.Property(e => e.IsCikisNedeniSgk).HasColumnName("IsCikisNedeniSGK");

                entity.Property(e => e.IsCikisNedeniSgkadi)
                    .HasMaxLength(50)
                    .HasColumnName("IsCikisNedeniSGKAdi");

                entity.Property(e => e.KanGrubu).HasMaxLength(50);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SgkAdi).HasMaxLength(100);

                entity.Property(e => e.Sgkid).HasColumnName("SGKId");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SirketAdi).HasMaxLength(50);

                entity.Property(e => e.SonGecerlilikTarihi).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.StatuAdi).HasMaxLength(50);

                entity.Property(e => e.TaseronFirmaAdi).HasMaxLength(50);

                entity.Property(e => e.Tckn).HasMaxLength(20);

                entity.Property(e => e.Telefon1).HasMaxLength(20);

                entity.Property(e => e.Telefon2).HasMaxLength(20);
            });

            modelBuilder.Entity<VwSelectSicilIzinKural>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectSicilIzinKural");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.KuralAdi).HasMaxLength(50);

                entity.Property(e => e.KuralId).HasColumnName("KuralID");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);

                entity.Property(e => e.ToplamHakEdilenIzinGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ToplamKalanIzinGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ToplamKullanilanIzinGun).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VwSelectSicilOzlukRapor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectSicilOzlukRapor");

                entity.Property(e => e.Adi).HasMaxLength(100);

                entity.Property(e => e.Adres).HasMaxLength(300);

                entity.Property(e => e.AskerlikDurum).HasMaxLength(50);

                entity.Property(e => e.BabaAdi).HasMaxLength(100);

                entity.Property(e => e.BirimAdi).HasMaxLength(100);

                entity.Property(e => e.BrutUcret).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CepTelefon).HasMaxLength(100);

                entity.Property(e => e.Cezasi).HasMaxLength(500);

                entity.Property(e => e.CikisNeden).HasMaxLength(1000);

                entity.Property(e => e.Cinsiyet).HasMaxLength(100);

                entity.Property(e => e.DiplomaNotu).HasMaxLength(100);

                entity.Property(e => e.DogumTarih).HasColumnType("datetime");

                entity.Property(e => e.DogumYeri).HasMaxLength(100);

                entity.Property(e => e.Ehliyet).HasMaxLength(100);

                entity.Property(e => e.EhliyetVeBelgeTarihi)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EngelliEmekli).HasMaxLength(100);

                entity.Property(e => e.Eposta)
                    .HasMaxLength(100)
                    .HasColumnName("EPosta");

                entity.Property(e => e.EsiCalisyorMu).HasMaxLength(100);

                entity.Property(e => e.EskiBirim).HasMaxLength(1000);

                entity.Property(e => e.FiiliGorev).HasMaxLength(100);

                entity.Property(e => e.GorevAdi).HasMaxLength(200);

                entity.Property(e => e.GorevTarihi).HasMaxLength(100);

                entity.Property(e => e.GorevYeri).HasMaxLength(100);

                entity.Property(e => e.GorevlendirildigiYer).HasMaxLength(1000);

                entity.Property(e => e.HizmetGeciciGorev).HasMaxLength(100);

                entity.Property(e => e.HizmetKadro).HasMaxLength(100);

                entity.Property(e => e.Ilce).HasMaxLength(100);

                entity.Property(e => e.IsBasiTarih).HasColumnType("datetime");

                entity.Property(e => e.KadroDegisiklik).HasMaxLength(100);

                entity.Property(e => e.Kadrosu).HasMaxLength(1000);

                entity.Property(e => e.KanGrubu).HasMaxLength(100);

                entity.Property(e => e.MedeniDurum).HasMaxLength(100);

                entity.Property(e => e.MeslekKodu).HasMaxLength(100);

                entity.Property(e => e.MezunOlduguAlan).HasMaxLength(100);

                entity.Property(e => e.MezunOlduguBolum).HasMaxLength(100);

                entity.Property(e => e.MezunOlduguOkul).HasMaxLength(200);

                entity.Property(e => e.Mezuniyet).HasMaxLength(100);

                entity.Property(e => e.MezuniyetTarih).HasMaxLength(100);

                entity.Property(e => e.NufusIli).HasMaxLength(100);

                entity.Property(e => e.Odul).HasMaxLength(500);

                entity.Property(e => e.Referans).HasMaxLength(500);

                entity.Property(e => e.SendikaBilgisi).HasMaxLength(50);

                entity.Property(e => e.SendikaUnvani).HasMaxLength(100);

                entity.Property(e => e.SendikaUyeBaslangicTarih).HasColumnType("datetime");

                entity.Property(e => e.SendikaUyeBitisTarih).HasColumnType("datetime");

                entity.Property(e => e.Sertifika).HasMaxLength(500);

                entity.Property(e => e.SgkSicilNo).HasMaxLength(100);

                entity.Property(e => e.Soyadi).HasMaxLength(100);

                entity.Property(e => e.SozlesmeTuru).HasMaxLength(100);

                entity.Property(e => e.Tckn).HasMaxLength(100);

                entity.Property(e => e.TecilTarih).HasColumnType("datetime");

                entity.Property(e => e.UcretTipi).HasMaxLength(100);

                entity.Property(e => e.VekaletBilgi).HasMaxLength(1000);

                entity.Property(e => e.YabanciDil).HasMaxLength(100);

                entity.Property(e => e.YabanciDilSeviye).HasMaxLength(100);
            });

            modelBuilder.Entity<VwSelectTanimsizMesaiOdaSure>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SelectTanimsizMesaiOdaSure");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BirimId).HasColumnName("BirimID");

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.CikisTarminali).HasMaxLength(50);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.GirisTerminali).HasMaxLength(50);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.OdaAdi).HasMaxLength(150);

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Sure).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tarih).HasColumnType("date");

                entity.Property(e => e.ToplamSure).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VwSelectTerminalAlarmStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectTerminalAlarmStatus");

                entity.Property(e => e.Ad).HasMaxLength(150);

                entity.Property(e => e.CihazSokulmeDurum).HasMaxLength(150);

                entity.Property(e => e.CihazSonIslemZamani).HasColumnType("datetime");

                entity.Property(e => e.Eventtime).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Port).HasMaxLength(15);

                entity.Property(e => e.SicilNo).HasMaxLength(150);

                entity.Property(e => e.SonAlarm).HasColumnType("datetime");

                entity.Property(e => e.SonBaglantiOlayi).HasMaxLength(150);

                entity.Property(e => e.SonBaglantiZamani).HasColumnType("datetime");

                entity.Property(e => e.SonKapiDurumu).HasMaxLength(50);

                entity.Property(e => e.SonKapiIslemi).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(150);
            });

            modelBuilder.Entity<VwSelectTerminalErisim>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectTerminalErisim");

                entity.Property(e => e.HaritaId).HasColumnName("HaritaID");

                entity.Property(e => e.IlHaritaKod)
                    .HasMaxLength(50)
                    .HasColumnName("ilHaritaKod");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.SonErisim).HasColumnType("datetime");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");
            });

            modelBuilder.Entity<VwSelectTerminalYetki>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SelectTerminalYetki");

                entity.Property(e => e.Ad).HasMaxLength(20);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LokasyonId).HasColumnName("LokasyonID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(20);

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.YetkiAdi)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.YetkiDurum)
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwSelectTumSicilListesiRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SelectTumSicilListesiRaporu");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Adres).HasMaxLength(100);

                entity.Property(e => e.AmirAdi).HasMaxLength(101);

                entity.Property(e => e.AnneAdi).HasMaxLength(50);

                entity.Property(e => e.BabaAdi).HasMaxLength(50);

                entity.Property(e => e.Bilgi).HasColumnType("ntext");

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BirimKodu).HasColumnName("birimKodu");

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.BolumId).HasColumnName("BolumID");

                entity.Property(e => e.CepTelefon).HasMaxLength(20);

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.Cinsiyet).HasMaxLength(50);

                entity.Property(e => e.DogumTarihi).HasColumnType("date");

                entity.Property(e => e.DogumYeri).HasMaxLength(50);

                entity.Property(e => e.EgitimDurumu).HasMaxLength(50);

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.GorevId).HasColumnName("GorevID");

                entity.Property(e => e.KanGrubu).HasMaxLength(50);

                entity.Property(e => e.KayitliOlduguIl).HasMaxLength(50);

                entity.Property(e => e.MedeniHal).HasMaxLength(50);

                entity.Property(e => e.MesaiPeriyodu).HasMaxLength(50);

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.Okod2)
                    .HasMaxLength(50)
                    .HasColumnName("OKod2");

                entity.Property(e => e.Okod3)
                    .HasMaxLength(50)
                    .HasColumnName("OKod3");

                entity.Property(e => e.Okod4)
                    .HasMaxLength(50)
                    .HasColumnName("OKod4");

                entity.Property(e => e.Okod5)
                    .HasMaxLength(50)
                    .HasColumnName("OKod5");

                entity.Property(e => e.Okod6)
                    .HasMaxLength(50)
                    .HasColumnName("OKod6");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PictureId).HasMaxLength(500);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TelefonNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwSelectUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectUser");

                entity.Property(e => e.RoleName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(56);
            });

            modelBuilder.Entity<VwSelectUserLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectUserLogs");

                entity.Property(e => e.Ad).HasMaxLength(20);

                entity.Property(e => e.IslemAciklama).HasMaxLength(500);

                entity.Property(e => e.IslemAdi).HasMaxLength(50);

                entity.Property(e => e.Soyad).HasMaxLength(20);

                entity.Property(e => e.Tarih).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(56);
            });

            modelBuilder.Entity<VwSelectUsersAndRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SelectUsersAndRoles");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IsCikisNedeniSgk).HasColumnName("IsCikisNedeniSGK");

                entity.Property(e => e.RoleName).HasMaxLength(256);

                entity.Property(e => e.SgkbilgiTanim).HasColumnName("SGKBilgiTanim");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(56);
            });

            modelBuilder.Entity<VwSelectVardiyaliVardiyasizGirisCikisSure>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectVardiyaliVardiyasizGirisCikisSure");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.GlobalSicilId)
                    .HasMaxLength(50)
                    .HasColumnName("GlobalSicilID");

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwSelectYemekhaneGeci>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectYemekhaneGecis");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.GorevId).HasColumnName("GorevID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OgunAdi).HasMaxLength(150);

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.Okod2)
                    .HasMaxLength(50)
                    .HasColumnName("OKod2");

                entity.Property(e => e.Port).HasMaxLength(15);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);

                entity.Property(e => e.TerminalAdi).HasMaxLength(250);

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.YetkiAdi).HasMaxLength(90);

                entity.Property(e => e.YetkiId).HasColumnName("YetkiID");
            });

            modelBuilder.Entity<VwSelectYemekhaneSayi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectYemekhaneSayi");

                entity.Property(e => e.Adi).HasMaxLength(50);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyadi).HasMaxLength(50);
            });

            modelBuilder.Entity<VwSelectgecisresim>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectgecisresim");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Eventtime).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.Resim).HasColumnType("image");

                entity.Property(e => e.RowDataozetId).HasColumnName("RowDataozetID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TerminalAdi).HasMaxLength(50);

                entity.Property(e => e.Yon).HasMaxLength(50);
            });

            modelBuilder.Entity<VwSelectmail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectmail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MailAdresi).HasMaxLength(250);

                entity.Property(e => e.MailYetkiAdi).HasMaxLength(50);

                entity.Property(e => e.RaporDosyaAdi).HasMaxLength(50);
            });

            modelBuilder.Entity<VwSelectsize>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_selectsizes");

                entity.Property(e => e.SchemaName).HasMaxLength(128);

                entity.Property(e => e.TableName).HasMaxLength(128);

                entity.Property(e => e.TotalSpaceKb).HasColumnName("TotalSpaceKB");

                entity.Property(e => e.TotalSpaceMb)
                    .HasColumnType("numeric(36, 2)")
                    .HasColumnName("TotalSpaceMB");

                entity.Property(e => e.UnusedSpaceKb).HasColumnName("UnusedSpaceKB");

                entity.Property(e => e.UnusedSpaceMb)
                    .HasColumnType("numeric(36, 2)")
                    .HasColumnName("UnusedSpaceMB");

                entity.Property(e => e.UsedSpaceKb).HasColumnName("UsedSpaceKB");

                entity.Property(e => e.UsedSpaceMb)
                    .HasColumnType("numeric(36, 2)")
                    .HasColumnName("UsedSpaceMB");
            });

            modelBuilder.Entity<VwSicilAracListesi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SicilAracListesi");

                entity.Property(e => e.AracPlaka).HasMaxLength(11);

                entity.Property(e => e.SicilAdi).HasMaxLength(50);

                entity.Property(e => e.TagNo).HasMaxLength(50);
            });

            modelBuilder.Entity<VwSicilDetayRapor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SicilDetayRapor");

                entity.Property(e => e.AcilDurumIrtibatKisisi).HasMaxLength(100);

                entity.Property(e => e.AcilDurumIrtibatKisisiEvTel).HasMaxLength(100);

                entity.Property(e => e.AcilDurumIrtibatKisisiIsTel).HasMaxLength(100);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Adres).HasMaxLength(100);

                entity.Property(e => e.AmirAdi)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Bilgi).HasColumnType("ntext");

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.BolumId).HasColumnName("BolumID");

                entity.Property(e => e.CardId).HasMaxLength(15);

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GecerlilikSuresi).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.GorevId).HasColumnName("GorevID");

                entity.Property(e => e.Iban).HasMaxLength(100);

                entity.Property(e => e.IseBaslama).HasColumnType("smalldatetime");

                entity.Property(e => e.IseBaslamaString)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IstenAyrilisNedeni).HasMaxLength(500);

                entity.Property(e => e.IstenAyrilma).HasColumnType("smalldatetime");

                entity.Property(e => e.IstenAyrilmaString)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LokasyonAdi)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MesaiPeriyodu)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.Okod2)
                    .HasMaxLength(50)
                    .HasColumnName("OKod2");

                entity.Property(e => e.Okod3)
                    .HasMaxLength(50)
                    .HasColumnName("OKod3");

                entity.Property(e => e.Okod4)
                    .HasMaxLength(50)
                    .HasColumnName("OKod4");

                entity.Property(e => e.Okod5)
                    .HasMaxLength(50)
                    .HasColumnName("OKod5");

                entity.Property(e => e.Okod6)
                    .HasMaxLength(50)
                    .HasColumnName("OKod6");

                entity.Property(e => e.Okod7)
                    .HasMaxLength(50)
                    .HasColumnName("OKod7");

                entity.Property(e => e.Okod8)
                    .HasMaxLength(50)
                    .HasColumnName("OKod8");

                entity.Property(e => e.PictureId).HasMaxLength(500);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilInfo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tcno)
                    .HasMaxLength(20)
                    .HasColumnName("TCNo");

                entity.Property(e => e.TelefonNo).HasMaxLength(20);

                entity.Property(e => e.TelefonNo2).HasMaxLength(20);

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<VwSicilGecisGrupsuz>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SicilGecisGrupsuz");

                entity.Property(e => e.Ad)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AmirAdi)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BirimAdi)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BolumAdi)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EventCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Gorev)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GorevAdi)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Okod1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OKod1");

                entity.Property(e => e.Okod2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OKod2");

                entity.Property(e => e.Okod3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OKod3");

                entity.Property(e => e.PoolId).HasColumnName("PoolID");

                entity.Property(e => e.PozisyonAdi)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SicilNo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SirketAdi)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Soyad)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TaseronFirmaAdi)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TcNo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalAdi)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalGrupAdi)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Yon)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwSicilGirisCikisDinlenmeCalismaCizelge>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SicilGirisCikisDinlenmeCalismaCizelge");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis)
                    .HasColumnType("datetime")
                    .HasColumnName("cikis");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris)
                    .HasColumnType("datetime")
                    .HasColumnName("giris");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IzinIdList).HasMaxLength(250);

                entity.Property(e => e.IzinKodu).HasMaxLength(3);

                entity.Property(e => e.MesaiAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiBas).HasMaxLength(33);

                entity.Property(e => e.MesaiBit).HasMaxLength(33);

                entity.Property(e => e.MesaiKodu).HasMaxLength(3);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.Pozisyon)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("pozisyon");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TasnifId).HasColumnName("tasnifId");

                entity.Property(e => e.VarsayilanMesaiAdi).HasMaxLength(50);

                entity.Property(e => e.VarsayilanMesaiKodu).HasMaxLength(3);
            });

            modelBuilder.Entity<VwSicilOzlukRaporuMefa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SicilOzlukRaporu_Mefa");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AskerlikDurumu).HasMaxLength(50);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.CepTelefon).HasMaxLength(50);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.PantolonBeden).HasMaxLength(50);

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.ServisDurak).HasMaxLength(50);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TisortBeden).HasMaxLength(50);
            });

            modelBuilder.Entity<VwSicilSonGeci>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SicilSonGecis");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LokasyonAdi).HasMaxLength(500);

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwSicilSonGecisRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SicilSonGecisRaporu");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAd).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.FirmaAd).HasMaxLength(500);

                entity.Property(e => e.FirmaKodu).HasMaxLength(200);

                entity.Property(e => e.GorevAd).HasMaxLength(500);

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAd).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonGecis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TerminalAdi).HasMaxLength(250);
            });

            modelBuilder.Entity<VwSicilVeAracBilgileri>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SicilVeAracBilgileri");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Adres).HasMaxLength(100);

                entity.Property(e => e.AracPlaka).HasMaxLength(15);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BirimKodu).HasColumnName("birimKodu");

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.BolumId).HasColumnName("BolumID");

                entity.Property(e => e.CepTelefon).HasMaxLength(20);

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.GorevId).HasColumnName("GorevID");

                entity.Property(e => e.Marka).HasMaxLength(250);

                entity.Property(e => e.Model).HasMaxLength(300);

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.RuhsatNo).HasMaxLength(50);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TaseronFirmaAdi).HasMaxLength(200);

                entity.Property(e => e.Telefon1).HasMaxLength(20);

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<VwSicilYetkiGrubuwithTerminal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SicilYetkiGrubuwithTerminal");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(500);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Okod1).HasMaxLength(50);

                entity.Property(e => e.Okod2).HasMaxLength(50);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);

                entity.Property(e => e.TerminalAdi).HasMaxLength(250);

                entity.Property(e => e.YetkiAciklama).HasMaxLength(90);

                entity.Property(e => e.YetkiAdi).HasMaxLength(50);
            });

            modelBuilder.Entity<VwSirketBazliYemekhaneRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SirketBazliYemekhaneRaporu");

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.FirmaAd).HasMaxLength(500);

                entity.Property(e => e.Tarih).HasColumnType("date");

                entity.Property(e => e.TerminalAd).HasMaxLength(250);
            });

            modelBuilder.Entity<VwSodexoHesap>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SodexoHesap");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AdSoyad).HasMaxLength(101);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SodexoHi).HasColumnName("SodexoHI");

                entity.Property(e => e.SodexoHs).HasColumnName("SodexoHS");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tarih).HasColumnType("datetime");

                entity.Property(e => e.Tcnumarasi)
                    .HasMaxLength(20)
                    .HasColumnName("TCNumarasi");
            });

            modelBuilder.Entity<VwSodexoHesapOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SodexoHesap_old");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AdSoyad).HasMaxLength(101);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasMaxLength(70);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SodexoHi).HasColumnName("SodexoHI");

                entity.Property(e => e.SodexoHs).HasColumnName("SodexoHS");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tarih).HasColumnType("datetime");

                entity.Property(e => e.Tcnumarasi)
                    .HasMaxLength(20)
                    .HasColumnName("TCNumarasi");
            });

            modelBuilder.Entity<VwStgArgePersonelBazliAraGeci>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_StgArgePersonelBazliAraGecis");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Io).HasColumnName("IO");

                entity.Property(e => e.MesaiAciklama).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1).HasMaxLength(50);

                entity.Property(e => e.Okod2).HasMaxLength(50);

                entity.Property(e => e.Okod3).HasMaxLength(50);

                entity.Property(e => e.Okod4).HasMaxLength(50);

                entity.Property(e => e.Okod5).HasMaxLength(50);

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TerminalAdi).HasMaxLength(250);
            });

            modelBuilder.Entity<VwStm2018arge>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_STM2018ARGE");

                entity.Property(e => e.AdSoyad).HasMaxLength(101);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.Gun).HasColumnName("gun");

                entity.Property(e => e.Hafta).HasColumnName("hafta");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("tarih");
            });

            modelBuilder.Entity<VwTableSize>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_TableSize");

                entity.Property(e => e.SchemaName).HasMaxLength(128);

                entity.Property(e => e.TableName).HasMaxLength(128);

                entity.Property(e => e.TotalSpaceKb).HasColumnName("TotalSpaceKB");

                entity.Property(e => e.TotalSpaceMb)
                    .HasColumnType("numeric(36, 2)")
                    .HasColumnName("TotalSpaceMB");

                entity.Property(e => e.UnusedSpaceKb).HasColumnName("UnusedSpaceKB");

                entity.Property(e => e.UnusedSpaceMb)
                    .HasColumnType("numeric(36, 2)")
                    .HasColumnName("UnusedSpaceMB");

                entity.Property(e => e.UsedSpaceKb).HasColumnName("UsedSpaceKB");

                entity.Property(e => e.UsedSpaceMb)
                    .HasColumnType("numeric(36, 2)")
                    .HasColumnName("UsedSpaceMB");
            });

            modelBuilder.Entity<VwTasnifAragecisDetaylari>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_TasnifAragecisDetaylari");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.CikisTerminali).HasMaxLength(250);

                entity.Property(e => e.CikisZamani).HasColumnType("datetime");

                entity.Property(e => e.FazlaMesaiNedeni).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GerceklesenMesaiAdi).HasMaxLength(50);

                entity.Property(e => e.GirisTerminali).HasMaxLength(250);

                entity.Property(e => e.GirisZamani).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IlkGiris).HasColumnType("datetime");

                entity.Property(e => e.IzinIdList).HasMaxLength(250);

                entity.Property(e => e.MesaiAdi).HasMaxLength(50);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SonCikis).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TalepEdilenFmsure).HasColumnName("TalepEdilenFMSure");

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwTasnifDisiGecisler>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_TasnifDisiGecisler");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tcno)
                    .HasMaxLength(20)
                    .HasColumnName("TCNo");

                entity.Property(e => e.TerminalAdi).HasMaxLength(250);

                entity.Property(e => e.Yon).HasMaxLength(50);
            });

            modelBuilder.Entity<VwTerminalErisim>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_terminalErisim");
            });

            modelBuilder.Entity<VwTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Test");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwTimeSheetReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_TimeSheetReport");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TypeOfHourseWorked)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwToleransliOdaIcerideDisaridum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ToleransliOdaIcerideDisarida");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis)
                    .HasColumnType("datetime")
                    .HasColumnName("cikis");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris)
                    .HasColumnType("datetime")
                    .HasColumnName("giris");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.OdaAdi).HasMaxLength(150);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwToplamOdalardakiSicilSayisi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ToplamOdalardakiSicilSayisi");

                entity.Property(e => e.Ad).HasMaxLength(101);

                entity.Property(e => e.OdaAdi).HasMaxLength(150);

                entity.Property(e => e.SonGecis).HasColumnType("datetime");

                entity.Property(e => e.Soyad)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalAdi).HasMaxLength(50);
            });

            modelBuilder.Entity<VwTpicozelRaporField>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_TPICOzelRaporFields");

                entity.Property(e => e.Ad)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Birim)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Bolum)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.Firma)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.Gorev)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IzinAciklama)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Pozisyon)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SicilNo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Soyad)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Tcno)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TCNO");
            });

            modelBuilder.Entity<VwTumGirisCikisRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_TumGirisCikisRaporu");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.FirmaAd).HasMaxLength(500);

                entity.Property(e => e.GorevAd).HasMaxLength(500);

                entity.Property(e => e.Io).HasColumnName("IO");

                entity.Property(e => e.KartNo).HasMaxLength(15);

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAd).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TerminalName).HasMaxLength(250);
            });

            modelBuilder.Entity<VwTumIzinListesi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_TumIzinListesi");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BasTarih).HasColumnType("datetime");

                entity.Property(e => e.BitTarih).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Gun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IzinIslemDurumAdi).HasMaxLength(50);

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TipId).HasColumnName("TipID");
            });

            modelBuilder.Entity<VwUnauthorizedCardAccess>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UnauthorizedCardAccess");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAd).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.CardId)
                    .HasMaxLength(100)
                    .HasColumnName("CardID");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAd).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TerminalAd).HasMaxLength(250);

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<VwUnauthorizedCardAccessGateIo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UnauthorizedCardAccessGateIO");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAd).HasMaxLength(150);

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.CardId)
                    .HasMaxLength(250)
                    .HasColumnName("CardID");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAd).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TerminalAd).HasMaxLength(250);

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<VwUsersInrole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UsersInroles");
            });

            modelBuilder.Entity<VwUygunKartlar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UygunKartlar");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<VwVakoAylikPuantaj>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_VakoAylikPuantaj");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.CardId).HasMaxLength(15);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.IzinAciklama).HasMaxLength(500);

                entity.Property(e => e.IzinBasTarih).HasColumnType("datetime");

                entity.Property(e => e.IzinBitTarih).HasColumnType("datetime");

                entity.Property(e => e.IzinGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IzinKod).HasMaxLength(3);

                entity.Property(e => e.IzinTipAciklama).HasMaxLength(50);

                entity.Property(e => e.MesaiAciklama).HasMaxLength(500);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.Okod2)
                    .HasMaxLength(50)
                    .HasColumnName("OKod2");

                entity.Property(e => e.Okod3)
                    .HasMaxLength(50)
                    .HasColumnName("OKod3");

                entity.Property(e => e.Okod4)
                    .HasMaxLength(50)
                    .HasColumnName("OKod4");

                entity.Property(e => e.Okod5).HasColumnName("OKod5");

                entity.Property(e => e.Okod6)
                    .HasMaxLength(50)
                    .HasColumnName("OKod6");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tcno)
                    .HasMaxLength(20)
                    .HasColumnName("TCNo");
            });

            modelBuilder.Entity<VwVardiyaSelect>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_VardiyaSelect");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BirimId).HasColumnName("BirimID");

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.BolumId).HasColumnName("BolumID");

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MesaiAdi).HasMaxLength(50);

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<VwVardiyasizMesaiOzet>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_VardiyasizMesaiOzet");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.SirketAdi).HasMaxLength(50);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TaseronFirmaAdi).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);
            });

            modelBuilder.Entity<VwWcgecisler>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_WCGecisler");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.Idno)
                    .HasMaxLength(20)
                    .HasColumnName("IDNo");

                entity.Property(e => e.Lokasyon).HasMaxLength(500);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tarih).HasColumnType("date");

                entity.Property(e => e.TerminalAdiCikis).HasMaxLength(70);

                entity.Property(e => e.TerminalAdiGiris).HasMaxLength(70);
            });

            modelBuilder.Entity<VwYemekHaneDetayliRapor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_YemekHaneDetayliRapor");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SonOkutmaSaati).HasColumnType("datetime");

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<VwYemekhaneFirma>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_YemekhaneFirma");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.OgunAdi).HasMaxLength(150);

                entity.Property(e => e.Tarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwYemekhaneOgunRaporlari>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_YemekhaneOgunRaporlari");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.GorevId).HasColumnName("GorevID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.Okod2)
                    .HasMaxLength(50)
                    .HasColumnName("OKod2");

                entity.Property(e => e.Port).HasMaxLength(15);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TcNo).HasMaxLength(20);

                entity.Property(e => e.TerminalAdi).HasMaxLength(250);

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.YetkiAdi).HasMaxLength(90);

                entity.Property(e => e.YetkiId).HasColumnName("YetkiID");
            });

            modelBuilder.Entity<VwYemekhaneOgunRaporu0421>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_YemekhaneOgunRaporu_0421");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevId).HasColumnName("GorevID");

                entity.Property(e => e.Ogun).HasMaxLength(150);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Terminal).HasMaxLength(250);

                entity.Property(e => e.Zaman).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwYillikDetayliFazlaMesai>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_YillikDetayliFazlaMesai");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwYillikDetayliFm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_YillikDetayliFM");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Agustos).HasMaxLength(10);

                entity.Property(e => e.Aralik).HasMaxLength(10);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.CikisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.Ekim).HasMaxLength(10);

                entity.Property(e => e.Eylul).HasMaxLength(10);

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Haziran).HasMaxLength(10);

                entity.Property(e => e.Kasim).HasMaxLength(10);

                entity.Property(e => e.Mart).HasMaxLength(10);

                entity.Property(e => e.Mayis).HasMaxLength(10);

                entity.Property(e => e.Nisan).HasMaxLength(10);

                entity.Property(e => e.Ocak).HasMaxLength(10);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.PozisyonId).HasColumnName("PozisyonID");

                entity.Property(e => e.ResmiTatilFm).HasColumnName("ResmiTatilFM");

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Subat).HasMaxLength(10);

                entity.Property(e => e.TcNo).HasMaxLength(20);

                entity.Property(e => e.Temmuz).HasMaxLength(10);

                entity.Property(e => e.Toplam).HasMaxLength(10);
            });

            modelBuilder.Entity<VwYillikHakedilenveKalanIzin>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_YillikHakedilenveKalanIzin");

                entity.Property(e => e.Aciklama).HasMaxLength(500);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BakiyeFarkiGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BasTarih).HasColumnType("datetime");

                entity.Property(e => e.BirimAd).HasMaxLength(150);

                entity.Property(e => e.BitTarih).HasColumnType("datetime");

                entity.Property(e => e.BolumAd).HasMaxLength(500);

                entity.Property(e => e.DogumTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.FirmaAd).HasMaxLength(500);

                entity.Property(e => e.GirisTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.GorevAd).HasMaxLength(500);

                entity.Property(e => e.Gun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HakEdilenGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IzinKuralAd).HasMaxLength(50);

                entity.Property(e => e.KalanIzinGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAd).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.ToplamKullanilanIzinGun).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.YillikHakEdilenTarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwYolUcretiRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_YolUcretiRaporu");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.DonusYolUcret).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MesaiAciklama).HasMaxLength(50);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Tarih).HasColumnType("datetime");

                entity.Property(e => e.Toplam).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.YolUcret).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VwZiyaretciHareketleri>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ZiyaretciHareketleri");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.BirimAdi).HasMaxLength(150);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.EventCode).HasMaxLength(50);

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.FirmaAdi).HasMaxLength(500);

                entity.Property(e => e.GorevAdi).HasMaxLength(500);

                entity.Property(e => e.Okod1)
                    .HasMaxLength(50)
                    .HasColumnName("OKod1");

                entity.Property(e => e.Okod2)
                    .HasMaxLength(50)
                    .HasColumnName("OKod2");

                entity.Property(e => e.Okod3)
                    .HasMaxLength(50)
                    .HasColumnName("OKod3");

                entity.Property(e => e.Okod4)
                    .HasMaxLength(50)
                    .HasColumnName("OKod4");

                entity.Property(e => e.Okod5)
                    .HasMaxLength(50)
                    .HasColumnName("OKod5");

                entity.Property(e => e.PersonelNo).HasMaxLength(20);

                entity.Property(e => e.PozisyonAdi).HasMaxLength(500);

                entity.Property(e => e.SicilNo).HasMaxLength(20);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.TerminalAdi).HasMaxLength(250);

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.Property(e => e.Yon).HasMaxLength(50);
            });

            modelBuilder.Entity<VwZiyaretciListesi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Ziyaretci_Listesi");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Bilgi).HasColumnType("ntext");

                entity.Property(e => e.BirimAdi).HasMaxLength(500);

                entity.Property(e => e.BolumAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("smalldatetime");

                entity.Property(e => e.DogumTarihi).HasColumnType("datetime");

                entity.Property(e => e.DogumYeri).HasMaxLength(50);

                entity.Property(e => e.Firma).HasMaxLength(50);

                entity.Property(e => e.Giris).HasColumnType("smalldatetime");

                entity.Property(e => e.HesCode).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.KameraResim).HasColumnType("image");

                entity.Property(e => e.KimlikNo).HasMaxLength(30);

                entity.Property(e => e.Kisi1).HasMaxLength(122);

                entity.Property(e => e.Kisi2).HasMaxLength(122);

                entity.Property(e => e.LokasyonAd).HasMaxLength(500);

                entity.Property(e => e.LokasyonId).HasColumnName("LokasyonID");

                entity.Property(e => e.Plaka).HasMaxLength(15);

                entity.Property(e => e.ResimId).HasMaxLength(500);

                entity.Property(e => e.RuhsatSeriNo).HasMaxLength(50);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.Telefon).HasMaxLength(20);

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(56);

                entity.Property(e => e.ZiyaretNedeni).HasMaxLength(100);

                entity.Property(e => e.ZiyaretciKart).HasMaxLength(101);
            });

            modelBuilder.Entity<VwZiyaretciListesiLokasyon>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Ziyaretci_Listesi_Lokasyon");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Bilgi).HasColumnType("ntext");

                entity.Property(e => e.BirimAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("smalldatetime");

                entity.Property(e => e.DogumTarihi).HasColumnType("datetime");

                entity.Property(e => e.DogumYeri).HasMaxLength(50);

                entity.Property(e => e.Firma).HasMaxLength(50);

                entity.Property(e => e.Giris).HasColumnType("smalldatetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.KameraResim).HasColumnType("image");

                entity.Property(e => e.KimlikNo).HasMaxLength(30);

                entity.Property(e => e.Kisi1).HasMaxLength(101);

                entity.Property(e => e.Kisi2).HasMaxLength(101);

                entity.Property(e => e.LokasyonAd).HasMaxLength(500);

                entity.Property(e => e.LokasyonId).HasColumnName("LokasyonID");

                entity.Property(e => e.Plaka).HasMaxLength(15);

                entity.Property(e => e.ResimId).HasMaxLength(500);

                entity.Property(e => e.RuhsatSeriNo).HasMaxLength(50);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(56);

                entity.Property(e => e.ZiyaretNedeni).HasMaxLength(100);

                entity.Property(e => e.ZiyaretciKart).HasMaxLength(101);
            });

            modelBuilder.Entity<VwZiyaretciRapor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ZiyaretciRapor");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ad)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Bilgi)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BirimAdi)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BirimId).HasColumnName("BirimID");

                entity.Property(e => e.BolumAdiBir)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BolumAdiIki)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Cikis).HasColumnType("datetime");

                entity.Property(e => e.CikisStr)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DogumTarih).HasColumnType("datetime");

                entity.Property(e => e.DogumYeri)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Firma)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Giris).HasColumnType("datetime");

                entity.Property(e => e.GirisStr)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HesCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IlkKartOkuma).HasColumnType("datetime");

                entity.Property(e => e.IlkTerminalName)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Kadi)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Kid).HasColumnName("KId");

                entity.Property(e => e.Kime)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.KullaniciAdi)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LoginName)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LokasyonAdi)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Plaka)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Pozisyon)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ResimId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ResimID");

                entity.Property(e => e.RuhsatSeriNo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SicilId1).HasColumnName("SicilID1");

                entity.Property(e => e.SicilId1info)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SicilID1Info");

                entity.Property(e => e.SicilId2).HasColumnName("SicilID2");

                entity.Property(e => e.SicilId2info)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SicilID2Info");

                entity.Property(e => e.SicilId3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SicilID3");

                entity.Property(e => e.SicilNo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SonKartOkuma).HasColumnType("datetime");

                entity.Property(e => e.SonTerminalName)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Soyad)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SurucuBelgeNo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TarihStr)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TcKimlikNo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Uyruk)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZiyaretNedeni)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZiyaretciKartAdi)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WebpagesMembership>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__webpages__1788CC4C6BE981A3");

                entity.ToTable("webpages_Membership");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.ConfirmationToken).HasMaxLength(128);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.IsConfirmed).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastPasswordFailureDate).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(128);

                entity.Property(e => e.PasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.PasswordSalt).HasMaxLength(128);

                entity.Property(e => e.PasswordVerificationToken).HasMaxLength(128);

                entity.Property(e => e.PasswordVerificationTokenExpirationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<WebpagesOauthMembership>(entity =>
            {
                entity.HasKey(e => new { e.Provider, e.ProviderUserId })
                    .HasName("PK__webpages__F53FC0ED145AA4AB");

                entity.ToTable("webpages_OAuthMembership");

                entity.Property(e => e.Provider).HasMaxLength(30);

                entity.Property(e => e.ProviderUserId).HasMaxLength(100);
            });

            modelBuilder.Entity<WebpagesRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__webpages__8AFACE1A9A97DD1A");

                entity.ToTable("webpages_Roles");

                entity.HasIndex(e => e.RoleName, "UQ__webpages__8A2B616098F4D9ED")
                    .IsUnique();

                entity.Property(e => e.RoleName).HasMaxLength(256);
            });

            modelBuilder.Entity<YapilacakFazlaMesaiOnaylar>(entity =>
            {
                entity.ToTable("YapilacakFazlaMesaiOnaylar");

                entity.Property(e => e.IslemTarih).HasColumnType("datetime");

                entity.Property(e => e.KayitTarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<YapilacakFazlaMesailer>(entity =>
            {
                entity.ToTable("YapilacakFazlaMesailer");

                entity.Property(e => e.Aciklama).HasMaxLength(250);

                entity.Property(e => e.Baslangic).HasColumnType("datetime");

                entity.Property(e => e.Bitis).HasColumnType("datetime");

                entity.Property(e => e.MesaiTarih).HasColumnType("datetime");

                entity.Property(e => e.TalepTarihi).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Yasaklar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("yasaklar");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(500)
                    .HasColumnName("aciklama");

                entity.Property(e => e.Aktif)
                    .HasColumnName("aktif")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Baslangic)
                    .HasColumnType("datetime")
                    .HasColumnName("baslangic");

                entity.Property(e => e.Bitis)
                    .HasColumnType("datetime")
                    .HasColumnName("bitis");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.SicilId).HasColumnName("sicilId");

                entity.Property(e => e.Suresiz).HasColumnName("suresiz");
            });

            modelBuilder.Entity<Yemekhane>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Yemekhane");

                entity.Property(e => e.EkKredi).HasDefaultValueSql("((0))");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Kredi).HasDefaultValueSql("((0))");

                entity.Property(e => e.Kredi1).HasColumnName("Kredi+");

                entity.Property(e => e.SicilId).HasColumnName("SicilID");

                entity.Property(e => e.Tarih).HasColumnType("smalldatetime");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");

                entity.HasOne(d => d.Sicil)
                    .WithMany()
                    .HasForeignKey(d => d.SicilId)
                    .HasConstraintName("FK_Yemekhane_Sicil");
            });

            modelBuilder.Entity<YemekhaneDuty>(entity =>
            {
                entity.ToTable("YemekhaneDuty");

                entity.Property(e => e.DeviceMessage).HasMaxLength(500);

                entity.Property(e => e.Owner)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Process)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.RecordDate).HasColumnType("datetime");

                entity.Property(e => e.TargetDevice)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TimeZoneId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TimeZoneID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userID");
            });

            modelBuilder.Entity<Yetki>(entity =>
            {
                entity.ToTable("Yetki");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aciklama).HasMaxLength(500);

                entity.Property(e => e.AciklamaDetay).HasMaxLength(200);
            });

            modelBuilder.Entity<YetkiLog>(entity =>
            {
                entity.ToTable("Yetki_Log");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aciklama).HasMaxLength(90);

                entity.Property(e => e.AciklamaDetay).HasMaxLength(200);

                entity.Property(e => e.IslemDatetime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Yuvarlamalar>(entity =>
            {
                entity.ToTable("Yuvarlamalar");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MesaiId).HasColumnName("MesaiID");

                entity.Property(e => e.Saat1).HasColumnType("smalldatetime");

                entity.Property(e => e.Saat2).HasColumnType("smalldatetime");

                entity.Property(e => e.Saat3).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Mesai)
                    .WithMany(p => p.Yuvarlamalars)
                    .HasForeignKey(d => d.MesaiId)
                    .HasConstraintName("FK_Yuvarlamalar_Mesailer");
            });

            modelBuilder.Entity<Ziyaretci>(entity =>
            {
                entity.ToTable("Ziyaretci");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Bilgi).HasColumnType("ntext");

                entity.Property(e => e.Cikis).HasColumnType("smalldatetime");

                entity.Property(e => e.DogumTarihi).HasColumnType("datetime");

                entity.Property(e => e.DogumYeri).HasMaxLength(50);

                entity.Property(e => e.Firma).HasMaxLength(50);

                entity.Property(e => e.Giris).HasColumnType("smalldatetime");

                entity.Property(e => e.HesCode).HasMaxLength(50);

                entity.Property(e => e.IlkKartOkuma).HasColumnType("datetime");

                entity.Property(e => e.IlkKartOkumaTerminal).HasMaxLength(200);

                entity.Property(e => e.Imza).HasColumnType("smalldatetime");

                entity.Property(e => e.KameraResim).HasColumnType("image");

                entity.Property(e => e.Kime).HasMaxLength(500);

                entity.Property(e => e.KimlikNo).HasMaxLength(30);

                entity.Property(e => e.KimlikTipi).HasDefaultValueSql("((0))");

                entity.Property(e => e.Plaka).HasMaxLength(15);

                entity.Property(e => e.ResimId).HasMaxLength(500);

                entity.Property(e => e.RuhsatSeriNo).HasMaxLength(50);

                entity.Property(e => e.SicilId1).HasColumnName("SicilID1");

                entity.Property(e => e.SicilId2).HasColumnName("SicilID2");

                entity.Property(e => e.SicilId3).HasColumnName("SicilID3");

                entity.Property(e => e.SonKartOkuma).HasColumnType("datetime");

                entity.Property(e => e.SonKartOkumaTerminal).HasMaxLength(200);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.SurucuBelgeNo).HasMaxLength(50);

                entity.Property(e => e.Telefon).HasMaxLength(20);

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .HasColumnName("UserID");

                entity.Property(e => e.ZiyaretNedeni).HasMaxLength(100);

                entity.HasOne(d => d.KimlikTipiNavigation)
                    .WithMany(p => p.Ziyaretcis)
                    .HasForeignKey(d => d.KimlikTipi)
                    .HasConstraintName("FK_Ziyaretci_cbo_Kimlik");
            });

            modelBuilder.Entity<ZiyaretciListesi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Ziyaretci_Listesi");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Bilgi).HasColumnType("ntext");

                entity.Property(e => e.BirimAdi).HasMaxLength(500);

                entity.Property(e => e.Cikis).HasColumnType("smalldatetime");

                entity.Property(e => e.DogumTarihi).HasColumnType("datetime");

                entity.Property(e => e.DogumYeri).HasMaxLength(50);

                entity.Property(e => e.Firma).HasMaxLength(50);

                entity.Property(e => e.Giris).HasColumnType("smalldatetime");

                entity.Property(e => e.HesCode).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.KimlikNo).HasMaxLength(30);

                entity.Property(e => e.Kisi1).HasMaxLength(122);

                entity.Property(e => e.Kisi2).HasMaxLength(122);

                entity.Property(e => e.Plaka).HasMaxLength(15);

                entity.Property(e => e.ResimId).HasMaxLength(500);

                entity.Property(e => e.RuhsatSeriNo).HasMaxLength(50);

                entity.Property(e => e.SicilId1).HasColumnName("SicilID1");

                entity.Property(e => e.SicilId2).HasColumnName("SicilID2");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.SurucuBelgeNo).HasMaxLength(50);

                entity.Property(e => e.Telefon).HasMaxLength(20);

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(56);

                entity.Property(e => e.ZiyaretNedeni).HasMaxLength(100);

                entity.Property(e => e.ZiyaretciKart).HasMaxLength(101);
            });

            modelBuilder.Entity<ZiyaretciLog>(entity =>
            {
                entity.ToTable("Ziyaretci_Log");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Bilgi).HasColumnType("ntext");

                entity.Property(e => e.Cikis).HasColumnType("smalldatetime");

                entity.Property(e => e.DogumTarihi).HasColumnType("datetime");

                entity.Property(e => e.DogumYeri).HasMaxLength(50);

                entity.Property(e => e.Firma).HasMaxLength(50);

                entity.Property(e => e.Giris).HasColumnType("smalldatetime");

                entity.Property(e => e.HesCode).HasMaxLength(50);

                entity.Property(e => e.Imza).HasColumnType("smalldatetime");

                entity.Property(e => e.IslemDatetime).HasColumnType("datetime");

                entity.Property(e => e.KameraResim).HasColumnType("image");

                entity.Property(e => e.Kime).HasMaxLength(500);

                entity.Property(e => e.KimlikNo).HasMaxLength(30);

                entity.Property(e => e.Plaka).HasMaxLength(15);

                entity.Property(e => e.ResimId).HasMaxLength(500);

                entity.Property(e => e.RuhsatSeriNo).HasMaxLength(50);

                entity.Property(e => e.SicilId1).HasColumnName("SicilID1");

                entity.Property(e => e.SicilId2).HasColumnName("SicilID2");

                entity.Property(e => e.SicilId3).HasColumnName("SicilID3");

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.Property(e => e.SurucuBelgeNo).HasMaxLength(50);

                entity.Property(e => e.Telefon).HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .HasColumnName("UserID");

                entity.Property(e => e.ZiyaretNedeni).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
