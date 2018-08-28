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
    public partial class LoginForm : Form
    {
        private Data data = new Data();
        List<User> userList = new List<User>();
        SqlConnection con;
        string str;
        private bool loggedIn = false;
        private bool admin = false;





        public LoginForm()
        {
            InitializeComponent();
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(data.str);
                con.Open();

                string qry = "SELECT * FROM Account";
                SqlDataReader dr = new SqlCommand(qry, con).ExecuteReader();

                while (dr.Read())
                {
                    userList.Add(new User(dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), false));
                }

                dr.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message.ToString());
            }

            foreach (User uList in userList)
            {
                listUsernames.Items.Add(uList.getUsername());
            }

            //listUsernames.SelectedIndex = 0;

        }

        private void listUsernames_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPassword.Clear();
            int selectedIndex = listUsernames.SelectedIndex;
            txtPassword.Text = userList[selectedIndex].getPassword().ToString();
        }


        private void btnForceConflict_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "343424";

            checkLogin();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int selectedIndex = listUsernames.SelectedIndex;

            checkLogin();


            if (selectedIndex == 0 && loggedIn)
            {
                this.Visible = false;

                MeetingScheduler msForm = new MeetingScheduler(userList[selectedIndex].getUsername() , isAdmin());

                msForm.Show();
            }
            else if (loggedIn)
            {

                UserPanel uPanel = new UserPanel(selectedIndex);

                this.Hide();

                uPanel.Show();

            }

        }

        public bool isAdmin()
        {
            int selectedIndex = listUsernames.SelectedIndex;

            bool isAdmin = false;

            if (userList[selectedIndex].getUsername() == "Admin")
            {
                isAdmin = true;
            }

            return isAdmin;
        }

        private void checkLogin()
        {
            int selectedIndex = listUsernames.SelectedIndex;
            if (userList[selectedIndex].getPassword() == txtPassword.Text)
            {

                userList[selectedIndex].loggedIn = true;
                loggedIn = true;
            }
            else
            {
                MessageBox.Show("Login details are incorrect", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWipeAutoI_Click(object sender, EventArgs e)
        {

        }
    }
}
