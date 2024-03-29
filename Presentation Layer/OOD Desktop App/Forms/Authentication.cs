﻿using PresentationLayerLibrary;
using System;
using DesktopApp;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp.Forms
{
	public partial class Authentication : Form
	{
		private UserInterfaceImplementation userInterfaceImplementation;
		public Authentication()
		{
			InitializeComponent();
			CustomizeButton(loginBtn);
			userInterfaceImplementation = new UserInterfaceImplementation();
		}

		private void CustomizeButton(Button button)
		{
			button.FlatStyle = FlatStyle.Flat;
			button.BackColor = Color.FromArgb(50, 50, 50);
			button.ForeColor = Color.White;
			button.Padding = new Padding(10);
			GraphicsPath path = new GraphicsPath();
			Rectangle rect = button.ClientRectangle;
			int radius = 20;
			path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
			path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
			path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
			path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
			path.CloseFigure();
			button.Region = new Region(path);
		}

		private void loginBtn_Click(object sender, EventArgs e)
		{
			bool isAuthenticated = userInterfaceImplementation.desktopLogin(userNameLoginTextBox.Text, passwordLoginTextBox.Text);
			if (isAuthenticated)
			{
				AdminDashboard adminDashboard = new AdminDashboard(userInterfaceImplementation);
				Program.SwitchToForm(adminDashboard); 
			}
			else
			{
				MessageBox.Show("Invalid credentials");
			}
		}

		private void ClearInputs()
		{
			userNameLoginTextBox.Text = "";
			passwordLoginTextBox.Text = "";
		}
	}
}