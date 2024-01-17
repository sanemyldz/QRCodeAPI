using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Terminaller
    {
        public Terminaller()
        {
            ClockworkBellControls = new HashSet<ClockworkBellControl>();
            MobilKomuts = new HashSet<MobilKomut>();
            TblLedPanels = new HashSet<TblLedPanel>();
            TblSicilYemekhanes = new HashSet<TblSicilYemekhane>();
            TblTerminalUrunGrubus = new HashSet<TblTerminalUrunGrubu>();
            TerminalAcu121s = new HashSet<TerminalAcu121>();
            TerminalRelations = new HashSet<TerminalRelation>();
            UserListIndices = new HashSet<UserListIndex>();
        }

        public int Id { get; set; }
        public string? MobilCihazKimlikNo { get; set; }
        public string Name { get; set; } = null!;
        public int Model { get; set; }
        public string Port { get; set; } = null!;
        public int ControllerNo { get; set; }
        public int Io { get; set; }
        public int Function { get; set; }
        public int OpMode { get; set; }
        public int Kind { get; set; }
        public int? X { get; set; }
        public int? Y { get; set; }
        public string? SonGecen { get; set; }
        public DateTime? SonTarih { get; set; }
        public DateTime? ZamanKontrol { get; set; }
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public DateTime ConnectionTime { get; set; }
        public DateTime LastEventTime { get; set; }
        public int LongLogPeriod { get; set; }
        public int ShortLogPeriod { get; set; }
        public string SourceName { get; set; } = null!;
        public string CardFormat { get; set; } = null!;
        public int? PingCheck { get; set; }
        public int? Debug { get; set; }
        public int? TimeSend { get; set; }
        public int? ReaderCount { get; set; }
        public DateTime? LastAccounted { get; set; }
        public string? Door { get; set; }
        public int? X3 { get; set; }
        public int OperationMode { get; set; }
        public int Limit { get; set; }
        public int? FirmaId { get; set; }
        public DateTime? DoorStatusTime { get; set; }
        public string? Lokasyon { get; set; }
        public int? LastId { get; set; }
        public DateTime SonGelenKayitZamani { get; set; }
        public int? PanelPortNo { get; set; }
        public bool Deleted { get; set; }
        public string? LedPanoIp { get; set; }
        public int? LedPanoPort { get; set; }
        public int? Otopark1 { get; set; }
        public int? Otopark2 { get; set; }
        public string? OtoparkMesaj { get; set; }
        public string SourceDeviceId { get; set; } = null!;
        public int RelayId { get; set; }
        public int DeviceType { get; set; }
        public int RelayTime { get; set; }
        public int TemplateOnCard { get; set; }
        public int Temperature { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public bool? Connected { get; set; }
        public int? DinamikLokasyonId { get; set; }
        public bool SanalTerminal { get; set; }
        public string? Aciklama { get; set; }
        public string? Longitude { get; set; }
        public string? Latitude { get; set; }
        public int? QrInRangeRadiusInMeters { get; set; }

        public virtual TerminalPort PortNavigation { get; set; } = null!;
        public virtual ICollection<ClockworkBellControl> ClockworkBellControls { get; set; }
        public virtual ICollection<MobilKomut> MobilKomuts { get; set; }
        public virtual ICollection<TblLedPanel> TblLedPanels { get; set; }
        public virtual ICollection<TblSicilYemekhane> TblSicilYemekhanes { get; set; }
        public virtual ICollection<TblTerminalUrunGrubu> TblTerminalUrunGrubus { get; set; }
        public virtual ICollection<TerminalAcu121> TerminalAcu121s { get; set; }
        public virtual ICollection<TerminalRelation> TerminalRelations { get; set; }
        public virtual ICollection<UserListIndex> UserListIndices { get; set; }
    }
}
