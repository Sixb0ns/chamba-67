/*
 * Creado por SharpDevelop.
 * Usuario: owner
 * Fecha: 25/11/2026
 * Hora: 08:14 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace rama_quezabirria
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
		
		void BtnVoltearClick(object sender, EventArgs e)
		{
			string palabra = txtPalabra.Text;
    		
		    char[] caracteres = palabra.ToCharArray();
		    Array.Reverse(caracteres);
		    
		    lblPalabraAlreves.Text = new string(caracteres);
		}
	}
}
