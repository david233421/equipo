/*
 * Created by SharpDevelop.
 * User: CC2_PC39
 * Date: 29/10/2024
 * Time: 07:16 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace equipo
{
	partial class MainForm
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
			this.btnlen = new System.Windows.Forms.Button();
			this.btnfi = new System.Windows.Forms.Button();
			this.btnmat = new System.Windows.Forms.Button();
			this.btnin = new System.Windows.Forms.Button();
			this.btnhum = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnlen
			// 
			this.btnlen.Location = new System.Drawing.Point(144, 72);
			this.btnlen.Name = "btnlen";
			this.btnlen.Size = new System.Drawing.Size(75, 23);
			this.btnlen.TabIndex = 0;
			this.btnlen.Text = "lengua y comunicacion";
			this.btnlen.UseVisualStyleBackColor = true;
			this.btnlen.Click += new System.EventHandler(this.BtnlenClick);
			// 
			// btnfi
			// 
			this.btnfi.Location = new System.Drawing.Point(144, 132);
			this.btnfi.Name = "btnfi";
			this.btnfi.Size = new System.Drawing.Size(75, 23);
			this.btnfi.TabIndex = 1;
			this.btnfi.Text = "fisica";
			this.btnfi.UseVisualStyleBackColor = true;
			this.btnfi.Click += new System.EventHandler(this.BtnfiClick);
			// 
			// btnmat
			// 
			this.btnmat.Location = new System.Drawing.Point(33, 132);
			this.btnmat.Name = "btnmat";
			this.btnmat.Size = new System.Drawing.Size(75, 23);
			this.btnmat.TabIndex = 2;
			this.btnmat.Text = "matematicas";
			this.btnmat.UseVisualStyleBackColor = true;
			this.btnmat.Click += new System.EventHandler(this.BtnmatClick);
			// 
			// btnin
			// 
			this.btnin.Location = new System.Drawing.Point(33, 72);
			this.btnin.Name = "btnin";
			this.btnin.Size = new System.Drawing.Size(75, 23);
			this.btnin.TabIndex = 3;
			this.btnin.Text = "ingles";
			this.btnin.UseVisualStyleBackColor = true;
			this.btnin.Click += new System.EventHandler(this.BtninClick);
			// 
			// btnhum
			// 
			this.btnhum.Location = new System.Drawing.Point(91, 177);
			this.btnhum.Name = "btnhum";
			this.btnhum.Size = new System.Drawing.Size(75, 23);
			this.btnhum.TabIndex = 4;
			this.btnhum.Text = "humanidades";
			this.btnhum.UseVisualStyleBackColor = true;
			this.btnhum.Click += new System.EventHandler(this.BtnhumClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(79, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Elige una materia";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnhum);
			this.Controls.Add(this.btnin);
			this.Controls.Add(this.btnmat);
			this.Controls.Add(this.btnfi);
			this.Controls.Add(this.btnlen);
			this.Name = "MainForm";
			this.Text = "equipo";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnhum;
		private System.Windows.Forms.Button btnin;
		private System.Windows.Forms.Button btnmat;
		private System.Windows.Forms.Button btnfi;
		private System.Windows.Forms.Button btnlen;
	}
}
