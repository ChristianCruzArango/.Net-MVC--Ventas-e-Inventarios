using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa.Modelos.Bancos
{
	class BancoPagos_Modelo
	{
		private int idbancopago;
		private int idingreso;
		private string fecha;
		private double total;
		private int idbancos;
		private int iddivsa;
		private int idtipocuenta;

		public int Idbancopago { get => idbancopago; set => idbancopago = value; }
		public int Idingreso { get => idingreso; set => idingreso = value; }
		public string Fecha { get => fecha; set => fecha = value; }
		public double Total { get => total; set => total = value; }
		public int Idbancos { get => idbancos; set => idbancos = value; }
		public int Iddivsa { get => iddivsa; set => iddivsa = value; }
		public int Idtipocuenta { get => idtipocuenta; set => idtipocuenta = value; }
	}
}
