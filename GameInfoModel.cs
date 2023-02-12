using System;
namespace am.kon.packages.Saba.Api.Primitives
{
	/// <summary>
	/// Model for more detailed information about event
	/// </summary>
	public class GameInfoModel
    {
        /// <summary>
        /// Specifies the current part of the game.
        /// </summary>
        /// <remarks>
        /// If the value is 0, the front end should displayed the time. It means the game is at a special time.
        /// Property supported only for:
        /// 1:  Soccer
        /// 2:  Backetball
        /// 3:  Football
        /// 4:  Icehockey
        /// 9:  Badminton
        /// 24: Handball
        /// 26: Rugby
        /// 43: E-Sports
        /// </remarks>
		public byte LivePeriod { get; set; }

        /// <summary>
        /// Defines direction of time progres. Increment timer until end of the event or decrement until it become zero.
        /// </summary>
		public ClockDirectionType ClockDirection { get; set; }

        /// <summary>
        /// Current time of the event in seconds
        /// </summary>
		public int Seconds { get; set; }

        /// <summary>
        /// Property identifying whether the event is not hold by any competitor, not by home nor by away team.
        /// </summary>
		public bool IsNeutral { get; set; }

        /// <summary>
        /// Property identifying whether the event is in half time state. ( it’s Second Half time ).
        /// </summary>
        public bool IsHt { get; set; }

        /// <summary>
        /// Property identifying whether event is in a break time.
        /// </summary>
        public bool IsBreak { get; set; }

        /// <summary>
        /// Property identifying whether event has been closed.
        /// </summary>
        public bool IsClosed { get; set; }

        /// <summary>
        /// Property identifying whether event is in injury time.
        /// </summary>
        public byte InJuryTime { get; set; }

        /// <summary>
        /// Property identifying whether the event is delaying.
        /// </summary>
        public bool DelayLive { get; set; }

        /// <summary>
        /// Property defining status of the event
        /// </summary>
        public GameStatusType GameStatus { get; set; }

        /// <summary>
        /// Event timer. only for soccer, basketball, Football
        /// </summary>
        /// <remarks>
        /// For soccer, basketball and other sport types it will provide timer as a string.
        /// </remarks>
        public string InPlayTime { get; set; }

        /// <summary>
        /// Current score of the home team.
        /// </summary>
        public int LiveHomeScore { get; set; }

        /// <summary>
        /// Current score of the away team.
        /// </summary>
        public int LiveAwayScore { get; set; }
    }
}

