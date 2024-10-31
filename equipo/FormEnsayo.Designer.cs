/*
 * Created by SharpDevelop.
 * User: CC2_PC40
 * Date: 29/10/2024
 * Time: 07:51 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace equipo
{
	partial class Ensayo
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
			this.btntipos = new System.Windows.Forms.Button();
			this.btnpartes = new System.Windows.Forms.Button();
			this.btnelaborar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btntipos
			// 
			this.btntipos.ForeColor = System.Drawing.Color.MediumBlue;
			this.btntipos.Location = new System.Drawing.Point(72, 21);
			this.btntipos.Name = "btntipos";
			this.btntipos.Size = new System.Drawing.Size(138, 23);
			this.btntipos.TabIndex = 0;
			this.btntipos.Text = "Tipos de ensayo";
			this.btntipos.UseVisualStyleBackColor = true;
			this.btntipos.Click += new System.EventHandler(this.BtntiposClick);
			// 
			// btnpartes
			// 
			this.btnpartes.ForeColor = System.Drawing.Color.MediumBlue;
			this.btnpartes.Location = new System.Drawing.Point(72, 79);
			this.btnpartes.Name = "btnpartes";
			this.btnpartes.Size = new System.Drawing.Size(138, 23);
			this.btnpartes.TabIndex = 1;
			this.btnpartes.Text = "Partes del ensayo";
			this.btnpartes.UseVisualStyleBackColor = true;
			this.btnpartes.Click += new System.EventHandler(this.BtnpartesClick);
			// 
			// btnelaborar
			// 
			this.btnelaborar.ForeColor = System.Drawing.Color.MediumBlue;
			this.btnelaborar.Location = new System.Drawing.Point(72, 137);
			this.btnelaborar.Name = "btnelaborar";
			this.btnelaborar.Size = new System.Drawing.Size(138, 23);
			this.btnelaborar.TabIndex = 2;
			this.btnelaborar.Text = "Como elaborar un ensayo";
			this.btnelaborar.UseVisualStyleBackColor = true;
			this.btnelaborar.Click += new System.EventHandler(this.BtnelaborarClick);
			// 
			// Ensayo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PeachPuff;
			this.ClientSize = new System.Drawing.Size(284, 197);
			this.Controls.Add(this.btnelaborar);
			this.Controls.Add(this.btnpartes);
			this.Controls.Add(this.btntipos);
			this.Name = "Ensayo";
			this.Text = "Ensayo";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnelaborar;
		private System.Windows.Forms.Button btnpartes;
		private System.Windows.Forms.Button btntipos;
	}
}
