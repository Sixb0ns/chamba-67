/*
 * Creado por SharpDevelop.
 * Usuario: Edwin
 * Fecha: 26/11/2026
 * Hora: 07:14 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace chamba_67
{
	partial class MenuPrincipal
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnVocales = new System.Windows.Forms.Button();
			this.btnOrdenar = new System.Windows.Forms.Button();
			this.btnMayorMenor = new System.Windows.Forms.Button();
			this.btnInvertir = new System.Windows.Forms.Button();
			this.btnOff = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnVocales
			// 
			this.btnVocales.Location = new System.Drawing.Point(12, 101);
			this.btnVocales.Name = "btnVocales";
			this.btnVocales.Size = new System.Drawing.Size(185, 34);
			this.btnVocales.TabIndex = 7;
			this.btnVocales.Text = "Vocales y Consonantes";
			this.btnVocales.UseVisualStyleBackColor = true;
			this.btnVocales.Click += new System.EventHandler(this.BtnVocalesClick);
			// 
			// btnOrdenar
			// 
			this.btnOrdenar.Location = new System.Drawing.Point(12, 63);
			this.btnOrdenar.Name = "btnOrdenar";
			this.btnOrdenar.Size = new System.Drawing.Size(185, 34);
			this.btnOrdenar.TabIndex = 6;
			this.btnOrdenar.Text = "Ordenar Numeros";
			this.btnOrdenar.UseVisualStyleBackColor = true;
			this.btnOrdenar.Click += new System.EventHandler(this.BtnOrdenarClick);
			// 
			// btnMayorMenor
			// 
			this.btnMayorMenor.Location = new System.Drawing.Point(239, 101);
			this.btnMayorMenor.Name = "btnMayorMenor";
			this.btnMayorMenor.Size = new System.Drawing.Size(185, 34);
			this.btnMayorMenor.TabIndex = 9;
			this.btnMayorMenor.Text = "Numeros Ordenados";
			this.btnMayorMenor.UseVisualStyleBackColor = true;
			this.btnMayorMenor.Click += new System.EventHandler(this.BtnMayorMenorClick);
			// 
			// btnInvertir
			// 
			this.btnInvertir.Location = new System.Drawing.Point(239, 63);
			this.btnInvertir.Name = "btnInvertir";
			this.btnInvertir.Size = new System.Drawing.Size(185, 34);
			this.btnInvertir.TabIndex = 8;
			this.btnInvertir.Text = "Invertir";
			this.btnInvertir.UseVisualStyleBackColor = true;
			this.btnInvertir.Click += new System.EventHandler(this.Button2Click);
			// 
			// btnOff
			// 
			this.btnOff.Location = new System.Drawing.Point(126, 153);
			this.btnOff.Name = "btnOff";
			this.btnOff.Size = new System.Drawing.Size(185, 34);
			this.btnOff.TabIndex = 10;
			this.btnOff.Text = "Salir";
			this.btnOff.UseVisualStyleBackColor = true;
			this.btnOff.Click += new System.EventHandler(this.BtnOffClick);
			// 
			// MenuPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(436, 341);
			this.Controls.Add(this.btnOff);
			this.Controls.Add(this.btnMayorMenor);
			this.Controls.Add(this.btnInvertir);
			this.Controls.Add(this.btnVocales);
			this.Controls.Add(this.btnOrdenar);
			this.Name = "MenuPrincipal";
			this.Text = "MenuPrincipal";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnOff;
		private System.Windows.Forms.Button btnInvertir;
		private System.Windows.Forms.Button btnMayorMenor;
		private System.Windows.Forms.Button btnOrdenar;
		private System.Windows.Forms.Button btnVocales;
	}
}
