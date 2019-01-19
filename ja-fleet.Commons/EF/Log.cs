using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jafleet.Commons.EF
{
    public class Log
    {
        public int? LogId { get; set; }
        public DateTime? LogDate { get; set; }
        public string LogType { get; set; }
        public string LogDetail { get; set; }
        public string UserId { get; set; }
        public string LogDateYyyyMmDd { get; set; }
        public string IsAdmin { get; set; }
    }
}