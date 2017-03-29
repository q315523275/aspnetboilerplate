﻿using System;
using System.Runtime.Serialization;

namespace Abp.Domain.Uow
{
#if NET46
    [Serializable]
#endif
    public class AbpDbConcurrencyException : AbpException
    {
        /// <summary>
        /// Creates a new <see cref="AbpDbConcurrencyException"/> object.
        /// </summary>
        public AbpDbConcurrencyException()
        {

        }

#if NET46
        /// <summary>
        /// Creates a new <see cref="AbpException"/> object.
        /// </summary>
        public AbpDbConcurrencyException(SerializationInfo serializationInfo, StreamingContext context)
            : base(serializationInfo, context)
        {

        }
#endif

        /// <summary>
        /// Creates a new <see cref="AbpDbConcurrencyException"/> object.
        /// </summary>
        /// <param name="message">Exception message</param>
        public AbpDbConcurrencyException(string message)
            : base(message)
        {

        }

        /// <summary>
        /// Creates a new <see cref="AbpDbConcurrencyException"/> object.
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="innerException">Inner exception</param>
        public AbpDbConcurrencyException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}