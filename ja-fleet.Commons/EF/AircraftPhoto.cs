using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jafleet.Commons.EF
{
    [Table("AIRCRAFT_PHOTO")]
    public class AircraftPhoto
    {
        [Key]
        [Column("REGISTRATION_NUMBER")]
        public string RegistrationNumber { get; set; }

        [Column("PHOTO_URL")]
        public string PhotoUrl { get; set; }

        [Column("LAST_ACCESS")]
        public DateTime LastAccess { get; set; }
    }
}
