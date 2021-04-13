using System;
using System.Runtime.Serialization;

namespace BL
{
    [Serializable]
    internal class NoMainAdminException : Exception
    {
        public NoMainAdminException()
        {
        }

        public NoMainAdminException(string message) : base(message)
        {
        }

        public NoMainAdminException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoMainAdminException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}