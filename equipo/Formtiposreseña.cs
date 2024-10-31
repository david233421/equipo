/*
 * Created by SharpDevelop.
 * User: CC2_PC40
 * Date: 30/10/2024
 * Time: 08:11 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace equipo
{
	/// <summary>
	/// Description of Formtiposreseña.
	/// </summary>
	public partial class Tiposreseña : Form
	{
		public Tiposreseña()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnreseñaliterariaClick(object sender, EventArgs e)
		{
			Reseñaliteraria Formreseñaliteraria = new Reseñaliteraria();
			Formreseñaliteraria.Show();
		}
		
		void BtnreseñacriticaClick(object sender, EventArgs e)
		{
			Reseñacritica Formreseñacritica = new Reseñacritica();
			Formreseñacritica.Show();
		}
	}
}
