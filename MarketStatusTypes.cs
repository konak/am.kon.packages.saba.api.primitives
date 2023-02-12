using System;
namespace am.kon.packages.Saba.Api.Primitives
{
    /// <summary>
    /// Entity describing available status types for the market
    /// </summary>
	public enum MarketStatusTypes
	{
        /// <summary>
        /// Status used to identify unhadled cases or exceptions
        /// </summary>
        Unknnown = 0,

        /// <summary>
        /// Market is in running state
        /// </summary>
        Running = 1,

        /// <summary>
        /// Market is temporary suspended but prices (values of the odds) should stay visible for client
        /// </summary>
        Suspend = 2,

        /// <summary>
        /// Market is closed and prices (values of the odds) of the market should be shown as locked and nont available for betting
        /// </summary>
        ClosePrice = 3,

        /// <summary>
        /// Market is closed and do nont contain prices
        /// </summary>
        Closed = 4
    }
}

