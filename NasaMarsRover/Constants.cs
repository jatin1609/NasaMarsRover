using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NasaMarsRover
{
    public static class Constants
    {
        /// <summary>
        /// Base URL for NASA API
        /// </summary>
        public const string FetchQuery = "https://api.nasa.gov/mars-photos/api/v1/";

        /// <summary>
        /// Path to feed the dates input file
        /// </summary>
        public const string DatesPath = @"..\NasaMarsRover\Resources\dates.txt";

        /// <summary>
        /// The API Parameter
        /// </summary>
        public const string API_Parameter = "rovers/curiosity/photos?earth_date=";

        /// <summary>
        /// The API Key
        /// </summary>
        public const string API_Key = "&api_key=zNhO8rfSkQKfqtsFabMAlZgS6rXaygYrbQ5JpRiK";
    }
}
