using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifyWindowAPP
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Application = new Form1();
            Application.ShowDialog();
            this.Close();
        }
    }
}
