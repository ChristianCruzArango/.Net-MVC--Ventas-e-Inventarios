namespace Programa.Modulos.Articulos
{
	partial class Crear_Categorias
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crear_Categorias));
			this.buttonConsultar = new System.Windows.Forms.Button();
			this.buttonLimpiar = new System.Windows.Forms.Button();
			this.categoriaDGV = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.estadoCBX = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.descripcionTXT = new System.Windows.Forms.TextBox();
			this.buttonModificar = new System.Windows.Forms.Button();
			this.buttonGuardar = new System.Windows.Forms.Button();
			this.buttonElminar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.lblUSER_NAME = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.categoriaDGV)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonConsultar
			// 
			this.buttonConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonConsultar.Image = ((System.Drawing.Image)(resources.GetObject("buttonConsultar.Image")));
			this.buttonConsultar.Location = new System.Drawing.Point(849, 365);
			this.buttonConsultar.Name = "buttonConsultar";
			this.buttonConsultar.Size = new System.Drawing.Size(78, 69);
			this.buttonConsultar.TabIndex = 58;
			this.buttonConsultar.UseVisualStyleBackColor = true;
			this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
			// 
			// buttonLimpiar
			// 
			this.buttonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("buttonLimpiar.Image")));
			this.buttonLimpiar.Location = new System.Drawing.Point(684, 365);
			this.buttonLimpiar.Name = "buttonLimpiar";
			this.buttonLimpiar.Size = new System.Drawing.Size(85, 69);
			this.buttonLimpiar.TabIndex = 57;
			this.buttonLimpiar.UseVisualStyleBackColor = true;
			this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
			// 
			// categoriaDGV
			// 
			this.categoriaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.categoriaDGV.Location = new System.Drawing.Point(580, 76);
			this.categoriaDGV.Name = "categoriaDGV";
			this.categoriaDGV.Size = new System.Drawing.Size(485, 243);
			this.categoriaDGV.TabIndex = 56;
			this.categoriaDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoriaDGV_CellClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.estadoCBX);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.descripcionTXT);
			this.groupBox1.Controls.Add(this.buttonModificar);
			this.groupBox1.Controls.Add(this.buttonGuardar);
			this.groupBox1.Controls.Add(this.buttonElminar);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtID);
			this.groupBox1.Controls.Add(this.lblUSER_NAME);
			this.groupBox1.Controls.Add(this.txtNombre);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(49, 76);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(503, 445);
			this.groupBox1.TabIndex = 55;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Información";
			// 
			// estadoCBX
			// 
			this.estadoCBX.FormattingEnabled = true;
			this.estadoCBX.Location = new System.Drawing.Point(185, 266);
			this.estadoCBX.Name = "estadoCBX";
			this.estadoCBX.Size = new System.Drawing.Size(172, 21);
			this.estadoCBX.TabIndex = 56;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label5.Location = new System.Drawing.Point(98, 266);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 16);
			this.label5.TabIndex = 54;
			this.label5.Text = "Estado:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(98, 182);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 16);
			this.label4.TabIndex = 53;
			this.label4.Text = "Descripción:";
			// 
			// descripcionTXT
			// 
			this.descripcionTXT.Location = new System.Drawing.Point(185, 166);
			this.descripcionTXT.Multiline = true;
			this.descripcionTXT.Name = "descripcionTXT";
			this.descripcionTXT.Size = new System.Drawing.Size(172, 45);
			this.descripcionTXT.TabIndex = 52;
			// 
			// buttonModificar
			// 
			this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonModificar.Image = ((System.Drawing.Image)(resources.GetObject("buttonModificar.Image")));
			this.buttonModificar.Location = new System.Drawing.Point(349, 363);
			this.buttonModificar.Name = "buttonModificar";
			this.buttonModificar.Size = new System.Drawing.Size(77, 59);
			this.buttonModificar.TabIndex = 48;
			this.buttonModificar.UseVisualStyleBackColor = true;
			this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
			// 
			// buttonGuardar
			// 
			this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.Image")));
			this.buttonGuardar.Location = new System.Drawing.Point(70, 363);
			this.buttonGuardar.Name = "buttonGuardar";
			this.buttonGuardar.Size = new System.Drawing.Size(77, 59);
			this.buttonGuardar.TabIndex = 47;
			this.buttonGuardar.UseVisualStyleBackColor = true;
			this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
			// 
			// buttonElminar
			// 
			this.buttonElminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonElminar.Image = ((System.Drawing.Image)(resources.GetObject("buttonElminar.Image")));
			this.buttonElminar.Location = new System.Drawing.Point(208, 363);
			this.buttonElminar.Name = "buttonElminar";
			this.buttonElminar.Size = new System.Drawing.Size(77, 59);
			this.buttonElminar.TabIndex = 45;
			this.buttonElminar.UseVisualStyleBackColor = true;
			this.buttonElminar.Click += new System.EventHandler(this.buttonElminar_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(98, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(23, 16);
			this.label2.TabIndex = 43;
			this.label2.Text = "ID:";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(185, 47);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(37, 20);
			this.txtID.TabIndex = 42;
			this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
			// 
			// lblUSER_NAME
			// 
			this.lblUSER_NAME.AutoSize = true;
			this.lblUSER_NAME.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.lblUSER_NAME.Location = new System.Drawing.Point(98, 106);
			this.lblUSER_NAME.Name = "lblUSER_NAME";
			this.lblUSER_NAME.Size = new System.Drawing.Size(59, 16);
			this.lblUSER_NAME.TabIndex = 37;
			this.lblUSER_NAME.Text = "Nombre:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(185, 102);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(172, 20);
			this.txtNombre.TabIndex = 38;
			// 
			// Crear_Categorias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1114, 597);
			this.Controls.Add(this.buttonConsultar);
			this.Controls.Add(this.buttonLimpiar);
			this.Controls.Add(this.categoriaDGV);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Crear_Categorias";
			this.Text = "Crear_Categorias";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Crear_Categorias_Load);
			((System.ComponentModel.ISupportInitialize)(this.categoriaDGV)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonConsultar;
		private System.Windows.Forms.Button buttonLimpiar;
		private System.Windows.Forms.DataGridView categoriaDGV;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox estadoCBX;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox descripcionTXT;
		private System.Windows.Forms.Button buttonModificar;
		private System.Windows.Forms.Button buttonGuardar;
		private System.Windows.Forms.Button buttonElminar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label lblUSER_NAME;
		private System.Windows.Forms.TextBox txtNombre;
	}
}