/*
 * Created by SharpDevelop.
 * User: CC2_PC39
 * Date: 31/10/2024
 * Time: 08:06 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace equipo
{
	/// <summary>
	/// Description of Formprom.
	/// </summary>
	public partial class prom : Form
	{
		public prom()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtncalcClick(object sender, EventArgs e)
		{
			double cal1, cal2, cal3, cal4, cal5, cal6, cal7, cal8, pro;
		    cal1 = Convert.ToDouble(txtcal1.Text);
		    cal2 = Convert.ToDouble(txtcal2.Text);
		    cal3 = Convert.ToDouble(txtcal3.Text);
		    cal4 = Convert.ToDouble(txtcal4.Text);
		    cal5 = Convert.ToDouble(txtcal5.Text);
		    cal6 = Convert.ToDouble(txtcal6.Text);
		    cal7 = Convert.ToDouble(txtcal7.Text);
		    cal8 = Convert.ToDouble(txtcal8.Text);
		
		    pro = (cal1 + cal2 + cal3 + cal4 + cal5 + cal6 + cal7 + cal8) / 8;
		
		    txtr.Text = pro.ToString("F2");
		}
		
		void BtnatraClick(object sender, EventArgs e)
		{
			mat formmat = new mat();
			formmat.Show();
		}
	}
}
