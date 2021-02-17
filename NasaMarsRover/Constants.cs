namespace NasaMarsRover
{
    /// <summary>
    /// The Constants class
    /// </summary>
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
        public const string APIParameter = "rovers/curiosity/photos?earth_date=";

        /// <summary>
        /// The API Key
        /// </summary>
        public const string APIKey = "&api_key=zNhO8rfSkQKfqtsFabMAlZgS6rXaygYrbQ5JpRiK";
    }
}
