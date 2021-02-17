namespace NasaMarsRover.Models
{
    /// <summary>
    /// The Camera Class
    /// </summary>
    public class Camera
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the rover identifier.
        /// </summary>
        /// <value>
        /// The rover identifier.
        /// </value>
        public int Rover_Id { get; set; }

        /// <summary>
        /// Gets or sets the full name.
        /// </summary>
        /// <value>
        /// The full name.
        /// </value>
        public string Full_Name { get; set; }
    }
}