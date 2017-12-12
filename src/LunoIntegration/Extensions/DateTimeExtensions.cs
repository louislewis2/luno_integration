namespace System
{
    public static class DateTimeExtensions
    {
        public static double DateTimeToUnixTimestamp(this DateTime dateTime)
        {
            return (TimeZoneInfo.ConvertTimeToUtc(dateTime) -
                   new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
        }
    }
}
