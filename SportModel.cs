using System;
namespace am.kon.packages.Saba.Api.Primitives
{
	/// <summary>
	/// Sport data model provided by API.
	/// </summary>
	public class SportModel
	{
		/// <summary>
		/// Identifier of the sport item.
		/// </summary>
		public int SportType { get; set; }

		/// <summary>
		/// Name of the sport item.
		/// </summary>
		public string SportName { get; set; }

        /// <summary>
        /// Number of the live events.
        /// </summary>
        public int liveGameCount { get; set; }

        /// <summary>
        /// Number of the non-live events.
        /// </summary>
        public int gameCount { get; set; }

        /// <summary>
        /// Number of the parlay’s events.
        /// </summary>
        public int ParlayGame { get; set; }

        /// <summary>
        /// Number of the outright’s events.
        /// </summary>
        public int OutrightGame { get; set; }
    }
}

