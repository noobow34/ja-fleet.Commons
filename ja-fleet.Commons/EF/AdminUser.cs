using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jafleet.Commons.EF
{
    [Table("ADMIN_USER")]
    public class AdminUser
    {
        [Key]
        [Column("USER_ID")]
        public string UserId { get; set; }
    }
}
