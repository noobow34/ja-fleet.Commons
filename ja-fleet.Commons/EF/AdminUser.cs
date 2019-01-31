using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

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
