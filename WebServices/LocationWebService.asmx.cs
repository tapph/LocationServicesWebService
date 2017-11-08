using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using LocationServicesWebService.Common;
using LocationServicesWebService.Common.Constants;
using LocationServicesWebService.Models;

namespace LocationServicesWebService.WebServices
{
    /// <summary>
    /// Summary description for LocationWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class LocationWebService : System.Web.Services.WebService
    {

        /// <summary>
        /// Gets the current location of a vehicle vehicles
        /// </summary>
        /// <param name="model">UserLocation model</param>
        /// <remarks>
        /// Please supply the ff: parameters
        /// 1. UserId = user id of the vehicle       
        /// </remarks>
        /// <returns>JSON string </returns>
        [WebMethod]
        public string GetUserLocation(UserLocation model)
        {
            AppFunctions af = new AppFunctions();

            UserLocation userLocation = new UserLocation();

            BLL.UserLocation bll = new BLL.UserLocation();

            DataSet ds = (DataSet)bll.GetVehicleLastKnownLocation(model);

            return af.DataTableToJsonObj(ds.Tables[0]);
        }


        /// <summary>
        /// Gets the current location of the available vehicles
        /// </summary>
        /// <returns>JSON string </returns>
        [WebMethod]
        public string GetAvailableVehiclesLastKnowLocation()
        {
            AppFunctions af = new AppFunctions();

            BLL.UserLocation bll = new BLL.UserLocation();

            DataSet ds = (DataSet)bll.GetAvailableVehiclesLastKnowLocation();
            return af.DataTableToJsonObj(ds.Tables[0]);
        }

        /// <summary>
        /// Saves the current location of the user
        /// </summary>
        /// <param name="model">Required fields: UserID</param>
        /// <remarks>
        /// Please supply the ff: parameters
        /// 1. UserId = user id of the vehicle
        /// 2. DateTimeInLocation = Date and time that the vehicle is in a certain location coordinate
        /// 3. Longitude = Longitude of the vehicle's current coordinate location
        /// 4. Latitude = Latitude of the vehicle's current coordinate location
        /// </remarks>        
        /// <returns>integer 0 - Failed, 1 - Success, 2 - Exception Occured </returns>
        [WebMethod]
        public Result SaveLocationData(UserLocation model)
        {
            
            BLL.UserLocation bll = new BLL.UserLocation();

            return bll.SaveLocationData(model);            
        }



    }


}
