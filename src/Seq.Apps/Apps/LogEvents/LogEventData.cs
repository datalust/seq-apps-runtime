using System;
using System.Collections.Generic;

namespace Seq.Apps.LogEvents
{
    /// <summary>
    /// Represents event data generated via log data.
    /// </summary>
    public class LogEventData
    {
        /// <summary>
        /// The identifier assigned to the event by Seq.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The local timestamp at which the event was generated.
        /// </summary>
        public DateTimeOffset LocalTimestamp { get; set; }

        /// <summary>
        /// The level of the event.
        /// </summary>
        public LogEventLevel Level { get; set; }

        /// <summary>
        /// The template for the log event message.
        /// </summary>
        public string MessageTemplate { get; set; }

        /// <summary>
        /// The rendered message.
        /// </summary>
        public string RenderedMessage { get; set; }

        /// <summary>
        /// The exception associated with the event, or null.
        /// </summary>
        public string Exception { get; set; }

        /// <summary>
        /// Structured properties associated with the event.
        /// </summary>
        public IReadOnlyDictionary<string, object> Properties { get; set; }
    }
}
