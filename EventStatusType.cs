using System;
namespace am.kon.packages.Saba.Api.Primitives
{
    /// <summary>
    /// Enumerator describing status of the event
    /// </summary>
	public enum EventStatusType
	{
        /// <summary>
        /// Event is in running state.
        /// </summary>
        running = 1,

        /// <summary>
        /// Event is finished and closed.
        /// </summary>
        closed = 2,

        /// <summary>
        /// Event is postponed
        /// </summary>
        postponed = 3,

        /// <summary>
        /// Event was deleted
        /// </summary>
        deleted = 4,

        /// <summary>
        /// Event is completed and outcomes should be available
        /// </summary>
        completed = 5,

        /// <summary>
        /// Event is completed and all bets should be refunded
        /// </summary>
        refund = 6
    }
}

