using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_linea_credito_banjercito
	{
		public int id_subprograma {get; set;}
		[Key]public int id_tipo_credito {get; set;}
	}
}
