/*
 * Created by SharpDevelop.
 * User: CC2_PC24
 * Date: 25/11/2026
 * Time: 07:45 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace chamba_67
{
	/// <summary>
	/// Description of OrdenarNumeros.
	/// </summary>
	public partial class OrdenarNumeros : Form
	{
		private int[] arreglo;
        private string texrtodelarregloekisde="";
        private int indice;
        private int tamañoarreglo;
		public OrdenarNumeros()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void EstablecertamañoClick(object sender, EventArgs e)
		{
			tamañoarreglo= Convert.ToInt32(txtArreglo.Text);
	        arreglo = new int[tamañoarreglo];
	        txtArreglo.Enabled= false;
		}
		
		void BtnagregarClick(object sender, EventArgs e)
		{
			if(indice==tamañoarreglo){
                btnagregar.Enabled=false;
                txtContinuar.Enabled=false;
            }
            arreglo[indice]= Convert.ToInt32(txtContinuar.Text);
            indice++;
            txtContinuar.Text="";
            txtContinuar.Focus();
		}
		
		void BtnArreglarClick(object sender, EventArgs e)
		{
			int mayor = arreglo[0];
			int menor = arreglo[0];
             int help=0;
             for (int i = 0; i < tamañoarreglo - 1; i++){
                 for (int j = 0; j < tamañoarreglo - 1; j++){
                     if (arreglo[j] < arreglo[j + 1]){
                         help=arreglo[j];
                         arreglo[j]=arreglo[j + 1];
                         arreglo[j+1]=help;
                         }
                     }
                 }
             texrtodelarregloekisde="";
             for (int i = 0; i < tamañoarreglo; i++){
                 texrtodelarregloekisde = texrtodelarregloekisde+" "+ arreglo[i].ToString()+ " ;";
                 }
             lblMayor.Text= texrtodelarregloekisde;
             texrtodelarregloekisde="";
             for (int i = tamañoarreglo-1; i >= 0; i--){
                 texrtodelarregloekisde = texrtodelarregloekisde+" "+ arreglo[i].ToString()+ " ;";
                 }
             lblMenor.Text= texrtodelarregloekisde;
		}
	}
}
