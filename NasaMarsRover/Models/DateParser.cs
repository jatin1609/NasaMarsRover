using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NasaMarsRover.Models
{
    /// <summary>
    /// The Date Parser class
    /// </summary>
    public class DateParser
    {
        /// <summary>
        /// Parses the date.
        /// </summary>
        /// <param name="text">The text.</param>
        public static List<string> parseDates(string filePath)
        {
            string text = System.IO.File.ReadAllText(filePath);

            // Split the text string into dates and store them in array
            string[] dates = text.Split("\r\n");

            List<string> parsedDates = new List<string>();

            foreach (string date in dates)
            {
                // Format string as per the JSON data in API
                string parsedDate = "";
                string format = "yyyy-MM-dd";
                try
                {
                    parsedDate = DateTime.Parse(date).ToString(format);
                }
                catch
                {
                    Console.WriteLine(String.Format("Invalid Date! - {0}", date));
                }
                parsedDates.Add(parsedDate);
            }

            return parsedDates;
        }
    }
}

