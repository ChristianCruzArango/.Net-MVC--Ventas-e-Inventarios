using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programa.Modelos.Compras;


namespace Programa.Controller.Compras
{
	class CrearIngresos_Controller : Controller
	{
		private CrearIngresos_Modelo modelo;		
		private string tabla;
		private string tablaDetalle;
		

		public CrearIngresos_Controller()
		{
			modelo = new CrearIngresos_Modelo();
			tabla = "ingresos";
			tablaDetalle = "detalleingresos";
		}

		public string Tabla { get => tabla; set => tabla = value; }
		public string TablaDetalle { get => tablaDetalle; set => tablaDetalle = value; }
		internal CrearIngresos_Modelo Modelo { get => modelo; set => modelo = value; }
	
		

		public override bool Eliminar()
		{
			throw new NotImplementedException();
		}

		public override bool Guardar()
		{
			List<Parametro> parametros = new List<Parametro>();
			parametros.Add(new Parametro("idtipocomprobante", modelo.Idtipocomprobante.ToString()));
			parametros.Add(new Parametro("idproveedor", modelo.Idproveedor.ToString()));
			parametros.Add(new Parametro("seriecomprobante", modelo.Seriecomprobante.ToString()));
			parametros.Add(new Parametro("timbrado", modelo.Timbrado.ToString()));
			parametros.Add(new Parametro("fecha", modelo.Fecha,0));
			parametros.Add(new Parametro("total", modelo.Total.ToString()));			
			parametros.Add(new Parametro("idformapago", modelo.Idformapago.ToString()));
			parametros.Add(new Parametro("idcheque", modelo.Chequedias.ToString()));
			string sql = GenerarInsertarSql(tabla, parametros);
			return ExecuteQuery(sql, 0);
		}
		

		internal void GuardarDetalles(List<CrearIngresos_Modelo> DetalleIngreso)
		{
			List<Parametro> parametros = new List<Parametro>();
			string idingreso = "(select (select idingresos from ingresos order by idingresos desc limit 1) +1)";
			foreach (CrearIngresos_Modelo item in DetalleIngreso)
			{
				parametros.Clear();
				parametros.Add(new Parametro("idingreso", idingreso));				
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
