using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace NasaMarsRover.Models
{
    public class ImageDownloader
    {
        //Global variable for Rootobject class
        public static Rootobject result = new Rootobject();

        //Global variable for list of URLs
        public static List<string> urls = new List<string>();

        //Global variable for list of IDs
        public static List<string> ids = new List<string>();

        // Function to get data from api when earthdate is passed as parameter
        public static void DownloadImages(List<string> dates)
        {
            try
            {
                foreach (string earthDate in dates)
                {
                    var client = new RestClient(Constants.FetchQuery);
                    string earthdate_query = Constants.API_Parameter +
                        earthDate + Constants.API_Key;
                    RestRequest request = new RestRequest(earthdate_query, Method.GET);
                    var response = client.Execute(request);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        //Store the data from the request made
                        string rawResponse = response.Content;

                        // Deserealize data and convert it into readable format
                        result = JsonConvert.DeserializeObject<Rootobject>(rawResponse);
                        for (int i = 0; i < result.photos.Length; i++)
                        {
                            // Download images
                            GetImage(i, result.photos[i].id);

                            // Add img urls in list
                            urls.Add(result.photos[i].img_src);

                            // Add ids in list
                            ids.Add(result.photos[i].id.ToString());
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine(String.Format("invalid API"));
            }
        }

        // Function to download images and store it in images folder
        public static void GetImage(int index, int id)
        {
            using (WebClient client = new System.Net.WebClient())
            {
                try
                {
                    var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    var folderPath = desktopPath + @"\Mars-Rover\";

                    if (!Directory.Exists(folderPath))
                        Directory.CreateDirectory(folderPath);
                    client.DownloadFile(new Uri(result.photos[index].img_src),
                        folderPath + id.ToString() + ".jpg");
                }
                catch
                {
                    Console.WriteLine(String.Format("Invalid Path! - {0}", result.photos[index].img_src));
                }
            }
        }
    }
}
