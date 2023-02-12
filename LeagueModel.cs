using System;
namespace am.kon.packages.Saba.Api.Primitives
{
	/// <summary>
	/// Model of the League provided by API
	/// </summary>
	public class LeagueModel
    {
        /// <summary>
        /// Identifier of the league.
        /// </summary>
        public int LeagueId { get; set; }

        /// <summary>
        /// Name of the league.
        /// </summary>
        public string LeagueName { get; set; }

        /// <summary>
        /// Identifier of the sport.
        /// </summary>
        public int SportType { get; set; }

        /// <summary>
        /// Name of the sport.
        /// </summary>
        public string SportName { get; set; }

        /// <summary>
        /// Number of the live events.
        /// </summary>
        public int LiveGameCount { get; set; }

        /// <summary>
        /// Number of the non-live events.
        /// </summary>
        public int GameCount { get; set; }

        /// <summary>
        /// Property identifying whether the event is a parlay.
        /// </summary>
        public bool IsParlay { get; set; }
    }
}

