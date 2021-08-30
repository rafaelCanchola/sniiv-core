using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class subprograma_fovissste
	{
		[Key] public int id { get; set; }
		public int id_esquema { get; set; }
		public int id_linea_credito { get; set; }
		public int id_modalidad { get; set; }
		public int id_subprograma { get; set; }
		public int id_tipo_credito { get; set; }
	}
}