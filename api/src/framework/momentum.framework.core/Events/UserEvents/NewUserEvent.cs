using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace momentum.framework.core.Events.UserEvents
{
    public class NewUserEvent : IInternalEvent, INotification //TODO: convert everything from IInternalEvent to INotification
    {
        public Guid UserId { get; set; }

        public Guid? FromUserId { get; set; }
    }
}
