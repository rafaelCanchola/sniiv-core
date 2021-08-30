using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class grupo_esquema_cnbv
	{
		[Key] public int id { get; set; }
		[StringLength(10)] public string clave_producto_hipotecario {get; set;}
		[StringLength(10)] public string clave_entidad_cofinanciamiento {get; set;}
		public int id_esquema_cnbv {get; set;}
	}
}
