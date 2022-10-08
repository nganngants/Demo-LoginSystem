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

namespace LoginSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=EURUS21;Initial Catalog=DemoLoginSys;Integrated Security=True");

        private void but_Login_Click(object sender, EventArgs e)
        {
            String username = txt_usrname.Text;
            String userpwd = txt_usrpwd.Text;

            try
            {
                String selectQuery = "SELECT * FROM Users" +
                                        " WHERE username = '" + username + "'" +
                                        " AND userpwd = '" + userpwd + "'";
                SqlDataAdapter sda = new SqlDataAdapter(selectQuery, conn);

                DataTable dTable = new DataTable();
                sda.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    MessageBox.Show("Login sucessfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SuccessfulLogin successfulLogin = new SuccessfulLogin(username);
                    this.Hide();
                    successfulLogin.Show();
                }
                else
                {
                    MessageBox.Show("Wrong username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_usrname.Clear();
                    txt_usrpwd.Clear();
                    txt_usrname.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Some errors occur!");
            }
            finally
            {
                conn.Close();
            }
        }

        private void but_Clear_Click(object sender, EventArgs e)
        {
            txt_usrname.Clear();
            txt_usrpwd.Clear();
            txt_usrname.Focus();
        }

        private void but_Exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }
    }
}
