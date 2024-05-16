using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Part_Managment_Service
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_Home uC_Home = new UC_Home();
            addUserControl(uC_Home);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UC_Customer uC_Customer = new UC_Customer();
            addUserControl(uC_Customer);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UC_Buying uC_Buying = new UC_Buying();
            addUserControl(uC_Buying);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            UC_Selling uC_Selling = new UC_Selling();
            addUserControl(uC_Selling);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
}
