using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jafleet.Commons.EF
{
    [Table("AIRCRAFT_HISTORY_VIEW")]
    public partial class AircraftHistoryView
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("AH_ID")]
        public int? AhId { get; set; }
        [Column("SEQ")]
        public int? Seq { get; set; }

        [Column("DISPLAY_ORDER")]
        public string DisplayOrder { get; set; }
        [Column("AIRLINE_GROUP_CODE")]
        public string AirlineGroupCode { get; set; }
        [Column("AIRLINE")]
        public string Airline { get; set; }
        [Column("AIRLINE_NAME_JP_SHORT")]
        public string AirlineNameJpShort { get; set; }
        [Column("TYPE_CODE")]
        public string TypeCode { get; set; }
        [Column("TYPE_NAME")]
        public string TypeName { get; set; }
        [Column("TYPE_DETAIL_CODE")]
        public string TypeDetailCode { get; set; }
        [Column("TYPE_DETAIL_NAME")]
        public string TypeDetailName { get; set; }
        [Column("REGISTRATION_NUMBER")]
        public string RegistrationNumber { get; set; }
        [Column("SERIAL_NUMBER")]
        public string SerialNumber { get; set; }
        [Column("REGISTER_DATE")]
        public string RegisterDate { get; set; }
        [Column("WIFI_CODE")]
        public string WifiCode { get; set; }
        [Column("WIFI")]
        public string Wifi { get; set; }
        [Column("OPERATION_CODE")]
        public string OperationCode { get; set; }
        [Column("OPERATION")]
        public string Operation { get; set; }
        [Column("REMARKS")]
        public string Remarks { get; set; }
        [Column("CREATION_TIME")]
        public DateTime? CreationTime { get; set; }
        [Column("UPDATE_TIME")]
        public DateTime? UpdateTime { get; set; }
        [Column("LINK_URL")]
        public string LinkUrl { get; set; }
        [Column("ACTUAL_UPDATE_TIME")]
        public DateTime? ActualUpdateTime { get; set; }
        [Column("TYPE_DETAIL_ID")]
        public int TypeDetailId { get; set; }

        [NotMapped]
        public String UpdateTimeString
        {
            get { return UpdateTime?.ToString("yyyy/MM/dd"); }
        }
    }
}
