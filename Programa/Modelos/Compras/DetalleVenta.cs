using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa.Modelos.Compras
{
	class DetalleVenta
	{

		private int idingreso;
		private int idarticulo;
		private double precio;
		private int cantidad;

		public DetalleVenta()
		{
		}

		public DetalleVenta( int idIngreso, int idArticulo,double precio, int stockInicial)
		{			
			Idingreso = idIngreso;
			Idarticulo = idArticulo;
			Precio = precio;
			Cantidad = stockInicial;			
		}

		public int Idingreso { get => idingreso; set => idingreso = value; }
		public int Idarticulo { get => idarticulo; set => idarticulo = value; }
		public double Precio { get => precio; set => precio = value; }
		public int Cantidad { get => cantidad; set => cantidad = value; }
	}
}
