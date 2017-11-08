using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocationServicesWebService.Models
{
    [Serializable()]
    public class Result
    {
        private int _returncode;
        private string _message;
        private string _messagedetails;

        /// <summary>
        /// Return Code integer 0 - Failed, 1 - Success, 2 - Exception Occured
        /// </summary>
        public int ReturnCode
        {
            set { _returncode = value; }
            get { return _returncode; }
        }

        /// <summary>
        /// Message
        /// </summary>
        public string Message
        {
            set { _message = value; }
            get { return _message; }
        }

        /// <summary>
        /// Message Details
        /// </summary>
        public string MessageDetails
        {
            set { _messagedetails = value; }
            get { return _messagedetails; }
        }
    }
}