using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace optimumLocation
{
    public partial class SplashScreen : Form
    {
        public event EventHandler<string> LoginComplete;

        public SplashScreen()
        {
            InitializeComponent();     
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            OnLoginCompleted(userNameTextBox.Text);
            this.Close();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            int x = (this.Width / 2) - (loginTableLayoutPanel.Width / 2);
            int y = (this.Height / 2) - (loginTableLayoutPanel.Height / 2);
            loginTableLayoutPanel.Location = new Point(x, y);
            this.Activate();
        }

        private void OnLoginCompleted(string username)
        {
            LoginComplete?.Invoke(this, username);
        }
    }
}
