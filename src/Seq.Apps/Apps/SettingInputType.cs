namespace Seq.Apps
{
    /// <summary>
    /// Specifies the user input control that displays and edits values
    /// supplied for the setting.
    /// </summary>
    public enum SettingInputType
    {
        /// <summary>
        /// The default value; determines an appropriate input
        /// type based on the associated property.
        /// </summary>
        Unspecified,

        /// <summary>
        /// A single line of text.
        /// </summary>
        Text,

        /// <summary>
        /// A block of text possibly including newlines.
        /// </summary>
        LongText,
        
        /// <summary>
        /// A Boolean yes/no checkbox.
        /// </summary>
        Checkbox,
        
        /// <summary>
        /// A numeric input not accepting factional parts.
        /// </summary>
        Integer,
        
        /// <summary>
        /// A numeric input with a possible fractional part.
        /// </summary>
        Decimal,

        /// <summary>
        /// A single line of text that is written but never read or
        /// displayed.
        /// </summary>
        Password
    }
}