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
using System.Data.SqlServerCe;

namespace SAD
{
    public partial class signInForm : Form
    {
        public signInForm()
        {
            InitializeComponent();
        }

        string userName;
        string password;

        private void userName_Click(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void signIn_Click(object sender, EventArgs e)
        {
            if (dbConnection.userPassMatches(userName, password))
                MessageBox.Show(userName + " " + password, " Matched", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show(userName + " " + password, " Not Matched", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            userName = userNameTextBox.Text;
        }

        private void signInForm_Load(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            password = passwordTextBox.Text;
        }
    }
}
