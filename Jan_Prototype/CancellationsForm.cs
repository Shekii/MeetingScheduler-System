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
    public partial class CancellationsForm : Form
    {

        private Data data = new Data();

        public CancellationsForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            MeetingScheduler ms = new MeetingScheduler("Admin", true);
            ms.Show();
    
        }

        private void loadCancellations()
        {
            try
            {

                using (SqlConnection con = new SqlConnection(data.str))
                {
                    con.Open();

                    string meetingSql = @"SELECT 
                                                CancelledMeetings.cancellationID,
                                                Account.accountName,
                                                Meeting.meetingName,
                                                CancelledMeetings.reason
                                            FROM CancelledMeetings 
                                            INNER JOIN Requests ON CancelledMeetings.requestID = Requests.requestID
                                            INNER JOIN Account ON Requests.accountID = Account.accountID
                                            INNER JOIN Meeting ON Requests.meetingID = Meeting.meetingID";



                    using (SqlCommand cmd = new SqlCommand(meetingSql, con))
                    {

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            var commandBuilder = new SqlCommandBuilder(da);
                            var ds = new DataSet();
                            da.Fill(ds);
                            dataCancellations.DataSource = ds.Tables[0];
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

        private void CancellationsForm_Load(object sender, EventArgs e)
        {
            loadCancellations();
        }
    }
}
