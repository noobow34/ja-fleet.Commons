using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jafleet.Commons.EF
{
    [Table("LINE_USER_PROFILE_IMAGE")]
    public class LineUserProfileImage
    {
        [Key]
        [Column("USER_ID")]
        public string UserId { get; set; }
        [Column("PROFILE_IMAGE")]
        public byte[] ProfileImage { get; set; }
        [Column("UPDATE_TIME")]
        public DateTime? UpdateTIme { get; set; }
    }
}
