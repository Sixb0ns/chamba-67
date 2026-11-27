/*
 * Created by SharpDevelop.
 * User: CC2_PC24
 * Date: 25/11/2026
 * Time: 07:46 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace chamba_67
{
	/// <summary>
	/// Description of encuentramayormenor.
	/// </summary>
	public partial class encuentramayormenor : Form
	{
		private int[] arreglo;
         private string texto="";
         private int indice;
         private int tamañoarreglo;
		public encuentramayormenor()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			    int mayor = arreglo[0];
			    int menor = arreglo[0];
			    int suma = 0;
			
			    for (int i = 0; i < arreglo.Length; i++)
			    {
			        if (arreglo[i] > mayor)
			            mayor = arreglo[i];
			
			        if (arreglo[i] < menor)
			            menor = arreglo[i];
			
			        suma += arreglo[i];
			    }
			
			    double promedio = (double)suma / arreglo.Length;
			
			    lblMayor.Text =mayor.ToString();
			    lblMenor.Text = menor.ToString();
			    lblPromedio.Text = promedio.ToString("0.##");
			    
			}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			string entrada = textBox1.Text.Trim();

	    if (string.IsNullOrEmpty(entrada))
	    {
	        arreglo = null;
	        tamañoarreglo = 0;
	        return;
	    }
	
	    tamañoarreglo = entrada.Length;
	    arreglo = new int[tamañoarreglo];
	
	    for (int i = 0; i < entrada.Length; i++)
	    {
	        if (char.IsDigit(entrada[i]))
	        {
	            arreglo[i] = int.Parse(entrada[i].ToString());
	        }
	       
   			}
		}
	}
}
