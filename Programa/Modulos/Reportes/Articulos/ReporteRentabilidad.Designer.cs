namespace Programa.Modulos.Reportes.Articulos
{
	partial class ReporteRentabilidad
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
			this.productosRentabilidadReport = new Microsoft.Reporting.WinForms.ReportViewer();
			this.SuspendLayout();
			// 
			// productosRentabilidadReport
			// 
			this.productosRentabilidadReport.Dock = System.Windows.Forms.DockStyle.Fill;
			this.productosRentabilidadReport.Location = new System.Drawing.Point(0, 0);
			this.productosRentabilidadReport.Name = "productosRentabilidadReport";
			this.productosRentabilidadReport.ServerReport.BearerToken = null;
			this.productosRentabilidadReport.Size = new System.Drawing.Size(800, 450);
			this.productosRentabilidadReport.TabIndex = 0;
			this.productosRentabilidadReport.Load += new System.EventHandler(this.reportViewer1_Load);
			// 
			// ReporteRentabilidad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.productosRentabilidadReport);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ReporteRentabilidad";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ReporteRentabilidad";
			this.Load += new System.EventHandler(this.ReporteRentabilidad_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer productosRentabilidadReport;
	}
}