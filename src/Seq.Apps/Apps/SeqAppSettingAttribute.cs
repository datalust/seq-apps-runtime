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

        /// <summary>
        /// If set to <c>true</c>, the setting should be considered an invocation
        /// parameter (as opposed to a purely configuration-time setting). Typical
        /// invocation parameters include things like destination email addresses,
        /// notification channels, message queue names, and so-on.
        /// </summary>
        /// <remarks>
        /// At configuration-time, the Seq administrator can still decide to deny
        /// user overrides of the parameter, or select other parameters to be user-
        /// overridable. This setting provides an interface hint so that appropriate
        /// invocation parameters can be selected by default.
        /// </remarks>
        public bool IsInvocationParameter { get; set; }
    }
}
