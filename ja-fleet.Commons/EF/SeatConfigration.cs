﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jafleet.Commons.EF
{
    [Table("SEAT_CONFIGRATION")]
    public class SeatConfigration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CONFIG_ID")]
        public int? ConfigId { get; set; }

        [Column("AIRLINE")]
        public string Airline { get; set; }

        [Column("TYPE")]
        public string Type { get; set; }

        [Column("URL")]
        public string Url { get; set; }

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
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? SeatSum { get; }
               
    }
}
