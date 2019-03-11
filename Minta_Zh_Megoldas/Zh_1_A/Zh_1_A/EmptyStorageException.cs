using System;
using System.Runtime.Serialization;

namespace Zh_1_A
{
    internal class EmptyStorageException : Exception
    {
        private int length;

        public EmptyStorageException()
        {
        }

        public EmptyStorageException(int length)
        {
            this.length = length;
        }

        public EmptyStorageException(string message) : base(message)
        {
        }

        public EmptyStorageException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EmptyStorageException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}