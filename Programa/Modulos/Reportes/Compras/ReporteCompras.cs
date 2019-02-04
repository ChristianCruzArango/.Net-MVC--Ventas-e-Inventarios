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
using Programa.Controller.Compras;

namespace Programa.Modulos.Reportes.Compras
{
	public partial class ReporteCompras : Form
	{
		private CrearIngresos_Controller controlador;
		public ReporteCompras()
		{
			InitializeComponent();
			controlador = new CrearIngresos_Controller();
			ReporteComprasView();
		}

		private void ReporteComprasView()
		{
			controlador.Sql = "SELECT i.idingresos," +
									 "tc.nombre as 'tipocomprobante' ," +
	                                  "p.nombre as proveedor," +
									  "i.seriecomprobante," +
									  "i.timbrado," +
									  "i.fecha," +
									  "i.total," +
									  "fp.nombre as formapago," +
		                              "c.diaspago" +
								 " FROM ingresos as i "+
                                   "inner join proveedores as p on i.idproveedor = p.idproveedores "+
								   "inner join tipocomprobante as tc on tc.idtipocomprobante=i.idtipocomprobante "+
								   "left join formapago as fp on fp.idformapago = i.idformapago " +
                                   "left join cheque as c on c.idcheque = i.idcheque";
			ReportDataSource rds = new ReportDataSource();
			rds.Name = "DataSetCompras";
			rds.Value = controlador.ConsultarTabla();

			comprasreporteV.LocalReport.DataSources.Clear();
			comprasreporteV.LocalReport.DataSources.Add(rds);
			comprasreporteV.LocalReport.ReportPath = "ReporteCompras.rdlc";
			comprasreporteV.LocalReport.Refresh();
		}

		private void ReporteCompras_Load(object sender, EventArgs e)
		{

			this.comprasreporteV.RefreshReport();
		}

		private void reportViewer1_Load(object sender, EventArgs e)
		{

		}
	}
}
