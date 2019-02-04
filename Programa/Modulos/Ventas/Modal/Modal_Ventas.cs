using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programa.Modelos.Ventas;
using Programa.Modulos.Articulos;
using Programa.Controller.Articulos;

namespace Programa.Modulos.Ventas.Modal
{
	public partial class Modal_Ventas : Form
	{
		private CrearArticulo_Controller controlador;
		public Modal_Ventas()
		{
			InitializeComponent();
			controlador = new CrearArticulo_Controller();
			productosGDV.ReadOnly = true;
		}

		private void consultar()
		{
			controlador.Sql = "SELECT idarticulos as 'Id Articulo'," +
								  "a.nombre as 'Nombre'," +
								  "a.precio_venta as 'Precio Venta'," +								  
								  "a.stock as 'Stock' " +
							  "FROM `articulos` as a " +
								"WHERE a.idestado = 6";
			productosGDV.DataSource = controlador.ConsultarTabla();
			productosGDV.Refresh();
		}

		private void seleccionar()
		{

			int fila = int.Parse(productosGDV.CurrentCell.RowIndex.ToString().Trim());
			if (productosGDV.Rows[fila].Cells[0].Value.ToString().Trim() != "")
			{
				Ventas frmVentas = Owner as Ventas;

				string A = this.productosGDV.CurrentRow.Cells[0].Value.ToString().Trim();
				string B = this.productosGDV.CurrentRow.Cells[1].Value.ToString().Trim();
				string C = this.productosGDV.CurrentRow.Cells[2].Value.ToString().Trim();

				frmVentas.productoGTV.Rows.Add(A, B,C);

			}
		}





		private void BarraTitulo_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnCerrarPB_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void productosGDV_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			seleccionar();
		}

		private void buttonConsultar_Click(object sender, EventArgs e)
		{
			consultar();
		}
	}
}
