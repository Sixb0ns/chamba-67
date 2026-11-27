/*
 * Created by SharpDevelop.
 * User: CC2_PC24
 * Date: 25/11/2026
 * Time: 07:45 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace chamba_67
{
	partial class OrdenarNumeros
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtArreglo = new System.Windows.Forms.TextBox();
			this.Establecertamaño = new System.Windows.Forms.Button();
			this.txtContinuar = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnagregar = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblMayor = new System.Windows.Forms.Label();
			this.lblMenor = new System.Windows.Forms.Label();
			this.btnArreglar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(25, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(259, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Asignar tamaño al arreglo:";
			// 
			// txtArreglo
			// 
			this.txtArreglo.Location = new System.Drawing.Point(339, 54);
			this.txtArreglo.Name = "txtArreglo";
			this.txtArreglo.Size = new System.Drawing.Size(105, 26);
			this.txtArreglo.TabIndex = 11;
			// 
			// Establecertamaño
			// 
			this.Establecertamaño.Location = new System.Drawing.Point(453, 54);
			this.Establecertamaño.Name = "Establecertamaño";
			this.Establecertamaño.Size = new System.Drawing.Size(185, 34);
			this.Establecertamaño.TabIndex = 2;
			this.Establecertamaño.Text = "Establecer tamaño";
			this.Establecertamaño.UseVisualStyleBackColor = true;
			this.Establecertamaño.Click += new System.EventHandler(this.EstablecertamañoClick);
			// 
			// txtContinuar
			// 
			this.txtContinuar.Location = new System.Drawing.Point(339, 91);
			this.txtContinuar.Name = "txtContinuar";
			this.txtContinuar.Size = new System.Drawing.Size(105, 26);
			this.txtContinuar.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(25, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(259, 37);
			this.label2.TabIndex = 3;
			this.label2.Text = "Numeros a agregar:";
			// 
			// btnagregar
			// 
			this.btnagregar.Location = new System.Drawing.Point(453, 92);
			this.btnagregar.Name = "btnagregar";
			this.btnagregar.Size = new System.Drawing.Size(185, 34);
			this.btnagregar.TabIndex = 5;
			this.btnagregar.Text = "Agregar Numero";
			this.btnagregar.UseVisualStyleBackColor = true;
			this.btnagregar.Click += new System.EventHandler(this.BtnagregarClick);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(25, 182);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(223, 37);
			this.label3.TabIndex = 6;
			this.label3.Text = "Mayor a Menor:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(25, 211);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(223, 37);
			this.label4.TabIndex = 7;
			this.label4.Text = "Menor a Mayor:";
			// 
			// lblMayor
			// 
			this.lblMayor.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMayor.Location = new System.Drawing.Point(339, 182);
			this.lblMayor.Name = "lblMayor";
			this.lblMayor.Size = new System.Drawing.Size(259, 37);
			this.lblMayor.TabIndex = 8;
			// 
			// lblMenor
			// 
			this.lblMenor.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMenor.Location = new System.Drawing.Point(339, 211);
			this.lblMenor.Name = "lblMenor";
			this.lblMenor.Size = new System.Drawing.Size(259, 37);
			this.lblMenor.TabIndex = 9;
			// 
			// btnArreglar
			// 
			this.btnArreglar.Location = new System.Drawing.Point(25, 121);
			this.btnArreglar.Name = "btnArreglar";
			this.btnArreglar.Size = new System.Drawing.Size(185, 34);
			this.btnArreglar.TabIndex = 10;
			this.btnArreglar.Text = "Ejecutar";
			this.btnArreglar.UseVisualStyleBackColor = true;
			this.btnArreglar.Click += new System.EventHandler(this.BtnArreglarClick);
			// 
			// OrdenarNumeros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(776, 267);
			this.Controls.Add(this.btnArreglar);
			this.Controls.Add(this.lblMenor);
			this.Controls.Add(this.lblMayor);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnagregar);
			this.Controls.Add(this.txtContinuar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Establecertamaño);
			this.Controls.Add(this.txtArreglo);
			this.Controls.Add(this.label1);
			this.Name = "OrdenarNumeros";
			this.Text = "OrdenarNumeros";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnArreglar;
		private System.Windows.Forms.Label lblMenor;
		private System.Windows.Forms.Label lblMayor;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnagregar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtContinuar;
		private System.Windows.Forms.Button Establecertamaño;
		private System.Windows.Forms.TextBox txtArreglo;
		private System.Windows.Forms.Label label1;
	}
}
