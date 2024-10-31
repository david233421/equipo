/*
 * Created by SharpDevelop.
 * User: CC2_PC40
 * Date: 30/10/2024
 * Time: 08:11 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace equipo
{
	partial class Tiposreseña
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
			this.btnreseñaliteraria = new System.Windows.Forms.Button();
			this.btnreseñacritica = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnreseñaliteraria
			// 
			this.btnreseñaliteraria.ForeColor = System.Drawing.Color.MediumBlue;
			this.btnreseñaliteraria.Location = new System.Drawing.Point(13, 13);
			this.btnreseñaliteraria.Name = "btnreseñaliteraria";
			this.btnreseñaliteraria.Size = new System.Drawing.Size(123, 23);
			this.btnreseñaliteraria.TabIndex = 0;
			this.btnreseñaliteraria.Text = "Reseña literaria";
			this.btnreseñaliteraria.UseVisualStyleBackColor = true;
			this.btnreseñaliteraria.Click += new System.EventHandler(this.BtnreseñaliterariaClick);
			// 
			// btnreseñacritica
			// 
			this.btnreseñacritica.ForeColor = System.Drawing.Color.MediumBlue;
			this.btnreseñacritica.Location = new System.Drawing.Point(13, 43);
			this.btnreseñacritica.Name = "btnreseñacritica";
			this.btnreseñacritica.Size = new System.Drawing.Size(123, 23);
			this.btnreseñacritica.TabIndex = 1;
			this.btnreseñacritica.Text = "Reseña critica";
			this.btnreseñacritica.UseVisualStyleBackColor = true;
			this.btnreseñacritica.Click += new System.EventHandler(this.BtnreseñacriticaClick);
			// 
			// Tiposreseña
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PeachPuff;
			this.ClientSize = new System.Drawing.Size(150, 96);
			this.Controls.Add(this.btnreseñacritica);
			this.Controls.Add(this.btnreseñaliteraria);
			this.Name = "Tiposreseña";
			this.Text = "Tipos de reseña";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnreseñacritica;
		private System.Windows.Forms.Button btnreseñaliteraria;
	}
}
