﻿using System;

namespace CalculatesInterest.Domain.Exceptions
{
    public class ServiceUnavailableException : Exception
    {
        public ServiceUnavailableException()
        {

        }
        public ServiceUnavailableException(string message) : base(message)
        {

        }

        public ServiceUnavailableException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
