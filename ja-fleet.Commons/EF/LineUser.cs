using System;
using System.Collections.Generic;
using System.Text;

namespace jafleet.EF
{
    public class LineUser
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public byte[] ProfileImage { get; set; }
        public DateTime LastAccess { get; set; }
        public DateTime FollowDate { get; set; }
        public DateTime UnfollowDate { get; set; }
    }
}
