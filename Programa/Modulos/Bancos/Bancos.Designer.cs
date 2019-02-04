namespace Programa.Modulos.Bancos
{
	partial class Bancos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bancos));
			this.BancoDGV = new System.Windows.Forms.DataGridView();
			this.NuevoBTN = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.idingresoTB = new System.Windows.Forms.TextBox();
			this.fechaTPC = new System.Windows.Forms.DateTimePicker();
			this.IdTXT = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.formapagoCBX = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.serieTBX = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.timbradoTXT = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tipoComprobanteTBX = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.proveedorCBX = new System.Windows.Forms.ComboBox();
			this.lblUSER_NAME = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.totalTXT = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.bancoCBX = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.divisaCBX = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.buttonConsultar = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.numerochequeTXT = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.BancoDGV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// BancoDGV
			// 
			this.BancoDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BancoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.BancoDGV.Location = new System.Drawing.Point(64, 414);
			this.BancoDGV.Name = "BancoDGV";
			this.BancoDGV.Size = new System.Drawing.Size(752, 236);
			this.BancoDGV.TabIndex = 0;
			this.BancoDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BancoDGV_CellClick);
			this.BancoDGV.Click += new System.EventHandler(this.BancoDGV_Click);
			// 
			// NuevoBTN
			// 
			this.NuevoBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NuevoBTN.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NuevoBTN.Image = ((System.Drawing.Image)(resources.GetObject("NuevoBTN.Image")));
			this.NuevoBTN.Location = new System.Drawing.Point(452, 340);
			this.NuevoBTN.Name = "NuevoBTN";
			this.NuevoBTN.Size = new System.Drawing.Size(73, 59);
			this.NuevoBTN.TabIndex = 50;
			this.NuevoBTN.UseVisualStyleBackColor = true;
			this.NuevoBTN.Click += new System.EventHandler(this.NuevoBTN_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(848, 13);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(243, 310);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 57;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.numerochequeTXT);
			this.groupBox1.Controls.Add(this.divisaCBX);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.bancoCBX);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.idingresoTB);
			this.groupBox1.Controls.Add(this.fechaTPC);
			this.groupBox1.Controls.Add(this.IdTXT);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.formapagoCBX);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.serieTBX);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.timbradoTXT);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.tipoComprobanteTBX);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.proveedorCBX);
			this.groupBox1.Controls.Add(this.lblUSER_NAME);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(64, 34);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(752, 289);
			this.groupBox1.TabIndex = 58;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Información del Ingreso";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label8.Location = new System.Drawing.Point(40, 76);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(62, 16);
			this.label8.TabIndex = 66;
			this.label8.Text = "# Ingreso";
			// 
			// idingresoTB
			// 
			this.idingresoTB.Location = new System.Drawing.Point(43, 96);
			this.idingresoTB.Name = "idingresoTB";
			this.idingresoTB.Size = new System.Drawing.Size(70, 20);
			this.idingresoTB.TabIndex = 65;
			// 
			// fechaTPC
			// 
			this.fechaTPC.Enabled = false;
			this.fechaTPC.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.fechaTPC.Location = new System.Drawing.Point(617, 19);
			this.fechaTPC.Name = "fechaTPC";
			this.fechaTPC.Size = new System.Drawing.Size(107, 20);
			this.fechaTPC.TabIndex = 64;
			// 
			// IdTXT
			// 
			this.IdTXT.Location = new System.Drawing.Point(62, 28);
			this.IdTXT.Name = "IdTXT";
			this.IdTXT.Size = new System.Drawing.Size(51, 20);
			this.IdTXT.TabIndex = 63;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label7.Location = new System.Drawing.Point(36, 28);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(20, 16);
			this.label7.TabIndex = 62;
			this.label7.Text = "ID";
			// 
			// formapagoCBX
			// 
			this.formapagoCBX.Enabled = false;
			this.formapagoCBX.FormattingEnabled = true;
			this.formapagoCBX.Location = new System.Drawing.Point(43, 175);
			this.formapagoCBX.Name = "formapagoCBX";
			this.formapagoCBX.Size = new System.Drawing.Size(154, 21);
			this.formapagoCBX.TabIndex = 59;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label5.Location = new System.Drawing.Point(40, 146);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(106, 16);
			this.label5.TabIndex = 58;
			this.label5.Text = "Formas de Pago:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(614, 76);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 16);
			this.label4.TabIndex = 57;
			this.label4.Text = "Serie";
			// 
			// serieTBX
			// 
			this.serieTBX.Enabled = false;
			this.serieTBX.Location = new System.Drawing.Point(617, 95);
			this.serieTBX.Name = "serieTBX";
			this.serieTBX.Size = new System.Drawing.Size(67, 20);
			this.serieTBX.TabIndex = 56;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(478, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 16);
			this.label3.TabIndex = 55;
			this.label3.Text = "Numero de Timbrado";
			// 
			// timbradoTXT
			// 
			this.timbradoTXT.Enabled = false;
			this.timbradoTXT.Location = new System.Drawing.Point(481, 95);
			this.timbradoTXT.Name = "timbradoTXT";
			this.timbradoTXT.Size = new System.Drawing.Size(130, 20);
			this.timbradoTXT.TabIndex = 54;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(215, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 16);
			this.label2.TabIndex = 53;
			this.label2.Text = "Tipo Comprobante:";
			// 
			// tipoComprobanteTBX
			// 
			this.tipoComprobanteTBX.Enabled = false;
			this.tipoComprobanteTBX.FormattingEnabled = true;
			this.tipoComprobanteTBX.Location = new System.Drawing.Point(218, 95);
			this.tipoComprobanteTBX.Name = "tipoComprobanteTBX";
			this.tipoComprobanteTBX.Size = new System.Drawing.Size(201, 21);
			this.tipoComprobanteTBX.TabIndex = 52;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(563, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.TabIndex = 50;
			this.label1.Text = "Fecha:";
			// 
			// proveedorCBX
			// 
			this.proveedorCBX.Enabled = false;
			this.proveedorCBX.FormattingEnabled = true;
			this.proveedorCBX.Location = new System.Drawing.Point(410, 175);
			this.proveedorCBX.Name = "proveedorCBX";
			this.proveedorCBX.Size = new System.Drawing.Size(241, 21);
			this.proveedorCBX.TabIndex = 49;
			// 
			// lblUSER_NAME
			// 
			this.lblUSER_NAME.AutoSize = true;
			this.lblUSER_NAME.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.lblUSER_NAME.Location = new System.Drawing.Point(407, 146);
			this.lblUSER_NAME.Name = "lblUSER_NAME";
			this.lblUSER_NAME.Size = new System.Drawing.Size(73, 16);
			this.lblUSER_NAME.TabIndex = 37;
			this.lblUSER_NAME.Text = "Proveedor:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.totalTXT);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(885, 497);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(183, 88);
			this.groupBox2.TabIndex = 59;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Total";
			// 
			// totalTXT
			// 
			this.totalTXT.Enabled = false;
			this.totalTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.totalTXT.Location = new System.Drawing.Point(26, 34);
			this.totalTXT.Name = "totalTXT";
			this.totalTXT.Size = new System.Drawing.Size(130, 31);
			this.totalTXT.TabIndex = 55;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(887, 367);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(73, 59);
			this.button1.TabIndex = 60;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.Location = new System.Drawing.Point(995, 367);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(73, 59);
			this.button2.TabIndex = 61;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// bancoCBX
			// 
			this.bancoCBX.FormattingEnabled = true;
			this.bancoCBX.Location = new System.Drawing.Point(43, 242);
			this.bancoCBX.Name = "bancoCBX";
			this.bancoCBX.Size = new System.Drawing.Size(154, 21);
			this.bancoCBX.TabIndex = 68;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label9.Location = new System.Drawing.Point(40, 211);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(49, 16);
			this.label9.TabIndex = 67;
			this.label9.Text = "Banco:";
			// 
			// divisaCBX
			// 
			this.divisaCBX.FormattingEnabled = true;
			this.divisaCBX.Location = new System.Drawing.Point(234, 242);
			this.divisaCBX.Name = "divisaCBX";
			this.divisaCBX.Size = new System.Drawing.Size(53, 21);
			this.divisaCBX.TabIndex = 70;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label10.Location = new System.Drawing.Point(231, 213);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(45, 16);
			this.label10.TabIndex = 69;
			this.label10.Text = "Divisa:";
			// 
			// buttonConsultar
			// 
			this.buttonConsultar.Image = ((System.Drawing.Image)(resources.GetObject("buttonConsultar.Image")));
			this.buttonConsultar.Location = new System.Drawing.Point(562, 340);
			this.buttonConsultar.Name = "buttonConsultar";
			this.buttonConsultar.Size = new System.Drawing.Size(71, 59);
			this.buttonConsultar.TabIndex = 66;
			this.buttonConsultar.UseVisualStyleBackColor = true;
			this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label6.Location = new System.Drawing.Point(231, 155);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(65, 16);
			this.label6.TabIndex = 72;
			this.label6.Text = "# Cheque";
			// 
			// numerochequeTXT
			// 
			this.numerochequeTXT.Location = new System.Drawing.Point(234, 175);
			this.numerochequeTXT.Name = "numerochequeTXT";
			this.numerochequeTXT.Size = new System.Drawing.Size(142, 20);
			this.numerochequeTXT.TabIndex = 71;
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.Location = new System.Drawing.Point(745, 341);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(71, 57);
			this.button3.TabIndex = 67;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Bancos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.ClientSize = new System.Drawing.Size(1139, 662);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.buttonConsultar);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.NuevoBTN);
			this.Controls.Add(this.BancoDGV);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Bancos";
			this.Text = "Bancos";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Bancos_Load);
			((System.ComponentModel.ISupportInitialize)(this.BancoDGV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView BancoDGV;
		private System.Windows.Forms.Button NuevoBTN;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker fechaTPC;
		private System.Windows.Forms.TextBox IdTXT;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox formapagoCBX;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox serieTBX;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox timbradoTXT;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox tipoComprobanteTBX;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox proveedorCBX;
		private System.Windows.Forms.Label lblUSER_NAME;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox totalTXT;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox idingresoTB;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ComboBox bancoCBX;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox divisaCBX;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button buttonConsultar;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox numerochequeTXT;
		private System.Windows.Forms.Button button3;
	}
}