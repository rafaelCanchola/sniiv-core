using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SNIIV.Models
{
	public class desarrollador_fovissste
	{
		[Column(TypeName = "bigint")]
		public int folio {get; set;}
		public int anio {get; set;}
		public int mes {get; set;}
		[StringLength(10)] public string clave_estado {get; set;}
		[StringLength(10)] public string clave_municipio {get; set;}
		public int id_esquema {get; set;}
		public string desarrollador {get; set;}
		public int acciones {get; set;}
		public Decimal monto {get; set;}
	}
}
