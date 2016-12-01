namespace TejuanaAdmin
{
    using System;

    public static class Utils
    {
        public static string FormatDate(DateTime date)
        {
            return string.Format("{0}/{1}/{2}", date.Day, date.Month, date.Year);
        }

        public static string ServerUrl()
        {
            return "http://192.168.1.82:8080";
        }
    }
}
