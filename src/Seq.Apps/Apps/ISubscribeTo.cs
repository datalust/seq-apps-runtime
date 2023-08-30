namespace Seq.Apps
{
    /// <summary>
    /// Subscribes an app to a typed event.
    /// </summary>
    /// <typeparam name="TData">The type representing event data.</typeparam>
    /// <remarks>Use <see cref="ISubscribeToJsonAsync" /> for new code when possible.</remarks>
    public interface ISubscribeTo<TData>
    {
        /// <summary>
        /// Invoked when an event is sent to a reactor.
        /// </summary>
        /// <param name="evt">The event.</param>
        void On(Event<TData> evt);
    }
}