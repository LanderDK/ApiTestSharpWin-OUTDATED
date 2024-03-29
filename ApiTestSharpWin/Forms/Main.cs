﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlitzWare.Properties;
using Microsoft.Win32;

namespace BlitzWare
{
    public partial class Main : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public Main()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            welcome.Text = "Welcome back, " + API.User.Username + "!";
            userid.Text = "ID: " + API.User.ID;
            username.Text = "Username: " + API.User.Username;
            expiry.Text = "Subscription Expiry: " + API.User.Expiry;
            email.Text = "Email: " + API.User.Email;
            hwid.Text = "HWID: " + API.User.HWID;
            ip.Text = "IP: " + API.User.IP;
            lastlogin.Text = "Last Login: " + API.User.LastLogin;
        }

        private void MainR6S_Load(object sender, EventArgs e)
        {
            //picturebox.Load(User.ProfilePicture);
            welcome.Text = "Welcome back, " + API.User.Username + "!";
            userid.Text = "ID: " + API.User.ID;
            username.Text = "Username: " + API.User.Username;
            expiry.Text = "Subscription Expiry: " + API.User.Expiry;
            email.Text = "Email: " + API.User.Email;
            hwid.Text = "HWID: " + API.User.HWID;
            ip.Text = "IP: " + API.User.IP;
            lastlogin.Text = "Last Login: " + API.User.LastLogin;
        }

        private void welcome_Click(object sender, EventArgs e)
        {

        }

        private void userid_Click(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void expiry_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void Main_Load_1(object sender, EventArgs e)
        {

        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void listView1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void listView1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            API.CreateQRCode(); 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Please provide a code to enable 2FA!", API.OnProgramStart.Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                API.Verify2FA(textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Please provide a code to disable 2FA!", API.OnProgramStart.Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                API.Disable2FA(textBox2.Text);
            }
        }
    }
}
