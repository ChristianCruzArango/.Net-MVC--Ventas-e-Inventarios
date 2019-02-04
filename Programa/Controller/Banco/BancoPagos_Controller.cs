using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programa.Modelos.Bancos;

namespace Programa.Controller.Banco
{
	class BancoPagos_Controller : Controller
	{
		private BancoPagos_Modelo modelo;
		private string tabla;

		public BancoPagos_Controller()
		{
			modelo = new BancoPagos_Modelo();
			tabla = "bancopago";
		}

		public string Tabla { get => tabla; set => tabla = value; }
		internal BancoPagos_Modelo Modelo { get => modelo; set => modelo = value; }

		public override bool Eliminar()
		{
			throw new NotImplementedException();
		}

		public override bool Guardar()
		{
			List<Parametro> parametros = new List<Parametro>();
			parametros.Add(new Parametro("idingreso", modelo.Idingreso.ToString()));
			parametros.Add(new Parametro("fecha", modelo.Fecha.ToString()));
			parametros.Add(new Parametro("total", modelo.Total.ToString()));
			parametros.Add(new Parametro("idbancos", modelo.Idbancopago.ToString()));
			parametros.Add(new Parametro("iddivisa", modelo.Iddivsa.ToString()));
			parametros.Add(new Parametro("idtipocuenta", modelo.Idtipocuenta.ToString()));
			string sql = GenerarInsertarSql(tabla, parametros);
			return ExecuteQuery(sql, 0);
		}

		public override bool Modificar()
		{
			throw new NotImplementedException();
		}
	}
}
