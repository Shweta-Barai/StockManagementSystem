using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            sideBarPanel.Height = dashboardButton.Height;
            sideBarPanel.Top = dashboardButton.Top;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to Exit ?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(dialogResult == DialogResult.Yes)
                Application.Exit();
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            sideBarPanel.Height = dashboardButton.Height;
            sideBarPanel.Top = dashboardButton.Top;
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            sideBarPanel.Height = categoryButton.Height;
            sideBarPanel.Top = categoryButton.Top;
        }

        private void productButton_Click(object sender, EventArgs e)
        {
            sideBarPanel.Height = productButton.Height;
            sideBarPanel.Top = productButton.Top;
        }

        private void parchaseButton_Click(object sender, EventArgs e)
        {
            sideBarPanel.Height = parchaseButton.Height;
            sideBarPanel.Top = parchaseButton.Top;
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            sideBarPanel.Height = orderButton.Height;
            sideBarPanel.Top = orderButton.Top;
        }

        private void saleButton_Click(object sender, EventArgs e)
        {
            sideBarPanel.Height = saleButton.Height;
            sideBarPanel.Top = saleButton.Top;
        }

        private void stockOutButton_Click(object sender, EventArgs e)
        {
            sideBarPanel.Height = stockOutButton.Height;
            sideBarPanel.Top = stockOutButton.Top;
        }

        private void stockButton_Click(object sender, EventArgs e)
        {
            sideBarPanel.Height = stockButton.Height;
            sideBarPanel.Top = stockButton.Top;
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            sideBarPanel.Height = reportsButton.Height;
            sideBarPanel.Top = reportsButton.Top;
        }

        //Window Moving
        Point lastPoint;
        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void flowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        
    }
}
