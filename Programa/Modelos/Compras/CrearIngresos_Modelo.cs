using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programa.Modelos.Compras;
using Programa.Controller.Compras;

namespace Programa.Modelos.Compras
{
	class CrearIngresos_Modelo
	{
		private int idingreso;
		private int idtipocomprobante;
		private int idproveedor;
		private int seriecomprobante;
		private int timbrado;
		private string fecha;
		private int idestado;
		private int idformapago;
		private int idcheque;
		private double total;
		private int chequedias;

		private int idarticuloDetalleVenta;
		private int cantidadDetalleVenta;
		private double precioDetalleVenta;	




		public int Idingreso { get => idingreso; set => idingreso = value; }
		public int Idtipocomprobante { get => idtipocomprobante; set => idtipocomprobante = value; }
		public int Idproveedor { get => idproveedor; set => idproveedor = value; }
		public int Seriecomprobante { get => seriecomprobante; set => seriecomprobante = value; }
		public int Timbrado { get => timbrado; set => timbrado = value; }
		public string Fecha { get => fecha; set => fecha = value; }
		public int Idestado { get => idestado; set => idestado = value; }
		public int Idformapago { get => idformapago; set => idformapago = value; }
		public int Idcheque { get => idcheque; set => idcheque = value; }
		public double Total { get => total; set => total = value; }		
		public int Chequedias { get => chequedias; set => chequedias = value; }
		public int IdarticuloDetalleVenta { get => idarticuloDetalleVenta; set => idarticuloDetalleVenta = value; }
		public int CantidadDetalleVenta { get => cantidadDetalleVenta; set => cantidadDetalleVenta = value; }
		public double PrecioDetalleVenta { get => precioDetalleVenta; set => precioDetalleVenta = value; }
		
	}
}
