/*
 * Created by SharpDevelop.
 * User: CC2_PC40
 * Date: 31/10/2024
 * Time: 07:39 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace equipo
{
	/// <summary>
	/// Description of Formtiposcom.
	/// </summary>
	public partial class Tiposcom : Form
	{
		public Tiposcom()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtncriticoClick(object sender, EventArgs e)
		{
			Comcritico Formcomcritico = new Comcritico();
			Formcomcritico.Show();
		}
		
		void BtnfilologicoClick(object sender, EventArgs e)
		{
			Comfilologicos Formcomfilologicos = new Comfilologicos();
			Formcomfilologicos.Show();
		}
		
		void BtnbiblicoClick(object sender, EventArgs e)
		{
			Combiblicos Formcombiblicos = new Combiblicos();
			Formcombiblicos.Show();
		}
		
		void BtnhistoricoClick(object sender, EventArgs e)
		{
			Comhistoricos Formcomhistoricos = new Comhistoricos();
			Formcomhistoricos.Show();
		}
		
		void BtnliterarioClick(object sender, EventArgs e)
		{
			Comliterarios Formcomliterarios = new Comliterarios();
			Formcomliterarios.Show();
		}
	}
}
