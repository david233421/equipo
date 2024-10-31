/*
 * Created by SharpDevelop.
 * User: CC2_PC40
 * Date: 31/10/2024
 * Time: 07:39 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace equipo
{
	partial class Tiposcom
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
			this.btncritico = new System.Windows.Forms.Button();
			this.btnfilologico = new System.Windows.Forms.Button();
			this.btnbiblico = new System.Windows.Forms.Button();
			this.btnhistorico = new System.Windows.Forms.Button();
			this.btnliterario = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btncritico
			// 
			this.btncritico.ForeColor = System.Drawing.Color.MediumBlue;
			this.btncritico.Location = new System.Drawing.Point(13, 13);
			this.btncritico.Name = "btncritico";
			this.btncritico.Size = new System.Drawing.Size(119, 23);
			this.btncritico.TabIndex = 0;
			this.btncritico.Text = "Comentario critico";
			this.btncritico.UseVisualStyleBackColor = true;
			this.btncritico.Click += new System.EventHandler(this.BtncriticoClick);
			// 
			// btnfilologico
			// 
			this.btnfilologico.ForeColor = System.Drawing.Color.MediumBlue;
			this.btnfilologico.Location = new System.Drawing.Point(13, 42);
			this.btnfilologico.Name = "btnfilologico";
			this.btnfilologico.Size = new System.Drawing.Size(119, 23);
			this.btnfilologico.TabIndex = 1;
			this.btnfilologico.Text = "Comentario filologico";
			this.btnfilologico.UseVisualStyleBackColor = true;
			this.btnfilologico.Click += new System.EventHandler(this.BtnfilologicoClick);
			// 
			// btnbiblico
			// 
			this.btnbiblico.ForeColor = System.Drawing.Color.MediumBlue;
			this.btnbiblico.Location = new System.Drawing.Point(13, 71);
			this.btnbiblico.Name = "btnbiblico";
			this.btnbiblico.Size = new System.Drawing.Size(119, 23);
			this.btnbiblico.TabIndex = 2;
			this.btnbiblico.Text = "Comentario biblico";
			this.btnbiblico.UseVisualStyleBackColor = true;
			this.btnbiblico.Click += new System.EventHandler(this.BtnbiblicoClick);
			// 
			// btnhistorico
			// 
			this.btnhistorico.ForeColor = System.Drawing.Color.MediumBlue;
			this.btnhistorico.Location = new System.Drawing.Point(13, 100);
			this.btnhistorico.Name = "btnhistorico";
			this.btnhistorico.Size = new System.Drawing.Size(119, 23);
			this.btnhistorico.TabIndex = 3;
			this.btnhistorico.Text = "Comentario historico";
			this.btnhistorico.UseVisualStyleBackColor = true;
			this.btnhistorico.Click += new System.EventHandler(this.BtnhistoricoClick);
			// 
			// btnliterario
			// 
			this.btnliterario.ForeColor = System.Drawing.Color.MediumBlue;
			this.btnliterario.Location = new System.Drawing.Point(13, 129);
			this.btnliterario.Name = "btnliterario";
			this.btnliterario.Size = new System.Drawing.Size(119, 23);
			this.btnliterario.TabIndex = 4;
			this.btnliterario.Text = "Comentario literario";
			this.btnliterario.UseVisualStyleBackColor = true;
			this.btnliterario.Click += new System.EventHandler(this.BtnliterarioClick);
			// 
			// Tiposcom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PeachPuff;
			this.ClientSize = new System.Drawing.Size(144, 164);
			this.Controls.Add(this.btnliterario);
			this.Controls.Add(this.btnhistorico);
			this.Controls.Add(this.btnbiblico);
			this.Controls.Add(this.btnfilologico);
			this.Controls.Add(this.btncritico);
			this.Name = "Tiposcom";
			this.Text = "Tipos de comentario critico";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnliterario;
		private System.Windows.Forms.Button btnhistorico;
		private System.Windows.Forms.Button btnbiblico;
		private System.Windows.Forms.Button btnfilologico;
		private System.Windows.Forms.Button btncritico;
	}
}
