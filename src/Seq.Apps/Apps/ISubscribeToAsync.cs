﻿using System.Threading.Tasks;

namespace Seq.Apps
{
    /// <summary>
    /// Subscribes a app to a typed event, with the event handled asynchronously.
    /// </summary>
    /// <typeparam name="TData">The type representing event data.</typeparam>
    /// <remarks>Use <see cref="ISubscribeToJsonAsync" /> for new code when possible.</remarks>
    public interface ISubscribeToAsync<TData>
    {
        /// <summary>
        /// Invoked when an event is sent to a reactor.
        /// </summary>
        /// <param name="evt">The event.</param>
        /// <returns>A <see cref="Task"/> that will complete when the app has finished handling the event.</returns>
        Task OnAsync(Event<TData> evt);
    }
}
