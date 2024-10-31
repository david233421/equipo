/*
 * Created by SharpDevelop.
 * User: CC2_PC38
 * Date: 30/10/2024
 * Time: 02:36 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace equipo
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class fisica2 : Form
	{
		public fisica2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void Button1Click(object sender, EventArgs e)
		{
			
			fisica4 Form3 = new fisica4();
			Form3.Show();
		}
	}
}
