/*
 * Created by SharpDevelop.
 * User: CC2_PC24
 * Date: 25/11/2026
 * Time: 07:46 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace chamba_67
{
	partial class encuentramayormenor
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblMayor = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblMenor = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblPromedio = new System.Windows.Forms.Label();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(142, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(292, 53);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ingrese un arreglo";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(132, 84);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(292, 37);
			this.textBox1.TabIndex = 1;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(23, 161);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(229, 53);
			this.label2.TabIndex = 2;
			this.label2.Text = "Numero mayor";
			// 
			// lblMayor
			// 
			this.lblMayor.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMayor.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblMayor.Location = new System.Drawing.Point(35, 214);
			this.lblMayor.Name = "lblMayor";
			this.lblMayor.Size = new System.Drawing.Size(217, 53);
			this.lblMayor.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new System.Drawing.Point(285, 161);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(236, 53);
			this.label3.TabIndex = 4;
			this.label3.Text = "Numero menor";
			// 
			// lblMenor
			// 
			this.lblMenor.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMenor.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblMenor.Location = new System.Drawing.Point(293, 214);
			this.lblMenor.Name = "lblMenor";
			this.lblMenor.Size = new System.Drawing.Size(209, 53);
			this.lblMenor.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label4.Location = new System.Drawing.Point(194, 267);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(171, 53);
			this.label4.TabIndex = 6;
			this.label4.Text = "Promedio";
			// 
			// lblPromedio
			// 
			this.lblPromedio.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPromedio.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblPromedio.Location = new System.Drawing.Point(132, 355);
			this.lblPromedio.Name = "lblPromedio";
			this.lblPromedio.Size = new System.Drawing.Size(292, 53);
			this.lblPromedio.TabIndex = 7;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(132, 461);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(292, 38);
			this.btnCalcular.TabIndex = 8;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// encuentramayormenor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(553, 541);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.lblPromedio);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblMenor);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblMayor);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "encuentramayormenor";
			this.Text = "encuentramayormenor";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label lblPromedio;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblMenor;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblMayor;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
	}
}
