using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programa.Modelos.Articulos;

namespace Programa.Controller.Articulos
{
	class CrearCategoria_Controller:Controller
	{
		private CrearCategoria_Modelo modelo;
		private string tabla;

		public CrearCategoria_Controller()
		{
			modelo = new CrearCategoria_Modelo();
			tabla = "categoria";
		}

		public string Tabla { get => tabla; set => tabla = value; }
		internal CrearCategoria_Modelo Modelo { get => modelo; set => modelo = value; }

		public override bool Eliminar()
		{
			string sql = GenerarEliminarSql(tabla, new Parametro("idcategoria", modelo.Idcategoria.ToString()));
			return ExecuteQuery(sql, -1);
		}

		public override bool Guardar()
		{
			List<Parametro> parametros = new List<Parametro>();
			parametros.Add(new Parametro("nombre", modelo.Nombre, 0));
			parametros.Add(new Parametro("descripcion", modelo.Descripcion, 0));
			parametros.Add(new Parametro("idestado", modelo.Idestado.ToString()));
			string sql = GenerarInsertarSql(tabla, parametros);
			return ExecuteQuery(sql, 0);
		}

		public override bool Modificar()
		{
			List<Parametro> parametros = new List<Parametro>();
			parametros.Add(new Parametro("nombre", modelo.Nombre, 0));
			parametros.Add(new Parametro("descripcion", modelo.Descripcion, 0));
			parametros.Add(new Parametro("idestado", modelo.Idestado.ToString()));

			string sql = GenerarActualizarSql(tabla, parametros, new Parametro("idcategoria", modelo.Idcategoria.ToString()));
			return ExecuteQuery(sql, 1);

		}
	}
}
