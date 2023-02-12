using System;
namespace am.kon.packages.Saba.Api.Primitives
{
	/// <summary>
	/// Model for ESport specific events information
	/// </summary>
	public class ESportInfoModel
    {
        /// <summary>
        /// How many maps will be use.
        /// </summary>
        public int BestOfMap { get; set; }

		/// <summary>
		/// Property identifying whether competition is going to start soon.
		/// </summary>
		public bool IsStartingSoon { get; set; }

        /// <summary>
        /// Property identifying whether display a flag in web page or no.
        /// </summary>
        public bool MoveBO3Down { get; set; }

        /// <summary>
        /// Property containing information about league
        /// </summary>
        /// <remarks>
        /// 1 → Dota2 ; 2 → LOL ; 3 → CS2 ; 4 → KOG ; 99 → Others
        /// </remarks>
        public int OverTimeSession { get; set; }

        /// <summary>
        /// Name of the league group.
        /// </summary>
		public string LeagueGroup { get; set; }

        /// <summary>
        /// Identifier of the league group.
        /// </summary>
		public int LeagueGroupId { get; set; }
    }
}

