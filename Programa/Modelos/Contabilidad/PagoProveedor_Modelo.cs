using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa.Modelos.Contabilidad
{
	class PagoProveedor_Modelo
	{
		private int idingreso;
		private double pago;
		private int idformapago;
		private string numerocheque;
		private string fecha;

		public int Idingreso { get => idingreso; set => idingreso = value; }
		public double Pago { get => pago; set => pago = value; }
		public int Idformapago { get => idformapago; set => idformapago = value; }
		public string Numerocheque { get => numerocheque; set => numerocheque = value; }
		public string Fecha { get => fecha; set => fecha = value; }
	}
}
