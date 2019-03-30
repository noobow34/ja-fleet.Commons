using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jafleet.Commons.EF
{
    [Table("AIRCRAFT_HISTORY")]
    public partial class AircraftHistory:AircraftBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("AH_ID")]
        public int? AhId { get; set; }
        [Column("SEQ")]
        public int? Seq { get; set; }
        [Column("HISTORY_REGISTER_AT")]
        public DateTime? HistoryRegisterAt { get; set; }

        [Display(Name = "機体記号")]
        [Column("REGISTRATION_NUMBER")]
        public new string RegistrationNumber { get; set; }
    }
}
