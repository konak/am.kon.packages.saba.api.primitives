using System;
namespace am.kon.packages.Saba.Api.Primitives
{
	/// <summary>
	/// Model for tennis specific information of the event
	/// </summary>
	public class TennisInfoModel
    {
		/// <summary>
		/// Home player points in the current set
		/// </summary>
		public int[] HomeGameScore { get; set; }

        /// <summary>
        /// Away player points in the current set
        /// </summary>
        public int[] AwayGameScore { get; set; }

        /// <summary>
        /// Home player points in the current game
        /// </summary>
        public string HomePointScore { get; set; }

        /// <summary>
        /// Away player points in the current game
        /// </summary>
		public string AwayPointScore { get; set; }

        /// <summary>
        /// Current set
        /// </summary>
		public int CurrentSet { get; set; }

        /// <summary>
        /// Current serving player
        /// </summary>
        /// <remarks>
        /// 0=No Current Serve, 1=home, 2=away
        /// </remarks>
		public int CurrentServe { get; set; }
    }
}

