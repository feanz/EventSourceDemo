using System;

namespace Eventus.Events
{
    public interface IEvent 
    {
        /// <summary>
        /// Target version of the Aggregate this event will be applied against
        /// </summary>
        int TargetVersion { get; set; }

        /// <summary>
        /// The aggregateID of the aggregate
        /// </summary>
        Guid AggregateId { get; set; }

        /// <summary>
        /// This is used to timestamp the event when it get's committed
        /// </summary>
        DateTime EventCommittedTimestamp { get; set; }
        
        /// <summary>
        /// This is used to handle versioning of events over time when refactoring or feature additions are done
        /// </summary>
        int ClassVersion { get; set; }

        /// <summary>
        /// Unique Id to correlate actions
        /// </summary>
        Guid CorrelationId { get; }
    }
}