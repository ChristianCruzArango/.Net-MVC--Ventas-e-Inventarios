using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa.Modelos.Compras
{
	class CrearProveedor_Modelo
	{
		private int idproveedor;
		private string nombre;
		private int idtipoDocumento;
		private int numeroDocumento;
		private string correo;
		private int telefono;
		private string direccion;
		private int idestado;

		public int Idproveedor { get => idproveedor; set => idproveedor = value; }
		public string Nombre { get => nombre; set => nombre = value; }
		public int IdTipoDocumento { get => idtipoDocumento; set => idtipoDocumento = value; }
		public int NumeroDocumento { get => numeroDocumento; set => numeroDocumento = value; }
		public string Correo { get => correo; set => correo = value; }
		public int Telefono { get => telefono; set => telefono = value; }
		public string Direccion { get => direccion; set => direccion = value; }
		public int Idestado { get => idestado; set => idestado = value; }
	}
}
