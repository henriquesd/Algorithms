namespace Algorithms.Simulation
{
    public static class ConvertTime
    {
        // Given a time in 12-hour AM/PM format, convert it to military (24-hour) time.
        // Ex.: "07:05:45PM" should be converted to "19:05:45";

        private static readonly Dictionary<string, string> TimeDictionaryPM = new Dictionary<string, string>
        {
            { "01", "13" },
            { "02", "14" },
            { "03", "15" },
            { "04", "16" },
            { "05", "17" },
            { "06", "18" },
            { "07", "19" },
            { "08", "20" },
            { "09", "21" },
            { "10", "22" },
            { "11", "23" },
            { "12", "12" }
        };

        public static string Convert(string timeToConvert)
        {
            if (string.IsNullOrEmpty(timeToConvert) || timeToConvert.Length != 10) return "";

            var result = timeToConvert.Substring(0, 8);

            string amPm = timeToConvert[^2..];
            if (amPm != "AM" && amPm != "PM") return "";

            string hour = timeToConvert.Substring(0, 2);

            if (amPm == "PM" && TimeDictionaryPM.ContainsKey(hour))
            {
                var hourConverted = TimeDictionaryPM[hour];
                result = result.Replace(hour, hourConverted);
                return result;
            }

            if (hour == "12")
            {
                var hourConverted = "00";
                result = result.Replace(hour, hourConverted);
                return result;
            }

            result = timeToConvert.Substring(0, 8);

            return result;
        }

        public static string ConvertToMilitaryTime(string time)
        {
            if (string.IsNullOrEmpty(time)) return "";

            // Parse the time string in AM/PM format
            if (DateTime.TryParseExact(time, "h:mm:sstt", null, System.Globalization.DateTimeStyles.None, out DateTime dateTime))
            {
                // Format the parsed time in 24-hour format
                return dateTime.ToString("HH:mm:ss");
            }

            return "";
        }
    }
}
