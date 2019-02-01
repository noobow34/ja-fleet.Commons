using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jafleet.Commons.EF
{
    [Table("TYPE_DETAIL")]
    public partial class TypeDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("TYPE_DETAIL_ID")]
        public int? TypeDetailId { get; set; }
        [Column("TYPE_CODE")]
        public string TypeCode { get; set; }
        [Column("TYPE_DETAIL_CODE")]
        public string TypeDetailCode { get; set; }
        [Column("TYPE_DETAIL_NAME")]
        public string TypeDetailName { get; set; }
    }
}
