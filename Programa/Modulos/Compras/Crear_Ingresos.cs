using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programa.Modulos.Compras.Modal;
using Programa.Controller.Compras;
using Programa.Modelos.Compras;
using Programa.Controller;

namespace Programa.Modulos.Compras
{
	public partial class Crear_Ingresos : Form
	{
		
		private CrearIngresos_Controller controlador;
		
		
		public Crear_Ingresos()
		{
			InitializeComponent();
			controlador = new CrearIngresos_Controller();
			tipoComprobanteTBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			proveedorCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			formapagoCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			IdTXT.ReadOnly = true;
			IdTXT.Text = "0";
			llenarComboTipoComprobante();
			llenarComboProveedores();
			llenarComboFormasPago();
			llenarDiasChequePago();
			totalTXT.ReadOnly = true;
			fechaTPC.Value = DateTime.Now;
			fechaTPC.CustomFormat= "yyyy-MM-dd";
		}

		

		private void llenarDiasChequePago()
		{
			controlador.Sql = "select * from cheque";
			chequediasTBX.DataSource = controlador.ConsultarTabla();
			chequediasTBX.DisplayMember = "diaspago".Trim();
			chequediasTBX.ValueMember = "idcheque".Trim();
			chequediasTBX.Refresh();
		}

		private void llenarComboTipoComprobante()
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

		private void guardar()
		{
			
			if (comprobar(false))
			{

				if (controlador.Guardar())
				{
					
					limpiar();					
				}
			}
		}		

		private void limpiar()
		{
			serieTBX.Text = "";
			timbradoTXT.Text = "";
			totalTXT.Text = "";
			productoGTV.Rows.Clear();
		}
		
		private bool comprobar(bool id)
		{
			bool result = false;
			
			if (IdTXT.Text.Trim() != "")
			{
				controlador.Modelo.Idingreso = int.Parse(IdTXT.Text.Trim());
				if (serieTBX.Text.Trim() != "")
				{
					controlador.Modelo.Seriecomprobante = int.Parse(serieTBX.Text.Trim());
					if (timbradoTXT.Text.Trim() != "")
					{
						controlador.Modelo.Timbrado = int.Parse(timbradoTXT.Text.Trim());
						if (fechaTPC.Text.Trim() != "" )
						{
							controlador.Modelo.Fecha = fechaTPC.Text.Trim();
							if (totalTXT.Text.Trim() !="") {

								controlador.Modelo.Total = double.Parse(totalTXT.Text.Trim().ToString());
								result = true;
								controlador.Modelo.Idtipocomprobante = int.Parse(tipoComprobanteTBX.SelectedValue.ToString());
								controlador.Modelo.Idproveedor = int.Parse(proveedorCBX.SelectedValue.ToString());
								controlador.Modelo.Idformapago = int.Parse(formapagoCBX.SelectedValue.ToString());
								controlador.Modelo.Chequedias = int.Parse(chequediasTBX.SelectedValue.ToString());
															
								List<CrearIngresos_Modelo> parametros = new List<CrearIngresos_Modelo>();
								foreach (DataGridViewRow row in productoGTV.Rows)
								{
									parametros.Add(new CrearIngresos_Modelo
									{										
										IdarticuloDetalleVenta = int.Parse(row.Cells["Column1"].Value.ToString().ToString().Trim()),
										CantidadDetalleVenta = int.Parse(row.Cells["Column3"].Value.ToString().ToString().Trim()),
										PrecioDetalleVenta = int.Parse(row.Cells["Column4"].Value.ToString().ToString().Trim())

									});																	
								}
								

								CrearIngresos_Controller frmIngresoDetalle = new CrearIngresos_Controller();
								frmIngresoDetalle.GuardarDetalles(parametros);

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


	

		private void button1_Click(object sender, EventArgs e)
		{
			Modal.Modal frm = new Modal.Modal();
			AddOwnedForm(frm);   
			frm.Show();
		}		

		private void Crear_Ingresos_Load(object sender, EventArgs e)
		{
			DataGridViewButtonColumn btncl = new DataGridViewButtonColumn();
			btncl.Name = "Cal";
			productoGTV.Columns.Add(btncl);			
		}

	

		private void productoGTV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void idarticuloTXT_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void idarticuloTXT_Leave(object sender, EventArgs e)
		{
			
		}

		private void buttonElminar_Click(object sender, EventArgs e)
		{
			productoGTV.Rows.RemoveAt(productoGTV.CurrentRow.Index);
		}

		private void productoGTV_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.ColumnIndex >= 0 && this.productoGTV.Columns[e.ColumnIndex].Name == "Cal" && e.RowIndex >= 0)
			{
				e.Paint(e.CellBounds, DataGridViewPaintParts.All);
				DataGridViewButtonCell celBoton = this.productoGTV.Rows[e.RowIndex].Cells["Cal"] as DataGridViewButtonCell;
				Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\\calcular.ico");
				e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

				this.productoGTV.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
				this.productoGTV.Columns[e.ColumnIndex].Width = icoAtomico.Width + 8;

				e.Handled = true;
			}
		}

		private void productoGTV_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.productoGTV.Columns[e.ColumnIndex].Name == "Cal")
			{
				int cantidad = int.Parse(productoGTV.CurrentRow.Cells[2].Value.ToString().Trim());
				int previoVenta = int.Parse(productoGTV.CurrentRow.Cells[3].Value.ToString().Trim());

				int resulto = cantidad * previoVenta;
				DataGridViewRow row = productoGTV.CurrentRow;

				row.Cells["Column5"].Value = resulto.ToString();
			}
		}

		private void buttonModificar_Click(object sender, EventArgs e)
		{
			double suma = productoGTV.Rows.OfType<DataGridViewRow>().
						 Sum(x => Convert.ToDouble(x.Cells["Column5"].Value));

			totalTXT.Text = string.Format("{0:N2}", suma);
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void formapagoCBX_SelectedIndexChanged(object sender, EventArgs e)
		{
			string nombre = formapagoCBX.Text;
			if (nombre == "CHEQUE")
			{
				chequediasTBX.Visible = true;
				label6.Visible = true;
			}
			else
			{
				chequediasTBX.Visible = false;
				label6.Visible = false;
			}
		}

		private void formapagoCBX_Click(object sender, EventArgs e)
		{
			
		}

		private void formapagoCBX_KeyPress(object sender, KeyPressEventArgs e)
		{

		}

		private void buttonGuardar_Click(object sender, EventArgs e)
		{
			guardar();
		}

		private void totalTXT_TextChanged(object sender, EventArgs e)
		{

		}

		private void productoGTV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void fechaTPC_ValueChanged(object sender, EventArgs e)
		{

		}

		private void proveedorCBX_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void chequediasTBX_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
