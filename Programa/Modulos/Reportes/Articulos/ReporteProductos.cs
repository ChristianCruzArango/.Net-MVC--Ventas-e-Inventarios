using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Programa.Controller.Articulos;

namespace Programa.Modulos.Reportes.Articulos
{
	public partial class ReporteProductos : Form
	{
		private CrearArticulo_Controller controlador;

		public ReporteProductos()
		{
			InitializeComponent();
			controlador = new CrearArticulo_Controller();
			ReporteProductosView();
		}

		private void ReporteProductosView()
		{
			controlador.Sql = "SELECT a.idarticulos, " +
									  "c.nombre as Categoria, " +
									  "a.nombre, a.descripcion," +
									  "a.stock, " +
                                      "a.precio_venta, " +
									  "a.precio_compra," +
		                              "e.nombreEstado as Estado " +
								"FROM articulos as a "+
									"inner join categoria as c on a.idcategoria = c.idcategoria "+
									"inner join estados as e on a.idestado = e.idestados ";

			ReportDataSource rds = new ReportDataSource();
			rds.Name = "DataSetReportesInventario";
			rds.Value = controlador.ConsultarTabla();

			productosReportV.LocalReport.DataSources.Clear();
			productosReportV.LocalReport.DataSources.Add(rds);
			productosReportV.LocalReport.ReportPath = "Report_Articulos.rdlc";
			productosReportV.LocalReport.Refresh();

		}



		private void ReporteProductos_Load(object sender, EventArgs e)
		{

			this.productosReportV.RefreshReport();
		}

		private void reportViewer1_Load(object sender, EventArgs e)
		{

		}
	}
}
