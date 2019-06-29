using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jafleet.Commons.EF
{
    [Table("CODE")]
    public partial class Code
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CODE_ID")]
        public int? CodeId { get; set; }
        [Column("CODE_TYPE")]
        public string CodeType { get; set; }
        [Column("KEY")]
        public string Key { get; set; }
        [Column("VALUE")]
        public string Value { get; set; }
        [Column("VALUE_SHORT")]
        public string ValueShort { get; set; }

        [NotMapped]
        public string OptGroup { get; set; }
    }
}
