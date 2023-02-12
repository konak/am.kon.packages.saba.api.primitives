using System;
namespace am.kon.packages.Saba.Api.Primitives
{
	/// <summary>
	/// Model for soccer specific events
	/// </summary>
	public class SoccerInfoModel
    {
		/// <summary>
		/// Current amount of red cards got by home team
		/// </summary>
		public byte HomeRedCard { get; set; }

        /// <summary>
        /// Current amount of red cards got by away team
        /// </summary>
        public byte AwayRedCard { get; set; }

        /// <summary>
        /// Current amount of yellow cards got by home team
        /// </summary>
        public byte HomeYellowCard { get; set; }

        /// <summary>
        /// Current amount of yellow cards got by away team
        /// </summary>
		public byte AwayYellowCard { get; set; }
    }
}

