namespace Programa.Modulos.Reportes.Articulos
{
	partial class ReporteProductos
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
			this.productosReportV = new Microsoft.Reporting.WinForms.ReportViewer();
			this.SuspendLayout();
			// 
			// productosReportV
			// 
			this.productosReportV.Dock = System.Windows.Forms.DockStyle.Fill;
			this.productosReportV.Location = new System.Drawing.Point(0, 0);
			this.productosReportV.Name = "productosReportV";
			this.productosReportV.ServerReport.BearerToken = null;
			this.productosReportV.Size = new System.Drawing.Size(800, 450);
			this.productosReportV.TabIndex = 0;
			this.productosReportV.Load += new System.EventHandler(this.reportViewer1_Load);
			// 
			// ReporteProductos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.productosReportV);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ReporteProductos";
			this.Text = "ReporteProductos";
			this.Load += new System.EventHandler(this.ReporteProductos_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer productosReportV;
	}
}