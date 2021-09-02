using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_sector_economico_2
	{
		[Key] [StringLength(10)] public string id {get; set;}
		public int id_sector_economico_1 {get; set;}
		public string descripcion {get; set;}
	}
}
