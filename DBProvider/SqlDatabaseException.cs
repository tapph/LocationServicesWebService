﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocationServicesWebService.DBProvider
{
    /// <summary>
    /// Represents errors that occur during application execution.
    /// </summary>
    public class SqlDatabaseException : Exception
    {

        /// <summary>
        /// Initializes a new instance of the ADO.SqlDatabaseException class.
        /// </summary>
        public SqlDatabaseException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ADO.SqlDatabaseException class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public SqlDatabaseException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ADO.SqlDatabaseException class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public SqlDatabaseException(string message, Exception innerException)
            : base(message, innerException)
        {
        }



    }
}
