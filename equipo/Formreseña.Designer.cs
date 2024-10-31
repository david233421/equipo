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
	partial class Reseña
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
			this.btntiposre = new System.Windows.Forms.Button();
			this.btnpartesre = new System.Windows.Forms.Button();
			this.btnhacerre = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btntiposre
			// 
			this.btntiposre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btntiposre.ForeColor = System.Drawing.Color.MediumBlue;
			this.btntiposre.Location = new System.Drawing.Point(64, 12);
			this.btntiposre.Name = "btntiposre";
			this.btntiposre.Size = new System.Drawing.Size(140, 23);
			this.btntiposre.TabIndex = 0;
			this.btntiposre.Text = "Tipos de reseña";
			this.btntiposre.UseVisualStyleBackColor = true;
			this.btntiposre.Click += new System.EventHandler(this.BtntiposreClick);
			// 
			// btnpartesre
			// 
			this.btnpartesre.ForeColor = System.Drawing.Color.MediumBlue;
			this.btnpartesre.Location = new System.Drawing.Point(64, 58);
			this.btnpartesre.Name = "btnpartesre";
			this.btnpartesre.Size = new System.Drawing.Size(140, 23);
			this.btnpartesre.TabIndex = 1;
			this.btnpartesre.Text = "Partes de la reseña";
			this.btnpartesre.UseVisualStyleBackColor = true;
			this.btnpartesre.Click += new System.EventHandler(this.BtnpartesreClick);
			// 
			// btnhacerre
			// 
			this.btnhacerre.ForeColor = System.Drawing.Color.MediumBlue;
			this.btnhacerre.Location = new System.Drawing.Point(64, 105);
			this.btnhacerre.Name = "btnhacerre";
			this.btnhacerre.Size = new System.Drawing.Size(140, 23);
			this.btnhacerre.TabIndex = 2;
			this.btnhacerre.Text = "Como elaborar una reseña";
			this.btnhacerre.UseVisualStyleBackColor = true;
			this.btnhacerre.Click += new System.EventHandler(this.BtnhacerreClick);
			// 
			// Reseña
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PeachPuff;
			this.ClientSize = new System.Drawing.Size(274, 141);
			this.Controls.Add(this.btnhacerre);
			this.Controls.Add(this.btnpartesre);
			this.Controls.Add(this.btntiposre);
			this.Name = "Reseña";
			this.Text = "Reseña";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnhacerre;
		private System.Windows.Forms.Button btnpartesre;
		private System.Windows.Forms.Button btntiposre;
	}
}
