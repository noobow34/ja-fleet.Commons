using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jafleet.Commons.EF
{
    [Table("admin_user")]
    public class AdminUser
    {
        [Key]
        [Column("user_id")]
        public string UserId { get; set; }
    }
}
