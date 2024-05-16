using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Car_Part_Managment_Service.CustomerPages; // Eklenen satır

namespace Car_Part_Managment_Service
{
    public partial class UC_Customer : UserControl
    {
        public UC_Customer()
        {
            InitializeComponent();
        }

        private void addCustomerControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelCustomer.Controls.Clear();
            panelCustomer.Controls.Add(userControl);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_CustomerList uC_CustomerList = new UC_CustomerList();
            addCustomerControl(uC_CustomerList);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UC_CustomerHistory uC_AddCustomerHistory = new UC_CustomerHistory();
            addCustomerControl(uC_AddCustomerHistory);
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            UC_CustomerSetting uC_AddCustomerSetting = new UC_CustomerSetting();
            addCustomerControl(uC_AddCustomerSetting);
        }
    }
}
