using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_sector_economico_1
	{
		[Key] public int id {get; set;}
		[StringLength(50)] public string descripcion {get; set;}
		[StringLength(10)] public string etiqueta {get; set;}
	}
}
