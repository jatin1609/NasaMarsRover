using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public int id { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string name { get; set; }
        /// <summary>
        /// Gets or sets the landing date.
        /// </summary>
        /// <value>
        /// The landing date.
        /// </value>
        public string landing_date { get; set; }
        /// <summary>
        /// Gets or sets the launch date.
        /// </summary>
        /// <value>
        /// The launch date.
        /// </value>
        public string launch_date { get; set; }
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public string status { get; set; }
    }
}
