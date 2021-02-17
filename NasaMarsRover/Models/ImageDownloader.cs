namespace NasaMarsRover.Models
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using Newtonsoft.Json;
    using RestSharp;    
    
    /// <summary>
    /// The Image Downloader class
    /// </summary>
    public class ImageDownloader
    {
        /// <summary>
        /// Global variable for list of URLs
        /// </summary>
        public static List<string> url = new List<string>();

        /// <summary>
        /// Global variable for the Root object class
        /// </summary>
        public static Rootobject result = new Rootobject();

        /// <summary>
        /// Global variable for list of IDs
        /// </summary>
        public static List<string> ids = new List<string>();

        /// <summary>
        /// Function to Download the images.
        /// </summary>
        /// <param name="dates">The dates.</param>
        public static void DownloadImages(List<string> dates)
        {
            try
            {
                foreach (string earthDate in dates)
                {
                    var client = new RestClient(Constants.FetchQuery);
                    string earthdate_query = Constants.APIParameter +
                        earthDate + Constants.APIKey;
                    RestRequest request = new RestRequest(earthdate_query, Method.GET);
                    var response = client.Execute(request);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        // Store the data from the request made
                        string rawResponse = response.Content;

                        // Deserealize data and convert it into readable format
                        result = JsonConvert.DeserializeObject<Rootobject>(rawResponse);
                        for (int i = 0; i < result.Photos.Length; i++)
                        {
                            // Download images
                            GetImage(i, result.Photos[i].Id);

                            // Add img urls in list
                            url.Add(result.Photos[i].Img_Src);

                            // Add ids in list
                            ids.Add(result.Photos[i].Id.ToString());
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("invalid API");
            }
        }

        /// <summary>
        /// Function to gets the image.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="id">The identifier.</param>
        public static void GetImage(int index, int id)
        {
            using (WebClient client = new System.Net.WebClient())
            {
                try
                {
                    var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    var folderPath = desktopPath + @"\Mars-Rover\";

                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }

                    client.DownloadFile(
                        new Uri(result.Photos[index].Img_Src), folderPath + id.ToString() + ".jpg");
                }
                catch
                {
                    Console.WriteLine("Invalid Path! - " + result.Photos[index].Img_Src);
                }
            }
        }
    }
}
