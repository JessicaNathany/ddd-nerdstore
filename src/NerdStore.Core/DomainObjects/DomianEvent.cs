using NerdStore.Core.Events;
using System;
namespace NerdStore.Core.DomainObjects
{
    public class DomianEvent : Event
    {
        public DomianEvent(Guid aggregateId)
        {
            AggregateId = aggregateId;
        }
    }
}
