using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using LocationServicesWebService.DBProvider;
using LocationServicesWebService.Models;
using LocationServicesWebService.Common.Constants;


namespace LocationServicesWebService.DAL
{
    public class UserLocationDAL
    {
        public UserLocationDAL()
        { }

        public Result SaveLocationData(UserLocation model)
        {

            SQLConnection ConnStr = new SQLConnection();
            SqlDatabase sqldb = new SqlDatabase(ConnStr.SQLConnectionString());

            SqlParameter[] @params = new SqlParameter[5];
            Result result = new Result();

            int fnReturnValue;
            
            @params[0] = new SqlParameter("@userid", SqlDbType.Int);
            @params[0].Value = model.UserID;

            @params[1] = new SqlParameter("@datetimeinlocation", SqlDbType.DateTime);
            @params[1].Value = model.DateTimeInLocation;

            @params[2] = new SqlParameter("@longitude", SqlDbType.Float);
            @params[2].Value = model.Longitude;

            @params[3] = new SqlParameter("@latitude", SqlDbType.Float);
            @params[3].Value = model.Latitude;

            @params[4] = new SqlParameter("@result", SqlDbType.Int);
            @params[4].Direction = ParameterDirection.Output;

            try
            {
                sqldb.ExecuteReader("SaveLocationData", CommandType.StoredProcedure, @params);
                fnReturnValue =int.Parse(@params[4].Value.ToString());
            }

            catch (SqlDatabaseException ex)
            {
                fnReturnValue = ResponseCode.EXCEPTION_OCCURED;
                result.Message = ex.Message.ToString();
                result.MessageDetails = ex.InnerException.ToString();

            }

            result.ReturnCode = fnReturnValue;
            return result;
        }

        public Object GetUserLocation(UserLocation model)
        {

            SQLConnection ConnStr = new SQLConnection();
            SqlDatabase sqldb = new SqlDatabase(ConnStr.SQLConnectionString());

            SqlParameter[] @params = new SqlParameter[1];
            

           
            @params[0] = new SqlParameter("@userid", SqlDbType.Int);
            @params[0].Value = model.UserID;
            

            try
            {

                DataSet ds = sqldb.FillDataset("SaveLocationData", CommandType.StoredProcedure, @params);

                return ds;
            }

            catch (SqlDatabaseException ex)
            {
                return ex;
            }
            
        }

        public Object GetVehicleLastKnownLocation(UserLocation model)
        {

            SQLConnection ConnStr = new SQLConnection();
            SqlDatabase sqldb = new SqlDatabase(ConnStr.SQLConnectionString());

            SqlParameter[] @params = new SqlParameter[1];



            @params[0] = new SqlParameter("@userid", SqlDbType.Int);
            @params[0].Value = model.UserID;


            try
            {

                DataSet ds = sqldb.FillDataset("GetVehicleLastKnownLocation", CommandType.StoredProcedure, @params);

                return ds;
            }

            catch (SqlDatabaseException ex)
            {
                return ex;
            }

        }

        public Object GetAvailableVehiclesLastKnowLocation()
        {

            SQLConnection ConnStr = new SQLConnection();
            SqlDatabase sqldb = new SqlDatabase(ConnStr.SQLConnectionString());

            try
            {

                DataSet ds = sqldb.FillDataset("GetAvailableVehiclesLastKnowLocation", CommandType.StoredProcedure);

                return ds;
            }

            catch (SqlDatabaseException ex)
            {
                return ex;
            }

        }
    }
}