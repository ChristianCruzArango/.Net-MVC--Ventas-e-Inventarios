using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa.Modulos.Bancos.Cheque
{
	public partial class Cheque : Form
	{
		Bitmap imagen;
		private Button botonImprimir = new Button();
		private PrintDocument printDocument1 = new PrintDocument();

		public Cheque()
		{
			InitializeComponent();			
			chequefechaDTP.Value = DateTime.Now;
			botonImprimir.Text = "Imprimir Formulario";
			botonImprimir.Click += new EventHandler(imprimirBTN_Click);
			printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
			this.Controls.Add(botonImprimir);
		}

		private void btnCerrarPB_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		public void ChequeDatos( int serie,int timbrado,string proveedor,double total)
		{
			serieTBT.Text = serie.ToString();
			timbradoTXT.Text = timbrado.ToString();
			proveedorTBT.Text = proveedor;
			totalTBT.Text = total.ToString();
		}

		private void CapturarPantalla()
		{
			Graphics g = this.CreateGraphics();
			Size s = this.Size;
			imagen = new Bitmap(s.Width, s.Height, g);
			Graphics g2 = Graphics.FromImage(imagen);
			g2.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
		}


		private void Cheque_Load(object sender, EventArgs e)
		{

		}

		private void chequefechaDTP_ValueChanged(object sender, EventArgs e)
		{

		}

		private void imprimirBTN_Click(object sender, EventArgs e)
		{
			CapturarPantalla();
			printDocument1.Print();
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.DrawImage(imagen, 0, 0);
		}
	}
}
