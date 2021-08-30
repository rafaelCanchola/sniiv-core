using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_tipo_ee
	{
		[Key] public int id {get; set;}
		public int id_tipo_ee_sniiv {get; set;}
		[StringLength(50)] public string descripcion {get; set;}
	}
}
