namespace Programa.Modulos.Reportes.Compras
{
	partial class ReporteCompras
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
			this.comprasreporteV = new Microsoft.Reporting.WinForms.ReportViewer();
			this.SuspendLayout();
			// 
			// comprasreporteV
			// 
			this.comprasreporteV.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comprasreporteV.Location = new System.Drawing.Point(0, 0);
			this.comprasreporteV.Name = "comprasreporteV";
			this.comprasreporteV.ServerReport.BearerToken = null;
			this.comprasreporteV.Size = new System.Drawing.Size(800, 450);
			this.comprasreporteV.TabIndex = 0;
			this.comprasreporteV.Load += new System.EventHandler(this.reportViewer1_Load);
			// 
			// ReporteCompras
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.comprasreporteV);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ReporteCompras";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ReporteCompras";
			this.Load += new System.EventHandler(this.ReporteCompras_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer comprasreporteV;
	}
}