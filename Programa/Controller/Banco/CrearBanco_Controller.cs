using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programa.Modelos.Bancos;

namespace Programa.Controller.Banco
{
	class CrearBanco_Controller : Controller
	{

		private CrearBanco_Modelo modelo;
		private string tabla;

		public CrearBanco_Controller()
		{
			modelo = new CrearBanco_Modelo();
			tabla = "bancos";
		}

		public string Tabla { get => tabla; set => tabla = value; }
		internal CrearBanco_Modelo Modelo { get => modelo; set => modelo = value; }

		public override bool Eliminar()
		{
			string sql = GenerarEliminarSql(Tabla, new Parametro("idbancos", modelo.Idbancos.ToString()));
			return ExecuteQuery(sql, -1);
		}

		public override bool Guardar()
		{
			List<Parametro> parametros = new List<Parametro>();
			parametros.Add(new Parametro("nombre", modelo.Nombre, 0));
			parametros.Add(new Parametro("numerocuenta", modelo.Numerocuenta.ToString()));
			string sql = GenerarInsertarSql(Tabla, parametros);
			return ExecuteQuery(sql, 0);
		}

		public override bool Modificar()
		{
			List<Parametro> parametros = new List<Parametro>();
			parametros.Add(new Parametro("nombre", modelo.Nombre, 0));
			parametros.Add(new Parametro("numerocuenta", modelo.Numerocuenta.ToString()));

			string sql = GenerarActualizarSql(tabla, parametros, new Parametro("idbancos", modelo.Idbancos.ToString()));
			return ExecuteQuery(sql, 1);
		}
	}
}
