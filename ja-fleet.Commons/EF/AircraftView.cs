using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jafleet.Commons.EF
{
    [Table("aircraft_view")]
    public partial class AircraftView:AircraftViewBase
    {
        [Column("registration_number")]
        [Key]
        public new string RegistrationNumber { get; set; }

        [Column("photo_direct_url")]
        public string PhotoDirectUrl { get; set; }
    }
}
