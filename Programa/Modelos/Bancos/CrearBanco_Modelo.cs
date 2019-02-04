using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa.Modelos.Bancos
{
	class CrearBanco_Modelo
	{
		private int idbancos;
		private string nombre;
		private int numerocuenta;

		public int Idbancos { get => idbancos; set => idbancos = value; }
		public string Nombre { get => nombre; set => nombre = value; }
		public int Numerocuenta { get => numerocuenta; set => numerocuenta = value; }
	}
}
