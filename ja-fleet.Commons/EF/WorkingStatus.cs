using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jafleet.Commons.EF
{
    [Table("WORKING_STATUS")]
    public class WorkingStatus
    {
        [Key]
        [Column("REGISTRATION_NUMBER")]
        public string RegistrationNumber { get; set; }

        [Column("FLIGHT_DATE")]
        public DateTime? FlightDate { get; set; }

        [Column("FROM_AP")]
        public string FromAp { get; set; }
        
        [Column("TO_AP")]
        public string ToAp { get; set; }

        [Column("FLIGHT_NUMBER")]
        public string FlightNumber { get; set; }

        [Column("STATUS")]
        public string Status { get; set; }

        [Column("WORKING")]
        public bool? Working { get; set; }

        [Column("MAINTENANCING")]
        public bool? Maintenancing { get; set; }

        [Column("TEST_FLIGHT_DATE")]
        public DateTime? TestFlightDate { get; set; }
    }
}
