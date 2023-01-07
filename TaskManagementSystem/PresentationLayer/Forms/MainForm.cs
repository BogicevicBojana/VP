﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared.Models;

namespace PresentationLayer
{
    public partial class MainForm : Form
    {
        bool mouseDown;
        private Point offset;
        private Admin admin;
        Forms.LoginForm prevForm;

        public MainForm(Admin _admin, Forms.LoginForm _prevForm)
        {
            this.admin = _admin;
            this.prevForm = _prevForm;
            InitializeComponent();

            uC_AdminProfile1.SetAdmin(_admin);
        }

        private void panel_top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Point currentMousePosition = PointToScreen(e.Location);
                Location = new Point(currentMousePosition.X - offset.X, currentMousePosition.Y - offset.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void uC_AdminProfile1_Load(object sender, EventArgs e)
        {
  
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            uC_AdminProfile1.SetAdmin(admin);
        }

        private void btnRents_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void btnApartments_Click(object sender, EventArgs e)
        {

        }
    }
}