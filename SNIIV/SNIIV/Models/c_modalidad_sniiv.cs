using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_modalidad_sniiv
	{
		[Key] public int id {get; set;}
		[StringLength(50)] public string descripcion {get; set;}
	}
}
