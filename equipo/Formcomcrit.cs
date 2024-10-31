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
	/// Description of Formcomcrit.
	/// </summary>
	public partial class Comcrit : Form
	{
		public Comcrit()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtntiposcomClick(object sender, EventArgs e)
		{
			Tiposcom Formtiposcom = new Tiposcom();
			Formtiposcom.Show();
		}
		
		void BtnelaborarcomClick(object sender, EventArgs e)
		{
			Formelaborarcom Formelaborarcom = new Formelaborarcom();
			Formelaborarcom.Show();
		}
	}
}
