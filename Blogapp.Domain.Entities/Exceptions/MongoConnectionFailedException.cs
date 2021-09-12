﻿using System;
using System.Runtime.Serialization;

namespace Blogapp.Domain.Entities.Exceptions
{
    public class MongoConnectionFailedException : Exception
    {
        public MongoConnectionFailedException() : base()
        {
        }
        public MongoConnectionFailedException(string message) : base(message)
        {
        }
        public MongoConnectionFailedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MongoConnectionFailedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
