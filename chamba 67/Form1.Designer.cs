/*
 * Created by SharpDevelop.
 * User: CC2_PC24
 * Date: 26/11/2026
 * Time: 07:28 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace chamba_67
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.lblNumeroMayor = new System.Windows.Forms.Label();
			this.lblPromedio = new System.Windows.Forms.Label();
			this.lblNumeroMenor = new System.Windows.Forms.Label();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(203, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(260, 38);
			this.label1.TabIndex = 0;
			this.label1.Text = "Inserte un arreglo";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(274, 153);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(156, 38);
			this.label3.TabIndex = 2;
			this.label3.Text = "Promedio:";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(469, 200);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(226, 38);
			this.label4.TabIndex = 3;
			this.label4.Text = "Numero menor";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(12, 200);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(223, 38);
			this.label5.TabIndex = 4;
			this.label5.Text = "Numero mayor";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(203, 50);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(260, 44);
			this.textBox1.TabIndex = 5;
			// 
			// lblNumeroMayor
			// 
			this.lblNumeroMayor.BackColor = System.Drawing.Color.Transparent;
			this.lblNumeroMayor.Location = new System.Drawing.Point(44, 247);
			this.lblNumeroMayor.Name = "lblNumeroMayor";
			this.lblNumeroMayor.Size = new System.Drawing.Size(100, 23);
			this.lblNumeroMayor.TabIndex = 6;
			// 
			// lblPromedio
			// 
			this.lblPromedio.BackColor = System.Drawing.Color.Transparent;
			this.lblPromedio.Location = new System.Drawing.Point(305, 200);
			this.lblPromedio.Name = "lblPromedio";
			this.lblPromedio.Size = new System.Drawing.Size(100, 23);
			this.lblPromedio.TabIndex = 7;
			// 
			// lblNumeroMenor
			// 
			this.lblNumeroMenor.BackColor = System.Drawing.Color.Transparent;
			this.lblNumeroMenor.Location = new System.Drawing.Point(537, 247);
			this.lblNumeroMenor.Name = "lblNumeroMenor";
			this.lblNumeroMenor.Size = new System.Drawing.Size(100, 23);
			this.lblNumeroMenor.TabIndex = 8;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.Color.Red;
			this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.Location = new System.Drawing.Point(81, 100);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(127, 53);
			this.btnLimpiar.TabIndex = 9;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = false;
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.Red;
			this.btnSalir.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Location = new System.Drawing.Point(469, 100);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(122, 44);
			this.btnSalir.TabIndex = 10;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = false;
			// 
			// btnCalcular
			// 
			this.btnCalcular.BackColor = System.Drawing.Color.Red;
			this.btnCalcular.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(213, 311);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(260, 46);
			this.btnCalcular.TabIndex = 11;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(707, 405);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.lblNumeroMenor);
			this.Controls.Add(this.lblPromedio);
			this.Controls.Add(this.lblNumeroMayor);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Mayor Menor y Promedio";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Label lblNumeroMenor;
		private System.Windows.Forms.Label lblPromedio;
		private System.Windows.Forms.Label lblNumeroMayor;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
	}
}
