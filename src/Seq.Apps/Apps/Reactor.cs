using System;
using Serilog;

namespace Seq.Apps
{
    /// <summary>
    /// A reactor is an object that reacts to events.
    /// </summary>
    public abstract class Reactor
    {
        IAppHost _host;

        /// <summary>
        /// Attach the reactor instance to the host.
        /// </summary>
        /// <param name="host">The host running the reactor.</param>
        public void Attach(IAppHost host)
        {
            _host = host;
            OnAttached();
        }

        /// <summary>
        /// The app to which the reactor belongs.
        /// </summary>
        protected App App => _host.App;

        /// <summary>
        /// The Seq instance running the app.
        /// </summary>
        protected Host Host => _host.Host;

        /// <summary>
        /// A logger allowing the reactor to itself raise events.
        /// </summary>
        protected ILogger Log => _host.Logger;

        /// <summary>
        /// A folder in which the app may store data.
        /// </summary>
        [Obsolete("Use App.StoragePath")]
        protected string StoragePath => _host.App.StoragePath;

        /// <summary>
        /// Called after all configuration has completed, but before any
        /// events are sent to the app.
        /// </summary>
        protected virtual void OnAttached()
        {
        }
    }
}
