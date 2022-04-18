using System;

namespace Training
{
    internal static class Date
    {
        public static DayOfWeek StringToDay(string str)
        {
            switch (str)
            {
                case "Monday":
                    return DayOfWeek.Monday;

                case "Tuesday":
                    return DayOfWeek.Tuesday;

                case "Wednesday":
                    return DayOfWeek.Wednesday;

                case "Thursday":
                    return DayOfWeek.Thursday;

                case "Friday":
                    return DayOfWeek.Friday;

                case "Saturday":
                    return DayOfWeek.Saturday;

                case "Sunday":
                    return DayOfWeek.Sunday;
            }

            throw new FormatException();
        }
    }
}
