﻿using System;
using System.Runtime.Serialization;

namespace FreeCourse.Web.Exceptions
{
    public class UnAuthorizeException : Exception
    {

        public UnAuthorizeException() : base()
        {
        }

        public UnAuthorizeException(string message) : base(message)
        {
        }

        public UnAuthorizeException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
