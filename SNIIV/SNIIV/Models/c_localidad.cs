using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_localidad
	{
		[StringLength(10)] public string clave_entidad_federativa {get; set;}
		[StringLength(10)] public string clave_municipio {get; set;}
		[StringLength(10)] public string clave {get; set;}
		public string descripcion {get; set;}
		[StringLength(10)] public string ambito {get; set;}
		public Boolean status {get; set;}
	}
}
