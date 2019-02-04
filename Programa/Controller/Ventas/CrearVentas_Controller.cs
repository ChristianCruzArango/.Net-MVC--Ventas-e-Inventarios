using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programa.Modelos.Ventas;

namespace Programa.Controller.Ventas
{
	class CrearVentas_Controller : Controller
	{
		private CrearVentas_Modelo modelo;
		private string tabla;
		private string tablaDetalle;

		public CrearVentas_Controller()
		{
			modelo = new CrearVentas_Modelo();
			tabla = "ventas";
			tablaDetalle = "detalleventa";

		}

		public string Tabla { get => tabla; set => tabla = value; }
		public string TablaDetalle { get => tablaDetalle; set => tablaDetalle = value; }
		internal CrearVentas_Modelo Modelo { get => modelo; set => modelo = value; }

		public override bool Eliminar()
		{
			throw new NotImplementedException();
		}

		public override bool Guardar()
		{
			List<Parametro> parametros = new List<Parametro>();
			parametros.Add(new Parametro("idtipocomprobante", modelo.Idtipocomprobante.ToString()));
			parametros.Add(new Parametro("idcliente", modelo.Idcliente.ToString()));
			parametros.Add(new Parametro("seriecomprobante", modelo.Seriecomprobante.ToString()));
			parametros.Add(new Parametro("timbrado", modelo.Timbrado.ToString()));
			parametros.Add(new Parametro("fecha", modelo.Fecha, 0));
			parametros.Add(new Parametro("total", modelo.Total.ToString()));
			parametros.Add(new Parametro("idformapago", modelo.Idformapago.ToString()));
			parametros.Add(new Parametro("numerocheque", modelo.NumeroCheque.ToString()));
			string sql = GenerarInsertarSql(tabla, parametros);
			return ExecuteQuery(sql, 0);
		}
		internal void GuardarDetalles(List<CrearVentas_Modelo> DetalleIngreso)
		{
			List<Parametro> parametros = new List<Parametro>();
			string idingreso = "(select (select idventa from ventas order by idventa desc limit 1) +1)";
			foreach (CrearVentas_Modelo item in DetalleIngreso)
			{
				parametros.Clear();
				parametros.Add(new Parametro("idventa", idingreso));
				parametros.Add(new Parametro("idarticulo", item.IdarticuloDetalleVenta.ToString()));
				parametros.Add(new Parametro("cantidad", item.CantidadDetalleVenta.ToString()));
				parametros.Add(new Parametro("precio", item.PrecioDetalleVenta.ToString()));
				string sql = GenerarInsertarSql(tablaDetalle, parametros);
				ExecuteQuery(sql, 0);
			}

		}

		public override bool Modificar()
		{
			throw new NotImplementedException();
		}
	}
}
