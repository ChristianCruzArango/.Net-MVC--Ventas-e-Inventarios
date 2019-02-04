using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programa.Modelos.Bancos;

namespace Programa.Controller.Banco
{
	class CrearDivisa_Controller : Controller
	{
		private CrearDivisas_Modelo modelo;
		private string tabla;

		public CrearDivisa_Controller()
		{
			modelo = new CrearDivisas_Modelo();
			tabla = "divisa";
		}

		public string Tabla { get => tabla; set => tabla = value; }
		internal CrearDivisas_Modelo Modelo { get => modelo; set => modelo = value; }

		public override bool Eliminar()
		{
			string sql = GenerarEliminarSql(Tabla, new Parametro("iddivisa", modelo.Iddivisa.ToString()));
			return ExecuteQuery(sql, -1);
		}

		public override bool Guardar()
		{
			
			List<Parametro> parametros = new List<Parametro>();			
			parametros.Add(new Parametro("nombreDivisa", modelo.NombreDivisa, 0));
			parametros.Add(new Parametro("simboloDivisa", modelo.SimboloDivisa, 0));			
			string sql = GenerarInsertarSql(Tabla, parametros);
			return ExecuteQuery(sql, 0);
		}

		public override bool Modificar()
		{
			List<Parametro> parametros = new List<Parametro>();
			parametros.Add(new Parametro("nombreDivisa", modelo.NombreDivisa, 0));
			parametros.Add(new Parametro("simboloDivisa", modelo.SimboloDivisa, 0));

			string sql = GenerarActualizarSql(tabla, parametros, new Parametro("iddivisa", modelo.Iddivisa.ToString()));
			return ExecuteQuery(sql, 1);
		}
	}
}
