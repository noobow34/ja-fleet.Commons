using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jafleet.Commons.EF
{
    [Table("SEARCH_CONDITION")]
    public class SearchCondition
    {
        [Key]
        [Column("SEARCH_CONDITION_KEY")]
        public string SearchConditionKey { get; set; }
        [Column("SEARCH_CONDITOIN")]
        public string SearchConditionJson { get; set; }
        [Column("SEARCH_COUNT")]
        public int? SearchCount { get; set; }
        [Column("FIRST_SEARCH_DATE")]
        public DateTime? FirstSearchDate { get; set; }
        [Column("LAST_SEARCH_DATE")]
        public DateTime? LastSearchDate { get; set; }
        [Column("SEARCH_CONDITION_NAME")]
        public string SearchConditionName { get; set; }
    }
}
