using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jafleet.Commons.EF
{
    [Table("TYPE")]
    public class Type
    {
        [Key]
        [Column("TYPE_CODE")]
        public string TypeCode { get; set; }
        [Column("MAKER_CODE")]
        public string MakerCode { get; set; }
        [Column("TYPE_NAME")]
        public string TypeName { get; set; }
        [Column("DISPLAY_ORDER")]
        public string DisplayOrder { get; set; }
    }
}
