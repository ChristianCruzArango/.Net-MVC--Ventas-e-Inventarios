using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programa.Controller.Articulos;

namespace Programa.Modulos.Articulos
{
	public partial class Crear_Categorias : Form
	{
		private CrearCategoria_Controller controlador;
		public Crear_Categorias()
		{
			InitializeComponent();
			controlador = new CrearCategoria_Controller();
			txtID.ReadOnly = true;
			txtID.Text = "0";			
			estadoCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			llenarComboEstados();			
			categoriaDGV.ReadOnly = true;
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

		private void seleccionar()
		{
			int fila = int.Parse(categoriaDGV.CurrentCell.RowIndex.ToString().Trim());//obtenemos fila
			if (categoriaDGV.Rows[fila].Cells[0].Value.ToString().Trim() != "")
			{
				txtID.Text = categoriaDGV.Rows[fila].Cells[0].Value.ToString().Trim();				
				txtNombre.Text = categoriaDGV.Rows[fila].Cells[1].Value.ToString().Trim();
				descripcionTXT.Text = categoriaDGV.Rows[fila].Cells[2].Value.ToString().Trim();
				estadoCBX.SelectedIndex = estadoCBX.FindString(categoriaDGV.Rows[fila].Cells[3].Value.ToString().Trim());
			}
		}

		private bool comprobar(bool id)
		{
			bool result = false;
			if (txtID.Text.Trim() != "")
			{
				controlador.Modelo.Idcategoria = int.Parse(txtID.Text.Trim());
				if (txtNombre.Text.Trim() != "")
				{
					controlador.Modelo.Nombre = txtNombre.Text.Trim();
					if (descripcionTXT.Text.Trim() != "")
					{
						controlador.Modelo.Descripcion = descripcionTXT.Text.Trim();						
						controlador.Modelo.Idestado = int.Parse(estadoCBX.SelectedValue.ToString());
						result = true;
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


		private void consultar()
		{
			controlador.Sql = "SELECT c.idcategoria as 'Id Categoria'," +
								"c.nombre as Nombre," +
								"c.descripcion as Descripcion," +
								"e.nombreEstado as Estado " +
							  "FROM categoria as c "+
                                "INNER JOIN estados as e ON e.idestados = c.idestado";
			categoriaDGV.DataSource = controlador.ConsultarTabla();
			categoriaDGV.Refresh();
		}

		private void limpiar()
		{
			txtID.Text = "0";
			txtNombre.Text = "";
			descripcionTXT.Text = "";			
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
				if (Validador.Pregunta("Dese Modificar la categoría \n " + txtNombre.Text, "Esta Seguro?"))
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
				if (Validador.Pregunta("Dese Eliminar la categoría \n " + txtNombre.Text, "Esta Seguro?"))
				{
					if (controlador.Eliminar())
					{
						limpiar();
						consultar();
					}
				}
			}
		}



		private void Crear_Categorias_Load(object sender, EventArgs e)
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

		private void categoriaDGV_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			seleccionar();
		}

		private void txtID_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
