using System;
using System.Collections.Generic;
using System.Text;

namespace momentum.framework.core
{

    public class User : AggregateRoot
    {

    }

    public abstract class AggregateRoot
    {
        public IList<IInternalEvent> Events { get; private set; } = new List<IInternalEvent>();
        public void AddEvent(IInternalEvent @event)
        {
            Events.Add(@event);
        }
        public void Clear()
        {
            Events = new List<IInternalEvent>();
        }
    }
}
