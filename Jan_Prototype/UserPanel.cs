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
    public partial class UserPanel : Form
    {

        private int accountNo;
        private int requestMeetingID;
        private int scheduleMeetingID;
        private int requestID;
        private Data data = new Data();

        public UserPanel(int accountNo)
        {
            InitializeComponent();

            this.accountNo = accountNo;
        }


        private void UserPanel_Load(object sender, EventArgs e)
        {
            lblWelcome.Text += " " + data.getUsername(this.accountNo);
            lblStartDate.Text = data.getStartDate(this.accountNo).ToShortDateString();
            lblEndDate.Text = data.getEndDate(this.accountNo).ToShortDateString();
            loadRequests();
            loadSchedule();
        }

        private void loadRequests()
        {

            try
            {

                using (SqlConnection con = new SqlConnection(data.str))
                {
                    con.Open();

                    string meetingSql = @"SELECT 
                                                meeting.meetingID,
                                                meeting.meetingName, 
                                                meeting.meetingDate, 
                                                meeting.meetingTimeFrom, 
                                                meeting.meetingTimeTo, 
                                                meeting.meetingDescription,
                                                Rooms.roomNumber,
                                                Requests.accepted
                                            FROM Meeting 
                                            INNER JOIN Rooms ON Rooms.RoomID = meeting.meetingRoomID
                                            INNER JOIN Requests ON Meeting.meetingID = Requests.meetingID
                                            WHERE Requests.accountID = @accountID AND Requests.accepted <> 1 AND Requests.accepted <> 2";



                    using (SqlCommand cmd = new SqlCommand(meetingSql, con))
                    {
                        cmd.Parameters.AddWithValue("@accountID", this.accountNo);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            var commandBuilder = new SqlCommandBuilder(da);
                            var ds = new DataSet();
                            da.Fill(ds);
                            dataMeetRequests.ReadOnly = true;
                            dataMeetRequests.DataSource = ds.Tables[0];                              
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

        private void loadSchedule()
        {
            try
            {

                using (SqlConnection con = new SqlConnection(data.str))
                {
                    con.Open();

                    string meetingSql = @"SELECT 
                                                meeting.meetingID,
                                                Requests.requestID,
                                                meeting.meetingDate, 
                                                meeting.meetingName,
                                                meeting.meetingTimeFrom, 
                                                meeting.meetingTimeTo, 
                                                meeting.meetingDescription,
                                                Rooms.roomNumber
                                            FROM Meeting 
                                            INNER JOIN Rooms ON Rooms.RoomID = meeting.meetingRoomID
                                            INNER JOIN Requests ON Meeting.meetingID = Requests.meetingID
                                            WHERE Requests.accountID = @accountID AND Requests.accepted = 1";



                    using (SqlCommand cmd = new SqlCommand(meetingSql, con))
                    {
                        cmd.Parameters.AddWithValue("@accountID", this.accountNo);

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

        private void addToSchedule()
        {
            try
            {

                using (SqlConnection con = new SqlConnection(data.str))
                {
                    con.Open();

                    string meetingSql = @"SELECT 
                                                meeting.meetingID,
                                                Requests.requestID,
                                                meeting.meetingDate, 
                                                meeting.meetingName,
                                                meeting.meetingTimeFrom, 
                                                meeting.meetingTimeTo, 
                                                meeting.meetingDescription,
                                                Rooms.roomNumber
                                            FROM Meeting 
                                            INNER JOIN Rooms ON Rooms.RoomID = meeting.meetingRoomID
                                            INNER JOIN Requests ON Meeting.meetingID = Requests.meetingID
                                            WHERE Requests.accountID = @accountID AND Requests.accepted <> 2 AND Requests.accepted <> 0";
                    


                    using (SqlCommand cmd = new SqlCommand(meetingSql, con))
                    {
                        cmd.Parameters.AddWithValue("@accountID", this.accountNo);

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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            LoginForm lForm = new LoginForm();

            lForm.Show();
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            if (data.isMeetingImportant(requestMeetingID))
            {
                DialogResult confirmDL = MessageBox.Show(@"The Meeting selected has been flagged 
                                                           as IMPORTANT by the Administrator, are you sure you want to 
                                                    decline this request?", "Meeting Is Important - Are You Sure?", MessageBoxButtons.YesNo);
                if (confirmDL == DialogResult.Yes)
                {
                    data.declineRequest(requestMeetingID, accountNo);
                    dataMeetRequests.Rows.RemoveAt(dataMeetRequests.SelectedRows[0].Index);
                    MessageBox.Show("Declined Meeting!");
                }
                else if (confirmDL == DialogResult.No)
                {
                    MessageBox.Show("Request Saved");
                }
            }
            else
            {
                data.declineRequest(requestMeetingID, accountNo);
                dataMeetRequests.Rows.RemoveAt(dataMeetRequests.SelectedRows[0].Index);
                MessageBox.Show("Declined Meeting!");
            }

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            
            data.acceptRequest(requestMeetingID, accountNo);
            addToSchedule();
            dataMeetRequests.Rows.RemoveAt(dataMeetRequests.SelectedRows[0].Index);
            MessageBox.Show("Accepted Meeting!");
        }


        private void dataMeetRequests_SelectionChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataMeetRequests.SelectedRows)
            {
                 requestMeetingID = Convert.ToInt32(row.Cells[0].Value);
                
            }
        }

        private void dataSchedule_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataSchedule.SelectedRows)
            {
                scheduleMeetingID = Convert.ToInt32(row.Cells[0].Value);
                requestID = Convert.ToInt32(row.Cells[1].Value);

            }
        }


        private void btnCancelAttendance_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataSchedule.SelectedRows[0].Index;

            if (data.isMeetingImportant(scheduleMeetingID))
            {
                if (string.IsNullOrEmpty(txtReason.Text))
                {
                    MessageBox.Show("The meeting selected has been flagged as IMPORTANT. You must enter a reason for this absence.", "Are you sure? Meeting is important",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    data.cancelRequest(requestID, txtReason.Text);
                    data.declineRequest(scheduleMeetingID, accountNo);
                    dataSchedule.Rows.RemoveAt(selectedIndex);
                    MessageBox.Show("Your cancellation has been notified to the meeting initiator.");
                }
            }

            if (!data.isMeetingImportant(scheduleMeetingID))
            {
                data.declineRequest(scheduleMeetingID, accountNo);
                dataSchedule.Rows.RemoveAt(selectedIndex);
                MessageBox.Show("Your cancellation has been notified to the meeting initiator.");
            } 
        }

        private void btnRemoveExclusionDates_Click(object sender, EventArgs e)
        {
            this.Hide();

            RemoveDates rd = new RemoveDates(accountNo);

            rd.Show();
        }





    }
}
