using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jafleet.Commons.EF
{
    [Table("TYPE_DETAIL_VIEW")]
    public class TypeDetailView
    {
        [Key]
        [Column("TYPE_DETAIL_ID")]
        public int TypeDetailId { get; set; }
        [Column("TYPE_CODE")]
        public string TypeCode { get; set; }
        [Column("TYPE_NAME")]
        public string TypeName { get; set; }
        [Column("TYPE_DETAIL_NAME")]
        public string TypeDetailName { get; set; }
        [Column("DISPLAY_ORDER")]
        public string DisplayOrder { get; set; }
    }
}
