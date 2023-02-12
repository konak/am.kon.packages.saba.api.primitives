using System;
namespace am.kon.packages.Saba.Api.Primitives
{
	/// <summary>
	/// Model for volleyball specific events info
	/// </summary>
	public class VolleyballInfoModel
	{
		/// <summary>
		/// Home team points in the set
		/// </summary>
		public int[] HomeGameScore { get; set; }

        /// <summary>
        /// Away team points in the set
        /// </summary>
        public int[] AwayGameScore { get; set; }

		/// <summary>
		/// Home team score
		/// </summary>
		public int HomePointScore { get; set; }

        /// <summary>
        /// Away team score
        /// </summary>
        public int AwayPointScore { get; set; }

        /// <summary>
        /// Current serving team
        /// </summary>
        /// <remarks>
        /// 0=No Current Serve, 1=home, 2=away
        /// </remarks>
        public int CurrentServe { get; set; }

        /// <summary>
        /// Home team score in current period
        /// </summary>
        public int HomeCurrentPoint { get; set; }

        /// <summary>
        /// Away team score in current period
        /// </summary>
		public int AwayCurrentPoint { get; set; }

        /// <summary>
        /// Property identifying injury team
        /// </summary>
        /// <remarks>
        /// 0=no one, 1=home, 2=away, 3=both
        /// </remarks>
		public int PlayerInjury { get; set; }

        /// <summary>
        /// Current period of the event
        /// </summary>
		public int LastestLivePeriod { get; set; }
	}
}

