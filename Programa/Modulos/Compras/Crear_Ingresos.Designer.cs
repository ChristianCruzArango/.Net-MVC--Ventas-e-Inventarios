namespace Programa.Modulos.Compras
{
	partial class Crear_Ingresos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crear_Ingresos));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.fechaTPC = new System.Windows.Forms.DateTimePicker();
			this.IdTXT = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.chequediasTBX = new System.Windows.Forms.ComboBox();
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
			this.productoGTV = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.buttonElminar = new System.Windows.Forms.Button();
			this.buttonGuardar = new System.Windows.Forms.Button();
			this.buttonModificar = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.totalTXT = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.productoGTV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.fechaTPC);
			this.groupBox1.Controls.Add(this.IdTXT);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.chequediasTBX);
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
			this.groupBox1.Location = new System.Drawing.Point(63, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(677, 229);
			this.groupBox1.TabIndex = 49;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Información del Ingreso";
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
			this.label6.Location = new System.Drawing.Point(573, 125);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 16);
			this.label6.TabIndex = 61;
			this.label6.Text = "Días de Pago:";
			this.label6.Visible = false;
			// 
			// chequediasTBX
			// 
			this.chequediasTBX.FormattingEnabled = true;
			this.chequediasTBX.Location = new System.Drawing.Point(576, 154);
			this.chequediasTBX.Name = "chequediasTBX";
			this.chequediasTBX.Size = new System.Drawing.Size(45, 21);
			this.chequediasTBX.TabIndex = 60;
			this.chequediasTBX.Visible = false;
			this.chequediasTBX.SelectedIndexChanged += new System.EventHandler(this.chequediasTBX_SelectedIndexChanged);
			// 
			// formapagoCBX
			// 
			this.formapagoCBX.FormattingEnabled = true;
			this.formapagoCBX.Location = new System.Drawing.Point(311, 154);
			this.formapagoCBX.Name = "formapagoCBX";
			this.formapagoCBX.Size = new System.Drawing.Size(241, 21);
			this.formapagoCBX.TabIndex = 59;
			this.formapagoCBX.SelectedIndexChanged += new System.EventHandler(this.formapagoCBX_SelectedIndexChanged);
			this.formapagoCBX.Click += new System.EventHandler(this.formapagoCBX_Click);
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
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// serieTBX
			// 
			this.serieTBX.Location = new System.Drawing.Point(200, 68);
			this.serieTBX.Name = "serieTBX";
			this.serieTBX.Size = new System.Drawing.Size(67, 20);
			this.serieTBX.TabIndex = 56;
			this.serieTBX.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
			// proveedorCBX
			// 
			this.proveedorCBX.FormattingEnabled = true;
			this.proveedorCBX.Location = new System.Drawing.Point(23, 154);
			this.proveedorCBX.Name = "proveedorCBX";
			this.proveedorCBX.Size = new System.Drawing.Size(241, 21);
			this.proveedorCBX.TabIndex = 49;
			this.proveedorCBX.SelectedIndexChanged += new System.EventHandler(this.proveedorCBX_SelectedIndexChanged);
			// 
			// lblUSER_NAME
			// 
			this.lblUSER_NAME.AutoSize = true;
			this.lblUSER_NAME.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.lblUSER_NAME.Location = new System.Drawing.Point(20, 125);
			this.lblUSER_NAME.Name = "lblUSER_NAME";
			this.lblUSER_NAME.Size = new System.Drawing.Size(73, 16);
			this.lblUSER_NAME.TabIndex = 37;
			this.lblUSER_NAME.Text = "Proveedor:";
			// 
			// productoGTV
			// 
			this.productoGTV.AllowUserToAddRows = false;
			this.productoGTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.productoGTV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.productoGTV.Location = new System.Drawing.Point(63, 385);
			this.productoGTV.Name = "productoGTV";
			this.productoGTV.Size = new System.Drawing.Size(671, 206);
			this.productoGTV.TabIndex = 57;
			this.productoGTV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productoGTV_CellClick);
			this.productoGTV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productoGTV_CellContentClick_1);
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
			// Column3
			// 
			this.Column3.HeaderText = "Stock";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Precio Venta";
			this.Column4.Name = "Column4";
			// 
			// Column5
			// 
			this.Column5.HeaderText = "SubTotal";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(63, 296);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(258, 65);
			this.button1.TabIndex = 57;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(798, 40);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(208, 277);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 56;
			this.pictureBox1.TabStop = false;
			// 
			// buttonElminar
			// 
			this.buttonElminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonElminar.Image = ((System.Drawing.Image)(resources.GetObject("buttonElminar.Image")));
			this.buttonElminar.Location = new System.Drawing.Point(528, 296);
			this.buttonElminar.Name = "buttonElminar";
			this.buttonElminar.Size = new System.Drawing.Size(96, 65);
			this.buttonElminar.TabIndex = 45;
			this.buttonElminar.UseVisualStyleBackColor = true;
			this.buttonElminar.Click += new System.EventHandler(this.buttonElminar_Click);
			// 
			// buttonGuardar
			// 
			this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.Image")));
			this.buttonGuardar.Location = new System.Drawing.Point(397, 296);
			this.buttonGuardar.Name = "buttonGuardar";
			this.buttonGuardar.Size = new System.Drawing.Size(97, 65);
			this.buttonGuardar.TabIndex = 47;
			this.buttonGuardar.UseVisualStyleBackColor = true;
			this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
			// 
			// buttonModificar
			// 
			this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonModificar.Image = ((System.Drawing.Image)(resources.GetObject("buttonModificar.Image")));
			this.buttonModificar.Location = new System.Drawing.Point(648, 296);
			this.buttonModificar.Name = "buttonModificar";
			this.buttonModificar.Size = new System.Drawing.Size(82, 66);
			this.buttonModificar.TabIndex = 48;
			this.buttonModificar.UseVisualStyleBackColor = true;
			this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.totalTXT);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(798, 421);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(183, 88);
			this.groupBox2.TabIndex = 56;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Total";
			// 
			// totalTXT
			// 
			this.totalTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.totalTXT.Location = new System.Drawing.Point(26, 34);
			this.totalTXT.Name = "totalTXT";
			this.totalTXT.Size = new System.Drawing.Size(130, 31);
			this.totalTXT.TabIndex = 55;
			this.totalTXT.TextChanged += new System.EventHandler(this.totalTXT_TextChanged);
			// 
			// Crear_Ingresos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 635);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.productoGTV);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonModificar);
			this.Controls.Add(this.buttonElminar);
			this.Controls.Add(this.buttonGuardar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Crear_Ingresos";
			this.Text = "Crear_Ingresos";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Crear_Ingresos_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.productoGTV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonGuardar;
		private System.Windows.Forms.Button buttonElminar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox tipoComprobanteTBX;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox timbradoTXT;
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.DataGridView productoGTV;
		private System.Windows.Forms.Button buttonModificar;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox totalTXT;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox serieTBX;
		private System.Windows.Forms.ComboBox formapagoCBX;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox chequediasTBX;
		private System.Windows.Forms.TextBox IdTXT;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox proveedorCBX;
		private System.Windows.Forms.Label lblUSER_NAME;
		private System.Windows.Forms.DateTimePicker fechaTPC;
	}
}