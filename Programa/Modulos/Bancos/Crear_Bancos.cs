using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programa.Controller.Banco;

namespace Programa.Modulos.Bancos
{
	public partial class Crear_Bancos : Form
	{
		private CrearBanco_Controller controlador;
		public Crear_Bancos()
		{
			InitializeComponent();
			controlador = new CrearBanco_Controller();
			IdTXT.ReadOnly = true;
			IdTXT.Text = "0";
			bancosGridV.ReadOnly = true;
			this.CenterToScreen();
		}

		private void seleccionar()
		{
			int fila = int.Parse(bancosGridV.CurrentCell.RowIndex.ToString().Trim());//obtenemos fila
			if (bancosGridV.Rows[fila].Cells[0].Value.ToString().Trim() != "")
			{
				IdTXT.Text = bancosGridV.Rows[fila].Cells[0].Value.ToString().Trim();
				nombrebancoTBT.Text = bancosGridV.Rows[fila].Cells[1].Value.ToString().Trim();
				numerocuentaTBT.Text = bancosGridV.Rows[fila].Cells[2].Value.ToString().Trim();
			}
		}

		private void consultar()
		{
			controlador.Sql = "SELECT * FROM bancos";
			bancosGridV.DataSource = controlador.ConsultarTabla();
			bancosGridV.Refresh();
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
		private bool comprobar(bool id)
		{
			bool result = false;
			if (IdTXT.Text.Trim() != "")
			{
				controlador.Modelo.Idbancos = int.Parse(IdTXT.Text.Trim());
				if (nombrebancoTBT.Text.Trim() != "")
				{
					controlador.Modelo.Nombre = nombrebancoTBT.Text.Trim();
					if (numerocuentaTBT.Text.Trim() != "")
					{
						controlador.Modelo.Numerocuenta = int.Parse(numerocuentaTBT.Text.Trim());
						result = true;
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
			nombrebancoTBT.Text = "";
			numerocuentaTBT.Text = "";
		}

		private void modificar()
		{
			if (comprobar(true))
			{
				if (Validador.Pregunta("Dese Modificar el banco \n " + nombrebancoTBT.Text, "Esta Seguro?"))
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
				if (Validador.Pregunta("Desea Eliminar el banco \n " + nombrebancoTBT.Text, "Esta Seguro?"))
				{
					if (controlador.Eliminar())
					{
						limpiar();
						consultar();
					}
				}
			}
		}


		private void btnCerrarPB_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void simbolodivisaTBT_TextChanged(object sender, EventArgs e)
		{

		}

		private void buttonConsultar_Click(object sender, EventArgs e)
		{
			consultar();
		}

		private void buttonLimpiar_Click(object sender, EventArgs e)
		{
			limpiar();
		}

		private void buttonModificar_Click(object sender, EventArgs e)
		{
			modificar();
		}

		private void buttonElminar_Click(object sender, EventArgs e)
		{
			eliminar();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			guardar();
		}

		private void bancosGridV_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			seleccionar();
		}
	}
}
