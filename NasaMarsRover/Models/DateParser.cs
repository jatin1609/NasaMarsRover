namespace NasaMarsRover.Models
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The Date Parser class
    /// </summary>
    public class DateParser
    {
        /// <summary>
        /// Parses the date.
        /// </summary>
        /// <param name="filePath">The filePath.</param>
        /// <returns>The list of dates.</returns>
        public static List<string> ParseDates(string filePath)
        {
            string text = System.IO.File.ReadAllText(filePath);

            // Split the text string into dates and store them in array
            string[] dates = text.Split("\r\n");

            List<string> parsedDates = new List<string>();

            foreach (string date in dates)
            {
                // Format string as per the JSON data in API
                string parsedDate = string.Empty;
                string format = "yyyy-MM-dd";
                try
                {
                    parsedDate = DateTime.Parse(date).ToString(format);
                }
                catch
                {
                    Console.WriteLine("Invalid Date! - " + date);
                }

                parsedDates.Add(parsedDate);
            }

            return parsedDates;
        }
    }
}