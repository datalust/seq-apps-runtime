using System;
using System.Runtime.Serialization;

namespace Seq.Apps
{
    /// <summary>
    /// Exception thrown by a Seq app
    /// </summary>
    [Serializable]
    public class SeqAppException : Exception
    {
        /// <summary>
        /// Create an instance of the exception with the provided message.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public SeqAppException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Create an instance of the exception with the provided message and inner exception.
        /// </summary>
        /// <param name="message">The exception message.</param>
        /// <param name="innerException">The inner exception.</param>
        public SeqAppException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Create an instance of the exception from serialized data.
        /// </summary>
        /// <param name="context">The streaming context.</param>
        /// <param name="info">The serialization info.</param>
        public SeqAppException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
