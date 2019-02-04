using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programa.Controller.Ventas;

namespace Programa.Modulos.Ventas
{
	public partial class Crear_Clientes : Form
	{
		private CrearClientes_Controller controlador;
		public Crear_Clientes()
		{
			InitializeComponent();
			controlador = new CrearClientes_Controller();
			txtID.ReadOnly = true;
			txtID.Text = "0";
			tipoDCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			estadoCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			llenarComboTipoDocumento();
			llenarComboEstados();
			clientesGDV.ReadOnly = true;
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
			int fila = int.Parse(clientesGDV.CurrentCell.RowIndex.ToString().Trim());//obtenemos fila
			if (clientesGDV.Rows[fila].Cells[0].Value.ToString().Trim() != "")
			{
				txtID.Text = clientesGDV.Rows[fila].Cells[0].Value.ToString().Trim();
				txtNombre.Text = clientesGDV.Rows[fila].Cells[1].Value.ToString().Trim();
				tipoDCBX.SelectedIndex = tipoDCBX.FindString(clientesGDV.Rows[fila].Cells[2].Value.ToString().Trim());
				numeroDTXT.Text = clientesGDV.Rows[fila].Cells[3].Value.ToString().Trim();
				txtCorreo.Text = clientesGDV.Rows[fila].Cells[4].Value.ToString().Trim();
				txtTelefono.Text = clientesGDV.Rows[fila].Cells[5].Value.ToString().Trim();
				direccionTXT.Text = clientesGDV.Rows[fila].Cells[6].Value.ToString().Trim();
				estadoCBX.SelectedIndex = estadoCBX.FindString(clientesGDV.Rows[fila].Cells[7].Value.ToString().Trim());
			}
		}

		private void consultar()
		{
			controlador.Sql = "SELECT c.idclientes as 'Id Cliente', " +
									"c.nombre as Nombre, " +
									"td.nombre as'Nombre TD', " +
									"c.numerodocumento as '# Documento', " +
									"c.correo as Correo, " +
									"c.telefono as Telefono, " +
									"c.direccion as Direccion, " +
									"e.nombreEstado as Estado " +
							  "FROM `clientes`  as c " +
								" INNER JOIN tipodocumento AS td ON td.idtipoDocumento = c.idtipodocumento " +
								" INNER JOIN estados AS e ON e.idestados = c.idestado";
			clientesGDV.DataSource = controlador.ConsultarTabla();
			clientesGDV.Refresh();
		}

		private bool comprobar(bool id)
		{
			bool result = false;
			if (txtID.Text.Trim() != "")
			{
				controlador.Modelo.Idcliente = int.Parse(txtID.Text.Trim());
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
									controlador.Modelo.IdtipoDocumento = int.Parse(tipoDCBX.SelectedValue.ToString());

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
				if (Validador.Pregunta("Desea Modificar el cliente \n " + txtNombre.Text, "Esta Seguro?"))
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
				if (Validador.Pregunta("Desea Eliminar el cliente \n " + txtNombre.Text, "Esta Seguro?"))
				{
					if (controlador.Eliminar())
					{
						limpiar();
						consultar();
					}
				}
			}
		}

		private void Crear_Clientes_Load(object sender, EventArgs e)
		{

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

		private void clientesGDV_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			seleccionar();
		}

		private void numeroDTXT_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
		{
			Validador.ValidarNumero(txtTelefono,e,10);
		}
	}
}
