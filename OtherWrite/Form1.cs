using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Word;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtherWrite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizedDesign();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public void customizedDesign()
        {
            panelMediaSubMenu.Visible = false;
            panelSubMenuEdit.Visible = false;
            panelSubMenuCheck.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelMediaSubMenu.Visible == true)
            {
                panelMediaSubMenu.Visible = false;
                if (panelSubMenuEdit.Visible == true)
                {
                    panelSubMenuEdit.Visible = false;
                    if (panelSubMenuCheck.Visible == true)
                    {
                        panelSubMenuCheck.Visible = false;
                    }
                }

            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        #region Menu

        private void buttonMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Codes
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Codes
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Codes
            hideSubMenu();
        }

        private void button1_Click_1(object sender, EventArgs e)
        { 
            // Codes
            hideSubMenu();
        }

        #endregion

        #region Edit

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuEdit);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Codes
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Codes
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Codes
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Codes
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Codes
            hideSubMenu();
        }
        #endregion

        #region Check

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuCheck);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Codes
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Codes
            hideSubMenu();
        }
        #endregion

        #region Help

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            // Codes
            hideSubMenu();
        }
        #endregion


        private Form activateForm = null;
        private void openChildForm(Form childForm)
        {
            if (activateForm != null)
            {
                activateForm.Close();
                activateForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelChildForm.Controls.Add(childForm);
                panelChildForm.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
    }