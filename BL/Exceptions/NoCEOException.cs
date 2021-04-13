using System;
using System.Runtime.Serialization;

namespace BL
{
    [Serializable]
    internal class NoCEOException : Exception
    {
        public NoCEOException()
        {
        }

        public NoCEOException(string message) : base(message)
        {
        }

        public NoCEOException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoCEOException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}