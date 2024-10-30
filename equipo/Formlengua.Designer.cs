/*
 * Created by SharpDevelop.
 * User: CC2_PC39
 * Date: 29/10/2024
 * Time: 07:24 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace equipo
{
	partial class lengua
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnensayo = new System.Windows.Forms.Button();
			this.btnresena = new System.Windows.Forms.Button();
			this.btncomcrit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.MediumBlue;
			this.label1.Location = new System.Drawing.Point(71, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(279, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Lengua y comunicacion";
			// 
			// btnensayo
			// 
			this.btnensayo.ForeColor = System.Drawing.Color.MediumBlue;
			this.btnensayo.Location = new System.Drawing.Point(12, 79);
			this.btnensayo.Name = "btnensayo";
			this.btnensayo.Size = new System.Drawing.Size(110, 27);
			this.btnensayo.TabIndex = 1;
			this.btnensayo.Text = "Ensayo";
			this.btnensayo.UseVisualStyleBackColor = true;
			this.btnensayo.Click += new System.EventHandler(this.BtnensayoClick);
			// 
			// btnresena
			// 
			this.btnresena.ForeColor = System.Drawing.Color.MediumBlue;
			this.btnresena.Location = new System.Drawing.Point(292, 79);
			this.btnresena.Name = "btnresena";
			this.btnresena.Size = new System.Drawing.Size(110, 27);
			this.btnresena.TabIndex = 2;
			this.btnresena.Text = "Reseña";
			this.btnresena.UseVisualStyleBackColor = true;
			this.btnresena.Click += new System.EventHandler(this.BtnresenaClick);
			// 
			// btncomcrit
			// 
			this.btncomcrit.ForeColor = System.Drawing.Color.MediumBlue;
			this.btncomcrit.Location = new System.Drawing.Point(149, 79);
			this.btncomcrit.Name = "btncomcrit";
			this.btncomcrit.Size = new System.Drawing.Size(110, 27);
			this.btncomcrit.TabIndex = 3;
			this.btncomcrit.Text = "Comentario critico";
			this.btncomcrit.UseVisualStyleBackColor = true;
			this.btncomcrit.Click += new System.EventHandler(this.BtncomcritClick);
			// 
			// lengua
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PeachPuff;
			this.ClientSize = new System.Drawing.Size(414, 147);
			this.Controls.Add(this.btncomcrit);
			this.Controls.Add(this.btnresena);
			this.Controls.Add(this.btnensayo);
			this.Controls.Add(this.label1);
			this.Name = "lengua";
			this.Text = "Formlengua";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btncomcrit;
		private System.Windows.Forms.Button btnresena;
		private System.Windows.Forms.Button btnensayo;
		private System.Windows.Forms.Label label1;
	}
}
