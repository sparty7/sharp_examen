﻿/*
 * Created by SharpDevelop.
 * User: alxax
 * Date: 30/10/2024
 * Time: 07:55 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoSharp
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label2Click(object sender, EventArgs e)
		{
			Mates matematicas = new Mates();
			matematicas.Show();
		}
		
		void Label4Click(object sender, EventArgs e)
		{
			humanidades form2 = new humanidades();

            form2.Show();			
		}
	}
}
