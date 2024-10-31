/*
 * Created by SharpDevelop.
 * User: CC2_PC40
 * Date: 29/10/2024
 * Time: 08:13 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace equipo
{
	partial class Comcrit
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
			this.btntiposcom = new System.Windows.Forms.Button();
			this.btnelaborarcom = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btntiposcom
			// 
			this.btntiposcom.ForeColor = System.Drawing.Color.MediumBlue;
			this.btntiposcom.Location = new System.Drawing.Point(60, 24);
			this.btntiposcom.Name = "btntiposcom";
			this.btntiposcom.Size = new System.Drawing.Size(164, 23);
			this.btntiposcom.TabIndex = 0;
			this.btntiposcom.Text = "Tipos de comentario critico";
			this.btntiposcom.UseVisualStyleBackColor = true;
			this.btntiposcom.Click += new System.EventHandler(this.BtntiposcomClick);
			// 
			// btnelaborarcom
			// 
			this.btnelaborarcom.ForeColor = System.Drawing.Color.MediumBlue;
			this.btnelaborarcom.Location = new System.Drawing.Point(60, 67);
			this.btnelaborarcom.Name = "btnelaborarcom";
			this.btnelaborarcom.Size = new System.Drawing.Size(164, 23);
			this.btnelaborarcom.TabIndex = 1;
			this.btnelaborarcom.Text = "Como elaborar un comentario critico";
			this.btnelaborarcom.UseVisualStyleBackColor = true;
			this.btnelaborarcom.Click += new System.EventHandler(this.BtnelaborarcomClick);
			// 
			// Comcrit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PeachPuff;
			this.ClientSize = new System.Drawing.Size(284, 115);
			this.Controls.Add(this.btnelaborarcom);
			this.Controls.Add(this.btntiposcom);
			this.Name = "Comcrit";
			this.Text = "Comentario critico";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnelaborarcom;
		private System.Windows.Forms.Button btntiposcom;
	}
}
