using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_estatus_programas_conavi
	{
		[Key] public int id {get; set;}
		[StringLength(50)] public string descripcion {get; set;}
	}
}
