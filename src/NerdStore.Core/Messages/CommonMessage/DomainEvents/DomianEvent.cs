using NerdStore.Core.Events;
using System;
namespace NerdStore.Core.Messages.CommonMessage.DomainEvents
{
    public class DomianEvent : Event
    {
        public DomianEvent(Guid aggregateId)
        {
            AggregateId = aggregateId;
        }
    }
}
