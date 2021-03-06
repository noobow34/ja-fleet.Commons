﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jafleet.Commons.EF
{
    [Table("AIRCRAFT_VIEW")]
    public partial class AircraftView:AircraftViewBase
    {
        [Column("REGISTRATION_NUMBER")]
        [Key]
        public new string RegistrationNumber { get; set; }

        [Column("PHOTO_DIRECT_URL")]
        public string PhotoDirectUrl { get; set; }
    }
}
