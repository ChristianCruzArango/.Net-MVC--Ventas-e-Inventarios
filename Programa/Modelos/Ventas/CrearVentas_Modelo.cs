using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa.Modelos.Ventas
{
	class CrearVentas_Modelo
	{
		private int idventa;
		private int idtipocomprobante;
		private int idcliente;
		private int seriecomprobante;
		private int timbrado;
		private string fecha;
		private int idestado;
		private int idformapago;
		private int numeroCheque;
		private double total;
		private int chequedias;

		private int idarticuloDetalleVenta;
		private int cantidadDetalleVenta;
		private double precioDetalleVenta;

		
		public int Idtipocomprobante { get => idtipocomprobante; set => idtipocomprobante = value; }
		public int Idcliente { get => idcliente; set => idcliente = value; }
		public int Seriecomprobante { get => seriecomprobante; set => seriecomprobante = value; }
		public int Timbrado { get => timbrado; set => timbrado = value; }
		public string Fecha { get => fecha; set => fecha = value; }
		public int Idestado { get => idestado; set => idestado = value; }
		public int Idformapago { get => idformapago; set => idformapago = value; }
		
		public double Total { get => total; set => total = value; }
		public int Chequedias { get => chequedias; set => chequedias = value; }
		public int IdarticuloDetalleVenta { get => idarticuloDetalleVenta; set => idarticuloDetalleVenta = value; }
		public int CantidadDetalleVenta { get => cantidadDetalleVenta; set => cantidadDetalleVenta = value; }
		public double PrecioDetalleVenta { get => precioDetalleVenta; set => precioDetalleVenta = value; }
		public int Idventa { get => idventa; set => idventa = value; }
		public int NumeroCheque { get => numeroCheque; set => numeroCheque = value; }
	}
}
