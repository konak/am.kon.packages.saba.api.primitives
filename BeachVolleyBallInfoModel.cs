using System;
namespace am.kon.packages.Saba.Api.Primitives
{
	/// <summary>
	/// Model for beach volleyball specific event information
	/// </summary>
	public class BeachVolleyBallInfoModel
    {
		/// <summary>
		/// Home team points in the current set.
		/// </summary>
		public int[] HomeGameScore { get; set; }

        /// <summary>
        /// Away team points in the current set.
        /// </summary>
        public int[] AwayGameScore { get; set; }

		/// <summary>
		/// Current set of the event.
		/// </summary>
		public int CurrentSet { get; set; }

        /// <summary>
        /// Current serving team
        /// </summary>
        /// <remarks>
        /// 0=No Current Serve, 1=home, 2=away
        /// </remarks>
		public int CurrentServe { get; set; }

        /// <summary>
        /// Property identifying injury team
        /// </summary>
        /// <remarks>
        /// 0=no one, 1=home, 2=away, 3=both
        /// </remarks>
        public int PlayerInjury { get; set; }

        /// <summary>
        /// Whether the weather is raining.
        /// </summary>
		public bool IsRain { get; set; }
    }
}

