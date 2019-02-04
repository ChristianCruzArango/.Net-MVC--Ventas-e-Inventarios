namespace Programa.Modulos.Ventas
{
	partial class Ventas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.totalTXT = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.productoGTV = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.numerochequeTBT = new System.Windows.Forms.TextBox();
			this.fechaTPC = new System.Windows.Forms.DateTimePicker();
			this.IdTXT = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.formapagoCBX = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.serieTBX = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.timbradoTXT = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tipoComprobanteTBX = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.clienteCBX = new System.Windows.Forms.ComboBox();
			this.lblUSER_NAME = new System.Windows.Forms.Label();
			this.buttonModificar = new System.Windows.Forms.Button();
			this.buttonElminar = new System.Windows.Forms.Button();
			this.buttonGuardar = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.devueltaTBT = new System.Windows.Forms.TextBox();
			this.totalTBT = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.productoGTV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.totalTBT);
			this.groupBox2.Controls.Add(this.devueltaTBT);
			this.groupBox2.Controls.Add(this.totalTXT);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(823, 426);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(183, 178);
			this.groupBox2.TabIndex = 62;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Total";
			// 
			// totalTXT
			// 
			this.totalTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.totalTXT.Location = new System.Drawing.Point(26, 19);
			this.totalTXT.Name = "totalTXT";
			this.totalTXT.Size = new System.Drawing.Size(130, 31);
			this.totalTXT.TabIndex = 55;
			this.totalTXT.TextChanged += new System.EventHandler(this.totalTXT_TextChanged);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(88, 301);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(258, 65);
			this.button1.TabIndex = 64;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// productoGTV
			// 
			this.productoGTV.AllowUserToAddRows = false;
			this.productoGTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.productoGTV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5});
			this.productoGTV.Location = new System.Drawing.Point(88, 390);
			this.productoGTV.Name = "productoGTV";
			this.productoGTV.Size = new System.Drawing.Size(671, 206);
			this.productoGTV.TabIndex = 65;
			this.productoGTV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productoGTV_CellClick);
			this.productoGTV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productoGTV_CellContentClick);
			this.productoGTV.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.productoGTV_CellPainting);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Id Articulo";
			this.Column1.Name = "Column1";
			this.Column1.ToolTipText = "Calcular";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Nombre";
			this.Column2.Name = "Column2";
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Precio Venta";
			this.Column4.Name = "Column4";
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Stock";
			this.Column3.Name = "Column3";
			// 
			// Column5
			// 
			this.Column5.HeaderText = "SubTotal";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(823, 45);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(208, 277);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 63;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numerochequeTBT);
			this.groupBox1.Controls.Add(this.fechaTPC);
			this.groupBox1.Controls.Add(this.IdTXT);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.formapagoCBX);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.serieTBX);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.timbradoTXT);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.tipoComprobanteTBX);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.clienteCBX);
			this.groupBox1.Controls.Add(this.lblUSER_NAME);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(88, 45);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(687, 229);
			this.groupBox1.TabIndex = 61;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Información del Ingreso";
			// 
			// numerochequeTBT
			// 
			this.numerochequeTBT.Location = new System.Drawing.Point(570, 154);
			this.numerochequeTBT.Name = "numerochequeTBT";
			this.numerochequeTBT.Size = new System.Drawing.Size(101, 20);
			this.numerochequeTBT.TabIndex = 65;
			// 
			// fechaTPC
			// 
			this.fechaTPC.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.fechaTPC.Location = new System.Drawing.Point(467, 68);
			this.fechaTPC.Name = "fechaTPC";
			this.fechaTPC.Size = new System.Drawing.Size(107, 20);
			this.fechaTPC.TabIndex = 64;
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
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label6.Location = new System.Drawing.Point(567, 125);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(104, 16);
			this.label6.TabIndex = 61;
			this.label6.Text = "Número cheque";
			this.label6.Visible = false;
			// 
			// formapagoCBX
			// 
			this.formapagoCBX.FormattingEnabled = true;
			this.formapagoCBX.Location = new System.Drawing.Point(311, 154);
			this.formapagoCBX.Name = "formapagoCBX";
			this.formapagoCBX.Size = new System.Drawing.Size(241, 21);
			this.formapagoCBX.TabIndex = 59;
			this.formapagoCBX.SelectedIndexChanged += new System.EventHandler(this.formapagoCBX_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label5.Location = new System.Drawing.Point(308, 125);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(106, 16);
			this.label5.TabIndex = 58;
			this.label5.Text = "Formas de Pago:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(197, 36);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 16);
			this.label4.TabIndex = 57;
			this.label4.Text = "Serie";
			// 
			// serieTBX
			// 
			this.serieTBX.Location = new System.Drawing.Point(200, 68);
			this.serieTBX.Name = "serieTBX";
			this.serieTBX.Size = new System.Drawing.Size(67, 20);
			this.serieTBX.TabIndex = 56;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(298, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 16);
			this.label3.TabIndex = 55;
			this.label3.Text = "Numero de Timbrado";
			// 
			// timbradoTXT
			// 
			this.timbradoTXT.Location = new System.Drawing.Point(301, 68);
			this.timbradoTXT.Name = "timbradoTXT";
			this.timbradoTXT.Size = new System.Drawing.Size(130, 20);
			this.timbradoTXT.TabIndex = 54;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(20, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 16);
			this.label2.TabIndex = 53;
			this.label2.Text = "Tipo Comprobante:";
			// 
			// tipoComprobanteTBX
			// 
			this.tipoComprobanteTBX.FormattingEnabled = true;
			this.tipoComprobanteTBX.Location = new System.Drawing.Point(23, 65);
			this.tipoComprobanteTBX.Name = "tipoComprobanteTBX";
			this.tipoComprobanteTBX.Size = new System.Drawing.Size(134, 21);
			this.tipoComprobanteTBX.TabIndex = 52;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(473, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.TabIndex = 50;
			this.label1.Text = "Fecha:";
			// 
			// clienteCBX
			// 
			this.clienteCBX.FormattingEnabled = true;
			this.clienteCBX.Location = new System.Drawing.Point(23, 154);
			this.clienteCBX.Name = "clienteCBX";
			this.clienteCBX.Size = new System.Drawing.Size(241, 21);
			this.clienteCBX.TabIndex = 49;
			// 
			// lblUSER_NAME
			// 
			this.lblUSER_NAME.AutoSize = true;
			this.lblUSER_NAME.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.lblUSER_NAME.Location = new System.Drawing.Point(20, 125);
			this.lblUSER_NAME.Name = "lblUSER_NAME";
			this.lblUSER_NAME.Size = new System.Drawing.Size(52, 16);
			this.lblUSER_NAME.TabIndex = 37;
			this.lblUSER_NAME.Text = "Cliente:";
			// 
			// buttonModificar
			// 
			this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonModificar.Image = ((System.Drawing.Image)(resources.GetObject("buttonModificar.Image")));
			this.buttonModificar.Location = new System.Drawing.Point(673, 301);
			this.buttonModificar.Name = "buttonModificar";
			this.buttonModificar.Size = new System.Drawing.Size(82, 66);
			this.buttonModificar.TabIndex = 60;
			this.buttonModificar.UseVisualStyleBackColor = true;
			this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
			// 
			// buttonElminar
			// 
			this.buttonElminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonElminar.Image = ((System.Drawing.Image)(resources.GetObject("buttonElminar.Image")));
			this.buttonElminar.Location = new System.Drawing.Point(553, 301);
			this.buttonElminar.Name = "buttonElminar";
			this.buttonElminar.Size = new System.Drawing.Size(96, 65);
			this.buttonElminar.TabIndex = 58;
			this.buttonElminar.UseVisualStyleBackColor = true;
			this.buttonElminar.Click += new System.EventHandler(this.buttonElminar_Click);
			// 
			// buttonGuardar
			// 
			this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.Image")));
			this.buttonGuardar.Location = new System.Drawing.Point(422, 301);
			this.buttonGuardar.Name = "buttonGuardar";
			this.buttonGuardar.Size = new System.Drawing.Size(97, 65);
			this.buttonGuardar.TabIndex = 59;
			this.buttonGuardar.UseVisualStyleBackColor = true;
			this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.Location = new System.Drawing.Point(823, 329);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(61, 49);
			this.button2.TabIndex = 66;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.Location = new System.Drawing.Point(890, 329);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(60, 49);
			this.button3.TabIndex = 67;
			this.button3.UseVisualStyleBackColor = true;
			// 
			// devueltaTBT
			// 
			this.devueltaTBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.devueltaTBT.Location = new System.Drawing.Point(26, 71);
			this.devueltaTBT.Name = "devueltaTBT";
			this.devueltaTBT.Size = new System.Drawing.Size(130, 31);
			this.devueltaTBT.TabIndex = 56;
			this.devueltaTBT.TextChanged += new System.EventHandler(this.devueltaTBT_TextChanged_1);
			this.devueltaTBT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.devueltaTBT_KeyPress);
			// 
			// totalTBT
			// 
			this.totalTBT.Enabled = false;
			this.totalTBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.totalTBT.Location = new System.Drawing.Point(26, 124);
			this.totalTBT.Name = "totalTBT";
			this.totalTBT.Size = new System.Drawing.Size(130, 31);
			this.totalTBT.TabIndex = 57;
			this.totalTBT.TextChanged += new System.EventHandler(this.totalTBT_TextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label8.Location = new System.Drawing.Point(49, 53);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(89, 16);
			this.label8.TabIndex = 66;
			this.label8.Text = "Valor Pagado";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label9.Location = new System.Drawing.Point(64, 105);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(60, 16);
			this.label9.TabIndex = 67;
			this.label9.Text = "Devuelta";
			// 
			// Ventas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1119, 641);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.productoGTV);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonModificar);
			this.Controls.Add(this.buttonElminar);
			this.Controls.Add(this.buttonGuardar);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Ventas";
			this.Text = "Ventas";
			this.Load += new System.EventHandler(this.Ventas_Load);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.productoGTV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox totalTXT;
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.DataGridView productoGTV;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker fechaTPC;
		private System.Windows.Forms.TextBox IdTXT;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox formapagoCBX;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox serieTBX;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox timbradoTXT;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox tipoComprobanteTBX;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox clienteCBX;
		private System.Windows.Forms.Label lblUSER_NAME;
		private System.Windows.Forms.Button buttonModificar;
		private System.Windows.Forms.Button buttonElminar;
		private System.Windows.Forms.Button buttonGuardar;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox numerochequeTBT;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.TextBox totalTBT;
		private System.Windows.Forms.TextBox devueltaTBT;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
	}
}