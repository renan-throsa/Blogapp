using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Blogapp.Domain.Repositories.Contract.Exceptions
{
    [Serializable]
    public class MissingIdOnEntityException : Exception
    {
        public MissingIdOnEntityException()
        {
        }

        public MissingIdOnEntityException(string message) : base(message)
        {
        }

        public MissingIdOnEntityException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MissingIdOnEntityException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
