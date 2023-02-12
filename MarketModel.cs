using System;
namespace am.kon.packages.Saba.Api.Primitives
{
	public class MarketModel
    {
		/// <summary>
		/// Identifier of the sport.
		/// </summary>
		public int SportType { get; set; }

		/// <summary>
		/// Identifier of the event.
		/// </summary>
		public int EventId { get; set; }

		/// <summary>
		/// Identifier of the bet type.
		/// </summary>
		public int BetType { get; set; }

		/// <summary>
		/// Name of the bet type.
		/// </summary>
		public string BetTypeName { get; set; }

		/// <summary>
		/// Identifier of the market.
		/// </summary>
		public int MarketId { get; set; }

		/// <summary>
		/// Maximum bet amount for current market..
		/// </summary>
		public decimal MaxBet { get; set; }

		/// <summary>
		/// Property idenntifying whether market is live or no.
		/// </summary>
		public bool IsLive { get; set; }

		/// <summary>
		/// Status of the market
		/// </summary>
		public MarketStatusTypes MarketStatus { get; set; }

        /// <summary>
        /// Identifier of the game map
        /// </summary>
        /// <remarks>
        /// Only for E-Sport sport type = 43 and bet type in 9001-9100
		/// </remarks>
		public short? GameMap { get; set; }

        /// <summary>
        /// Itentifier of the round of the game
        /// </summary>
        /// <remarks>
        /// Only for E-Sport sport type = 43 and bet type in (9007, 9011, 9027, 9062, 9068, 9070, 9071, 9072, 9073, 9077)
        /// </remarks>
        public short? GameRound { get; set; }

        /// <summary>
        /// X and Y value in Bet Type.
		/// Format: XX or XXYY.
        /// </summary>
		/// <example>
		/// Example: Bet Type 9007 - Map 1 First to 5 Kills, The value of resourceId is 0105.
		/// </example>
        public string ResourceId { get; set; }

        /// <summary>
        /// Category of the market
        /// </summary>
        public MarketCategoryTypes Category { get; set; }

        /// <summary>
        /// Ranking of the market used for ordering.
        /// </summary>
        /// <remarks>
        /// Used for bet type=1,3,7,8,219,220,401,402,701,704,705,3907,3908,3913 and having multiple points.
        /// </remarks>
        public int Sort { get; set; }

        /// <summary>
        /// minimum amount of selections from this market to place parlay.
        /// </summary>
        public int Combo { get; set; }

		/// <summary>
		/// 
		/// </summary>
        public SelectionInfoModel[] Selections { get; set; }
    }
}

