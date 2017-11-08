using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocationServicesWebService.Models
{
    [Serializable]
    public class UserLocation
    {
        public UserLocation()
        { }

        private long _id;
        private int _userid;
        private DateTime _datetimeinlocation;
        private double _longitude;
        private double _latitude;

        /// <summary>
        /// Unique Identifier / Primary Key
        /// </summary>
        public long ID
        {
            set { _id = value; }
            get { return _id; }
        }

        /// <summary>
        /// User ID 
        /// </summary>
        public int UserID
        {
            set { _userid = value; }
            get { return _userid; }
        }
        
        /// <summary>
        /// Date and Time that a user is in a longitude/latitude
        /// </summary>
        public DateTime DateTimeInLocation
        {
            set { _datetimeinlocation = value; }
            get { return _datetimeinlocation; }
        }

        /// <summary>
        /// Longitude of the user's current location
        /// </summary>
        public double Longitude
        {
            set { _longitude = value; }
            get { return _longitude; }
        }

        /// <summary>
        /// Latitude of the user's current location
        /// </summary>
        public double Latitude
        {
            set { _latitude = value; }
            get { return _latitude; }
        }

    }
}