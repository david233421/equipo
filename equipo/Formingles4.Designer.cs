/*
 * Created by SharpDevelop.
 * User: CC2_PC37
 * Date: 31/10/2024
 * Time: 07:52 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace equipo
{
	partial class ingles4
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ingles4));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(22, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(269, 61);
			this.label1.TabIndex = 0;
			this.label1.Text = "La preposición “for”\r\n se usa para expresar la duración de una acción, el periodo" +
			" de una acción o un evento.";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(22, 137);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(293, 65);
			this.label2.TabIndex = 1;
			this.label2.Text = "For en inglés puede utilizarse como preposición de modo,\r\n y se traduce como para" +
			" o por.\r\n Pero en algunos casos también puede indicar dirección \r\n(hacia, con de" +
			"stino a) y tiempo (durante).";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(389, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(239, 55);
			this.label3.TabIndex = 2;
			this.label3.Text = "“Since” se utiliza cuando queremos especificar un momento determinado en el que c" +
			"omenzó una acción en el pasado,";
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(22, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(463, 69);
			this.label5.TabIndex = 4;
			this.label5.Text = "Identificar los usos y significados de: For, Since, Just,";
			this.label5.Click += new System.EventHandler(this.Label5Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(389, 123);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(284, 79);
			this.label4.TabIndex = 5;
			this.label4.Text = resources.GetString("label4.Text");
			this.label4.Click += new System.EventHandler(this.Label4Click);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(126, 227);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(308, 69);
			this.label6.TabIndex = 6;
			this.label6.Text = resources.GetString("label6.Text");
			this.label6.Click += new System.EventHandler(this.Label6Click);
			// 
			// ingles4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(667, 339);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "ingles4";
			this.Text = "Formingles4";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
