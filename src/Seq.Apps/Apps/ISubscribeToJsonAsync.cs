using System.Threading.Tasks;

namespace Seq.Apps
{
    /// <summary>
    /// Subscribes an app to events formatted as CLEF JSON, with the event handled asynchronously.
    /// </summary>
    public interface ISubscribeToJsonAsync
    {
        /// <summary>
        /// Invoked when an event is sent to a reactor.
        /// </summary>
        /// <param name="json">The event, formatted as CLEF JSON.</param>
        /// <returns>A <see cref="Task"/> that will complete when the app has finished handling the event.</returns>
        Task OnAsync(string json);
    }
}
