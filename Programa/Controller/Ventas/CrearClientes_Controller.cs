using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programa.Modelos.Ventas;

namespace Programa.Controller.Ventas
{
	class CrearClientes_Controller : Controller
	{
		private CrearClientes_Modelo modelo;
		private string tabla;

		public CrearClientes_Controller()
		{
			modelo = new CrearClientes_Modelo();
			tabla = "clientes";
		}

		public string Tabla { get => tabla; set => tabla = value; }
		internal CrearClientes_Modelo Modelo { get => modelo; set => modelo = value; }

		public override bool Eliminar()
		{
			string sql = GenerarEliminarSql(tabla, new Parametro("idclientes", modelo.Idcliente.ToString()));
			return ExecuteQuery(sql, -1);
		}

		public override bool Guardar()
		{
			List<Parametro> parametros = new List<Parametro>();
			parametros.Add(new Parametro("nombre", modelo.Nombre, 0));
			parametros.Add(new Parametro("idtipodocumento", modelo.IdtipoDocumento.ToString()));
			parametros.Add(new Parametro("numerodocumento", modelo.NumeroDocumento.ToString()));
			parametros.Add(new Parametro("correo", modelo.Correo, 0));
			parametros.Add(new Parametro("telefono", modelo.Telefono.ToString()));
			parametros.Add(new Parametro("direccion", modelo.Direccion, 0));
			parametros.Add(new Parametro("idestado", modelo.Idestado.ToString()));
			string sql = GenerarInsertarSql(tabla, parametros);
			return ExecuteQuery(sql, 0);
		}

		public override bool Modificar()
		{
			List<Parametro> parametros = new List<Parametro>();
			parametros.Add(new Parametro("nombre", modelo.Nombre, 0));
			parametros.Add(new Parametro("idtipodocumento", modelo.IdtipoDocumento.ToString()));
			parametros.Add(new Parametro("numerodocumento", modelo.NumeroDocumento.ToString()));
			parametros.Add(new Parametro("correo", modelo.Correo, 0));
			parametros.Add(new Parametro("telefono", modelo.Telefono.ToString()));
			parametros.Add(new Parametro("direccion", modelo.Direccion, 0));
			parametros.Add(new Parametro("idestado", modelo.Idestado.ToString()));

			string sql = GenerarActualizarSql(tabla, parametros, new Parametro("idclientes", modelo.Idcliente.ToString()));
			return ExecuteQuery(sql, 1);
		}
	}
}
