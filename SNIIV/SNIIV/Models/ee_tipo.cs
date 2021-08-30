using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class ee_tipo
	{
		[Key] public int id { get; set; }
		public int id_ee {get; set;}
		public int id_tipo_ee {get; set;}
		public int anio {get; set;}
	}
}
