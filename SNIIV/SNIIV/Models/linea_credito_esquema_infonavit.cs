using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class linea_credito_esquema_infonavit
	{
		[Key] public int id {get; set;}
		public int id_esquema_Infonavit {get; set;}
		public int id_linea_credito_Infonavit {get; set;}
		public int id_tipo_credito {get; set;}
	
	}
}
