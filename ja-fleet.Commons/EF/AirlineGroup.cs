using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jafleet.Commons.EF
{
    [Table("AIRLINE_GROUP")]
    public class AirlineGroup
    {
        [Key]
        [Column("AIRLINE_GROUP_CODE")]
        public string AirlineGroupCode { get; set; }
        [Column("AIRLINE_GROUP_NAME")]
        public string AirlineGroupName { get; set; }
    }
}
