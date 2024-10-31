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
	partial class Tiposensayo
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
			this.btnfilosofico = new System.Windows.Forms.Button();
			this.btnliterario = new System.Windows.Forms.Button();
			this.btnargumentativo = new System.Windows.Forms.Button();
			this.btncientifico = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnfilosofico
			// 
			this.btnfilosofico.ForeColor = System.Drawing.Color.MediumBlue;
			this.btnfilosofico.Location = new System.Drawing.Point(13, 13);
			this.btnfilosofico.Name = "btnfilosofico";
			this.btnfilosofico.Size = new System.Drawing.Size(124, 23);
			this.btnfilosofico.TabIndex = 0;
			this.btnfilosofico.Text = "Ensayo filosofico";
			this.btnfilosofico.UseVisualStyleBackColor = true;
			this.btnfilosofico.Click += new System.EventHandler(this.BtnfilosoficoClick);
			// 
			// btnliterario
			// 
			this.btnliterario.ForeColor = System.Drawing.Color.MediumBlue;
			this.btnliterario.Location = new System.Drawing.Point(13, 43);
			this.btnliterario.Name = "btnliterario";
			this.btnliterario.Size = new System.Drawing.Size(124, 23);
			this.btnliterario.TabIndex = 1;
			this.btnliterario.Text = "Ensayo literario";
			this.btnliterario.UseVisualStyleBackColor = true;
			this.btnliterario.Click += new System.EventHandler(this.BtnliterarioClick);
			// 
			// btnargumentativo
			// 
			this.btnargumentativo.ForeColor = System.Drawing.Color.MediumBlue;
			this.btnargumentativo.Location = new System.Drawing.Point(13, 73);
			this.btnargumentativo.Name = "btnargumentativo";
			this.btnargumentativo.Size = new System.Drawing.Size(124, 23);
			this.btnargumentativo.TabIndex = 2;
			this.btnargumentativo.Text = "Ensayo argumentativo";
			this.btnargumentativo.UseVisualStyleBackColor = true;
			this.btnargumentativo.Click += new System.EventHandler(this.BtnargumentativoClick);
			// 
			// btncientifico
			// 
			this.btncientifico.ForeColor = System.Drawing.Color.MediumBlue;
			this.btncientifico.Location = new System.Drawing.Point(13, 103);
			this.btncientifico.Name = "btncientifico";
			this.btncientifico.Size = new System.Drawing.Size(124, 23);
			this.btncientifico.TabIndex = 3;
			this.btncientifico.Text = "Ensayo cientifico";
			this.btncientifico.UseVisualStyleBackColor = true;
			this.btncientifico.Click += new System.EventHandler(this.BtncientificoClick);
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(13, 133);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 33);
			this.label1.TabIndex = 4;
			this.label1.Text = "No son todos los tipos de ensayo";
			// 
			// Tiposensayo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PeachPuff;
			this.ClientSize = new System.Drawing.Size(153, 173);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btncientifico);
			this.Controls.Add(this.btnargumentativo);
			this.Controls.Add(this.btnliterario);
			this.Controls.Add(this.btnfilosofico);
			this.Name = "Tiposensayo";
			this.Text = "Tipos de ensayo";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btncientifico;
		private System.Windows.Forms.Button btnargumentativo;
		private System.Windows.Forms.Button btnliterario;
		private System.Windows.Forms.Button btnfilosofico;
	}
}
