using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Jan_Prototype
{

    public partial class MeetingScheduler : Form
    {
        private Data data = new Data();
        private string username;
        private int selectedMeetingID;
        SqlConnection con;
        //string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Jan_Prototype\Jan_Prototype\DB.mdf;Integrated Security=True";

        public MeetingScheduler(string username, bool admin)
        {
            InitializeComponent();

            this.username = username;

            timePickerFrom.Format = DateTimePickerFormat.Time;
            timePickerFrom.ShowUpDown = true;

            timePickerTo.Format = DateTimePickerFormat.Time;
            timePickerTo.ShowUpDown = true;
        }


        private void MeetingScheduler_Load(object sender, EventArgs e)
        {
            lblWelcome.Text += " " + this.username;

            try
            {
                con = new SqlConnection(data.str);
                con.Open();

                string qry = "SELECT accountName FROM Account";
                SqlDataReader dr = new SqlCommand(qry, con).ExecuteReader();

                while (dr.Read())
                {
                      listParticipants.Items.Add(dr.GetValue(0));
                }

                dr.Close();

                string roomQry = "SELECT roomNumber FROM Rooms";
                SqlDataReader roomDr = new SqlCommand(roomQry, con).ExecuteReader();

                while (roomDr.Read())
                    listRooms.Items.Add(roomDr.GetValue(0));

                roomDr.Close();

            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message.ToString());
            }

            loadRequests();
            loadSchedule();

        }

        private void loadSchedule()
        {
            try
            {

                using (SqlConnection con = new SqlConnection(data.str))
                {
                    con.Open();

                    string scheduleSql = @"SELECT 
                                                Meeting.meetingID,
                                                Meeting.meetingDate, 
                                                Meeting.meetingName, 
                                                Meeting.meetingTimeFrom, 
                                                Meeting.meetingTimeTo, 
                                                Meeting.meetingDescription,
                                                Rooms.roomNumber
                                            FROM Meeting 
                                            INNER JOIN Rooms ON Rooms.RoomID = meeting.meetingRoomID
                                            INNER JOIN Requests ON Requests.meetingID = Meeting.meetingID
                                            WHERE Requests.accepted = 1 AND Meeting.cancelled <> 1";



                    using (SqlCommand cmd = new SqlCommand(scheduleSql, con))
                    {

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            var commandBuilder = new SqlCommandBuilder(da);
                            var ds = new DataSet();
                            da.Fill(ds);
                            dataSchedule.DataSource = ds.Tables[0];

                        }
                    }

                    con.Close();

                }

            }
            catch (SqlException x)
            {
                MessageBox.Show(x.ToString());
            }
        }
        private void loadRequests()
        {
            try
            {

                using (SqlConnection con = new SqlConnection(data.str))
                {
                    con.Open();

                    string meetingSql = @"SELECT 
                                                Requests.requestID,
                                                Account.accountName,
                                                Meeting.meetingID,
                                                Meeting.meetingName, 
                                                Meeting.meetingDate, 
                                                Meeting.meetingTimeFrom, 
                                                Meeting.meetingTimeTo, 
                                                Meeting.meetingDescription,
                                                Rooms.roomNumber,
                                                Requests.accepted
                                            FROM Meeting 
                                            INNER JOIN Rooms ON Rooms.RoomID = meeting.meetingRoomID
                                            INNER JOIN Requests ON Meeting.meetingID = Requests.meetingID
                                            INNER JOIN Account ON Requests.accountID = Account.AccountID
                                            WHERE Requests.accepted = 0";



                    using (SqlCommand cmd = new SqlCommand(meetingSql, con))
                    {

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            var commandBuilder = new SqlCommandBuilder(da);
                            var ds = new DataSet();
                            da.Fill(ds);
                            dataRequests.DataSource = ds.Tables[0];
                        }
                    }

                    con.Close();

                }

            }
            catch (SqlException x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            this.Visible = false;

            LoginForm lForm = new LoginForm();

            lForm.Show();
        }




        private void btnRequestMeeting_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = DateTime.Parse(datePicker.Value.ToShortDateString());
            int roomID = listRooms.SelectedIndex;


            var newTimeFrom = TimeSpan.Parse(timePickerFrom.Value.ToString("t"));
            var newTimeTo = TimeSpan.Parse(timePickerTo.Value.ToString("t"));

            string meetingDetails = "";
            bool meetingFound = false;

            try
            {

                using (SqlConnection con = new SqlConnection(data.str))
                {
                    con.Open();

                    string meetingSql = @"SELECT * FROM Meeting
                                               WHERE 
                                                     meetingDate = @date AND
                                                     meetingRoomID = @roomID AND
                                                     meetingTimeFrom BETWEEN @timeFrom AND @timeTo";

                    using (SqlCommand cmd = new SqlCommand(meetingSql, con))
                    {
                        cmd.Parameters.AddWithValue("@date", selectedDate);
                        cmd.Parameters.AddWithValue("@roomID", roomID);
                        cmd.Parameters.AddWithValue("@timeFrom", newTimeFrom);
                        cmd.Parameters.AddWithValue("@timeTo", newTimeTo);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                meetingDetails += "  " + dr.GetValue(3).ToString();
                                meetingDetails += "  " + dr.GetValue(4).ToString();
                                meetingDetails += "  " + dr.GetValue(5).ToString();
                                meetingDetails += "  " + dr.GetValue(6).ToString();
                                meetingFound = true;
                            }
                        }
                    }

                    con.Close();

                }

            }
            catch (SqlException x)
            {
                MessageBox.Show(x.ToString());
            }

            if (meetingFound)
            {
                MessageBox.Show("Meeting already booked! : " + meetingDetails);
            }
            else if (canParticipantsAttend(selectedDate) == false)
            {
                MessageBox.Show("User cannot attend that day. The data selected is in their exclusion range. Ask the user to possibly remove a date from exclusion range. ");
            }
            else
            {
                MessageBox.Show("Meeting requests have been sent out to the appropriate participants.");
                insertIntoDatabase();
                loadRequests();
            }

      }

        private bool canParticipantsAttend(DateTime date)
        {
            bool canAttend = true;

            foreach (var item in listParticipants.SelectedItems)
            {

                int accountID = data.getAccountID(item.ToString());

                if (! data.canAttend(accountID, date))
                {
                    canAttend = false;
                }

                
            }

            return canAttend;
        }



    private void insertIntoDatabase() {
            DateTime date = DateTime.Parse(datePicker.Value.ToShortDateString());
            int important = 0;

            if (chkImportant.Checked)
                important = 1;

            try
            {
                using (SqlConnection con = new SqlConnection(data.str))
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Meeting VALUES (@Name, @Description, @Date, @TimeFrom, @TimeTo, @RoomID, @important)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Description", txtComments.Text);
                    cmd.Parameters.AddWithValue("@Date", date);
                    cmd.Parameters.AddWithValue("@TimeFrom", timePickerFrom.Value.ToLongTimeString());
                    cmd.Parameters.AddWithValue("@TimeTo", timePickerTo.Value.ToLongTimeString());
                    cmd.Parameters.AddWithValue("@RoomID", listRooms.SelectedIndex);
                    cmd.Parameters.AddWithValue("@important", important);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    con.Close();
                }

            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message.ToString());
            }


            foreach (var item in listParticipants.SelectedItems)
            {

                int accountID = data.getAccountID(item.ToString());

                if (!data.canAttend(accountID, date))

                    MessageBox.Show(item.ToString() + " cannot attend that date.");


                //if user can attend
                try
                {
                    using (SqlConnection con = new SqlConnection(data.str))
                    {
                        con.Open();
                        SqlCommand requestCmd = new SqlCommand("INSERT INTO Requests VALUES (@meetingID, @accountID, 0)");
                        requestCmd.CommandType = CommandType.Text;
                        requestCmd.Connection = con;
                        requestCmd.Parameters.AddWithValue("@accountID", accountID);
                        int lastMeetingID = data.getLastMeetingID();
                        requestCmd.Parameters.AddWithValue("@meetingID", lastMeetingID);
                        requestCmd.ExecuteNonQuery();

                        con.Close();

                    }
                }
                catch (SqlException x)
                {
                    MessageBox.Show(x.Message.ToString());
                }

            }
    }

    private void btnSeeCancelled_Click(object sender, EventArgs e)
    {
        this.Hide();

        CancellationsForm cf = new CancellationsForm();
        cf.Show();
    }

    private void dataSchedule_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        string users = "";
        try
        {

            using (SqlConnection con = new SqlConnection(data.str))
            {
                con.Open();

                string usersSql = @"SELECT DISTINCT
                                   Account.accountName
                                    FROM Requests
                                    INNER JOIN Account ON Requests.accountID = Account.accountID
                                    INNER JOIN Meeting ON Meeting.meetingID = Requests.meetingID";

                using (SqlCommand cmd = new SqlCommand(usersSql, con))
                {
                    cmd.Parameters.AddWithValue("@meetingID", selectedMeetingID);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            users += dr.GetValue(0).ToString();
                        }
                    }
                }

                con.Close();

            }

        }
        catch (SqlException x)
        {
            MessageBox.Show(x.ToString());
        }

        MessageBox.Show(users);

    }

    private void btnCancelMeeting_Click(object sender, EventArgs e)
    {
        try
        {

            using (SqlConnection con = new SqlConnection(data.str))
            {
                con.Open();

                string cancelSql = @"UPDATE Meeting SET cancelled = 1
                                        WHERE meetingID = @meetingID";

                using (SqlCommand cmd = new SqlCommand(cancelSql, con))
                {
                    cmd.Parameters.AddWithValue("@meetingID", selectedMeetingID);

                    cmd.ExecuteNonQuery();
                }

                con.Close();

            }

        }
        catch (SqlException x)
        {
            MessageBox.Show(x.ToString());
        }

        dataSchedule.Rows.RemoveAt(dataSchedule.SelectedRows[0].Index);

        MessageBox.Show("Meeting Successfully Cancelled - Users Have Been Notified.");

    }

    private void btnManageUsers_Click(object sender, EventArgs e)
    {

    }

    private void dataSchedule_SelectionChanged(object sender, EventArgs e)
    {
        foreach (DataGridViewRow row in dataSchedule.SelectedRows)
        {
            selectedMeetingID = Convert.ToInt32(row.Cells[0].Value);

        }
    }

    private void button1_Click(object sender, EventArgs e)
    {

            string str;

            System.Data.SqlClient.SqlConnectionStringBuilder builder =
                new System.Data.SqlClient.SqlConnectionStringBuilder();
            builder["Data Source"] = "(local)";
            builder["integrated Security"] = true;
            builder["Initial Catalog"] = "AdventureWorks;NewValue=Bad";

            MessageBox.Show( builder.ConnectionString);
        
    }



}

}
