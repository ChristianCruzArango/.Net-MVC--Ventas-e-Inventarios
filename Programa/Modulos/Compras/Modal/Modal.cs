using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programa.Modulos.Articulos;
using Programa.Controller.Articulos;


namespace Programa.Modulos.Compras.Modal
{
	public partial class Modal : Form
	{
		private CrearArticulo_Controller controlador;	
		
			
		public Modal()
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
								  "a.precio_compra as 'Precio Compra'," +								  
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

				Crear_Ingresos frmi = Owner as Crear_Ingresos;

				string A = this.productosGDV.CurrentRow.Cells[0].Value.ToString().Trim(); 
				string B = this.productosGDV.CurrentRow.Cells[1].Value.ToString().Trim();


				frmi.productoGTV.Rows.Add(A, B);			
				
			}
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

		private void productosGDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void BarraTitulo_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
