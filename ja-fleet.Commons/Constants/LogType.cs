using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jafleet.Constants
{
    public static class LogType
{
        public const string SEARCH = "1";
        public const string PHOTO = "2";
        public const string LINE = "3";
        public const string EXCEPTION = "4";
        public const string LINE_FOLLOW = "5";
        public const string LINE_UNFOLLOW = "6";

        public static string GetLogTypeName(string logtype)
        {
            switch (logtype)
            {
                case SEARCH:
                    return "検索";
                case PHOTO:
                    return "PHOTO";
                case LINE:
                    return "LINE";
                case EXCEPTION:
                    return "例外";
                case LINE_FOLLOW:
                    return "LINEフォロー";
                case LINE_UNFOLLOW:
                    return "LINEアンフォロー";
                default:
                    return logtype;
            }
        }
}
}
