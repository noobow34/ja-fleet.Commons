using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jafleet.Commons.EF
{
    [Table("DAILY_STATISTICS")]
    public class DailyStatistics
    {
        [Key]
        [Column("LOG_DATE_YYYYMMDD")]
        public string LogDateYyyyMmDd { get; set; }
        [Column("SEARCH_COUNT")]
        public int SearchCount { get; set; }
        [Column("LINE_COUNT")]
        public int LineCount { get; set; }
        [Column("PHOTO_COUNT")]
        public int PhotoCount { get; set; }
        [Column("EX_COUNT")]
        public int ExCount { get; set; }
    }
}
