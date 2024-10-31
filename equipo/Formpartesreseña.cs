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
	/// Description of Formpartesreseña.
	/// </summary>
	public partial class Partesreseña : Form
	{
		public Partesreseña()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnencabezadoClick(object sender, EventArgs e)
		{
			Encabezadoreseña Formencabezadoreseña = new Encabezadoreseña();
			Formencabezadoreseña.Show();
		}
		
		void BtnintroduccionClick(object sender, EventArgs e)
		{
			Introduccionreseña Formintroduccionreseña = new Introduccionreseña();
			Formintroduccionreseña.Show();
		}
		
		void BtndesarrolloClick(object sender, EventArgs e)
		{
			Desarrolloreseña Formdesarrolloreseña = new Desarrolloreseña();
			Formdesarrolloreseña.Show();
		}
		
		void BtncierreClick(object sender, EventArgs e)
		{
			Cierrereseña Formcierrereseña = new Cierrereseña();
			Formcierrereseña.Show();
		}
	}
}
