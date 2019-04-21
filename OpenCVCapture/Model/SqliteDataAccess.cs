using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace OpenCVCapture.Model
{
    public class SqliteDataAccess
    {  
        public static void SaveCaptureImage(CaptureImageModel captureImageModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Query<CaptureImageModel>(
                        "insert into CaptureImage(SaveTime,SavePath) values(@SaveTime,@SavePath)", captureImageModel);
                }
            }
            catch (Exception e)
            {
                //need to add error hold and log here
            }        
        }

        //This method is used only for test purpose
        public static List<CaptureImageModel> LoadCaptureImage()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CaptureImageModel>("select * from CaptureImage", new DynamicParameters());
                return output.ToList();
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
           return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
