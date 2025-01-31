using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jafleet.Commons.EF
{
    [Table("working_status")]
    public class WorkingStatus
    {
        [Key]
        [Column("registration_number")]
        public string RegistrationNumber { get; set; }

        [Column("flight_date")]
        public DateTime? FlightDate { get; set; }

        [Column("from_ap")]
        public string FromAp { get; set; }
        
        [Column("to_ap")]
        public string ToAp { get; set; }

        [Column("flight_number")]
        public string FlightNumber { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("working")]
        public bool? Working { get; set; }

        [Column("maintenancing")]
        public bool? Maintenancing { get; set; }

        [Column("test_flight_date")]
        public DateTime? TestFlightDate { get; set; }
    }
}
