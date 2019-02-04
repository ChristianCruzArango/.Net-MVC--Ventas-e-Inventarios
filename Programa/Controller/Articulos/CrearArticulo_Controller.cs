using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programa.Modelos.Articulos;

namespace Programa.Controller.Articulos
{
	class CrearArticulo_Controller : Controller
	{
		private CrearArticulo_Modelo modelo;
		private string tabla;

		public CrearArticulo_Controller()
		{
			modelo = new CrearArticulo_Modelo();
			Tabla = "articulos";
		}
		public string Tabla { get => tabla; set => tabla = value; }
		internal CrearArticulo_Modelo Modelo { get => modelo; set => modelo = value; }

		public override bool Eliminar()
		{
			string sql = GenerarEliminarSql(Tabla, new Parametro("idarticulos", modelo.Idarticulo.ToString()));
			return ExecuteQuery(sql, -1);
		}
		public override bool Guardar()
		{
			int stock = 0;
			List<Parametro> parametros = new List<Parametro>();
			parametros.Add(new Parametro("idcategoria", modelo.Idcategoria.ToString()));
			parametros.Add(new Parametro("nombre", modelo.Nombre, 0));
			parametros.Add(new Parametro("descripcion", modelo.Descripcion, 0));
			parametros.Add(new Parametro("stock", stock.ToString()));
			parametros.Add(new Parametro("precio_venta", modelo.Precio_venta.ToString()));			
			parametros.Add(new Parametro("idestado", modelo.Idestado.ToString()));
			string sql = GenerarInsertarSql(Tabla, parametros);
			return ExecuteQuery(sql, 0);
		}

		public override bool Modificar()
		{
			List<Parametro> parametros = new List<Parametro>();
			parametros.Add(new Parametro("idcategoria", modelo.Idcategoria.ToString()));
			parametros.Add(new Parametro("nombre", modelo.Nombre, 0));
			parametros.Add(new Parametro("descripcion", modelo.Descripcion, 0));
			parametros.Add(new Parametro("precio_venta", modelo.Precio_venta.ToString()));
			parametros.Add(new Parametro("idestado", modelo.Idestado.ToString()));

			string sql = GenerarActualizarSql(tabla, parametros, new Parametro("idarticulos", modelo.Idarticulo.ToString()));
			return ExecuteQuery(sql, 1);
		}

	}
}
