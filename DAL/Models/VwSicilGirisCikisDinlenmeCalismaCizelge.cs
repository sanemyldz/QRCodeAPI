﻿using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSicilGirisCikisDinlenmeCalismaCizelge
    {
        public int Id { get; set; }
        public int SicilId { get; set; }
        public string SicilNo { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public int TasnifId { get; set; }
        public DateTime MesaiTarih { get; set; }
        public int ResmiTatil { get; set; }
        public int Tatil { get; set; }
        public string IzinIdList { get; set; } = null!;
        public string Aciklama { get; set; } = null!;
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }
        public string Pozisyon { get; set; } = null!;
        public string? MesaiBas { get; set; }
        public string? MesaiBit { get; set; }
        public string FirmaAdi { get; set; } = null!;
        public int FirmaId { get; set; }
        public string BolumAdi { get; set; } = null!;
        public int BolumId { get; set; }
        public string GorevAdi { get; set; } = null!;
        public int GorevId { get; set; }
        public int BirimId { get; set; }
        public string BirimAdi { get; set; } = null!;
        public int PozisyonId { get; set; }
        public string PozisyonAdi { get; set; } = null!;
        public string PersonelNo { get; set; } = null!;
        public int TotalDinlenmeSure { get; set; }
        public int TotalIceridekiSure { get; set; }
        public string MesaiAdi { get; set; } = null!;
        public string MesaiKodu { get; set; } = null!;
        public string VarsayilanMesaiAdi { get; set; } = null!;
        public string VarsayilanMesaiKodu { get; set; } = null!;
        public int VarsayilanMesaiBaslangici { get; set; }
        public int VarsayilanMesaiBitisi { get; set; }
        public string IzinKodu { get; set; } = null!;
    }
}
