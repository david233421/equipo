/*
 * Created by SharpDevelop.
 * User: CC2_PC37
 * Date: 30/10/2024
 * Time: 08:15 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace equipo
{
	partial class ingles3
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ingles3));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.siguiente = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(26, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(219, 132);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(304, 99);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(184, 134);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.PictureBox2Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 147);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(270, 50);
			this.label1.TabIndex = 2;
			this.label1.Text = "Es principalmente conocido por expresar el futuro en inglés; sin embargo, en su f" +
			"orma de verbo modal, es usado para expresar una decisión tomada en el momento o " +
			"la intención de hacer algo.";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(288, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(164, 62);
			this.label2.TabIndex = 3;
			this.label2.Text = "VERBOS MODALES";
			// 
			// siguiente
			// 
			this.siguiente.ForeColor = System.Drawing.Color.Red;
			this.siguiente.Location = new System.Drawing.Point(363, 283);
			this.siguiente.Name = "siguiente";
			this.siguiente.Size = new System.Drawing.Size(75, 23);
			this.siguiente.TabIndex = 4;
			this.siguiente.Text = "SIGUIENTE";
			this.siguiente.UseVisualStyleBackColor = true;
			this.siguiente.Click += new System.EventHandler(this.SiguienteClick);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(26, 288);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(246, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "¿Cuál es la estructura de los verbos modales?";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 311);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(315, 18);
			this.label4.TabIndex = 6;
			this.label4.Text = "Sujeto + modal verb + verb (infinitive form) + complemento";
			this.label4.Click += new System.EventHandler(this.Label4Click);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 197);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(270, 74);
			this.label5.TabIndex = 7;
			this.label5.Text = " consiste en la adquisición de espectros de vibración multitud de puntos en la es" +
			"tructura de la máquina con una o varias referencias de fase fijas. ";
			// 
			// ingles3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(509, 338);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.siguiente);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Name = "ingles3";
			this.Text = "Formingles3";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button siguiente;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
