/*
 * Created by SharpDevelop.
 * User: CC2_PC40
 * Date: 29/10/2024
 * Time: 08:19 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace equipo
{
	partial class Partesensayo
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
			this.btnintroduccion = new System.Windows.Forms.Button();
			this.btndesarrollo = new System.Windows.Forms.Button();
			this.btnconclusion = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnintroduccion
			// 
			this.btnintroduccion.ForeColor = System.Drawing.Color.MediumBlue;
			this.btnintroduccion.Location = new System.Drawing.Point(68, 12);
			this.btnintroduccion.Name = "btnintroduccion";
			this.btnintroduccion.Size = new System.Drawing.Size(75, 23);
			this.btnintroduccion.TabIndex = 0;
			this.btnintroduccion.Text = "Introduccion";
			this.btnintroduccion.UseVisualStyleBackColor = true;
			this.btnintroduccion.Click += new System.EventHandler(this.BtnintroduccionClick);
			// 
			// btndesarrollo
			// 
			this.btndesarrollo.ForeColor = System.Drawing.Color.MediumBlue;
			this.btndesarrollo.Location = new System.Drawing.Point(68, 50);
			this.btndesarrollo.Name = "btndesarrollo";
			this.btndesarrollo.Size = new System.Drawing.Size(75, 23);
			this.btndesarrollo.TabIndex = 1;
			this.btndesarrollo.Text = "Desarrollo";
			this.btndesarrollo.UseVisualStyleBackColor = true;
			this.btndesarrollo.Click += new System.EventHandler(this.BtndesarrolloClick);
			// 
			// btnconclusion
			// 
			this.btnconclusion.ForeColor = System.Drawing.Color.MediumBlue;
			this.btnconclusion.Location = new System.Drawing.Point(68, 89);
			this.btnconclusion.Name = "btnconclusion";
			this.btnconclusion.Size = new System.Drawing.Size(75, 22);
			this.btnconclusion.TabIndex = 2;
			this.btnconclusion.Text = "Conclusion";
			this.btnconclusion.UseVisualStyleBackColor = true;
			this.btnconclusion.Click += new System.EventHandler(this.BtnconclusionClick);
			// 
			// Partesensayo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PeachPuff;
			this.ClientSize = new System.Drawing.Size(215, 131);
			this.Controls.Add(this.btnconclusion);
			this.Controls.Add(this.btndesarrollo);
			this.Controls.Add(this.btnintroduccion);
			this.Name = "Partesensayo";
			this.Text = "Partes del ensayo";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnconclusion;
		private System.Windows.Forms.Button btndesarrollo;
		private System.Windows.Forms.Button btnintroduccion;
	}
}
