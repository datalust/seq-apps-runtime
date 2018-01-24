using System;
using Serilog;

namespace Seq.Apps
{
    /// <summary>
    /// Link from a reactor back to the process in which it is running.
    /// </summary>
    public interface IAppHost
    {
        /// <summary>
        /// The app being run.
        /// </summary>
        App App { get; }

        /// <summary>
        /// The host running the app.
        /// </summary>
        Host Host { get; }

        /// <summary>
        /// A logger through which the app can raise events.
        /// </summary>
        ILogger Logger { get; }

        /// <summary>
        /// A folder in which the app may store data.
        /// </summary>
        [Obsolete("Use App.StoragePath")]
        string StoragePath { get; }
    }
}