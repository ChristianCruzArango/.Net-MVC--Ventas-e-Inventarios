using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa.Modelos.Articulos
{
	class CrearArticulo_Modelo
	{

		private int idarticulo;
		private int idcategoria;
		private string nombre;
		private string descripcion;		
		private double precio_venta;
		private int idestado;

		public int Idarticulo { get => idarticulo; set => idarticulo = value; }
		public int Idcategoria { get => idcategoria; set => idcategoria = value; }
		public string Nombre { get => nombre; set => nombre = value; }
		public string Descripcion { get => descripcion; set => descripcion = value; }
		public double Precio_venta { get => precio_venta; set => precio_venta = value; }
		public int Idestado { get => idestado; set => idestado = value; }
	}
}
