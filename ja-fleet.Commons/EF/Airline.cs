using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jafleet.Commons.EF
{
    [Table("AIRLINE")]
    public class Airline
    {
        [Key]
        [Column("AIRLINE_CODE")]
        public string AirlineCode { get; set; }
        [Column("AIRLINE_GROUP_CODE")]
        public string AirlineGroupCode { get; set; }
        [Column("AIRLINE_NAME_EN")]
        public string AirlineNameEn { get; set; }
        [Column("AIRLINE_NAME_EN_SHORT")]
        public string AirlineNameJp { get; set; }
        [Column("AIRLINE_NAME_JP")]
        public string AirlineNameEnShort { get; set; }
        [Column("AIRLINE_NAME_JP_SHORT")]
        public string AirlineNameJpShort { get; set; }
        [Column("DISPLAY_ORDER")]
        public string DisplayOrder { get; set; }

        [NotMapped]
        public string AirlineGroup { get; set; }
    }
}
