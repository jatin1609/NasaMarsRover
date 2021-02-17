namespace NasaMarsRover.Models
{
    /// <summary>
    /// The Photo class
    /// </summary>
    public class Photo
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the sol.
        /// </summary>
        /// <value>
        /// The sol.
        /// </value>
        public int Sol { get; set; }

        /// <summary>
        /// Gets or sets the camera.
        /// </summary>
        /// <value>
        /// The camera.
        /// </value>
        public Camera Camera { get; set; }

        /// <summary>
        /// Gets or sets the img source.
        /// </summary>
        /// <value>
        /// The img source.
        /// </value>
        public string Img_Src { get; set; }

        /// <summary>
        /// Gets or sets the earth date.
        /// </summary>
        /// <value>
        /// The earth date.
        /// </value>
        public string Earth_Date { get; set; }

        /// <summary>
        /// Gets or sets the rover.
        /// </summary>
        /// <value>
        /// The rover.
        /// </value>
        public Rover Rover { get; set; }
    }
}
