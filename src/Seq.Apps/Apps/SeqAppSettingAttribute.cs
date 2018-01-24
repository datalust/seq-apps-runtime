using System;

namespace Seq.Apps
{
    /// <summary>
    /// Marks a property on a <see cref="Reactor"/> type as being provided by
    /// the app user.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class SeqAppSettingAttribute : Attribute
    {
        /// <summary>
        /// The user-friendly setting name, if this differs from the
        /// name of the property.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Optional text to display to the user when providing values.
        /// </summary>
        public string HelpText { get; set; }

        /// <summary>
        /// If true, the user can provide null/blank/0 as an appropriate value.
        /// </summary>
        public bool IsOptional { get; set; }

        /// <summary>
        /// The style of user input control that is used to edit the setting.
        /// If not set, an appropriate input type will be chosen based on
        /// the type of the property.
        /// </summary>
        public SettingInputType InputType { get; set; }
    }
}
