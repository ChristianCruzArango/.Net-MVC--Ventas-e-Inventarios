using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa.Modelos.Articulos
{
	class CrearCategoria_Modelo
	{
		private int idcategoria;
		private int idestado;
		private string descripcion;
		private string nombre;

		public int Idcategoria { get => idcategoria; set => idcategoria = value; }
		public int Idestado { get => idestado; set => idestado = value; }
		public string Descripcion { get => descripcion; set => descripcion = value; }
		public string Nombre { get => nombre; set => nombre = value; }
	}
}
