namespace jafleet.Commons.Constants
{
    public static class LogType
    {
        public const string SEARCH = "1";
        public const string DETAIL = "2";
        public const string LINE = "3";
        public const string EXCEPTION = "4";
        public const string LINE_FOLLOW = "5";
        public const string LINE_UNFOLLOW = "6";
        public const string LINE_LINK = "7";
        public const string WORKING_INFO = "8";

        public static string GetLogTypeName(string logtype)
        {
            switch (logtype)
            {
                case SEARCH:
                    return "検索";
                case DETAIL:
                    return "DETAIL";
                case LINE:
                    return "LINE";
                case EXCEPTION:
                    return "例外";
                case LINE_FOLLOW:
                    return "LINEフォロー";
                case LINE_UNFOLLOW:
                    return "LINEアンフォロー";
                case LINE_LINK:
                    return "LINEリンク";
                case WORKING_INFO:
                    return "稼働状況";
                default:
                    return logtype;
            }
        }
    }
}
