/*
 * Created by SharpDevelop.
 * User: CC2_PC38
 * Date: 31/10/2024
 * Time: 02:25 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace equipo
{
	partial class Fisica8
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fisica8));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(11, 5);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(199, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ejemplo de la primera ley de newton";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(155, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(212, 77);
			this.label2.TabIndex = 1;
			this.label2.Text = "Por ejemplo, una rana -sentada sobre una hoja- se mantendrá en reposo mientras no" +
			" actúe una fuerza sobre ella.";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 124);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(202, 117);
			this.label3.TabIndex = 2;
			this.label3.Text = "En nuestro caso, el resultado (impacto) sanitario será el mismo con el transcurri" +
			"r del tiempo, mientras no exista un problema o intervención sanitaria (fuerza) q" +
			"ue actúe sobre ellos.";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(302, 101);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(319, 140);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(92, 250);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(194, 83);
			this.label4.TabIndex = 4;
			this.label4.Text = "Conclusion: Como el ejemplo lo dice la rana esta sentada en la hoja y se mantiene" +
			" quita y no agarra fuerza";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(539, 299);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(82, 34);
			this.button1.TabIndex = 5;
			this.button1.Text = "Siguiente";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Fisica8
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(645, 342);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Fisica8";
			this.Text = "Form7";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
