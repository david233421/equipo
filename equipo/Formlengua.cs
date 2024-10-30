/*
 * Created by SharpDevelop.
 * User: CC2_PC39
 * Date: 29/10/2024
 * Time: 07:24 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace equipo
{
	/// <summary>
	/// Description of Formlengua.
	/// </summary>
	public partial class lengua : Form
	{
		public lengua()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtncomcritClick(object sender, EventArgs e)
		{
			Comcrit Formcomcrit = new Comcrit();
			Formcomcrit.Show();
		}
		
		void BtnresenaClick(object sender, EventArgs e)
		{
			Reseña Formreseña = new Reseña();
			Formreseña.Show();
		}
		
		void BtnensayoClick(object sender, EventArgs e)
		{
			Ensayo FormEnsayo = new Ensayo();
			FormEnsayo.Show();
		}
	}
}
