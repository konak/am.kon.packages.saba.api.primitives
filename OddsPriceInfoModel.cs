using System;
namespace am.kon.packages.Saba.Api.Primitives
{
	/// <summary>
	/// Model describing details of the odd
	/// </summary>
	public class OddsPriceInfoModel
    {
		/// <summary>
		/// Parlay version of the price
		/// </summary>
		public decimal ParlayPrice { get; set; }

		/// <summary>
		/// Malay version of the price
		/// </summary>
		public decimal MalayPrice { get; set; }

		/// <summary>
		/// Hong Kong version of the price
		/// </summary>
		public decimal HongKongPrice { get; set; }

		/// <summary>
		/// Decimal version of the price
		/// </summary>
		public decimal DecimalPrice { get; set; }

		/// <summary>
		/// Indonesian version of the price
		/// </summary>
		public decimal IndoPrice { get; set; }

		/// <summary>
		/// American version of the price
		/// </summary>
		public decimal AmericanPrice { get; set; }
    }
}

