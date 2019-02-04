using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programa.Controller.Compras;

namespace Programa.Modulos.Compras
{
	public partial class Crear_Proveedor : Form
	{
		private CrearProveedor_Controller controlador;
		public Crear_Proveedor()
		{
			InitializeComponent();
			controlador = new CrearProveedor_Controller();
			txtID.ReadOnly = true;
			txtID.Text = "0";
			tipoDCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			estadoCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			llenarComboTipoDocumento();
			llenarComboEstados();
			proveedorGDV.ReadOnly = true;
			this.CenterToScreen();
		}

		private void llenarComboEstados()
		{
			controlador.Sql = "select * from estados where idestados in (6,7)";
			estadoCBX.DataSource = controlador.ConsultarTabla();
			estadoCBX.DisplayMember = "nombreEstado".Trim();
			estadoCBX.ValueMember = "idestados".Trim();
			estadoCBX.Refresh();
		}

		private void llenarComboTipoDocumento()
		{
			controlador.Sql = "select * from tipodocumento";
			tipoDCBX.DataSource = controlador.ConsultarTabla();
			tipoDCBX.DisplayMember = "nombre".Trim();
			tipoDCBX.ValueMember = "idtipoDocumento".Trim();
			tipoDCBX.Refresh();
		}

		private void seleccionar()
		{
			int fila = int.Parse(proveedorGDV.CurrentCell.RowIndex.ToString().Trim());//obtenemos fila
			if (proveedorGDV.Rows[fila].Cells[0].Value.ToString().Trim() != "")
			{
				txtID.Text = proveedorGDV.Rows[fila].Cells[0].Value.ToString().Trim();
				txtNombre.Text = proveedorGDV.Rows[fila].Cells[1].Value.ToString().Trim();
				tipoDCBX.SelectedIndex = tipoDCBX.FindString(proveedorGDV.Rows[fila].Cells[2].Value.ToString().Trim());
				numeroDTXT.Text = proveedorGDV.Rows[fila].Cells[3].Value.ToString().Trim();
				txtCorreo.Text = proveedorGDV.Rows[fila].Cells[4].Value.ToString().Trim();
				txtTelefono.Text = proveedorGDV.Rows[fila].Cells[5].Value.ToString().Trim();
				direccionTXT.Text = proveedorGDV.Rows[fila].Cells[6].Value.ToString().Trim();
				estadoCBX.SelectedIndex = estadoCBX.FindString(proveedorGDV.Rows[fila].Cells[7].Value.ToString().Trim());
			}
		}

		private void consultar()
		{
			controlador.Sql = "SELECT p.idproveedores as 'Id Proveedor', " +
									"p.nombre as Nombre, " +
									"td.nombre as'Nombre TD', " +
									"p.numerodocumento as '# Documento', " +
									"p.correo as Correo, " +
									"p.telefono as Telefono, " +
									"p.direccion as Direccion, " +
									"e.nombreEstado as Estado " +
							  "FROM `proveedores`  as p "+
								" INNER JOIN tipodocumento AS td ON td.idtipoDocumento = p.idtipoducumento " +
								" INNER JOIN estados AS e ON e.idestados = p.idestado";
			proveedorGDV.DataSource = controlador.ConsultarTabla();
			proveedorGDV.Refresh();
		}
		private bool comprobar(bool id)
		{
			bool result = false;
			if (txtID.Text.Trim() != "")
			{
				controlador.Modelo.Idproveedor = int.Parse(txtID.Text.Trim());
				if (txtNombre.Text.Trim() != "")
				{
					controlador.Modelo.Nombre = txtNombre.Text.Trim();
					if (numeroDTXT.Text.Trim() != "")
					{
						controlador.Modelo.NumeroDocumento = int.Parse(numeroDTXT.Text.Trim());
						if (txtCorreo.Text.Trim() != "" || txtCorreo.Text.Trim() == "")
						{
							controlador.Modelo.Correo = txtCorreo.Text.Trim();
							if (txtTelefono.Text.Trim() != "" || txtTelefono.Text.Trim() == "")
							{
								controlador.Modelo.Telefono = int.Parse(txtTelefono.Text.Trim());								
								if (direccionTXT.Text.Trim() != "" || direccionTXT.Text.Trim() == "")
								{
										controlador.Modelo.Direccion = direccionTXT.Text.Trim();
										result = true;
										controlador.Modelo.Idestado = int.Parse(estadoCBX.SelectedValue.ToString());
										controlador.Modelo.IdTipoDocumento = int.Parse(tipoDCBX.SelectedValue.ToString());

								}
							}
						}
					}
				}
			}

			if (id)
			{
				if (int.Parse(txtID.Text.Trim()) <= 0)
				{
					result = false;
				}
			}
			else
			{
				if (int.Parse(txtID.Text.Trim()) > 0)
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
			txtID.Text = "0";
			txtNombre.Text = "";
			numeroDTXT.Text = "";
			txtCorreo.Text = "";
			txtTelefono.Text = "";
			direccionTXT.Text = "";
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

		private void modificar()
		{
			if (comprobar(true))
			{
				if (Validador.Pregunta("Desea Modificar el proveedor \n " + txtNombre.Text, "Esta Seguro?"))
				{
					if (controlador.Modificar())
					{
						limpiar();
						consultar();
					}
				}
			}
		}

		private void eliminar()
		{
			if (comprobar(true))
			{
				if (Validador.Pregunta("Desea Eliminar el proveedor \n " + txtNombre.Text, "Esta Seguro?"))
				{
					if (controlador.Eliminar())
					{
						limpiar();
						consultar();
					}
				}
			}
		}

		private void Crear_Proveedor_Load(object sender, EventArgs e)
		{

		}

		private void proveedorGDV_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			seleccionar();
		}

		private void buttonGuardar_Click(object sender, EventArgs e)
		{
			guardar();
		}

		private void buttonElminar_Click(object sender, EventArgs e)
		{
			eliminar();
		}

		private void buttonModificar_Click(object sender, EventArgs e)
		{
			modificar();
		}

		private void buttonLimpiar_Click(object sender, EventArgs e)
		{
			limpiar();
		}

		private void buttonConsultar_Click(object sender, EventArgs e)
		{
			consultar();
		}

		private void txtCorreo_TextChanged(object sender, EventArgs e)
		{
			Validador.ValidarCorreo(txtCorreo.Text);
		}

		private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
		{
			
		}

		private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
		{
			Validador.ValidarNumero(txtTelefono, e, 100);
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void txtTelefono_TextChanged(object sender, EventArgs e)
		{

		}

		private void numeroDTXT_TextChanged(object sender, EventArgs e)
		{

		}

		private void numeroDTXT_KeyPress(object sender, KeyPressEventArgs e)
		{
			Validador.ValidarNumero(numeroDTXT, e, 100);
		}
	}
}
