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
	public partial class Crear_Articulos : Form
	{
		private CrearArticulo_Controller controlador;
		public Crear_Articulos()
		{
			InitializeComponent();
			controlador = new CrearArticulo_Controller();
			IdTXT.ReadOnly = true;
			IdTXT.Text = "0";
			categoriaCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			estadoCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			llenarComboEstados();
			llenarComboCategorias();
			articulosGRV.ReadOnly = true;
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

		private void llenarComboCategorias()
		{
			controlador.Sql = "select idcategoria,nombre from categoria where idestado=6";
			categoriaCBX.DataSource = controlador.ConsultarTabla();
			categoriaCBX.DisplayMember = "nombre".Trim();
			categoriaCBX.ValueMember = "idcategoria".Trim();
			categoriaCBX.Refresh();
		}

		private void seleccionar()
		{
			int fila = int.Parse(articulosGRV.CurrentCell.RowIndex.ToString().Trim());//obtenemos fila
			if (articulosGRV.Rows[fila].Cells[0].Value.ToString().Trim() != "")
			{
				IdTXT.Text = articulosGRV.Rows[fila].Cells[0].Value.ToString().Trim();
				nombreTXT.Text = articulosGRV.Rows[fila].Cells[1].Value.ToString().Trim();
				categoriaCBX.SelectedIndex =	categoriaCBX.FindString(articulosGRV.Rows[fila].Cells[2].Value.ToString().Trim());				
				descripcionTXT.Text = articulosGRV.Rows[fila].Cells[3].Value.ToString().Trim();
				precioVentaTXT.Text = articulosGRV.Rows[fila].Cells[4].Value.ToString().Trim();
				estadoCBX.SelectedIndex = estadoCBX.FindString(articulosGRV.Rows[fila].Cells[5].Value.ToString().Trim());
			}
		}

		private void consultar()
		{
			controlador.Sql = "SELECT idarticulos as 'Id Articulo'," +
								  "a.nombre as 'Nombre'," +
								  "c.nombre as 'Nombre Categria'," +
								  "a.descripcion as Descripcion," +
								  "a.precio_venta as 'Precio Venta'," +
								  "a.precio_compra as 'Precio Compra'," +				
								  "e.nombreEstado as 'Estado', " +
								  "a.stock as 'Stock' " +
							  "FROM `articulos` as a " +
								"INNER JOIN categoria as c ON a.idcategoria = c.idcategoria "+
								"INNER JOIN estados as e ON a.idestado = e.idestados";
			articulosGRV.DataSource = controlador.ConsultarTabla();
			articulosGRV.Refresh();
		}

		private bool comprobar(bool id)
		{
			bool result = false;
			if (IdTXT.Text.Trim() != "")
			{
				controlador.Modelo.Idarticulo = int.Parse(IdTXT.Text.Trim());
				if (nombreTXT.Text.Trim() != "")
				{
					controlador.Modelo.Nombre = nombreTXT.Text.Trim();
					if (descripcionTXT.Text.Trim() != "")
					{
						controlador.Modelo.Descripcion = descripcionTXT.Text.Trim();
						if (precioVentaTXT.Text.Trim() != "")
						{
							controlador.Modelo.Precio_venta = int.Parse(precioVentaTXT.Text.Trim());
							result = true;
							controlador.Modelo.Idestado = int.Parse(estadoCBX.SelectedValue.ToString());
							controlador.Modelo.Idcategoria = int.Parse(categoriaCBX.SelectedValue.ToString());

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
			nombreTXT.Text = "";
			descripcionTXT.Text = "";
			precioVentaTXT.Text = "";
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
				if (Validador.Pregunta("Desea Modificar el Artículo \n " + nombreTXT.Text, "Esta Seguro?"))
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
				if (Validador.Pregunta("Desea Eliminar el Artículo \n " + nombreTXT.Text, "Esta Seguro?"))
				{
					if (controlador.Eliminar())
					{
						limpiar();
						consultar();
					}
				}
			}
		}


		private void Crear_Articulos_Load(object sender, EventArgs e)
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

		private void precioVentaTXT_TextChanged(object sender, EventArgs e)
		{

		}

		private void precioVentaTXT_KeyPress(object sender, KeyPressEventArgs e)
		{
			Validador.ValidarNumero(precioVentaTXT, e, 100);
		}

		private void articulosGRV_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			seleccionar();
		}

		private void articulosGRV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void categoriaCBX_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
