/*
 * Created by SharpDevelop.
 * User: CC2_PC39
 * Date: 29/10/2024
 * Time: 07:16 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace equipo
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtninClick(object sender, EventArgs e)
		{
			ingles formingles = new ingles();
			formingles.Show();
		}
		
		void BtnlenClick(object sender, EventArgs e)
		{
			lengua formlengua = new lengua();
			formlengua.Show();
		}
		
		void BtnmatClick(object sender, EventArgs e)
		{
			mat formmat = new mat();
			formmat.Show();
		}
		
		void BtnfiClick(object sender, EventArgs e)
		{
			fisi formfici = new fisi();
			formfici.Show();			
		}
		
		void BtnhumClick(object sender, EventArgs e)
		{
			hum formhum = new hum();
			formhum.Show();			
		}
	}
}
