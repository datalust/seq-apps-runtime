using System;

namespace Seq.Apps
{
    /// <summary>
    /// Marks the main <see cref="Reactor"/> type in a Seq app.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class SeqAppAttribute : Attribute
    {
        /// <summary>
        /// Create a <see cref="SeqAppAttribute"/> describing the app.
        /// </summary>
        /// <param name="name">The name of the app, for example "Send Email".</param>
        public SeqAppAttribute(string name)
        {
            Name = name;
        }

        /// <summary>
        /// The name of the app, for example "Send Email".
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// An optional longer description of the app's purpose.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// If set to true, instances of the app will be able to process the events that they
        /// generate. If false (the default), events from each app instance will 
        /// be filtered out of its own input.
        /// </summary>
        public bool AllowReprocessing { get; set; }
    }
}
