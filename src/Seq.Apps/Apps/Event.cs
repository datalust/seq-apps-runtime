using System;
using System.ComponentModel;

namespace Seq.Apps
{
    /// <summary>
    /// Represents a Seq event, with a strongly-typed payload.
    /// </summary>
    /// <typeparam name="TData">The payload type.</typeparam>
    public class Event<TData>
    {
        /// <summary>
        /// Create an event with the specified parameters.
        /// </summary>
        /// <param name="id">The event ID.</param>
        /// <param name="eventType">The event type.</param>
        /// <param name="timestamp">The event timestamp.</param>
        /// <param name="data"></param>
        public Event(string id, uint eventType, DateTime timestamp, TData data)
        {
            Id = id;
            EventType = eventType;
            Timestamp = timestamp;
            Data = data;
        }

        /// <summary>
        /// The Seq event type for the event. For Serilog events this is calculated
        /// from the message template.
        /// </summary>
        public uint EventType { get; }

        /// <summary>
        /// The event timestamp.
        /// </summary>
        public DateTime Timestamp { get; }

        /// <summary>
        /// The event payload.
        /// </summary>
        public TData Data { get; }

        /// <summary>
        /// The Seq event ID.
        /// </summary>
        public string Id { get; }
        
        
        /// <summary>
        /// The event timestamp.
        /// </summary>
        [Obsolete("Use `Timestamp` instead."), EditorBrowsable(EditorBrowsableState.Never)]
        public DateTime TimestampUtc => Timestamp;
    }
}
