/*
 * Created by SharpDevelop.
 * User: CC2_PC24
 * Date: 25/11/2026
 * Time: 07:44 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace chamba_67
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
		
		void Button1Click(object sender, EventArgs e)
		{
			if(textBox2.Text=="contraseña"&&textBox1.Text=="user"){
				Form1 f= new Form1();
				f.Show();
				this.Hide();
			}
		}
	}
}
