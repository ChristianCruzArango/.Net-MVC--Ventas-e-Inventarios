using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa.Modelos.Ventas
{
	class CrearClientes_Modelo
	{
		private int idcliente;
		private string nombre;
		private int idtipoDocumento;
		private int numeroDocumento;
		private string correo;
		private int telefono;
		private string direccion;
		private int idestado;

		public int Idcliente { get => idcliente; set => idcliente = value; }
		public string Nombre { get => nombre; set => nombre = value; }
		public int IdtipoDocumento { get => idtipoDocumento; set => idtipoDocumento = value; }
		public int NumeroDocumento { get => numeroDocumento; set => numeroDocumento = value; }
		public string Correo { get => correo; set => correo = value; }
		public int Telefono { get => telefono; set => telefono = value; }
		public string Direccion { get => direccion; set => direccion = value; }
		public int Idestado { get => idestado; set => idestado = value; }
	}
}
