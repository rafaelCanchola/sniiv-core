using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_entidad_cofinanciamiento
	{
		[StringLength(10)] public string id {get; set;}
		[StringLength(50)] public string descripcion {get; set;}
	}
}
