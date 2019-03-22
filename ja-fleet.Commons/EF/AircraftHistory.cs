﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jafleet.Commons.EF
{
    [Table("AIRCRAFT_HISTORY")]
    public partial class AircraftHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("AH_ID")]
        public int? AhId { get; set; }
        [Column("SEQ")]
        public int? Seq { get; set; }
        [Column("HISTORY_REGISTER_AT")]
        public DateTime? HistoryRegisterAt { get; set; }

        [Display(Name = "航空会社")]
        [Column("AIRLINE")]
        public string Airline { get; set; }
        [Display(Name = "機体記号")]
        [Column("REGISTRATION_NUMBER")]
        public string RegistrationNumber { get; set; }
        [Display(Name = "登録年月日")]
        [Column("REGISTER_DATE")]
        public string RegisterDate { get; set; }
        [Display(Name = "運用状況")]
        [Column("OPERATION_CODE")]
        public string OperationCode { get; set; }
        [Display(Name = "WiFi")]
        [Column("WIFI_CODE")]
        public string WifiCode { get; set; }
        [Display(Name = "備考")]
        [Column("REMARKS")]
        public string Remarks { get; set; }
        [Display(Name = "製造番号")]
        [Column("SERIAL_NUMBER")]
        public string SerialNumber { get; set; }
        [Display(Name = "更新日時")]
        [Column("UPDATE_TIME")]
        public DateTime? UpdateTime { get; set; }
        [Display(Name = "作成日時")]
        [Column("CREATION_TIME")]
        public DateTime? CreationTime { get; set; }
        [Display(Name = "リンクURL")]
        [Column("LINK_URL")]
        public string LinkUrl { get; set; }
        [Display(Name = "実更新日時")]
        [Column("ACTUAL_UPDATE_TIME")]
        public DateTime? ActualUpdateTime { get; set; }
        [Display(Name = "詳細型式")]
        [Column("TYPE_DETAIL_ID")]
        public int TypeDetailId { get; set; }

    }
}
