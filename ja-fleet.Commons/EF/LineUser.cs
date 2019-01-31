using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jafleet.Commons.EF
{
    [Table("LINE_USER")]
    public class LineUser
    {
        [Key]
        [Column("USER_ID")]
        public string UserId { get; set; }
        [Column("USER_NAME")]
        public string UserName { get; set; }
        [Column("PROFILE_IMAGE")]
        public byte[] ProfileImage { get; set; }
        [Column("LAST_ACCESS")]
        public DateTime? LastAccess { get; set; }
        [Column("FOLLOW_DATE")]
        public DateTime? FollowDate { get; set; }
        [Column("UNFOLLOW_DATE")]
        public DateTime? UnfollowDate { get; set; }
    }
}
