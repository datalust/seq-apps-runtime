using System.IO;

namespace Seq.Apps
{
    /// <summary>
    /// When implemented by a <see cref="SeqApp"/>, the app will be treated as an input, and given the
    /// opportunity to publish events back to Seq.
    /// </summary>
    public interface IPublishJson
    {
        /// <summary>
        /// Start publishing events.
        /// </summary>
        /// <remarks>The app must synchronize its use of <paramref name="inputWriter"/> so that events
        /// are not interleaved. The app should return immediately from this method call.</remarks>
        /// <param name="inputWriter">A <see cref="TextWriter"/> through which the app can write newline-delimited, CLEF-formatted
        /// JSON events for ingestion into Seq.</param>
        void Start(TextWriter inputWriter);

        /// <summary>
        /// Called when the app should stop publishing events. This call should block until publishing is stopped.
        /// </summary>
        void Stop();
    }
}
