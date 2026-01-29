using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farzinAttachment.Class
{
    class  DataAccess
    {
        
        public  DataTable getDataFromDataBase(string query)
        {
            DataTable dt = new DataTable();
            SqlCommand aSqlCommand = new SqlCommand(query);

            SqlConnection aSqlConnection = new SqlConnection();
            aSqlConnection = new SqlConnection(@"Data Source=10.130.0.30\sql2008r2;Initial Catalog=eorganization89;User ID=webservice;Password=F@rzin2017");

            aSqlCommand.Connection = aSqlConnection;

            if (aSqlConnection.State != ConnectionState.Open)
            {
                aSqlConnection.Open();
            }
            new SqlDataAdapter(aSqlCommand).Fill(dt);
            aSqlConnection.Close();
            SqlConnection.ClearPool(aSqlConnection);
            aSqlConnection = null;
            return dt;
        }

        public  string execQuery(string query)
        { 
            try
            {
                System.Data.DataTable dt = new System.Data.DataTable();
                
                SqlCommand aSqlCommand = new SqlCommand(query);

                SqlConnection aSqlConnection = new SqlConnection();
                aSqlConnection = new SqlConnection(@"Data Source=10.130.0.30\sql2008r2;Initial Catalog=eorganization89;User ID=webservice;Password=F@rzin2017");

                aSqlCommand.Connection = aSqlConnection;

                if (aSqlConnection.State != ConnectionState.Open)
                {
                    aSqlConnection.Open();
                }
                aSqlCommand.ExecuteNonQuery();
                aSqlConnection.Close();
                SqlConnection.ClearPool(aSqlConnection);
                aSqlConnection = null;

                return "query Succesfully done";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public  UserData getUserData(string userName)
        {
            DataTable dt = new DataTable();
            SqlCommand aSqlCommand = new SqlCommand("SELECT [Password],r.Role_ID,u.User_ID,parentid FROM dbo.Users u JOIN dbo.Roles r ON u.User_ID=r.UserID WHERE USERNAME ='" + userName + "'");

            SqlConnection aSqlConnection = new SqlConnection();
            aSqlConnection = new SqlConnection(@"Data Source=10.130.0.30\sql2008r2;Initial Catalog=eorganization89;User ID=webservice;Password=F@rzin2017");

            aSqlCommand.Connection = aSqlConnection;
            if (aSqlConnection.State != ConnectionState.Open)
            {
                aSqlConnection.Open();
            }
            new SqlDataAdapter(aSqlCommand).Fill(dt);
            aSqlConnection.Close();
            SqlConnection.ClearPool(aSqlConnection);
            aSqlConnection = null;

            UserData userData = new UserData();
            userData.Password = dt.Rows[0][0].ToString();
            userData.Roleid = Int32.Parse(dt.Rows[0][1].ToString());
            userData.UserID = Int32.Parse(dt.Rows[0][2].ToString());
            userData.parentId = Int32.Parse(dt.Rows[0][3].ToString());

            //UserData userData = new UserData();
            //userData.Password = "2344";
            //userData.Roleid = 234;
            //userData.UserID = 423;
            //userData.parentId = 21423;


            return userData;
        }
    }
}
