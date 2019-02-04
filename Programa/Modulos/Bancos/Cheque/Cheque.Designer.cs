namespace Programa.Modulos.Bancos.Cheque
{
	partial class Cheque
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.chequefechaDTP = new System.Windows.Forms.DateTimePicker();
			this.totalTBT = new System.Windows.Forms.TextBox();
			this.proveedorTBT = new System.Windows.Forms.TextBox();
			this.timbradoTXT = new System.Windows.Forms.TextBox();
			this.imprimirBTN = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.BarraTitulo = new System.Windows.Forms.Panel();
			this.btnCerrarPB = new System.Windows.Forms.PictureBox();
			this.serieTBT = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.BarraTitulo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnCerrarPB)).BeginInit();
			this.SuspendLayout();
			// 
			// chequefechaDTP
			// 
			this.chequefechaDTP.Enabled = false;
			this.chequefechaDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.chequefechaDTP.Location = new System.Drawing.Point(422, 109);
			this.chequefechaDTP.Name = "chequefechaDTP";
			this.chequefechaDTP.Size = new System.Drawing.Size(99, 20);
			this.chequefechaDTP.TabIndex = 1;
			this.chequefechaDTP.ValueChanged += new System.EventHandler(this.chequefechaDTP_ValueChanged);
			// 
			// totalTBT
			// 
			this.totalTBT.Enabled = false;
			this.totalTBT.Location = new System.Drawing.Point(504, 148);
			this.totalTBT.Name = "totalTBT";
			this.totalTBT.Size = new System.Drawing.Size(98, 20);
			this.totalTBT.TabIndex = 2;
			// 
			// proveedorTBT
			// 
			this.proveedorTBT.Enabled = false;
			this.proveedorTBT.Location = new System.Drawing.Point(144, 148);
			this.proveedorTBT.Name = "proveedorTBT";
			this.proveedorTBT.Size = new System.Drawing.Size(313, 20);
			this.proveedorTBT.TabIndex = 3;
			// 
			// timbradoTXT
			// 
			this.timbradoTXT.Enabled = false;
			this.timbradoTXT.Location = new System.Drawing.Point(534, 73);
			this.timbradoTXT.Name = "timbradoTXT";
			this.timbradoTXT.Size = new System.Drawing.Size(80, 20);
			this.timbradoTXT.TabIndex = 4;
			// 
			// imprimirBTN
			// 
			this.imprimirBTN.Image = global::Programa.Properties.Resources.imprimir1;
			this.imprimirBTN.Location = new System.Drawing.Point(729, 64);
			this.imprimirBTN.Name = "imprimirBTN";
			this.imprimirBTN.Size = new System.Drawing.Size(75, 65);
			this.imprimirBTN.TabIndex = 5;
			this.imprimirBTN.UseVisualStyleBackColor = true;
			this.imprimirBTN.Click += new System.EventHandler(this.imprimirBTN_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Programa.Properties.Resources.cheque1;
			this.pictureBox1.Location = new System.Drawing.Point(-41, 51);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(753, 273);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// BarraTitulo
			// 
			this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.BarraTitulo.Controls.Add(this.btnCerrarPB);
			this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
			this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
			this.BarraTitulo.Name = "BarraTitulo";
			this.BarraTitulo.Size = new System.Drawing.Size(817, 35);
			this.BarraTitulo.TabIndex = 6;
			// 
			// btnCerrarPB
			// 
			this.btnCerrarPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCerrarPB.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCerrarPB.Image = global::Programa.Properties.Resources.cerrar;
			this.btnCerrarPB.Location = new System.Drawing.Point(778, 12);
			this.btnCerrarPB.Name = "btnCerrarPB";
			this.btnCerrarPB.Size = new System.Drawing.Size(27, 16);
			this.btnCerrarPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnCerrarPB.TabIndex = 0;
			this.btnCerrarPB.TabStop = false;
			this.btnCerrarPB.Click += new System.EventHandler(this.btnCerrarPB_Click);
			// 
			// serieTBT
			// 
			this.serieTBT.Enabled = false;
			this.serieTBT.Location = new System.Drawing.Point(495, 73);
			this.serieTBT.Name = "serieTBT";
			this.serieTBT.Size = new System.Drawing.Size(33, 20);
			this.serieTBT.TabIndex = 7;
			// 
			// Cheque
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(817, 337);
			this.Controls.Add(this.serieTBT);
			this.Controls.Add(this.BarraTitulo);
			this.Controls.Add(this.imprimirBTN);
			this.Controls.Add(this.timbradoTXT);
			this.Controls.Add(this.proveedorTBT);
			this.Controls.Add(this.totalTBT);
			this.Controls.Add(this.chequefechaDTP);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Cheque";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cheque";
			this.Load += new System.EventHandler(this.Cheque_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.BarraTitulo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnCerrarPB)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DateTimePicker chequefechaDTP;
		private System.Windows.Forms.TextBox totalTBT;
		private System.Windows.Forms.TextBox proveedorTBT;
		private System.Windows.Forms.TextBox timbradoTXT;
		private System.Windows.Forms.Button imprimirBTN;
		private System.Windows.Forms.Panel BarraTitulo;
		private System.Windows.Forms.PictureBox btnCerrarPB;
		private System.Windows.Forms.TextBox serieTBT;
	}
}