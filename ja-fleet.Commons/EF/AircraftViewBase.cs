using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace jafleet.Commons.EF
{
    public class AircraftViewBase
    {

        [Column("DISPLAY_ORDER")]
        public string DisplayOrder { get; set; }
        [Column("AIRLINE_GROUP_CODE")]
        public string AirlineGroupCode { get; set; }

        [Column("AIRLINE")]
        public string Airline { get; set; }
        [NotMapped]
        public int AirlineChanged { get; set; } = 0;

        [Column("AIRLINE_NAME_JP_SHORT")]
        public string AirlineNameJpShort { get; set; }

        [Column("TYPE_CODE")]
        public string TypeCode { get; set; }
        [Column("TYPE_NAME")]
        public string TypeName { get; set; }

        [Column("TYPE_DETAIL_CODE")]
        public string TypeDetailCode { get; set; }
        [NotMapped]
        public int TypeDetailChanged { get; set; } = 0;

        [Column("TYPE_DETAIL_NAME")]
        public string TypeDetailName { get; set; }

        [Column("REGISTRATION_NUMBER")]
        public string RegistrationNumber { get; set; }

        [Column("SERIAL_NUMBER")]
        public string SerialNumber { get; set; }
        [NotMapped]
        public int SerialNumberChanged { get; set; } = 0;

        [Column("REGISTER_DATE")]
        public string RegisterDate { get; set; }
        [NotMapped]
        public int RegisterDateChanged { get; set; } = 0;

        [Column("WIFI_CODE")]
        public string WifiCode { get; set; }
        [NotMapped]
        public int WifiChanged { get; set; } = 0;

        [Column("WIFI")]
        public string Wifi { get; set; }

        [Column("WIFI_SHORT")]
        public string WifiShort { get; set; }

        [Column("OPERATION_CODE")]
        public string OperationCode { get; set; }
        [NotMapped]
        public int OperationChanged { get; set; } = 0;

        [Column("OPERATION")]
        public string Operation { get; set; }

        [Column("REMARKS")]
        public string Remarks { get; set; }
        [NotMapped]
        public int RemarksChanged { get; set; } = 0;

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

        [Column("SPECIAL_LIVERY")]
        public string SpecialLivery { get; set; }
        [NotMapped]
        public int SpecialLiveryChanged { get; set; } = 0;

        [Column("F")]
        public int? F { get; set; }

        [Column("C")]
        public int? C { get; set; }

        [Column("PY")]
        public int? PY { get; set; }

        [Column("P")]
        public int? P { get; set; }

        [Column("J")]
        public int? J { get; set; }

        [Column("Y")]
        public int? Y { get; set; }

        [Column("SEAT_SUM")]
        public int? SeatSum { get; set; }

        [NotMapped]
        public string SeatConfig
        {
            get
            {
                return SeatConfigUtil.GenerateSeatConfigString(this.F,this.C,this.PY,this.P,this.J,this.Y,this.SeatSum);
            }
        }
        [NotMapped]
        public int SeatConfigChanged { get; set; } = 0;

        [Column("SEAT_URL")]
        public string SeatUrl { get; set; }

        [NotMapped]
        public string UpdateTimeString
        {
            get { return UpdateTime?.ToString("yyyy/MM/dd"); }
        }

        public void getDifferenceWith(AircraftViewBase compareTarget)
        {
            this.AirlineChanged = this.Airline != compareTarget.Airline ? 1 : 0;
            this.TypeDetailChanged = this.TypeDetailCode != compareTarget.TypeDetailCode? 1 : 0;
            this.SerialNumberChanged = this.SerialNumber != compareTarget.SerialNumber ? 1 : 0;
            this.RegisterDateChanged = this.RegisterDate != compareTarget.RegisterDate ? 1 : 0;
            this.OperationChanged = this.OperationCode != compareTarget.OperationCode ? 1 : 0;
            this.WifiChanged = this.WifiCode != compareTarget.WifiCode ? 1 :0;
            this.RemarksChanged = this.Remarks != compareTarget.Remarks ? 1 : 0;
            this.SpecialLiveryChanged = this.SpecialLivery != compareTarget.SpecialLivery ? 1 : 0;
            this.SeatConfigChanged = this.SeatConfig != compareTarget.SeatConfig ? 1 : 0;
        }

    }
}
