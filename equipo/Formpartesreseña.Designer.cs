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
	partial class Partesreseña
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
			this.btnencabezado = new System.Windows.Forms.Button();
			this.btnintroduccion = new System.Windows.Forms.Button();
			this.btndesarrollo = new System.Windows.Forms.Button();
			this.btncierre = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnencabezado
			// 
			this.btnencabezado.ForeColor = System.Drawing.Color.MediumBlue;
			this.btnencabezado.Location = new System.Drawing.Point(39, 14);
			this.btnencabezado.Name = "btnencabezado";
			this.btnencabezado.Size = new System.Drawing.Size(75, 23);
			this.btnencabezado.TabIndex = 0;
			this.btnencabezado.Text = "Encabezado";
			this.btnencabezado.UseVisualStyleBackColor = true;
			this.btnencabezado.Click += new System.EventHandler(this.BtnencabezadoClick);
			// 
			// btnintroduccion
			// 
			this.btnintroduccion.ForeColor = System.Drawing.Color.MediumBlue;
			this.btnintroduccion.Location = new System.Drawing.Point(39, 54);
			this.btnintroduccion.Name = "btnintroduccion";
			this.btnintroduccion.Size = new System.Drawing.Size(75, 23);
			this.btnintroduccion.TabIndex = 1;
			this.btnintroduccion.Text = "Introduccion";
			this.btnintroduccion.UseVisualStyleBackColor = true;
			this.btnintroduccion.Click += new System.EventHandler(this.BtnintroduccionClick);
			// 
			// btndesarrollo
			// 
			this.btndesarrollo.ForeColor = System.Drawing.Color.MediumBlue;
			this.btndesarrollo.Location = new System.Drawing.Point(39, 93);
			this.btndesarrollo.Name = "btndesarrollo";
			this.btndesarrollo.Size = new System.Drawing.Size(75, 23);
			this.btndesarrollo.TabIndex = 2;
			this.btndesarrollo.Text = "Desarrollo";
			this.btndesarrollo.UseVisualStyleBackColor = true;
			this.btndesarrollo.Click += new System.EventHandler(this.BtndesarrolloClick);
			// 
			// btncierre
			// 
			this.btncierre.ForeColor = System.Drawing.Color.MediumBlue;
			this.btncierre.Location = new System.Drawing.Point(39, 133);
			this.btncierre.Name = "btncierre";
			this.btncierre.Size = new System.Drawing.Size(75, 23);
			this.btncierre.TabIndex = 3;
			this.btncierre.Text = "Cierre";
			this.btncierre.UseVisualStyleBackColor = true;
			this.btncierre.Click += new System.EventHandler(this.BtncierreClick);
			// 
			// Partesreseña
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PeachPuff;
			this.ClientSize = new System.Drawing.Size(155, 187);
			this.Controls.Add(this.btncierre);
			this.Controls.Add(this.btndesarrollo);
			this.Controls.Add(this.btnintroduccion);
			this.Controls.Add(this.btnencabezado);
			this.Name = "Partesreseña";
			this.Text = "Partes de la reseña";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btncierre;
		private System.Windows.Forms.Button btndesarrollo;
		private System.Windows.Forms.Button btnintroduccion;
		private System.Windows.Forms.Button btnencabezado;
	}
}
