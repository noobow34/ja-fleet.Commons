using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jafleet.Commons.EF
{
    [Table("AIRCRAFT_HISTORY_VIEW")]
    public partial class AircraftHistoryView : AircraftViewBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("AH_ID")]
        public int? AhId { get; set; }
        [Column("SEQ")]
        public int? Seq { get; set; }

    }
}
