﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KPSonar
{
    public partial class MDISonar : Form
    {
        private int childFormNumber = 0;
        private DBConnect dbConnect;


        private CustomerDetails frmCustomerDetails;

        public MDISonar()
        {
            InitializeComponent();
            dbConnect = new DBConnect();

            if(dbConnect.IsConnected() == true)
            {
                toolStripStatusLabel.Text = "Database is Connected";
            }
            else
            {
                toolStripStatusLabel.Text = "Database is Not connected";
            }
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerDetails = new CustomerDetails();
            frmCustomerDetails.MdiParent = this;  
            frmCustomerDetails.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductDetails frmProductDetails = new ProductDetails();
            frmProductDetails.MdiParent = this;
            frmProductDetails.Show();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderDetails frmOrderDetails = new OrderDetails();
            frmOrderDetails.MdiParent = this;
            frmOrderDetails.Show();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentDetails frmPaymentDetails = new PaymentDetails();
            frmPaymentDetails.MdiParent = this;
            frmPaymentDetails.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeDetails frmEmployeeDetails = new EmployeeDetails();
            frmEmployeeDetails.MdiParent = this;
            frmEmployeeDetails.Show();
        }
        private void dailyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm frmSettingForm = new SettingForm();
            frmSettingForm.MdiParent = this;
            frmSettingForm.Show();
        }


        private void testToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            TestMysql frmForm = new TestMysql();
            frmForm.MdiParent = this;
            frmForm.Show();
        }

        private void assignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assignment frmAssignment = new Assignment();
            frmAssignment.MdiParent = this;
            frmAssignment.Show();
        }

    }
}
