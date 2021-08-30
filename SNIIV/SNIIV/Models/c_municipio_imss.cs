using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_municipio_imss
	{
		[StringLength(10)] public string clave {get; set;}
		[StringLength(50)] public string descripcion {get; set;}
		public int id_delegacion {get; set;}
		[StringLength(10)] public string clave_entidad_federativa {get; set;}
		[StringLength(10)] public string clave_municipio {get; set;}
	}
}
