using System;
namespace am.kon.packages.Saba.Api.Primitives
{
	/// <summary>
	/// Model describing selection inside market
	/// </summary>
	public class SelectionInfoModel
    {
		/// <summary>
		/// Key identifier of selection
		/// </summary>
		public string Key { get; set; }

		/// <summary>
		/// Name of selectio
		/// </summary>
		public string KeyName { get; set; }

		/// <summary>
		/// Point main spread of the selection
		/// </summary>
		public decimal? Point { get; set; }

		/// <summary>
		/// Poinnt additional spread of the selection
		/// </summary>
		public decimal? Point2 { get; set; }

		/// <summary>
		/// Odd price detailed information
		/// </summary>
		public OddsPriceInfoModel OddsPrice { get; set; }
    }
}

