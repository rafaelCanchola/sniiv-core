using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_sector_economico_4
	{
		[Key] [StringLength(10)] public string clave {get; set;}
		[StringLength(10)] public string id_sector_economico_2 {get; set;}
		[StringLength(50)] public string descripcion {get; set;}
	}
}
