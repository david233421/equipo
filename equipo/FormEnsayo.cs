/*
 * Created by SharpDevelop.
 * User: CC2_PC40
 * Date: 29/10/2024
 * Time: 07:51 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace equipo
{
	/// <summary>
	/// Description of FormEnsayo.
	/// </summary>
	public partial class Ensayo : Form
	{
		public Ensayo()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtntiposClick(object sender, EventArgs e)
		{
			Tiposensayo Formtiposensayo = new Tiposensayo();
			Formtiposensayo.Show();
		}
		
		void BtnpartesClick(object sender, EventArgs e)
		{
			Partesensayo Formpartesensayo = new Partesensayo();
			Formpartesensayo.Show();
		}
		
		void BtnelaborarClick(object sender, EventArgs e)
		{
			Elaborarensayo Formelaborarensayo = new Elaborarensayo();
			Formelaborarensayo.Show();
		}
	}
}
