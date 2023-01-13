using System;
using System.Runtime.Serialization;

namespace Back_end_Development_Assignment_1
{
    [Serializable]
    public class InvalidArmorException : Exception
    {
        public InvalidArmorException()
        {
        }

        public InvalidArmorException(string message) : base(message)
        {
        }

        public InvalidArmorException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidArmorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}