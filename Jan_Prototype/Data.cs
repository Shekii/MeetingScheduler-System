using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace Jan_Prototype
{


    class Data
    {

    /* 
     * 
     *  READ USER MANUAL ON HOW TO PROPERLY CHANGE CONNECTION STRING
     *  1. Open Solution Explorer
     *  2. Double Click on "DB.mdf"
     *  3. Right Click on "Db.mdf" under "Data Connections" and Select "Properties"
     *  4. Copy "Connection String" and paste into the string below
     */
       public string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Jan_Prototype\Jan_Prototype\DB.mdf;Integrated Security=True";
       /* 
        * 
        * */



        public DateTime getStartDate(int accountID)
        {
            DateTime startDate = DateTime.Now;

            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();

                string exclusionStartSql = "SELECT exclusionStart FROM Account WHERE accountID = @accountID";

                using (SqlCommand cmd = new SqlCommand(exclusionStartSql, con))
                {
                    cmd.Parameters.AddWithValue("@accountID", accountID);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            startDate = Convert.ToDateTime(dr.GetValue(0));
                        }
                    }
                }

            }

            return startDate;
        }
        public DateTime getEndDate(int accountID)
        {
            DateTime endDate = DateTime.Now;

            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();

                string exclusionEndSql = "SELECT exclusionEnd FROM Account WHERE accountID = @accountID";

                using (SqlCommand cmd = new SqlCommand(exclusionEndSql, con))
                {
                    cmd.Parameters.AddWithValue("@accountID", accountID);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            endDate = Convert.ToDateTime(dr.GetValue(0));
                        }
                    }
                }

                con.Close();
            }

            return endDate;
        }
        public int getAccountID(string accountName)
        {
            int accountID = -1;
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();

                    string exclusionStartSql = "SELECT accountID FROM Account WHERE accountName = @accountName";

                    using (SqlCommand cmd = new SqlCommand(exclusionStartSql, con))
                    {
                        cmd.Parameters.AddWithValue("@accountName", accountName);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                accountID = Convert.ToInt32(dr.GetValue(0));
                            }
                        }
                    }

                    con.Close();

                }

            }
            catch (SqlException x)
            {
                return accountID;
            }

            return accountID;
        }

        public int getLastMeetingID()
        {
            int lastID = 0;

            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();

                string qry = "SELECT MAX(meetingID) FROM Meeting";
                SqlDataReader dr = new SqlCommand(qry, con).ExecuteReader();

                while (dr.Read())
                    lastID = Convert.ToInt32(dr.GetValue(0));

                dr.Close();
            }

            return lastID;
        }

        public string getUsername(int accountNo)
        {
            string username = "";
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();

                    string usernameSql = "SELECT accountName FROM Account WHERE accountID = @accountID";

                    using (SqlCommand cmd = new SqlCommand(usernameSql, con))
                    {
                        cmd.Parameters.AddWithValue("@accountID", accountNo);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                username = dr.GetValue(0).ToString();
                            }
                        }
                    }

                    con.Close();

                }

            }
            catch (SqlException x)
            {
                return x.ToString();
            }

            return username;

        }

        public void acceptRequest(int meetingId, int accountNo)
        {
            //accepted - 0 = not yet decided
            //accepted - 1 = ACCEPTED
            //accepted - 2 = DECLINED
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();

                    string acceptSql = @"UPDATE Requests SET accepted = 1
                                        WHERE meetingID = @meetingID AND accountID = @accountID";

                    using (SqlCommand cmd = new SqlCommand(acceptSql, con))
                    {
                        cmd.Parameters.AddWithValue("@accountID", accountNo);
                        cmd.Parameters.AddWithValue("@meetingID", meetingId);

                        cmd.ExecuteNonQuery();
                    }

                    con.Close();

                }

            }
            catch (SqlException x)
            {
                throw x;
            }
        }

        public void declineRequest(int meetingId, int accountNo)
        {
            //accepted - 0 = not yet decided
            //accepted - 1 = ACCEPTED
            //accepted - 2 = DECLINED
            try
            {

                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();

                    string acceptSql = @"UPDATE Requests SET accepted = 2
                                        WHERE meetingID = @meetingID AND accountID = @accountID";

                    using (SqlCommand cmd = new SqlCommand(acceptSql, con))
                    {
                        cmd.Parameters.AddWithValue("@accountID", accountNo);
                        cmd.Parameters.AddWithValue("@meetingID", meetingId);

                        cmd.ExecuteNonQuery();
                    }

                    con.Close();

                }

            }
            catch (SqlException x)
            {
                throw x;
            }
        }

        public void cancelRequest(int requestId, string reason)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();

                using (var cmd = new SqlCommand("INSERT INTO CancelledMeetings VALUES (@requestID, @reason)"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@requestID", requestId);
                    cmd.Parameters.AddWithValue("@reason", reason);
                    cmd.ExecuteNonQuery();
                }

                con.Close();
            }
        }
        public bool isMeetingImportant(int meetingId)
        {
            bool important = false;
            int importantNum = 0;
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();

                string usernameSql = "SELECT important FROM Meeting WHERE meetingID = @meetingID";

                using (SqlCommand cmd = new SqlCommand(usernameSql, con))
                {
                    cmd.Parameters.AddWithValue("@meetingID", meetingId);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            importantNum = Convert.ToInt32(dr.GetValue(0));
                        }
                    }
                }

                con.Close();

            }

            if (importantNum == 1)
            {
                important = true;
            }

            return important;
        }

        public bool canAttend(int accountId, DateTime date)
        {
            bool canAttend = true;
            DateTime startDate = getStartDate(accountId);
            DateTime endDate = getEndDate(accountId);

            for (DateTime exclusionDate = startDate; exclusionDate.Date <= endDate.Date; exclusionDate = exclusionDate.AddDays(1))
           {
              if (date == exclusionDate)
                return false;
            }

            return canAttend;
        }


    }

}
