namespace Programa.Modulos.Contabilidad
{
	partial class PagoProveedor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagoProveedor));
			this.ingresosGVW = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.numerochequeTBT = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.montoTBT = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.idIngresoTBT = new System.Windows.Forms.TextBox();
			this.IdTXT = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.formapagoCBX = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.serieTBX = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.timbradoTXT = new System.Windows.Forms.TextBox();
			this.fechaTPC = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonGuardar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.buttonConsultar = new System.Windows.Forms.Button();
			this.buttonLimpiar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ingresosGVW)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// ingresosGVW
			// 
			this.ingresosGVW.AllowUserToAddRows = false;
			this.ingresosGVW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ingresosGVW.Location = new System.Drawing.Point(63, 393);
			this.ingresosGVW.Name = "ingresosGVW";
			this.ingresosGVW.Size = new System.Drawing.Size(985, 218);
			this.ingresosGVW.TabIndex = 58;
			this.ingresosGVW.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ingresosGVW_CellClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.numerochequeTBT);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.montoTBT);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.idIngresoTBT);
			this.groupBox1.Controls.Add(this.IdTXT);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.formapagoCBX);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.serieTBX);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.timbradoTXT);
			this.groupBox1.Controls.Add(this.fechaTPC);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(63, 61);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(718, 219);
			this.groupBox1.TabIndex = 59;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Información del Ingreso";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label8.Location = new System.Drawing.Point(290, 135);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(65, 16);
			this.label8.TabIndex = 69;
			this.label8.Text = "# Cheque";
			// 
			// numerochequeTBT
			// 
			this.numerochequeTBT.Location = new System.Drawing.Point(293, 167);
			this.numerochequeTBT.Name = "numerochequeTBT";
			this.numerochequeTBT.Size = new System.Drawing.Size(137, 20);
			this.numerochequeTBT.TabIndex = 68;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label6.Location = new System.Drawing.Point(483, 136);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(101, 16);
			this.label6.TabIndex = 67;
			this.label6.Text = "Monto del Pago";
			// 
			// montoTBT
			// 
			this.montoTBT.Location = new System.Drawing.Point(486, 168);
			this.montoTBT.Name = "montoTBT";
			this.montoTBT.Size = new System.Drawing.Size(137, 20);
			this.montoTBT.TabIndex = 66;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(23, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 16);
			this.label2.TabIndex = 65;
			this.label2.Text = "Id Ingreso";
			// 
			// idIngresoTBT
			// 
			this.idIngresoTBT.Location = new System.Drawing.Point(26, 71);
			this.idIngresoTBT.Name = "idIngresoTBT";
			this.idIngresoTBT.Size = new System.Drawing.Size(67, 20);
			this.idIngresoTBT.TabIndex = 64;
			// 
			// IdTXT
			// 
			this.IdTXT.Location = new System.Drawing.Point(620, 19);
			this.IdTXT.Name = "IdTXT";
			this.IdTXT.Size = new System.Drawing.Size(51, 20);
			this.IdTXT.TabIndex = 63;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label7.Location = new System.Drawing.Point(594, 19);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(20, 16);
			this.label7.TabIndex = 62;
			this.label7.Text = "ID";
			// 
			// formapagoCBX
			// 
			this.formapagoCBX.FormattingEnabled = true;
			this.formapagoCBX.Location = new System.Drawing.Point(26, 167);
			this.formapagoCBX.Name = "formapagoCBX";
			this.formapagoCBX.Size = new System.Drawing.Size(241, 21);
			this.formapagoCBX.TabIndex = 59;
			this.formapagoCBX.SelectedIndexChanged += new System.EventHandler(this.formapagoCBX_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label5.Location = new System.Drawing.Point(23, 138);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(106, 16);
			this.label5.TabIndex = 58;
			this.label5.Text = "Formas de Pago:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(146, 39);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 16);
			this.label4.TabIndex = 57;
			this.label4.Text = "Serie";
			// 
			// serieTBX
			// 
			this.serieTBX.Location = new System.Drawing.Point(149, 71);
			this.serieTBX.Name = "serieTBX";
			this.serieTBX.Size = new System.Drawing.Size(118, 20);
			this.serieTBX.TabIndex = 56;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(310, 42);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 16);
			this.label3.TabIndex = 55;
			this.label3.Text = "Numero de Timbrado";
			// 
			// timbradoTXT
			// 
			this.timbradoTXT.Location = new System.Drawing.Point(313, 74);
			this.timbradoTXT.Name = "timbradoTXT";
			this.timbradoTXT.Size = new System.Drawing.Size(130, 20);
			this.timbradoTXT.TabIndex = 54;
			// 
			// fechaTPC
			// 
			this.fechaTPC.Enabled = false;
			this.fechaTPC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.fechaTPC.Location = new System.Drawing.Point(486, 71);
			this.fechaTPC.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
			this.fechaTPC.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
			this.fechaTPC.Name = "fechaTPC";
			this.fechaTPC.Size = new System.Drawing.Size(118, 20);
			this.fechaTPC.TabIndex = 51;
			this.fechaTPC.Value = new System.DateTime(2019, 1, 16, 23, 56, 20, 0);
			this.fechaTPC.ValueChanged += new System.EventHandler(this.fechaTPC_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(483, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.TabIndex = 50;
			this.label1.Text = "Fecha:";
			// 
			// buttonGuardar
			// 
			this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.Image")));
			this.buttonGuardar.Location = new System.Drawing.Point(622, 310);
			this.buttonGuardar.Name = "buttonGuardar";
			this.buttonGuardar.Size = new System.Drawing.Size(97, 65);
			this.buttonGuardar.TabIndex = 61;
			this.buttonGuardar.UseVisualStyleBackColor = true;
			this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(849, 61);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(208, 219);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 63;
			this.pictureBox1.TabStop = false;
			// 
			// buttonConsultar
			// 
			this.buttonConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonConsultar.Image = ((System.Drawing.Image)(resources.GetObject("buttonConsultar.Image")));
			this.buttonConsultar.Location = new System.Drawing.Point(961, 309);
			this.buttonConsultar.Name = "buttonConsultar";
			this.buttonConsultar.Size = new System.Drawing.Size(87, 66);
			this.buttonConsultar.TabIndex = 65;
			this.buttonConsultar.UseVisualStyleBackColor = true;
			this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
			// 
			// buttonLimpiar
			// 
			this.buttonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("buttonLimpiar.Image")));
			this.buttonLimpiar.Location = new System.Drawing.Point(849, 308);
			this.buttonLimpiar.Name = "buttonLimpiar";
			this.buttonLimpiar.Size = new System.Drawing.Size(83, 66);
			this.buttonLimpiar.TabIndex = 64;
			this.buttonLimpiar.UseVisualStyleBackColor = true;
			this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
			// 
			// PagoProveedor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1110, 659);
			this.Controls.Add(this.buttonConsultar);
			this.Controls.Add(this.buttonLimpiar);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.buttonGuardar);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.ingresosGVW);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "PagoProveedor";
			this.Text = "PagoProveedor";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.PagoProveedor_Load);
			((System.ComponentModel.ISupportInitialize)(this.ingresosGVW)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.DataGridView ingresosGVW;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox IdTXT;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox serieTBX;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox timbradoTXT;
		private System.Windows.Forms.DateTimePicker fechaTPC;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonGuardar;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox montoTBT;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox idIngresoTBT;
		private System.Windows.Forms.ComboBox formapagoCBX;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonConsultar;
		private System.Windows.Forms.Button buttonLimpiar;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox numerochequeTBT;
	}
}