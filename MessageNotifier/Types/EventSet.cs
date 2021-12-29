using System;
using System.Collections.Generic;
using System.Threading;

namespace MessageNotifier.Types
{
    public class EventKey { }

    public class EventSet
    {
        private readonly Dictionary<EventKey, Delegate> eventsDict = new Dictionary<EventKey, Delegate>();

        public void Add(EventKey eventKey, Delegate handler)
        {            
            Monitor.Enter(eventsDict);

            Monitor.Exit(eventsDict);
        }
    }
}
