using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jafleet.Commons.EF
{
    [Table("MAKER")]
    public class Maker
    {
        [Key]
        [Column("MAKER_CODE")]
        public string MakerCode { get; set; }
        [Column("MAKER_NAME_EN")]
        public string MakerNameEn { get; set; }
        [Column("MAKER_NAME_JP")]
        public string MakerNameJp { get; set; }
    }
}
