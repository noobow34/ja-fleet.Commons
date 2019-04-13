using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jafleet.Commons.EF
{
    [Table("LOG")]
    public class Log
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("LOG_ID")]
        public int? LogId { get; set; }
        [Column("LOG_DATE")]
        public DateTime? LogDate { get; set; }
        [Column("LOG_TYPE")]
        public string LogType { get; set; }
        [Column("LOG_DETAIL")]
        public string LogDetail { get; set; }
        [Column("USER_ID")]
        public string UserId { get; set; }
        [Column("LOG_DATE_YYYYMMDD")]
        public string LogDateYyyyMmDd { get; set; }
        [Column("IS_ADMIN")]
        public string IsAdmin { get; set; }
        [Column("ADDITIONAL")]
        public string Additional { get; set; }
    }
}