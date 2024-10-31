/*
 * Created by SharpDevelop.
 * User: alxax
 * Date: 30/10/2024
 * Time: 07:58 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoSharp
{
	partial class humanidades
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(humanidades));
			this.label1 = new System.Windows.Forms.Label();
			this.queeselbien = new System.Windows.Forms.Button();
			this.ordensocial = new System.Windows.Forms.Button();
			this.relacionesdepoder = new System.Windows.Forms.Button();
			this.texto = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(115, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(340, 73);
			this.label1.TabIndex = 0;
			this.label1.Text = "Humanidades";
			// 
			// queeselbien
			// 
			this.queeselbien.Location = new System.Drawing.Point(545, 178);
			this.queeselbien.Name = "queeselbien";
			this.queeselbien.Size = new System.Drawing.Size(151, 62);
			this.queeselbien.TabIndex = 1;
			this.queeselbien.Text = "¿Qué es el bien?";
			this.queeselbien.UseVisualStyleBackColor = true;
			this.queeselbien.Click += new System.EventHandler(this.QueeselbienClick);
			// 
			// ordensocial
			// 
			this.ordensocial.Location = new System.Drawing.Point(547, 50);
			this.ordensocial.Name = "ordensocial";
			this.ordensocial.Size = new System.Drawing.Size(149, 59);
			this.ordensocial.TabIndex = 2;
			this.ordensocial.Text = "Orden social";
			this.ordensocial.UseVisualStyleBackColor = true;
			this.ordensocial.Click += new System.EventHandler(this.OrdensocialClick);
			// 
			// relacionesdepoder
			// 
			this.relacionesdepoder.Location = new System.Drawing.Point(547, 114);
			this.relacionesdepoder.Name = "relacionesdepoder";
			this.relacionesdepoder.Size = new System.Drawing.Size(149, 58);
			this.relacionesdepoder.TabIndex = 3;
			this.relacionesdepoder.Text = "Relaciones de poder";
			this.relacionesdepoder.UseVisualStyleBackColor = true;
			this.relacionesdepoder.Click += new System.EventHandler(this.RelacionesdepoderClick);
			// 
			// texto
			// 
			this.texto.Location = new System.Drawing.Point(31, 95);
			this.texto.Name = "texto";
			this.texto.Size = new System.Drawing.Size(493, 239);
			this.texto.TabIndex = 4;
			this.texto.Text = resources.GetString("texto.Text");
			// 
			// humanidades
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(750, 327);
			this.Controls.Add(this.texto);
			this.Controls.Add(this.relacionesdepoder);
			this.Controls.Add(this.ordensocial);
			this.Controls.Add(this.queeselbien);
			this.Controls.Add(this.label1);
			this.Name = "humanidades";
			this.Text = "humanidades";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label texto;
		private System.Windows.Forms.Button relacionesdepoder;
		private System.Windows.Forms.Button ordensocial;
		private System.Windows.Forms.Button queeselbien;
		private System.Windows.Forms.Label label1;
	}
}
