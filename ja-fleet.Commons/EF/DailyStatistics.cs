using System;
using System.Collections.Generic;
using System.Text;

namespace jafleet.Commons.EF
{
    public class DailyStatistics
    {
        public string LogDateYyyyMmDd { get; set; }
        public int SearchCount { get; set; }
        public int LineCount { get; set; }
        public int PhotoCount { get; set; }
        public int ExCount { get; set; }
    }
}
