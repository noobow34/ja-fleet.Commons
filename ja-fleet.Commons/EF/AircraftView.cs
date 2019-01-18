using System;
using System.Collections.Generic;

namespace jafleet.Commons.EF
{
    public partial class AircraftView
    {
        public string DisplayOrder { get; set; }
        public string AirlineGroupCode { get; set; }
        public string Airline { get; set; }
        public string AirlineNameJpShort { get; set; }
        public string TypeCode { get; set; }
        public string TypeName { get; set; }
        public string TypeDetailCode { get; set; }
        public string TypeDetailName { get; set; }
        public string RegistrationNumber { get; set; }
        public string SerialNumber { get; set; }
        public string RegisterDate { get; set; }
        public string WifiCode { get; set; }
        public string Wifi { get; set; }
        public string OperationCode { get; set; }
        public string Operation { get; set; }
        public string Remarks { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string LinkUrl { get; set; }
        public DateTime? ActualUpdateTime { get; set; }
    }
}
