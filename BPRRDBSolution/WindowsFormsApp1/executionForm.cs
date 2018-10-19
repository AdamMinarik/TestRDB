using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class executionForm : Form
    {
        public executionForm()
        {
            InitializeComponent();
        }

        private void projectsButton_Click(object sender, EventArgs e)
        {
            projectsPanel.Visible = true;
            portfolioPanel.Visible = false;
            createProjectPanel.Visible = false;
        }

        private void reportsButtons_Click(object sender, EventArgs e)
        {
            createProjectPanel.Visible = false;
            portfolioPanel.Visible = true;
        }

        private void createProjectPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createProjectButton_Click(object sender, EventArgs e)
        {
            portfolioPanel.Visible = true;
            createProjectPanel.Visible = true;
        }

        private void projectNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TOCLabel_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if(this.nccButton.Visible == false)
            {
                this.entryCurButton.Visible = true;
                //System.Threading.Thread.Sleep(20);
                this.diCatButton.Visible = true;
                //System.Threading.Thread.Sleep(20);
                this.nccButton.Visible = true;
                //System.Threading.Thread.Sleep(20);
                this.projectOwnerButton.Visible = true;
                //System.Threading.Thread.Sleep(20);
                this.orgUnitButton.Visible = true;
                //System.Threading.Thread.Sleep(20);
                this.wtgTypeButton.Visible = true;
                //System.Threading.Thread.Sleep(20);
                this.ownerButton.Visible = true;
                //System.Threading.Thread.Sleep(20);
                this.usersButton.Visible = true;
                //System.Threading.Thread.Sleep(20);
                this.transfSalesProjButton.Visible = true;
            }
            else
            {
                this.transfSalesProjButton.Visible = false;
                System.Threading.Thread.Sleep(20);
                this.usersButton.Visible = false;
                System.Threading.Thread.Sleep(20);
                this.ownerButton.Visible = false;
                System.Threading.Thread.Sleep(20);
                this.wtgTypeButton.Visible = false;
                System.Threading.Thread.Sleep(20);
                this.orgUnitButton.Visible = false;
                System.Threading.Thread.Sleep(20);
                this.projectOwnerButton.Visible = false;
                System.Threading.Thread.Sleep(20);
                this.nccButton.Visible = false;
                System.Threading.Thread.Sleep(20);
                this.diCatButton.Visible = false;
                System.Threading.Thread.Sleep(20);
                this.entryCurButton.Visible = false;
            }

        }

        private void transfSalesProjButton_Click(object sender, EventArgs e)
        {

        }

        private void projectOwnerButton_Click(object sender, EventArgs e)
        {

        }

        private void orgUnitButton_Click(object sender, EventArgs e)
        {

        }

        private void nccButton_Click(object sender, EventArgs e)
        {

        }

        private void ownerButton_Click(object sender, EventArgs e)
        {

        }

        private void usersButton_Click(object sender, EventArgs e)
        {

        }

        private void diCatButton_Click(object sender, EventArgs e)
        {

        }

        private void userLabel_Click(object sender, EventArgs e)
        {
            if (this.adminPictureBox.Visible == true) {
                readPictureBox.Visible = true;
                adminPictureBox.Visible = false;
                writePictureBox.Visible = false;
                approvalPictureBox.Visible = false;
            }
            else if(this.readPictureBox.Visible == true)
            {
                readPictureBox.Visible = false;
                writePictureBox.Visible = true;
                approvalPictureBox.Visible = false;
                adminPictureBox.Visible = false;
            }
            else if (this.writePictureBox.Visible == true)
            {
                readPictureBox.Visible = false;
                writePictureBox.Visible = false;
                approvalPictureBox.Visible = true;
                adminPictureBox.Visible = false;
            }
            else if (this.approvalPictureBox.Visible == true)
            {
                readPictureBox.Visible = false;
                writePictureBox.Visible = false;
                approvalPictureBox.Visible = false;
                adminPictureBox.Visible = true;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
