using System;
namespace am.kon.packages.Saba.Api.Primitives
{
	/// <summary>
	/// Model for baseball specific events innformation
	/// </summary>
	public class BaseballInfoModel
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
		/// Home team score of the overtime
		/// </summary>
		public int HomeOverTimeScore { get; set; }

        /// <summary>
        /// Away team score of the overtime
        /// </summary>
        public int AwayOverTimeScore { get; set; }

        /// <summary>
        /// Property identifying which base has runner.
        /// </summary>
		/// <remarks>
		/// First Item Indicates True If There's a Runner on First Base And So On
		/// </remarks>
        public bool[] BaseHasRunner { get; set; }

		/// <summary>
		/// Current inning of the event
		/// </summary>
		public int CurrentInning { get; set; }

        /// <summary>
        /// Current Batting Team
        /// </summary>
		/// <remarks>
		/// 1=Home，2=Away
		/// </remarks>
        public int CurrentBattingTeam { get; set; }

        /// <summary>
        /// Current outs of the batting team
        /// </summary>
        public int CurrentOuts { get; set; }
    }
}

