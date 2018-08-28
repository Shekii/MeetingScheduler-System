using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Jan_Prototype
{
    public partial class RemoveDates : Form
    {
        private int accountNo;
        private Data data = new Data();
        public RemoveDates(int accountNo)
        {
            this.accountNo = accountNo;

            InitializeComponent();
        }

        private void RemoveDates_Load(object sender, EventArgs e)
        {
            this.Text += data.getUsername(accountNo);

            loadExclusionDates();
        }

        private void loadExclusionDates()
        {
            DateTime startDate = data.getStartDate(accountNo);
            DateTime endDate = data.getEndDate(accountNo);

            datePickerStart.Value = startDate;
            datePickerEnd.Value = endDate;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            UserPanel up = new UserPanel(accountNo);
            up.Show();
        }

        private void btnChangeDates_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Parse(datePickerStart.Value.ToShortDateString());
            DateTime end = DateTime.Parse(datePickerEnd.Value.ToShortDateString());

            if (datesCorrect(start, end) )
            {
                try
                {

                    using (SqlConnection con = new SqlConnection(data.str))
                    {
                        con.Open();

                        string datesSql = @"UPDATE Account 
                                            SET 
                                            exclusionStart = @start,
                                            exclusionEnd = @end
                                            WHERE accountID = @accountID";

                        using (SqlCommand cmd = new SqlCommand(datesSql, con))
                        {

                            cmd.Parameters.AddWithValue("@accountID", accountNo);
                            cmd.Parameters.AddWithValue("@start", start);
                            cmd.Parameters.AddWithValue("@end", end);

                            cmd.ExecuteNonQuery();
                        }

                        con.Close();

                    }

                }
                catch (SqlException x)
                {
                    MessageBox.Show(x.ToString());
                }

            MessageBox.Show("Dates updated.");

            loadExclusionDates();  
       
            } else {
                MessageBox.Show("The Start Date must be be before the end date.", "Date Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool datesCorrect(DateTime d1, DateTime d2)
        {
            return (d1 < d2);
        }



    }
}
