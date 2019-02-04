namespace Programa.Modulos.Compras
{
	partial class Crear_Proveedor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crear_Proveedor));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.direccionTXT = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.tipoDCBX = new System.Windows.Forms.ComboBox();
			this.ID = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCorreo = new System.Windows.Forms.TextBox();
			this.estadoCBX = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.lblNOMBRE = new System.Windows.Forms.Label();
			this.lblMATERNO = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.numeroDTXT = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.buttonConsultar = new System.Windows.Forms.Button();
			this.buttonLimpiar = new System.Windows.Forms.Button();
			this.proveedorGDV = new System.Windows.Forms.DataGridView();
			this.buttonModificar = new System.Windows.Forms.Button();
			this.buttonGuardar = new System.Windows.Forms.Button();
			this.buttonElminar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.proveedorGDV)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.direccionTXT);
			this.groupBox1.Controls.Add(this.txtID);
			this.groupBox1.Controls.Add(this.tipoDCBX);
			this.groupBox1.Controls.Add(this.ID);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtCorreo);
			this.groupBox1.Controls.Add(this.estadoCBX);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtTelefono);
			this.groupBox1.Controls.Add(this.lblNOMBRE);
			this.groupBox1.Controls.Add(this.lblMATERNO);
			this.groupBox1.Controls.Add(this.txtNombre);
			this.groupBox1.Controls.Add(this.numeroDTXT);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(22, 58);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(858, 247);
			this.groupBox1.TabIndex = 39;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Información del Proveedor";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label5.Location = new System.Drawing.Point(411, 168);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 16);
			this.label5.TabIndex = 58;
			this.label5.Text = "Dirección";
			// 
			// direccionTXT
			// 
			this.direccionTXT.Location = new System.Drawing.Point(532, 168);
			this.direccionTXT.Name = "direccionTXT";
			this.direccionTXT.Size = new System.Drawing.Size(171, 20);
			this.direccionTXT.TabIndex = 59;
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(788, 25);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(51, 20);
			this.txtID.TabIndex = 57;
			// 
			// tipoDCBX
			// 
			this.tipoDCBX.FormattingEnabled = true;
			this.tipoDCBX.Location = new System.Drawing.Point(532, 60);
			this.tipoDCBX.Name = "tipoDCBX";
			this.tipoDCBX.Size = new System.Drawing.Size(171, 21);
			this.tipoDCBX.TabIndex = 38;
			// 
			// ID
			// 
			this.ID.AutoSize = true;
			this.ID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.ID.Location = new System.Drawing.Point(764, 25);
			this.ID.Name = "ID";
			this.ID.Size = new System.Drawing.Size(20, 16);
			this.ID.TabIndex = 56;
			this.ID.Text = "ID";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(411, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 16);
			this.label4.TabIndex = 36;
			this.label4.Text = "Correo";
			// 
			// txtCorreo
			// 
			this.txtCorreo.Location = new System.Drawing.Point(532, 112);
			this.txtCorreo.Name = "txtCorreo";
			this.txtCorreo.Size = new System.Drawing.Size(171, 20);
			this.txtCorreo.TabIndex = 37;
			this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
			this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreo_KeyPress);
			// 
			// estadoCBX
			// 
			this.estadoCBX.FormattingEnabled = true;
			this.estadoCBX.Location = new System.Drawing.Point(767, 217);
			this.estadoCBX.Name = "estadoCBX";
			this.estadoCBX.Size = new System.Drawing.Size(80, 21);
			this.estadoCBX.TabIndex = 35;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(704, 217);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 16);
			this.label3.TabIndex = 34;
			this.label3.Text = "Estado";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(408, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 16);
			this.label2.TabIndex = 32;
			this.label2.Text = "Tipo Documento";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(21, 171);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 16);
			this.label1.TabIndex = 30;
			this.label1.Text = "Teléfono";
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(153, 167);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(171, 20);
			this.txtTelefono.TabIndex = 31;
			this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
			this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
			// 
			// lblNOMBRE
			// 
			this.lblNOMBRE.AutoSize = true;
			this.lblNOMBRE.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.lblNOMBRE.Location = new System.Drawing.Point(21, 60);
			this.lblNOMBRE.Name = "lblNOMBRE";
			this.lblNOMBRE.Size = new System.Drawing.Size(59, 16);
			this.lblNOMBRE.TabIndex = 29;
			this.lblNOMBRE.Text = "Nombre:";
			// 
			// lblMATERNO
			// 
			this.lblMATERNO.AutoSize = true;
			this.lblMATERNO.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.lblMATERNO.Location = new System.Drawing.Point(21, 116);
			this.lblMATERNO.Name = "lblMATERNO";
			this.lblMATERNO.Size = new System.Drawing.Size(126, 16);
			this.lblMATERNO.TabIndex = 25;
			this.lblMATERNO.Text = "Número Documento";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(153, 61);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(171, 20);
			this.txtNombre.TabIndex = 28;
			// 
			// numeroDTXT
			// 
			this.numeroDTXT.Location = new System.Drawing.Point(153, 116);
			this.numeroDTXT.Name = "numeroDTXT";
			this.numeroDTXT.Size = new System.Drawing.Size(171, 20);
			this.numeroDTXT.TabIndex = 26;
			this.numeroDTXT.TextChanged += new System.EventHandler(this.numeroDTXT_TextChanged);
			this.numeroDTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeroDTXT_KeyPress);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(924, 58);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(208, 238);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 40;
			this.pictureBox1.TabStop = false;
			// 
			// buttonConsultar
			// 
			this.buttonConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonConsultar.Image = ((System.Drawing.Image)(resources.GetObject("buttonConsultar.Image")));
			this.buttonConsultar.Location = new System.Drawing.Point(1045, 322);
			this.buttonConsultar.Name = "buttonConsultar";
			this.buttonConsultar.Size = new System.Drawing.Size(87, 72);
			this.buttonConsultar.TabIndex = 52;
			this.buttonConsultar.UseVisualStyleBackColor = true;
			this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
			// 
			// buttonLimpiar
			// 
			this.buttonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("buttonLimpiar.Image")));
			this.buttonLimpiar.Location = new System.Drawing.Point(939, 322);
			this.buttonLimpiar.Name = "buttonLimpiar";
			this.buttonLimpiar.Size = new System.Drawing.Size(83, 72);
			this.buttonLimpiar.TabIndex = 51;
			this.buttonLimpiar.UseVisualStyleBackColor = true;
			this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
			// 
			// proveedorGDV
			// 
			this.proveedorGDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.proveedorGDV.Location = new System.Drawing.Point(22, 411);
			this.proveedorGDV.Name = "proveedorGDV";
			this.proveedorGDV.Size = new System.Drawing.Size(1110, 288);
			this.proveedorGDV.TabIndex = 50;
			this.proveedorGDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.proveedorGDV_CellClick);
			// 
			// buttonModificar
			// 
			this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonModificar.Image = ((System.Drawing.Image)(resources.GetObject("buttonModificar.Image")));
			this.buttonModificar.Location = new System.Drawing.Point(378, 322);
			this.buttonModificar.Name = "buttonModificar";
			this.buttonModificar.Size = new System.Drawing.Size(77, 72);
			this.buttonModificar.TabIndex = 55;
			this.buttonModificar.UseVisualStyleBackColor = true;
			this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
			// 
			// buttonGuardar
			// 
			this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.Image")));
			this.buttonGuardar.Location = new System.Drawing.Point(99, 322);
			this.buttonGuardar.Name = "buttonGuardar";
			this.buttonGuardar.Size = new System.Drawing.Size(77, 72);
			this.buttonGuardar.TabIndex = 54;
			this.buttonGuardar.UseVisualStyleBackColor = true;
			this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
			// 
			// buttonElminar
			// 
			this.buttonElminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonElminar.Image = ((System.Drawing.Image)(resources.GetObject("buttonElminar.Image")));
			this.buttonElminar.Location = new System.Drawing.Point(238, 322);
			this.buttonElminar.Name = "buttonElminar";
			this.buttonElminar.Size = new System.Drawing.Size(77, 72);
			this.buttonElminar.TabIndex = 53;
			this.buttonElminar.UseVisualStyleBackColor = true;
			this.buttonElminar.Click += new System.EventHandler(this.buttonElminar_Click);
			// 
			// Crear_Proveedor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1247, 711);
			this.Controls.Add(this.buttonModificar);
			this.Controls.Add(this.buttonGuardar);
			this.Controls.Add(this.buttonElminar);
			this.Controls.Add(this.buttonConsultar);
			this.Controls.Add(this.buttonLimpiar);
			this.Controls.Add(this.proveedorGDV);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Crear_Proveedor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Crear_Proveedor";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Crear_Proveedor_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.proveedorGDV)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox tipoDCBX;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCorreo;
		private System.Windows.Forms.ComboBox estadoCBX;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.Label lblNOMBRE;
		private System.Windows.Forms.Label lblMATERNO;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox numeroDTXT;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonConsultar;
		private System.Windows.Forms.Button buttonLimpiar;
		private System.Windows.Forms.DataGridView proveedorGDV;
		private System.Windows.Forms.Button buttonModificar;
		private System.Windows.Forms.Button buttonGuardar;
		private System.Windows.Forms.Button buttonElminar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox direccionTXT;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label ID;
	}
}