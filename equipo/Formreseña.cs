/*
 * Created by SharpDevelop.
 * User: CC2_PC40
 * Date: 29/10/2024
 * Time: 08:13 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace equipo
{
	/// <summary>
	/// Description of Formreseña.
	/// </summary>
	public partial class Reseña : Form
	{
		public Reseña()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtntiposreClick(object sender, EventArgs e)
		{
			Tiposreseña Formtiposreseña = new Tiposreseña();
			Formtiposreseña.Show();
		}
		
		void BtnpartesreClick(object sender, EventArgs e)
		{
			Partesreseña Formpartesreseña = new Partesreseña();
			Formpartesreseña.Show();
		}
		
		void BtnhacerreClick(object sender, EventArgs e)
		{
			Elaborarreseña Formelaborarreseña = new Elaborarreseña();
			Formelaborarreseña.Show();
		}
	}
}
