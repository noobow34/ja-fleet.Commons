using System;
using System.Collections.Generic;
using System.Text;

namespace jafleet.Commons.EF
{
    public class SearchCondition
    {
        public string SearchConditionKey { get; set; }
        public string SearchConditionJson { get; set; }
        public int? SearchCount { get; set; }
        public DateTime? FirstSearchDate { get; set; }
        public DateTime? LastSearchDate { get; set; }
    }
}
