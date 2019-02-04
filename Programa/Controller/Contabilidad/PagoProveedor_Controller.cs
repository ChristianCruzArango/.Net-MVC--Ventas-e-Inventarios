using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programa.Modelos.Contabilidad;

namespace Programa.Controller.Contabilidad
{
	class PagoProveedor_Controller : Controller
	{
		private PagoProveedor_Modelo modelo;
		private string tabla;

		public PagoProveedor_Controller()
		{
			modelo = new PagoProveedor_Modelo();
			tabla = "pagoproveedores";
		}

		public string Tabla { get => tabla; set => tabla = value; }
		internal PagoProveedor_Modelo Modelo { get => modelo; set => modelo = value; }

		public override bool Eliminar()
		{
			throw new NotImplementedException();
		}

		public override bool Guardar()
		{
			List<Parametro> parametros = new List<Parametro>();
			parametros.Add(new Parametro("idingreso", modelo.Idingreso.ToString()));
			parametros.Add(new Parametro("pago", modelo.Pago.ToString()));
			parametros.Add(new Parametro("idformapago", modelo.Idformapago.ToString()));
			parametros.Add(new Parametro("numerocheque", modelo.Numerocheque.ToString()));
			parametros.Add(new Parametro("fecha", modelo.Fecha.ToString()));	
			string sql = GenerarInsertarSql(tabla, parametros);
			return ExecuteQuery(sql, 0);
		}

		public override bool Modificar()
		{
			throw new NotImplementedException();
		}
	}
}
