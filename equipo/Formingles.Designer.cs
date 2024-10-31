/*
 * Created by SharpDevelop.
 * User: CC2_PC39
 * Date: 29/10/2024
 * Time: 07:22 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace equipo
{
	partial class ingles
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ingles));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.siguiente = new System.Windows.Forms.Button();
			this.cerrar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(54, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(171, 178);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// siguiente
			// 
			this.siguiente.Location = new System.Drawing.Point(21, 208);
			this.siguiente.Name = "siguiente";
			this.siguiente.Size = new System.Drawing.Size(75, 23);
			this.siguiente.TabIndex = 1;
			this.siguiente.Text = "siguiente";
			this.siguiente.UseVisualStyleBackColor = true;
			this.siguiente.Click += new System.EventHandler(this.SiguienteClick);
			// 
			// cerrar
			// 
			this.cerrar.Location = new System.Drawing.Point(164, 208);
			this.cerrar.Name = "cerrar";
			this.cerrar.Size = new System.Drawing.Size(75, 23);
			this.cerrar.TabIndex = 2;
			this.cerrar.Text = "cerrar";
			this.cerrar.UseVisualStyleBackColor = true;
			this.cerrar.Click += new System.EventHandler(this.CerrarClick);
			// 
			// ingles
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.cerrar);
			this.Controls.Add(this.siguiente);
			this.Controls.Add(this.pictureBox1);
			this.Name = "ingles";
			this.Text = "Formingles";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button cerrar;
		private System.Windows.Forms.Button siguiente;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
