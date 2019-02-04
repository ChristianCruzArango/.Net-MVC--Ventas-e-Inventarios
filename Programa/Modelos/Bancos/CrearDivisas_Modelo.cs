using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa.Modelos.Bancos
{
	class CrearDivisas_Modelo
	{
		private int iddivisa;
		private string nombreDivisa;
		private string simboloDivisa;

		public int Iddivisa { get => iddivisa; set => iddivisa = value; }
		public string NombreDivisa { get => nombreDivisa; set => nombreDivisa = value; }
		public string SimboloDivisa { get => simboloDivisa; set => simboloDivisa = value; }
	}
}
