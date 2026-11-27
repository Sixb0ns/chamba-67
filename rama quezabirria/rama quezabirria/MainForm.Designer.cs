/*
 * Creado por SharpDevelop.
 * Usuario: owner
 * Fecha: 25/11/2026
 * Hora: 08:14 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace rama_quezabirria
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.txtPalabra = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblPalabraAlreves = new System.Windows.Forms.Label();
			this.btnVoltear = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// txtPalabra
			// 
			this.txtPalabra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.txtPalabra.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.txtPalabra.Location = new System.Drawing.Point(222, 68);
			this.txtPalabra.Name = "txtPalabra";
			this.txtPalabra.Size = new System.Drawing.Size(424, 53);
			this.txtPalabra.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.label1.Location = new System.Drawing.Point(41, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(175, 52);
			this.label1.TabIndex = 1;
			this.label1.Text = "Palabra:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblPalabraAlreves
			// 
			this.lblPalabraAlreves.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.lblPalabraAlreves.Location = new System.Drawing.Point(41, 365);
			this.lblPalabraAlreves.Name = "lblPalabraAlreves";
			this.lblPalabraAlreves.Size = new System.Drawing.Size(605, 53);
			this.lblPalabraAlreves.TabIndex = 2;
			this.lblPalabraAlreves.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnVoltear
			// 
			this.btnVoltear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnVoltear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.btnVoltear.Location = new System.Drawing.Point(241, 275);
			this.btnVoltear.Name = "btnVoltear";
			this.btnVoltear.Size = new System.Drawing.Size(180, 59);
			this.btnVoltear.TabIndex = 3;
			this.btnVoltear.Text = "Voltear";
			this.btnVoltear.UseVisualStyleBackColor = false;
			this.btnVoltear.Click += new System.EventHandler(this.BtnVoltearClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(482, 296);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(78, 66);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(566, 296);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(80, 66);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(41, 296);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(78, 66);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 6;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(125, 296);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(78, 66);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 7;
			this.pictureBox4.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(673, 466);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnVoltear);
			this.Controls.Add(this.lblPalabraAlreves);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtPalabra);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "rama quezabirria";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnVoltear;
		private System.Windows.Forms.Label lblPalabraAlreves;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPalabra;
	}
}
