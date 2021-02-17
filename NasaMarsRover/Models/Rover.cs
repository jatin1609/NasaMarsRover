namespace NasaMarsRover.Models
{
    /// <summary>
    /// The Rover class
    /// </summary>
    public class Rover
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
        /// Gets or sets the landing date.
        /// </summary>
        /// <value>
        /// The landing date.
        /// </value>
        public string Landing_Date { get; set; }

        /// <summary>
        /// Gets or sets the launch date.
        /// </summary>
        /// <value>
        /// The launch date.
        /// </value>
        public string Launch_Date { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public string Status { get; set; }
    }
}
