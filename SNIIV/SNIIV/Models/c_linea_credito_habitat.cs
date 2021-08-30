using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_linea_credito_habitat
	{
		[Key] public int id {get; set;}
		public int id_tipo_credito {get; set;}
	}
}
