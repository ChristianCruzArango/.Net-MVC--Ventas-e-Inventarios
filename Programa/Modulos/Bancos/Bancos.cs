using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using Programa.Controller.Banco;

namespace Programa.Modulos.Bancos
{
	public partial class Bancos : Form
	{
		private BancoPagos_Controller controlador;
		public Bancos()
		{			
			InitializeComponent();
			controlador = new BancoPagos_Controller();
			BancoDGV.ReadOnly = true;
			IdTXT.ReadOnly = true;
			IdTXT.Text = "0";
			idingresoTB.ReadOnly = true;
			llenarComboFormasPago();
			llenarComboProveedores();			
			llenarComboTComprobantes();
			llenarComboBancos();
			llenarComboDivisas();
			fechaTPC.Value = DateTime.Now;
		}

		private void llenarComboBancos()
		{
			controlador.Sql = "select * from bancos";
			bancoCBX.DataSource = controlador.ConsultarTabla();
			bancoCBX.DisplayMember = "nombre".Trim();
			bancoCBX.ValueMember = "idbancos".Trim();
			bancoCBX.Refresh();
		}

		private void llenarComboDivisas()
		{
			controlador.Sql = "select * from divisa";
			divisaCBX.DataSource = controlador.ConsultarTabla();
			divisaCBX.DisplayMember = "simboloDivisa".Trim();
			divisaCBX.ValueMember = "iddivisa".Trim();
			divisaCBX.Refresh();
		}

		private void llenarComboTComprobantes()
		{
			controlador.Sql = "select * from tipocomprobante";
			tipoComprobanteTBX.DataSource = controlador.ConsultarTabla();
			tipoComprobanteTBX.DisplayMember = "nombre".Trim();
			tipoComprobanteTBX.ValueMember = "idtipocomprobante".Trim();
			tipoComprobanteTBX.Refresh();
		}

		private void llenarComboFormasPago()
		{
			controlador.Sql = "select * from formapago";
			formapagoCBX.DataSource = controlador.ConsultarTabla();
			formapagoCBX.DisplayMember = "nombre".Trim();
			formapagoCBX.ValueMember = "idformapago".Trim();
			formapagoCBX.Refresh();
		}

		

		private void llenarComboProveedores()
		{
			controlador.Sql = "select idproveedores,nombre from proveedores";
			proveedorCBX.DataSource = controlador.ConsultarTabla();
			proveedorCBX.DisplayMember = "nombre".Trim();
			proveedorCBX.ValueMember = "idproveedores".Trim();
			proveedorCBX.Refresh();
		}

		private void seleccionar()
		{
			int fila = int.Parse(BancoDGV.CurrentCell.RowIndex.ToString().Trim());//obtenemos fila
			if (BancoDGV.Rows[fila].Cells[0].Value.ToString().Trim() != "")
			{
				idingresoTB.Text = BancoDGV.Rows[fila].Cells[0].Value.ToString().Trim();
				tipoComprobanteTBX.SelectedIndex = tipoComprobanteTBX.FindString(BancoDGV.Rows[fila].Cells[1].Value.ToString().Trim());
				timbradoTXT.Text = BancoDGV.Rows[fila].Cells[2].Value.ToString().Trim();
				serieTBX.Text = BancoDGV.Rows[fila].Cells[3].Value.ToString().Trim();
				formapagoCBX.SelectedIndex = formapagoCBX.FindString(BancoDGV.Rows[fila].Cells[4].Value.ToString().Trim());
				proveedorCBX.SelectedIndex = proveedorCBX.FindString(BancoDGV.Rows[fila].Cells[6].Value.ToString().Trim());
				numerochequeTXT.Text = BancoDGV.Rows[fila].Cells[7].Value.ToString().Trim();
				totalTXT.Text = BancoDGV.Rows[fila].Cells[8].Value.ToString().Trim();
			}
		}



		private void consultar()
		{
			controlador.Sql = "SELECT i.idingresos," +
				                     "t.nombre as comprobante," +
						             "i.timbrado," +
									 "i.seriecomprobante," +
	                                 "f.nombre as 'forma de pago'," +
                                     "c.diaspago," +
                                     "pv.nombre as proveedor," +
									 "p.numerocheque," +
		                             "p.pago " +
	                          "FROM `pagoproveedores` as p "+
                                "inner join ingresos as i on p.idingreso = i.idingresos "+
                                "inner join tipocomprobante as t on i.idtipocomprobante = t.idtipocomprobante "+
								"inner join proveedores as pv on i.idproveedor = pv.idproveedores "+
								"inner join formapago as f on f.idformapago = i.idformapago "+
								"inner join cheque as c on c.idcheque = i.idcheque ";
			BancoDGV.DataSource = controlador.ConsultarTabla();
			BancoDGV.Refresh();
		}

		private void NuevoBTN_Click(object sender, EventArgs e)
		{
			
		}

		

		private void buttonModificar_Click(object sender, EventArgs e)
		{
		

		}

		private void BancoDGV_Click(object sender, EventArgs e)
		{
			
			
		}

		private void Bancos_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Crear_Divisa frm = new Crear_Divisa();
			AddOwnedForm(frm);
			frm.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Crear_Bancos frm = new Crear_Bancos();
			AddOwnedForm(frm);
			frm.Show();
		}

		private void buttonConsultar_Click(object sender, EventArgs e)
		{
			consultar();
		}

		private void BancoDGV_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			seleccionar();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int serie = int.Parse(serieTBX.Text);
			int timbrado = int.Parse(timbradoTXT.Text);
			string proveedor = proveedorCBX.Text;
			double total = double.Parse(totalTXT.Text);			
			Cheque.Cheque frmCheque = new Cheque.Cheque();
			AddOwnedForm(frmCheque);
			frmCheque.ChequeDatos(serie, timbrado, proveedor, total);
			frmCheque.Show();
		}
	}
}
