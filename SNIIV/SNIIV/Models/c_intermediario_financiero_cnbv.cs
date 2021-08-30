using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_intermediario_financiero_cnbv
	{
		[StringLength(10)] public string id {get; set;}
		[StringLength(50)] public string descripcion {get; set;}
	}
}
