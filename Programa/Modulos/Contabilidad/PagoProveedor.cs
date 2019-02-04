using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programa.Controller.Contabilidad;

namespace Programa.Modulos.Contabilidad
{
	public partial class PagoProveedor : Form
	{
		
		private PagoProveedor_Controller controlador;
		public PagoProveedor()
		{
			InitializeComponent();
			controlador = new PagoProveedor_Controller();
			formapagoCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;			
			IdTXT.ReadOnly = true;
			IdTXT.Text = "0";
			idIngresoTBT.ReadOnly = true;
			llenarComboFormasPago();
			serieTBX.ReadOnly = true;
			timbradoTXT.ReadOnly = true;
			this.CenterToScreen();
			fechaTPC.Value = DateTime.Now;			

		}

		private void seleccionar()
		{
			int fila = int.Parse(ingresosGVW.CurrentCell.RowIndex.ToString().Trim());//obtenemos fila
			if (ingresosGVW.Rows[fila].Cells[0].Value.ToString().Trim() != "")
			{
				idIngresoTBT.Text = ingresosGVW.Rows[fila].Cells[0].Value.ToString().Trim();
				serieTBX.Text = ingresosGVW.Rows[fila].Cells[1].Value.ToString().Trim();
				timbradoTXT.Text = ingresosGVW.Rows[fila].Cells[2].Value.ToString().Trim();
				formapagoCBX.SelectedIndex = formapagoCBX.FindString(ingresosGVW.Rows[fila].Cells[6].Value.ToString().Trim());
				montoTBT.Text= ingresosGVW.Rows[fila].Cells[8].Value.ToString().Trim();
			}
		}

		private void consultar()
		{
			controlador.Sql = "SELECT DISTINCT i.idingresos as 'Id Ingreso'," +
									  "i.idtipocomprobante as '# Comprobante'," +
									  "i.timbrado as Timbrado," +
									  "p.nombre as Proveedor," +
									  "i.fecha as Fecha," +
									  "i.total as Total," +
									  "fp.nombre as 'Forma Pago'," +
									  "c.diaspago as 'Dias Pago'," +
									  "(CASE " +
										"WHEN fp.idformapago = 1 THEN i.total " +
										"WHEN fp.idformapago = 2 THEN i.total " +
										"WHEN fp.idformapago = 3 THEN ROUND((i.total)/ c.diaspago)/*REPLACE(FORMAT(i.total/ c.diaspago,2),'.',',')*/ " +
										"ELSE i.total " +
									  "END) as 'Pago Cuotas' " +
								"FROM ingresos  as i " +
									"INNER JOIN formapago as fp ON fp.idformapago = i.idformapago " +
									"LEFT JOIN cheque as c ON c.idcheque = i.idcheque AND c.idformapago=fp.idformapago " +
									"INNER JOIN proveedores as p ON p.idproveedores = i.idproveedor ";
			ingresosGVW.DataSource = controlador.ConsultarTabla();
			ingresosGVW.Refresh();
		}


		private bool comprobar(bool id)
		{
			bool result = false;
			if (IdTXT.Text.Trim() != "")
			{
				controlador.Modelo.Idformapago = int.Parse(IdTXT.Text.Trim());
				if (idIngresoTBT.Text.Trim() != "")
				{
					controlador.Modelo.Idingreso = int.Parse(idIngresoTBT.Text.Trim());
					if (montoTBT.Text.Trim() != "")
					{
						controlador.Modelo.Pago = Convert.ToDouble(montoTBT.Text.Trim());
						if (numerochequeTBT.Text.Trim() != "" || numerochequeTBT.Text.Trim() == "")
						{
							controlador.Modelo.Numerocheque = numerochequeTBT.Text.Trim() == "" ?  "0" : numerochequeTBT.Text.Trim();
								if (fechaTPC.Text.Trim() != "")
								{
									controlador.Modelo.Fecha = Convert.ToString(fechaTPC.Text.Trim());
									result = true;
									controlador.Modelo.Idformapago = int.Parse(formapagoCBX.SelectedValue.ToString());
								}
						}
					}
				}
			}

			if (id)
			{
				if (int.Parse(IdTXT.Text.Trim()) <= 0)
				{
					result = false;
				}
			}
			else
			{
				if (int.Parse(IdTXT.Text.Trim()) > 0)
				{
					result = false;
				}
			}
			if (!result)
			{
				MessageBox.Show("DATOS INCOMPLETOS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			return result;
		}

		private void limpiar()
		{
			IdTXT.Text = "0";
			idIngresoTBT.Text = "";
			serieTBX.Text = "";
			timbradoTXT.Text = "";
			montoTBT.Text = "";
		}

		private void guardar()
		{
			if (comprobar(false))
			{

				if (controlador.Guardar())
				{
					limpiar();
					consultar();
				}
			}
		}
		private void llenarComboFormasPago()
		{
			controlador.Sql = "select * from formapago";
			formapagoCBX.DataSource = controlador.ConsultarTabla();
			formapagoCBX.DisplayMember = "nombre".Trim();
			formapagoCBX.ValueMember = "idformapago".Trim();
			formapagoCBX.Refresh();
		}

		

		private void PagoProveedor_Load(object sender, EventArgs e)
		{

		}

		private void buttonConsultar_Click(object sender, EventArgs e)
		{
			consultar();
		}

		private void buttonGuardar_Click(object sender, EventArgs e)
		{
			guardar();
		}

		private void buttonLimpiar_Click(object sender, EventArgs e)
		{
			limpiar();
		}

		private void ingresosGVW_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			seleccionar();
		}

		private void fechaTPC_ValueChanged(object sender, EventArgs e)
		{
			
		}

		private void formapagoCBX_SelectedIndexChanged(object sender, EventArgs e)
		{
			string nombre = formapagoCBX.Text;
			if (nombre == "CHEQUE")
			{
				numerochequeTBT.Visible = true;
				label8.Visible = true;
			}
			else
			{
				numerochequeTBT.Visible = false;
				label8.Visible = false;
			}
		}
	}
}
