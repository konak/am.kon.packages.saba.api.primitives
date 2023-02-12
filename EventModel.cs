using System;
using System.ComponentModel;
using System.Globalization;

namespace am.kon.packages.Saba.Api.Primitives
{
    /// <summary>
    /// Model of match events provided by API
    /// </summary>
    public class EventModel
    {
        /// <summary>
        /// Identifier of the sport.
        /// </summary>
        public int SportType { get; set; }

        /// <summary>
        /// Name of the sport.
        /// </summary>
        public string SportName { get; set; }

        /// <summary>
        /// Identifier of thr league.
        /// </summary>
        public int LeagueId { get; set; }

        /// <summary>
        /// Name of the league.
        /// </summary>
        public string LeagueName { get; set; }

        /// <summary>
        /// The URL of the icon of the league.
        /// </summary>
        /// <remarks>
        /// If the image not found, please change to use default url.
        /// {domain}/LeagueImg/league_flag.png
        /// Please replace domain with the domain returned by leagueIconUrl
        /// </remarks>
        public string LeagueIconUrl { get; set; }

        /// <summary>
        /// Identifier of the event.
        /// </summary>
        public int EventId { get; set; }

        /// <summary>
        /// Code of the event used for events ordering
        /// </summary>
        public string EventCode { get; set; }

        /// <summary>
        /// Status of the event.
        /// </summary>
        public EventStatusType EventStatus { get; set; }

        /// <summary>
        /// Property identifying whether this event provides main market data (main event data) or some extended (yellow/red cards or overtime) markets data.
        /// </summary>
        public bool IsMainMarket { get; set; }

        /// <summary>
        /// Kick of time of the event. Actual planned time to start the match.
        /// </summary>
        /// <remarks>
        /// GMT+0 time zonne is used for all of the DateTime values provided by API
        /// </remarks>
        public DateTime KickOffTime { get; set; }

        /// <summary>
        /// Actual planned time for match broadcasting
        /// </summary>
        /// <remarks>
        /// GMT+0 time zonne is used for all of the DateTime values provided by API
        /// </remarks>
        public DateTime GlobalShowTime { get; set; }

        /// <summary>
        /// Code of the country hosting the event.
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// Total amount of games the event can have
        /// </summary>
        public int GameSession { get; set; }

        /// <summary>
        /// Identifier of the parent event (main event containing mainn markets data)
        /// </summary>
        public int parentId { get; set; }

        /// <summary>
        /// Property identifying whether this event is test one (for testing purposes) or a real one.
        /// </summary>
        public bool IsTest { get; set; }

        /// <summary>
        /// Property identifying whether this event is live or no.
        /// </summary>
        public bool IsLive { get; set; }

        /// <summary>
        /// Property identifying whether this event is available for parly betting or no.
        /// </summary>
        public bool IsParlay { get; set; }

        /// <summary>
        /// Property identifying whether cashout is available on this event.
        /// </summary>
        public bool IsCashout { get; set; }

        /// <summary>
        /// Property identifying whether this event is virtual or no.
        /// </summary>
        public bool IsVirtualEvent { get; set; }

        /// <summary>
        /// Property identifying whether this event has live markets or no.
        /// </summary>
        public bool HasLiveMarket { get; set; }

        /// <summary>
        /// Amount of markets inn nthe event
        /// </summary>
        public int MarketCount { get; set; }

        /// <summary>
        /// Array of categories of all markets for the event.
        /// </summary>
        /// <remarks>
        /// Possible values:
        /// 0: None
        /// 1: FullTime
        /// 2: Half
        /// 3: Corners /Bookings
        /// 4: Intervals
        /// 5: Specials
        /// 6: Players
        /// 7: FastMarket
        /// 8: Quarter
        /// 9: ExtraTime
        /// 10: Penalty
        /// 11-19: E-Sports Map 1-9
        /// </remarks>
        public int[] MarketCategories { get; set; }

        /// <summary>
        /// Identifier of the streaming.
        /// </summary>
        public int StreamingOption { get; set; }

        /// <summary>
        /// Code of the streaming.
        /// </summary>
        public string ChannelCode { get; set; }

        /// <summary>
        /// Competing Team Information
        /// </summary>
        public TeamInfoModel TeamInfo { get; set; }

        /// <summary>
        /// GMore detailed information of the event (current part of the event, time of the event, scores etc.)
        /// </summary>
        public GameInfoModel GameInfo { get; set; }

        /// <summary>
        /// Soccer specific information of the event
        /// </summary>
        /// <remarks>
        /// This property is not available for other sport types.
        /// </remarks>
        public SoccerInfoModel soccerInfo { get; set; }

        /// <summary>
        /// Tennis specific information of the event
        /// </summary>
        /// <remarks>
        /// This property is not available for other sport types.
        /// </remarks>
        public TennisInfoModel tennisInfo { get; set; }

        /// <summary>
        /// Beach volleyball specific information of the event
        /// </summary>
        /// <remarks>
        /// This property is not available for other sport types.
        /// </remarks>
        public BeachVolleyBallInfoModel beachVolleyBallInfo { get; set; }

        /// <summary>
        /// ESport specific information of the event
        /// </summary>
        /// <remarks>
        /// This property is not available for other sport types.
        /// </remarks>
        public ESportInfoModel eSportInfo { get; set; }

        /// <summary>
        /// Basketball specific information of the event
        /// </summary>
        /// <remarks>
        /// This property is not available for other sport types.
        /// </remarks>
        public BasketballInfoModel basketballInfo { get; set; }

        /// <summary>
        /// Baseball specific information of the event
        /// </summary>
        /// <remarks>
        /// This property is not available for other sport types.
        /// </remarks>
        public BaseballInfoModel baseballInfo { get; set; }

        /// <summary>
        /// Volleyball specific information of the event
        /// </summary>
        /// <remarks>
        /// This property is not available for other sport types.
        /// </remarks>
        public VolleyballInfoModel volleyBallInfo { get; set; }
    }
}

