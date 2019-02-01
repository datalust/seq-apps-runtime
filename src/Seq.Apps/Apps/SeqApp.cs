using Serilog;

namespace Seq.Apps
{
    /// <summary>
    /// A Seq app; the app can subscribe to events by implementing <see cref="ISubscribeToJsonAsync"/>, <see cref="ISubscribeTo{TData}"/>, or
    /// <see cref="ISubscribeToAsync{TData}"/>, or produce events by implementing <see cref="IPublishJson"/>.
    /// </summary>
    /// <remarks>Apps are hosted in a single-threaded manner: initialization and event firing and disposal are
    /// performed on the same thread. Apps themselves may maintain captive threads for ingestion and
    /// interact with the host's logger, if required.</remarks>
    public abstract class SeqApp
    {
        IAppHost _host;

        /// <summary>
        /// Attach the app instance to the host.
        /// </summary>
        /// <param name="host">The host running the reactor.</param>
        public void Attach(IAppHost host)
        {
            _host = host;
            OnAttached();
        }

        /// <summary>
        /// The app to which the instance belongs.
        /// </summary>
        protected App App => _host.App;

        /// <summary>
        /// The Seq instance running the app.
        /// </summary>
        protected Host Host => _host.Host;

        /// <summary>
        /// A logger allowing the app raise diagnostic events.
        /// </summary>
        protected ILogger Log => _host.Logger;
        
        /// <summary>
        /// Called after all configuration has completed, but before any
        /// events are sent to the app and before ingestion begins. The
        /// app should use this event to validate its configuration.
        /// </summary>
        protected virtual void OnAttached()
        {
        }
    }
}