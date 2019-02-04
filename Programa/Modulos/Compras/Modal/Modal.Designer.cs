namespace Programa.Modulos.Compras.Modal
{
	partial class Modal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modal));
			this.BarraTitulo = new System.Windows.Forms.Panel();
			this.btnCerrarPB = new System.Windows.Forms.PictureBox();
			this.productosGDV = new System.Windows.Forms.DataGridView();
			this.buttonConsultar = new System.Windows.Forms.Button();
			this.BarraTitulo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnCerrarPB)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productosGDV)).BeginInit();
			this.SuspendLayout();
			// 
			// BarraTitulo
			// 
			this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.BarraTitulo.Controls.Add(this.btnCerrarPB);
			this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
			this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
			this.BarraTitulo.Name = "BarraTitulo";
			this.BarraTitulo.Size = new System.Drawing.Size(633, 35);
			this.BarraTitulo.TabIndex = 1;
			this.BarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraTitulo_Paint);
			// 
			// btnCerrarPB
			// 
			this.btnCerrarPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCerrarPB.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCerrarPB.Image = global::Programa.Properties.Resources.cerrar;
			this.btnCerrarPB.Location = new System.Drawing.Point(594, 12);
			this.btnCerrarPB.Name = "btnCerrarPB";
			this.btnCerrarPB.Size = new System.Drawing.Size(27, 16);
			this.btnCerrarPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnCerrarPB.TabIndex = 0;
			this.btnCerrarPB.TabStop = false;
			this.btnCerrarPB.Click += new System.EventHandler(this.btnCerrarPB_Click);
			// 
			// productosGDV
			// 
			this.productosGDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.productosGDV.Location = new System.Drawing.Point(12, 57);
			this.productosGDV.Name = "productosGDV";
			this.productosGDV.Size = new System.Drawing.Size(515, 246);
			this.productosGDV.TabIndex = 50;
			this.productosGDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productosGDV_CellClick);
			this.productosGDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productosGDV_CellContentClick);
			// 
			// buttonConsultar
			// 
			this.buttonConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonConsultar.Image = ((System.Drawing.Image)(resources.GetObject("buttonConsultar.Image")));
			this.buttonConsultar.Location = new System.Drawing.Point(542, 80);
			this.buttonConsultar.Name = "buttonConsultar";
			this.buttonConsultar.Size = new System.Drawing.Size(68, 56);
			this.buttonConsultar.TabIndex = 53;
			this.buttonConsultar.UseVisualStyleBackColor = true;
			this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
			// 
			// Modal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(633, 329);
			this.Controls.Add(this.buttonConsultar);
			this.Controls.Add(this.productosGDV);
			this.Controls.Add(this.BarraTitulo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Modal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Modal";
			this.BarraTitulo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnCerrarPB)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productosGDV)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel BarraTitulo;
		private System.Windows.Forms.PictureBox btnCerrarPB;
		private System.Windows.Forms.DataGridView productosGDV;
		private System.Windows.Forms.Button buttonConsultar;
	}
}