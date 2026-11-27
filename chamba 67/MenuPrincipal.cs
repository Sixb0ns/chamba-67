/*
 * Creado por SharpDevelop.
 * Usuario: Edwin
 * Fecha: 26/11/2026
 * Hora: 07:14 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace chamba_67
{
	/// <summary>
	/// Description of MenuPrincipal.
	/// </summary>
	public partial class MenuPrincipal : Form
	{
		public MenuPrincipal()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void BtnMayorMenorClick(object sender, EventArgs e)
		{
			OrdenarNumeros xd= new OrdenarNumeros();
			xd.Show();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			invertirpalabra xd= new invertirpalabra();
			xd.Show();
		}
		
		void BtnVocalesClick(object sender, EventArgs e)
		{
			vocalyconsonantes xd= new vocalyconsonantes();
			xd.Show();
		}
		
		void BtnOrdenarClick(object sender, EventArgs e)
		{
			OrdenarNumeros xd= new OrdenarNumeros();
			xd.Show();
		}
		
		void BtnOffClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
