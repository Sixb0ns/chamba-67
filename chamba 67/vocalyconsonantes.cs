/*
 * Created by SharpDevelop.
 * User: CC2_PC24
 * Date: 25/11/2026
 * Time: 07:47 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace chamba_67
{
	/// <summary>
	/// Description of vocalyconsonantes.
	/// </summary>
	public partial class vocalyconsonantes : Form
	{
		public vocalyconsonantes()
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
			int v=0;
			int c=0;
			for(int i=0; i<textBox1.Text.Length; i++){
				char tem=textBox1.Text[i];
				if (tem==65||tem==69||tem==73||tem==79||tem==85||tem==97||tem==101||tem==105||tem==111||tem==117){
					v++;
				}
				else if((tem>=65&&tem<=90)||(tem>=97&&tem<=122)){
					c++;
				}
			}
			textBox2.Text=v.ToString();
			textBox3.Text=c.ToString();			
		}
	}
}
