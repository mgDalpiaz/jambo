﻿using Jambo.Domain.ServiceBus;
using System;

namespace Jambo.Domain.Model.Posts.Events
{
    public class PostHiddenDomainEvent : DomainEvent
    {
        public PostHiddenDomainEvent()
        {

        }

        public PostHiddenDomainEvent(AggregateRoot aggregateRoot)
            : base(aggregateRoot)
        {
        }
    }
}