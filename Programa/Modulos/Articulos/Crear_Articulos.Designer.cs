namespace Programa.Modulos.Articulos
{
	partial class Crear_Articulos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crear_Articulos));
			this.articulosGRV = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.IdTXT = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.precioVentaTXT = new System.Windows.Forms.TextBox();
			this.estadoCBX = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.descripcionTXT = new System.Windows.Forms.TextBox();
			this.categoriaCBX = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblUSER_NAME = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.nombreTXT = new System.Windows.Forms.TextBox();
			this.buttonModificar = new System.Windows.Forms.Button();
			this.buttonGuardar = new System.Windows.Forms.Button();
			this.buttonElminar = new System.Windows.Forms.Button();
			this.buttonConsultar = new System.Windows.Forms.Button();
			this.buttonLimpiar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.articulosGRV)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// articulosGRV
			// 
			this.articulosGRV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.articulosGRV.Location = new System.Drawing.Point(35, 446);
			this.articulosGRV.Name = "articulosGRV";
			this.articulosGRV.Size = new System.Drawing.Size(1083, 243);
			this.articulosGRV.TabIndex = 52;
			this.articulosGRV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.articulosGRV_CellClick);
			this.articulosGRV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.articulosGRV_CellContentClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.IdTXT);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.precioVentaTXT);
			this.groupBox1.Controls.Add(this.estadoCBX);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.descripcionTXT);
			this.groupBox1.Controls.Add(this.categoriaCBX);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.lblUSER_NAME);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.nombreTXT);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(35, 84);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(875, 269);
			this.groupBox1.TabIndex = 51;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Información del Producto";
			// 
			// IdTXT
			// 
			this.IdTXT.Location = new System.Drawing.Point(156, 48);
			this.IdTXT.Name = "IdTXT";
			this.IdTXT.Size = new System.Drawing.Size(37, 20);
			this.IdTXT.TabIndex = 59;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(69, 184);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 16);
			this.label3.TabIndex = 58;
			this.label3.Text = "Precio Venta:";
			// 
			// precioVentaTXT
			// 
			this.precioVentaTXT.Location = new System.Drawing.Point(156, 183);
			this.precioVentaTXT.Name = "precioVentaTXT";
			this.precioVentaTXT.Size = new System.Drawing.Size(187, 20);
			this.precioVentaTXT.TabIndex = 57;
			this.precioVentaTXT.TextChanged += new System.EventHandler(this.precioVentaTXT_TextChanged);
			this.precioVentaTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precioVentaTXT_KeyPress);
			// 
			// estadoCBX
			// 
			this.estadoCBX.FormattingEnabled = true;
			this.estadoCBX.Location = new System.Drawing.Point(483, 183);
			this.estadoCBX.Name = "estadoCBX";
			this.estadoCBX.Size = new System.Drawing.Size(191, 21);
			this.estadoCBX.TabIndex = 56;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label5.Location = new System.Drawing.Point(396, 183);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 16);
			this.label5.TabIndex = 54;
			this.label5.Text = "Estado:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(396, 117);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 16);
			this.label4.TabIndex = 53;
			this.label4.Text = "Descripción:";
			// 
			// descripcionTXT
			// 
			this.descripcionTXT.Location = new System.Drawing.Point(483, 103);
			this.descripcionTXT.Multiline = true;
			this.descripcionTXT.Name = "descripcionTXT";
			this.descripcionTXT.Size = new System.Drawing.Size(248, 54);
			this.descripcionTXT.TabIndex = 52;
			// 
			// categoriaCBX
			// 
			this.categoriaCBX.FormattingEnabled = true;
			this.categoriaCBX.Location = new System.Drawing.Point(483, 47);
			this.categoriaCBX.Name = "categoriaCBX";
			this.categoriaCBX.Size = new System.Drawing.Size(248, 21);
			this.categoriaCBX.TabIndex = 49;
			this.categoriaCBX.SelectedIndexChanged += new System.EventHandler(this.categoriaCBX_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(69, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(23, 16);
			this.label2.TabIndex = 43;
			this.label2.Text = "ID:";
			// 
			// lblUSER_NAME
			// 
			this.lblUSER_NAME.AutoSize = true;
			this.lblUSER_NAME.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.lblUSER_NAME.Location = new System.Drawing.Point(69, 121);
			this.lblUSER_NAME.Name = "lblUSER_NAME";
			this.lblUSER_NAME.Size = new System.Drawing.Size(59, 16);
			this.lblUSER_NAME.TabIndex = 37;
			this.lblUSER_NAME.Text = "Nombre:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(396, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 16);
			this.label1.TabIndex = 39;
			this.label1.Text = "Categoría:";
			// 
			// nombreTXT
			// 
			this.nombreTXT.Location = new System.Drawing.Point(156, 117);
			this.nombreTXT.Name = "nombreTXT";
			this.nombreTXT.Size = new System.Drawing.Size(187, 20);
			this.nombreTXT.TabIndex = 38;
			// 
			// buttonModificar
			// 
			this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonModificar.Image = ((System.Drawing.Image)(resources.GetObject("buttonModificar.Image")));
			this.buttonModificar.Location = new System.Drawing.Point(315, 372);
			this.buttonModificar.Name = "buttonModificar";
			this.buttonModificar.Size = new System.Drawing.Size(77, 68);
			this.buttonModificar.TabIndex = 48;
			this.buttonModificar.UseVisualStyleBackColor = true;
			this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
			// 
			// buttonGuardar
			// 
			this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.Image")));
			this.buttonGuardar.Location = new System.Drawing.Point(36, 372);
			this.buttonGuardar.Name = "buttonGuardar";
			this.buttonGuardar.Size = new System.Drawing.Size(77, 68);
			this.buttonGuardar.TabIndex = 47;
			this.buttonGuardar.UseVisualStyleBackColor = true;
			this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
			// 
			// buttonElminar
			// 
			this.buttonElminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonElminar.Image = ((System.Drawing.Image)(resources.GetObject("buttonElminar.Image")));
			this.buttonElminar.Location = new System.Drawing.Point(174, 372);
			this.buttonElminar.Name = "buttonElminar";
			this.buttonElminar.Size = new System.Drawing.Size(77, 68);
			this.buttonElminar.TabIndex = 45;
			this.buttonElminar.UseVisualStyleBackColor = true;
			this.buttonElminar.Click += new System.EventHandler(this.buttonElminar_Click);
			// 
			// buttonConsultar
			// 
			this.buttonConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonConsultar.Image = ((System.Drawing.Image)(resources.GetObject("buttonConsultar.Image")));
			this.buttonConsultar.Location = new System.Drawing.Point(1040, 371);
			this.buttonConsultar.Name = "buttonConsultar";
			this.buttonConsultar.Size = new System.Drawing.Size(78, 69);
			this.buttonConsultar.TabIndex = 54;
			this.buttonConsultar.UseVisualStyleBackColor = true;
			this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
			// 
			// buttonLimpiar
			// 
			this.buttonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("buttonLimpiar.Image")));
			this.buttonLimpiar.Location = new System.Drawing.Point(922, 371);
			this.buttonLimpiar.Name = "buttonLimpiar";
			this.buttonLimpiar.Size = new System.Drawing.Size(85, 69);
			this.buttonLimpiar.TabIndex = 53;
			this.buttonLimpiar.UseVisualStyleBackColor = true;
			this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(922, 84);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(208, 269);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 55;
			this.pictureBox1.TabStop = false;
			// 
			// Crear_Articulos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1169, 754);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.buttonConsultar);
			this.Controls.Add(this.buttonLimpiar);
			this.Controls.Add(this.articulosGRV);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonModificar);
			this.Controls.Add(this.buttonElminar);
			this.Controls.Add(this.buttonGuardar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Crear_Articulos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Crear_Articulos";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Crear_Articulos_Load);
			((System.ComponentModel.ISupportInitialize)(this.articulosGRV)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonConsultar;
		private System.Windows.Forms.Button buttonLimpiar;
		private System.Windows.Forms.DataGridView articulosGRV;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox estadoCBX;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox descripcionTXT;
		private System.Windows.Forms.ComboBox categoriaCBX;
		private System.Windows.Forms.Button buttonModificar;
		private System.Windows.Forms.Button buttonGuardar;
		private System.Windows.Forms.Button buttonElminar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblUSER_NAME;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox nombreTXT;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox precioVentaTXT;
		private System.Windows.Forms.TextBox IdTXT;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}