﻿/*
 * Created by SharpDevelop.
 * User: CC2_PC39
 * Date: 29/10/2024
 * Time: 07:28 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace equipo
{
	partial class hum
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hum));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnmoral = new System.Windows.Forms.Button();
			this.btnetica = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(34, 138);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(415, 276);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// btnmoral
			// 
			this.btnmoral.Cursor = System.Windows.Forms.Cursors.Help;
			this.btnmoral.Location = new System.Drawing.Point(357, 109);
			this.btnmoral.Name = "btnmoral";
			this.btnmoral.Size = new System.Drawing.Size(75, 23);
			this.btnmoral.TabIndex = 6;
			this.btnmoral.Text = "moral";
			this.btnmoral.UseVisualStyleBackColor = true;
			this.btnmoral.Click += new System.EventHandler(this.BtnmoralClick);
			// 
			// btnetica
			// 
			this.btnetica.Cursor = System.Windows.Forms.Cursors.Help;
			this.btnetica.Location = new System.Drawing.Point(34, 109);
			this.btnetica.Name = "btnetica";
			this.btnetica.Size = new System.Drawing.Size(75, 23);
			this.btnetica.TabIndex = 5;
			this.btnetica.Text = "etica";
			this.btnetica.UseVisualStyleBackColor = true;
			this.btnetica.Click += new System.EventHandler(this.BtneticaClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.label1.Location = new System.Drawing.Point(90, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(212, 28);
			this.label1.TabIndex = 4;
			this.label1.Text = "que es la etica y moral";
			// 
			// hum
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(477, 426);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnmoral);
			this.Controls.Add(this.btnetica);
			this.Controls.Add(this.label1);
			this.Name = "hum";
			this.Text = "Formhum";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnetica;
		private System.Windows.Forms.Button btnmoral;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
