using System;
namespace am.kon.packages.Saba.Api.Primitives
{
	/// <summary>
	/// Model describing information about competing teams
	/// </summary>
	public class TeamInfoModel
    {
		/// <summary>
		/// Identifier of the home team
		/// </summary>
		public int HomeId { get; set; }

		/// <summary>
		/// Name of the home team
		/// </summary>
		public string HomeName { get; set; }

		/// <summary>
		/// URL of the icon of the home team
		/// </summary>
		/// <remarks>
		/// If the image not found, please change to use default url.
		/// {domain}/TeamImg/team_flag_home.png
		/// Please replace domain with the domain returned by homeIconUrl
		/// </remarks>
		public string HomeIconUrl { get; set; }

        /// <summary>
        /// Identifier of the away team
        /// </summary>
        public int AwayId { get; set; }

        /// <summary>
        /// Name of the away team
        /// </summary>
        public string AwayName { get; set; }

        /// <summary>
        /// URL of the icon of the home team
        /// </summary>
		/// <remarks>
		/// If the image not found, please change to use default url.
		/// {domain}/TeamImg/team_flag_home.png
		/// Please replace domain with the domain returned by homeIconUrl
		/// </remarks>
        public string AwayIconUrl { get; set; }
	}
}

