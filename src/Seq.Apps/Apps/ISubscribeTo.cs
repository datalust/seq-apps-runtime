namespace Seq.Apps
{
    /// <summary>
    /// Subscribes a reactor to a typed event.
    /// </summary>
    /// <typeparam name="TData">The type representing event data.</typeparam>
    public interface ISubscribeTo<TData>
    {
        /// <summary>
        /// Invoked when an event is sent to a reactor.
        /// </summary>
        /// <param name="evt">The event.</param>
        void On(Event<TData> evt);
    }
}