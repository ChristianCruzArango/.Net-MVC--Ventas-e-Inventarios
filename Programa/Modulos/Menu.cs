using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Programa.Modulos
{
    public partial class Manu : Form
    {
		
        public Manu()
        {
            InitializeComponent();
			
		}

		
		

		private void btnProductos_Click(object sender, EventArgs e)
        {
            
        }    

		private void Manu_Load(object sender, EventArgs e)
		{

		}

		private void btnCerrarPB_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void BarraTitulo_Paint(object sender, PaintEventArgs e)
		{

		}	
		private void AbrirFormSecondary(object formSecondary)
		{
			if (this.PanelContenedor.Controls.Count > 0)
				this.PanelContenedor.Controls.RemoveAt(0);
			Form fh = formSecondary as Form;
			fh.TopLevel = false;
			fh.Dock = DockStyle.Fill;
			this.PanelContenedor.Controls.Add(fh);
			this.PanelContenedor.Tag = fh;
			fh.Show();

		}

		private void CuentasBTN_Click(object sender, EventArgs e)
		{
			AbrirFormSecondary(new Bancos.Bancos());
		}		

		private void button23_Click(object sender, EventArgs e)
		{

		}

		private void ItemsBTN_Click(object sender, EventArgs e)
		{
			if (ArticulosPN.Visible == true)
			{
				ArticulosPN.Visible = false;
			}
			else
			{
				ArticulosPN.Visible = true;
			}
		}

		private void articulosbnt_Click(object sender, EventArgs e)
		{
			AbrirFormSecondary(new Articulos.Crear_Articulos());
		}

		private void categoriasbtn_Click(object sender, EventArgs e)
		{
			AbrirFormSecondary(new Articulos.Crear_Categorias());
		}

		private void ingresosBTN_Click(object sender, EventArgs e)
		{
			AbrirFormSecondary(new Compras.Crear_Ingresos());
		}

		private void proveedorBTN_Click(object sender, EventArgs e)
		{
			AbrirFormSecondary(new Compras.Crear_Proveedor());
		}

		private void comprasBTN_Click(object sender, EventArgs e)
		{
			if (comprasPN.Visible == true)
			{
				comprasPN.Visible = false;
			}
			else
			{
				comprasPN.Visible = true;
			}
		}

		private void ventasBTN_Click(object sender, EventArgs e)
		{
			if (ventasPN.Visible == true)
			{
				ventasPN.Visible = false;
			}
			else
			{
				ventasPN.Visible = true;
			}
		}

		private void clientesBTN_Click(object sender, EventArgs e)
		{
			AbrirFormSecondary(new Ventas.Crear_Clientes());
		}

		private void subventasBTN_Click(object sender, EventArgs e)
		{
			AbrirFormSecondary(new Ventas.Ventas());
		}

		private void button4_Click(object sender, EventArgs e)
		{
			AbrirFormSecondary(new Ventas.Ventas());
		}

		private void button13_Click(object sender, EventArgs e)
		{
			if (contabilidadPN.Visible == true)
			{
				contabilidadPN.Visible = false;
			}
			else
			{
				contabilidadPN.Visible = true;
			}
		}

		private void PanelContenedor_Click(object sender, EventArgs e)
		{
			
		}

		private void pagoProveedoresBTN_Click(object sender, EventArgs e)
		{
			AbrirFormSecondary(new Contabilidad.PagoProveedor());
		}

		private void PanelContenedor_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pictureBox1_Click_1(object sender, EventArgs e)
		{
			
		}

		private void reportesBTN_Click(object sender, EventArgs e)
		{
			if (reportesPanel.Visible == true)
			{
				reportesPanel.Visible = false;
			}
			else
			{
				reportesPanel.Visible = true;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			AbrirFormSecondary(new Reportes.Articulos.ReporteProductos());
		}

		private void Rentabilidad_Click(object sender, EventArgs e)
		{
			AbrirFormSecondary(new Reportes.Articulos.ReporteRentabilidad());
		}

		private void button1_Click_1(object sender, EventArgs e)
		{

		}

		private void reportecomprasBTN_Click(object sender, EventArgs e)
		{
			if (reportecomprasPanel.Visible == true)
			{
				reportecomprasPanel.Visible = false;
			}
			else
			{
				reportecomprasPanel.Visible = true;
			}
			
		}

		private void ingresosPanel_Click(object sender, EventArgs e)
		{
			AbrirFormSecondary(new Reportes.Compras.ReporteCompras());
		}

		private void bancosBTN_Click(object sender, EventArgs e)
		{
			if (chequePN.Visible == true)
			{
				chequePN.Visible = false;
			}
			else
			{
				chequePN.Visible = true;
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			AbrirFormSecondary(new Bancos.Bancos());
		}
	}
}
