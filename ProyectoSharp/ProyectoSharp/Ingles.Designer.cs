﻿/*
 * Created by SharpDevelop.
 * User: alxax
 * Date: 30/10/2024
 * Time: 07:58 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoSharp
{
	partial class Ingles
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingles));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(81, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(157, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "PRESENT PERFECT TENSE";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.label2.Location = new System.Drawing.Point(27, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(126, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "AFFIRMATIVE FORM";
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label3.Location = new System.Drawing.Point(190, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "NEGATIVE FORM";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(27, 55);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(157, 325);
			this.label4.TabIndex = 3;
			this.label4.Text = resources.GetString("label4.Text");
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(208, 55);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(151, 296);
			this.label5.TabIndex = 4;
			this.label5.Text = resources.GetString("label5.Text");
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(649, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(157, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "PAST PARTICIPLE";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(649, 38);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(157, 325);
			this.label7.TabIndex = 6;
			this.label7.Text = resources.GetString("label7.Text");
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(338, 38);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(344, 319);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(394, 396);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 8;
			this.label8.Text = "FOR AND SINCE";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(155, 419);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(605, 286);
			this.label9.TabIndex = 9;
			this.label9.Text = resources.GetString("label9.Text");
			// 
			// Ingles
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(875, 714);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Ingles";
			this.Text = "Ingles";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
