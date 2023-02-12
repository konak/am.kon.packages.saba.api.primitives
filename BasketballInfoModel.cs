using System;
namespace am.kon.packages.Saba.Api.Primitives
{
	/// <summary>
	/// Model for basketball specific events information
	/// </summary>
	public class BasketballInfoModel
    {
		/// <summary>
		/// Current score of the home team
		/// </summary>
		public int[] HomeGameScore { get; set; }

        /// <summary>
        /// Current score of the away team
        /// </summary>
        public int[] AwayGameScore { get; set; }

		/// <summary>
		/// Current period of the event
		/// </summary>
		public int LatestLivePeriod { get; set; }

        /// <summary>
        /// Current overtime score of the home team.
        /// </summary>
        public int HomeOverTimeScore { get; set; }

        /// <summary>
        /// Current overtime score of the Away team.
        /// </summary>
		public int AwayOverTimeScore { get; set; }
    }
}

