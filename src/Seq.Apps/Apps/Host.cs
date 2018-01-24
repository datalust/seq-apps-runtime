namespace Seq.Apps
{
    /// <summary>
    /// Represents the Seq instance running the app.
    /// </summary>
    public class Host
    {
        /// <summary>
        /// Create a <see cref="Host"/>.
        /// </summary>
        /// <param name="instanceName">The name of the Seq instance, or null.</param>
        /// <param name="listenUris">The URIs at which the server is listening.</param>
        public Host(string[] listenUris, string instanceName)
        {
            InstanceName = instanceName;
            ListenUris = listenUris;
        }

        /// <summary>
        /// The name of the Seq instance, or null.
        /// </summary>
        public string InstanceName { get; }

        /// <summary>
        /// The URIs at which the server is listening.
        /// </summary>
        public string[] ListenUris { get; }
    }
}