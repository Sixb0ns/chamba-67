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
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnVocales
			// 
			this.btnVocales.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVocales.Location = new System.Drawing.Point(57, 218);
			this.btnVocales.Margin = new System.Windows.Forms.Padding(2);
			this.btnVocales.Name = "btnVocales";
			this.btnVocales.Size = new System.Drawing.Size(217, 93);
			this.btnVocales.TabIndex = 7;
			this.btnVocales.Text = "Vocales y Consonantes";
			this.btnVocales.UseVisualStyleBackColor = true;
			this.btnVocales.Click += new System.EventHandler(this.BtnVocalesClick);
			// 
			// btnOrdenar
			// 
			this.btnOrdenar.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOrdenar.Location = new System.Drawing.Point(57, 99);
			this.btnOrdenar.Margin = new System.Windows.Forms.Padding(2);
			this.btnOrdenar.Name = "btnOrdenar";
			this.btnOrdenar.Size = new System.Drawing.Size(217, 93);
			this.btnOrdenar.TabIndex = 6;
			this.btnOrdenar.Text = "Ordenar Numeros";
			this.btnOrdenar.UseVisualStyleBackColor = true;
			this.btnOrdenar.Click += new System.EventHandler(this.BtnOrdenarClick);
			// 
			// btnMayorMenor
			// 
			this.btnMayorMenor.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMayorMenor.Location = new System.Drawing.Point(372, 218);
			this.btnMayorMenor.Margin = new System.Windows.Forms.Padding(2);
			this.btnMayorMenor.Name = "btnMayorMenor";
			this.btnMayorMenor.Size = new System.Drawing.Size(217, 93);
			this.btnMayorMenor.TabIndex = 9;
			this.btnMayorMenor.Text = "Mayor Menor y Promedio";
			this.btnMayorMenor.UseVisualStyleBackColor = true;
			this.btnMayorMenor.Click += new System.EventHandler(this.BtnMayorMenorClick);
			// 
			// btnInvertir
			// 
			this.btnInvertir.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInvertir.Location = new System.Drawing.Point(372, 99);
			this.btnInvertir.Margin = new System.Windows.Forms.Padding(2);
			this.btnInvertir.Name = "btnInvertir";
			this.btnInvertir.Size = new System.Drawing.Size(217, 93);
			this.btnInvertir.TabIndex = 8;
			this.btnInvertir.Text = "Invertir";
			this.btnInvertir.UseVisualStyleBackColor = true;
			this.btnInvertir.Click += new System.EventHandler(this.Button2Click);
			// 
			// btnOff
			// 
			this.btnOff.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOff.Location = new System.Drawing.Point(208, 357);
			this.btnOff.Margin = new System.Windows.Forms.Padding(2);
			this.btnOff.Name = "btnOff";
			this.btnOff.Size = new System.Drawing.Size(217, 93);
			this.btnOff.TabIndex = 10;
			this.btnOff.Text = "Salir";
			this.btnOff.UseVisualStyleBackColor = true;
			this.btnOff.Click += new System.EventHandler(this.BtnOffClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Montserrat", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(37, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(589, 88);
			this.label1.TabIndex = 11;
			this.label1.Text = "Bienvenidos al menu principal";
			// 
			// MenuPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(659, 558);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnOff);
			this.Controls.Add(this.btnMayorMenor);
			this.Controls.Add(this.btnInvertir);
			this.Controls.Add(this.btnVocales);
			this.Controls.Add(this.btnOrdenar);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MenuPrincipal";
			this.Text = "MenuPrincipal";
			this.Load += new System.EventHandler(this.MenuPrincipalLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnOff;
		private System.Windows.Forms.Button btnInvertir;
		private System.Windows.Forms.Button btnMayorMenor;
		private System.Windows.Forms.Button btnOrdenar;
		private System.Windows.Forms.Button btnVocales;
	}
}
