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
	public partial class ReporteRentabilidad : Form
	{
		private CrearArticulo_Controller controlador;
		public ReporteRentabilidad()
		{
			InitializeComponent();
			controlador = new CrearArticulo_Controller();
			ReporteRentabilidadProductosView();
		}

		private void ReporteRentabilidadProductosView ()
		{
			controlador.Sql = "SELECT a.idarticulos, " +
									  "c.nombre as Categoria, " +
									  "a.nombre, a.precio_venta, " +
									  "a.precio_compra," +
									  "round(((a.precio_venta - a.precio_compra) / a.precio_venta) * 100) as Rentabilidad, " +
									  "(CASE "+
										"WHEN round(((a.precio_venta -a.precio_compra) / a.precio_venta) *100) < 0 THEN 'Estas perdiendo dinero' "+
										"WHEN round(((a.precio_venta -a.precio_compra) / a.precio_venta) *100) > 50 THEN 'Puedes estar ganando más dinero' "+
									  "ELSE 'Estas ganando más de la mitad' END) as Informacion "+
							   "FROM articulos as a " +
							   "inner join categoria as c on a.idcategoria = c.idcategoria ";                               

			ReportDataSource rds = new ReportDataSource();
			rds.Name = "DataSetRentabilidad";			
			rds.Value = controlador.ConsultarTabla();

			productosRentabilidadReport.LocalReport.DataSources.Clear();
			productosRentabilidadReport.LocalReport.DataSources.Add(rds);
			productosRentabilidadReport.LocalReport.ReportPath = "Reporte_Rentabilidad.rdlc";
			productosRentabilidadReport.LocalReport.Refresh();

		}

		private void ReporteRentabilidad_Load(object sender, EventArgs e)
		{

			this.productosRentabilidadReport.RefreshReport();
		}

		private void reportViewer1_Load(object sender, EventArgs e)
		{

		}
	}
}
