using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LocationServicesWebService.Models;
using LocationServicesWebService.DAL;

namespace LocationServicesWebService.BLL
{
    public class UserLocation
    {
        UserLocationDAL dal = new UserLocationDAL();
        public UserLocation()
        { }

        public Result SaveLocationData(Models.UserLocation model)
        {
            return dal.SaveLocationData(model);
        }

        public Object GetVehicleLastKnownLocation(Models.UserLocation model)
        {
            return dal.GetVehicleLastKnownLocation(model);

        }

        public Object GetAvailableVehiclesLastKnowLocation()
        {
            return dal.GetAvailableVehiclesLastKnowLocation();

        }
    }
}