using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class DateModifier
    {
        // Method to calculate the difference in days between two dates
        public int CalculateDifference(string date1, string date2)
        {
            // Define the date format
            string dateFormat = "yyyy-MM-dd";

            // Parse the dates
            DateTime parsedDate1;
            DateTime parsedDate2;

            // Try to parse the dates and throw an exception if the format is invalid
            if (!DateTime.TryParseExact(date1, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate1))
            {
                throw new ArgumentException($"Invalid date format for date1: {date1}. Expected format is {dateFormat}.");
            }

            if (!DateTime.TryParseExact(date2, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate2))
            {
                throw new ArgumentException($"Invalid date format for date2: {date2}. Expected format is {dateFormat}.");
            }

            // Calculate the difference in days
            TimeSpan difference = parsedDate2 - parsedDate1;
            return Math.Abs(difference.Days);
        }
    }
}
