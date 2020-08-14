using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jafleet.Commons.EF
{
    [Table("APP_INFO")]
    public class AppInfo
    {
        [Key]
        [Column("COMMIT_HASH")]
        public string CommitHash { get; set; }
        [Column("COMMIT_DATE")]
        public DateTime CommitDate { get; set; }
    }
}
