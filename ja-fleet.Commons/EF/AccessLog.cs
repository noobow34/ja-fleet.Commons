using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jafleet.Commons.EF
{
    [Table("ACCESS_LOG")]
    public class AccessLog
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("LOG_ID")]
        public long LogId { get; set; }
        [Column("REQUEST_TIME")]
        public DateTime RequestTime { get; set; }
        [Column("REQUEST_IP")]
        public string RequestIp { get; set; }
        [Column("REQUEST_HOSTNAME")]
        public string RequestHostname { get; set; }
        [Column("REQUEST_PATH")]
        public string RequestPath { get; set; }
        [Column("REQUEST_QUERY")]
        public string RequestQuery { get; set; }
        [Column("REQUEST_COOKIES")]
        public string RequestCookies { get; set; }
        [Column("USER_AGENT")]
        public string UserAgent { get; set; }
        [Column("REFERER")]
        public string Referer { get; set; }
        [Column("RESPONSE_TIME")]
        public long? ResponseTime { get; set; }
        [Column("RESPONSE_CODE")]
        public int? ResponseCode { get; set; }
        [Column("IS_ADMIN")]
        public bool? IsAdmin { get; set; }

    }
}
