using System;
using System.Collections.Generic;

namespace Crayon.Api.Sdk.Domain.Csp
{
    public class CoterminositySubscriptions
    {
        public CoterminositySubscriptions(List<SubscriptionCoterminosity> subscriptions,DateTime calendarMonthDate)
        {
            Subscriptions = subscriptions;
            CalendarMonthDate = calendarMonthDate;
        }

        public DateTime CalendarMonthDate { get; set; }
        public List<SubscriptionCoterminosity> Subscriptions { get; set; }
    }

    public class SubscriptionCoterminosity
    {
        public int Id { get; set; }

        public string PublisherSubscriptionId { get; set; }

        public string FriendlyName { get; set; }

        public string TermDuration { get; set; }

        public DateTime? EndDate { get; set; }
    }
}
