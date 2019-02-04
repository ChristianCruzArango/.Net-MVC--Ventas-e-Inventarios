using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programa.Modelos.Compras;
using Programa.Controller.Ventas;
using Programa.Modelos.Ventas;
using Programa.Modulos.Compras;

namespace Programa.Modulos.Ventas
{
	public partial class Ventas : Form
	{
		private  CrearVentas_Controller controlador;
		double txt1 = 0, txt2 = 0;
		public Ventas()
		{
			InitializeComponent();
			controlador = new CrearVentas_Controller();
			tipoComprobanteTBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			clienteCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			formapagoCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			IdTXT.ReadOnly = true;
			IdTXT.Text = "0";
			numerochequeTBT.Text = "0";
			serieTBX.Text = "0";
			timbradoTXT.Text = "0";
			llenarComboTipoComprobante();
			llenarComboClientes();
			llenarComboFormasPago();			
			totalTXT.ReadOnly = true;
			fechaTPC.Value = DateTime.Now;
			fechaTPC.CustomFormat = "yyyy-MM-dd";
			this.CenterToScreen();
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
		private void llenarComboClientes()
		{
			controlador.Sql = "select idclientes,nombre from clientes";
			clienteCBX.DataSource = controlador.ConsultarTabla();
			clienteCBX.DisplayMember = "nombre".Trim();
			clienteCBX.ValueMember = "idclientes".Trim();
			clienteCBX.Refresh();
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
			totalTBT.Text = "";
			devueltaTBT.Text = "";
			productoGTV.Rows.Clear();
		}

		private bool comprobar(bool id)
		{
			bool result = false;

			if (IdTXT.Text.Trim() != "")
			{
				controlador.Modelo.Idcliente = int.Parse(IdTXT.Text.Trim());
				if (serieTBX.Text.Trim() != "")
				{
					controlador.Modelo.Seriecomprobante = int.Parse(serieTBX.Text.Trim());
					if (timbradoTXT.Text.Trim() != "")
					{
						controlador.Modelo.Timbrado = int.Parse(timbradoTXT.Text.Trim());
						if (fechaTPC.Text.Trim() != "")
						{
							controlador.Modelo.Fecha = fechaTPC.Text.Trim();
							if (numerochequeTBT.Text.Trim() != "" )
							{
								controlador.Modelo.NumeroCheque = int.Parse(numerochequeTBT.Text.Trim());
								if (totalTXT.Text.Trim() != "")
								{

									controlador.Modelo.Total = double.Parse(totalTXT.Text.Trim().ToString());
									result = true;
									controlador.Modelo.Idtipocomprobante = int.Parse(tipoComprobanteTBX.SelectedValue.ToString());
									controlador.Modelo.Idcliente = int.Parse(clienteCBX.SelectedValue.ToString());
									controlador.Modelo.Idformapago = int.Parse(formapagoCBX.SelectedValue.ToString());

									List<CrearVentas_Modelo> parametros = new List<CrearVentas_Modelo>();
									foreach (DataGridViewRow row in productoGTV.Rows)
									{
										parametros.Add(new CrearVentas_Modelo
										{
											IdarticuloDetalleVenta = int.Parse(row.Cells["Column1"].Value.ToString().ToString().Trim()),
											CantidadDetalleVenta = int.Parse(row.Cells["Column3"].Value.ToString().ToString().Trim()),
											PrecioDetalleVenta = int.Parse(row.Cells["Column4"].Value.ToString().ToString().Trim())

										});
									}

									CrearVentas_Controller frmVentaDetalle = new CrearVentas_Controller();
									frmVentaDetalle.GuardarDetalles(parametros);

								}
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
			Modal.Modal_Ventas frm = new Modal.Modal_Ventas();
			AddOwnedForm(frm);
			frm.Show();
		}

		public void resta(double n1,double n2)
		{
			double resultado = n2 - n1;
			totalTBT.Text = resultado.ToString();
		}

		private void Ventas_Load(object sender, EventArgs e)
		{
			DataGridViewButtonColumn btncl = new DataGridViewButtonColumn();
			btncl.Name = "Cal";
			productoGTV.Columns.Add(btncl);
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

		private void productoGTV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

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

		private void formapagoCBX_SelectedIndexChanged(object sender, EventArgs e)
		{
			string nombre = formapagoCBX.Text;
			if (nombre == "CHEQUE")
			{
				numerochequeTBT.Visible = true;
				label6.Visible = true;
			}
			else
			{
				numerochequeTBT.Visible = false;
				label6.Visible = false;
			}
		}

		private void buttonGuardar_Click(object sender, EventArgs e)
		{
			guardar();
		}

		private void devueltaTBT_KeyPress(object sender, KeyPressEventArgs e)
		{
			Validador.ValidarNumero(devueltaTBT, e, 100);
		}

		private void devueltaTBT_TextChanged(object sender, EventArgs e)
		{
			txt2 = double.Parse(devueltaTBT.Text.ToString());
			resta(txt1, txt2);
		}

		private void totalTBT_TextChanged(object sender, EventArgs e)
		{

		}

		private void devueltaTBT_TextChanged_1(object sender, EventArgs e)
		{
			try
			{
				txt1 = double.Parse(devueltaTBT.Text.ToString());
				resta(txt1, txt2);
			}
			catch (FormatException)
			{
				devueltaTBT.Clear();
			}
			
		}

		private void totalTXT_TextChanged(object sender, EventArgs e)
		{
			try {
				txt2 = double.Parse(totalTXT.Text.ToString());
				resta(txt1, txt2);
			}
			catch (FormatException )
			{
				totalTXT.Clear();
			}
			
		}
	}
}
