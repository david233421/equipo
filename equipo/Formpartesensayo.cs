/*
 * Created by SharpDevelop.
 * User: CC2_PC40
 * Date: 29/10/2024
 * Time: 08:19 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace equipo
{
	/// <summary>
	/// Description of Formpartesensayo.
	/// </summary>
	public partial class Partesensayo : Form
	{
		public Partesensayo()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnintroduccionClick(object sender, EventArgs e)
		{
			Introduccion Formintroduccion = new Introduccion();
			Formintroduccion.Show();
		}
		
		void BtndesarrolloClick(object sender, EventArgs e)
		{
			Desarrollo Formdesarrollo = new Desarrollo();
			Formdesarrollo.Show();
		}
		
		void BtnconclusionClick(object sender, EventArgs e)
		{
			Cierre Formcierre = new Cierre();
			Formcierre.Show();
		}
	}
}
