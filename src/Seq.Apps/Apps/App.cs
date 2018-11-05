using System;
using System.Collections.Generic;

namespace Seq.Apps
{
    /// <summary>
    /// A running Seq app (instance).
    /// </summary>
    public class App
    {
        /// <summary>
        /// Create an app.
        /// </summary>
        /// <param name="id">The id assigned by Seq to the app instance.</param>
        /// <param name="title">The app instance title configured by the user in Seq.</param>
        /// <param name="settings">Settings applied to the app.</param>
        /// <param name="storagePath">A folder in which the app may store data.</param>
        public App(string id, string title, IReadOnlyDictionary<string, string> settings, string storagePath)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));
            if (title == null) throw new ArgumentNullException(nameof(title));
            if (settings == null) throw new ArgumentNullException(nameof(settings));
            if (storagePath == null) throw new ArgumentNullException(nameof(storagePath));
            Id = id;
            Title = title;
            Settings = settings;
            StoragePath = storagePath;
        }

        /// <summary>
        /// Settings applied to the app.
        /// </summary>
        public IReadOnlyDictionary<string, string> Settings { get; }

        /// <summary>
        /// A folder in which the app may store data.
        /// </summary>
        public string StoragePath { get; }

        /// <summary>
        /// The id assigned by Seq to the app instance.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// The app instance title configured by the user in Seq.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Get a required setting.
        /// </summary>
        /// <typeparam name="T">The setting type.</typeparam>
        /// <param name="name">The setting name.</param>
        /// <returns>The setting.</returns>
        public T GetSetting<T>(string name)
        {
            if (!Settings.TryGetValue(name, out var value) || string.IsNullOrWhiteSpace(value))
                throw new SeqAppException("The app requires setting '" + name + "', which has not been provided");

            return (T)Convert.ChangeType(value, typeof(T));
        }

        /// <summary>
        /// Get an optional setting.
        /// </summary>
        /// <typeparam name="T">The setting type.</typeparam>
        /// <param name="name">The setting name.</param>
        /// <param name="defaultValue">The value to use if no explicit value is provided.</param>
        /// <returns>The setting.</returns>
        public T GetSetting<T>(string name, T defaultValue)
        {
            if (!Settings.TryGetValue(name, out var value) || string.IsNullOrWhiteSpace(value))
                return defaultValue;

            return (T)Convert.ChangeType(value, typeof(T));
        }
    }
}
