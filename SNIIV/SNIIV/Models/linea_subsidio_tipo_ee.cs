using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class linea_subsidio_tipo_ee
	{
		[Key] public int id {get; set;}
		public int id_linea_subsidio {get; set;}
		public int id_tipo_ee {get; set;}
		public int id_tipo_credito {get; set;}
	}
}
