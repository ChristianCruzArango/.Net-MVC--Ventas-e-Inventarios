namespace Programa.Modulos.Bancos
{
	partial class Crear_Divisa
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crear_Divisa));
			this.BarraTitulo = new System.Windows.Forms.Panel();
			this.btnCerrarPB = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.simbolodivisaTBT = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.nombredivisaTBT = new System.Windows.Forms.TextBox();
			this.IdTXT = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.divisaGridV = new System.Windows.Forms.DataGridView();
			this.buttonConsultar = new System.Windows.Forms.Button();
			this.buttonLimpiar = new System.Windows.Forms.Button();
			this.buttonModificar = new System.Windows.Forms.Button();
			this.buttonElminar = new System.Windows.Forms.Button();
			this.buttonGuardar = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.BarraTitulo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnCerrarPB)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.divisaGridV)).BeginInit();
			this.SuspendLayout();
			// 
			// BarraTitulo
			// 
			this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.BarraTitulo.Controls.Add(this.btnCerrarPB);
			this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
			this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
			this.BarraTitulo.Name = "BarraTitulo";
			this.BarraTitulo.Size = new System.Drawing.Size(730, 35);
			this.BarraTitulo.TabIndex = 2;
			this.BarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraTitulo_Paint);
			// 
			// btnCerrarPB
			// 
			this.btnCerrarPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCerrarPB.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCerrarPB.Image = global::Programa.Properties.Resources.cerrar;
			this.btnCerrarPB.Location = new System.Drawing.Point(691, 12);
			this.btnCerrarPB.Name = "btnCerrarPB";
			this.btnCerrarPB.Size = new System.Drawing.Size(27, 16);
			this.btnCerrarPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnCerrarPB.TabIndex = 0;
			this.btnCerrarPB.TabStop = false;
			this.btnCerrarPB.Click += new System.EventHandler(this.btnCerrarPB_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(663, 42);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(55, 53);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 58;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.simbolodivisaTBT);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.nombredivisaTBT);
			this.groupBox1.Controls.Add(this.IdTXT);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(53, 70);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(284, 175);
			this.groupBox1.TabIndex = 60;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Información de Divisas";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(157, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 16);
			this.label1.TabIndex = 68;
			this.label1.Text = "Simbolo Divisa";
			// 
			// simbolodivisaTBT
			// 
			this.simbolodivisaTBT.Location = new System.Drawing.Point(160, 125);
			this.simbolodivisaTBT.Name = "simbolodivisaTBT";
			this.simbolodivisaTBT.Size = new System.Drawing.Size(86, 20);
			this.simbolodivisaTBT.TabIndex = 67;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label8.Location = new System.Drawing.Point(33, 93);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(93, 16);
			this.label8.TabIndex = 66;
			this.label8.Text = "Nombre Divisa";
			// 
			// nombredivisaTBT
			// 
			this.nombredivisaTBT.Location = new System.Drawing.Point(36, 125);
			this.nombredivisaTBT.Name = "nombredivisaTBT";
			this.nombredivisaTBT.Size = new System.Drawing.Size(90, 20);
			this.nombredivisaTBT.TabIndex = 65;
			// 
			// IdTXT
			// 
			this.IdTXT.Location = new System.Drawing.Point(116, 31);
			this.IdTXT.Name = "IdTXT";
			this.IdTXT.Size = new System.Drawing.Size(51, 20);
			this.IdTXT.TabIndex = 63;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.label7.Location = new System.Drawing.Point(90, 31);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(20, 16);
			this.label7.TabIndex = 62;
			this.label7.Text = "ID";
			// 
			// divisaGridV
			// 
			this.divisaGridV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.divisaGridV.Location = new System.Drawing.Point(366, 70);
			this.divisaGridV.Name = "divisaGridV";
			this.divisaGridV.Size = new System.Drawing.Size(268, 269);
			this.divisaGridV.TabIndex = 61;
			this.divisaGridV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.divisaGridV_CellClick);
			this.divisaGridV.Click += new System.EventHandler(this.divisaGridV_Click);
			// 
			// buttonConsultar
			// 
			this.buttonConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonConsultar.Image = ((System.Drawing.Image)(resources.GetObject("buttonConsultar.Image")));
			this.buttonConsultar.Location = new System.Drawing.Point(505, 345);
			this.buttonConsultar.Name = "buttonConsultar";
			this.buttonConsultar.Size = new System.Drawing.Size(61, 46);
			this.buttonConsultar.TabIndex = 66;
			this.buttonConsultar.UseVisualStyleBackColor = true;
			this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
			// 
			// buttonLimpiar
			// 
			this.buttonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("buttonLimpiar.Image")));
			this.buttonLimpiar.Location = new System.Drawing.Point(402, 345);
			this.buttonLimpiar.Name = "buttonLimpiar";
			this.buttonLimpiar.Size = new System.Drawing.Size(61, 46);
			this.buttonLimpiar.TabIndex = 65;
			this.buttonLimpiar.UseVisualStyleBackColor = true;
			this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
			// 
			// buttonModificar
			// 
			this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonModificar.Image = ((System.Drawing.Image)(resources.GetObject("buttonModificar.Image")));
			this.buttonModificar.Location = new System.Drawing.Point(260, 288);
			this.buttonModificar.Name = "buttonModificar";
			this.buttonModificar.Size = new System.Drawing.Size(77, 68);
			this.buttonModificar.TabIndex = 64;
			this.buttonModificar.UseVisualStyleBackColor = true;
			this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
			// 
			// buttonElminar
			// 
			this.buttonElminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonElminar.Image = ((System.Drawing.Image)(resources.GetObject("buttonElminar.Image")));
			this.buttonElminar.Location = new System.Drawing.Point(157, 288);
			this.buttonElminar.Name = "buttonElminar";
			this.buttonElminar.Size = new System.Drawing.Size(77, 68);
			this.buttonElminar.TabIndex = 62;
			this.buttonElminar.UseVisualStyleBackColor = true;
			this.buttonElminar.Click += new System.EventHandler(this.buttonElminar_Click);
			// 
			// buttonGuardar
			// 
			this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.Image")));
			this.buttonGuardar.Location = new System.Drawing.Point(-176, 178);
			this.buttonGuardar.Name = "buttonGuardar";
			this.buttonGuardar.Size = new System.Drawing.Size(77, 68);
			this.buttonGuardar.TabIndex = 63;
			this.buttonGuardar.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(53, 288);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(77, 68);
			this.button1.TabIndex = 67;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Crear_Divisa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(730, 423);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.buttonConsultar);
			this.Controls.Add(this.buttonLimpiar);
			this.Controls.Add(this.buttonModificar);
			this.Controls.Add(this.buttonElminar);
			this.Controls.Add(this.buttonGuardar);
			this.Controls.Add(this.divisaGridV);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.BarraTitulo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Crear_Divisa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Crear_Divisa";
			this.BarraTitulo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnCerrarPB)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.divisaGridV)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel BarraTitulo;
		private System.Windows.Forms.PictureBox btnCerrarPB;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox simbolodivisaTBT;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox nombredivisaTBT;
		private System.Windows.Forms.TextBox IdTXT;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView divisaGridV;
		private System.Windows.Forms.Button buttonConsultar;
		private System.Windows.Forms.Button buttonLimpiar;
		private System.Windows.Forms.Button buttonModificar;
		private System.Windows.Forms.Button buttonElminar;
		private System.Windows.Forms.Button buttonGuardar;
		private System.Windows.Forms.Button button1;
	}
}