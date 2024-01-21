﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jafleet.Commons.EF
{
    [Table("aircraft_photo")]
    public class AircraftPhoto
    {
        [Key]
        [Column("registration_number")]
        public string RegistrationNumber { get; set; }

        [Column("photo_url")]
        public string PhotoUrl { get; set; }

        [Column("photo_direct_url")]
        public string PhotoDirectUrl { get; set; }

        [Column("last_access")]
        public DateTime LastAccess { get; set; }
    }
}
