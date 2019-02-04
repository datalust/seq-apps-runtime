using System;

namespace Seq.Apps
{
    /// <summary>
    /// A reactor is an object that reacts to events.
    /// </summary>
    [Obsolete("Derive from SeqApp instead")]
    public abstract class Reactor : SeqApp
    {
        /// <summary>
        /// Attach the reactor instance to the host.
        /// </summary>
        /// <param name="host">The host running the reactor.</param>
        public new void Attach(IAppHost host)
        {
            base.Attach(host);
        }

        /// <summary>
        /// A folder in which the app may store data.
        /// </summary>
        protected string StoragePath => App.StoragePath;
    }
}
