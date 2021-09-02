using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SNIIV.Models
{
	public class financiamientos
	{
		[Column(TypeName = "bigint")]
		public int id {get; set;}
		public int anio {get; set;}
		public int mes {get; set;}
		[StringLength(10)] public string clave_entidad_federativa {get; set;}
		[StringLength(10)] public string clave_municipio {get; set;}
		[StringLength(10)] public string clave_organismo {get; set;}
		public int id_subprograma {get; set;}
		public int id_tipo_credito {get; set;}
		public int id_genero {get; set;}
		public int id_rango_edad {get; set;}
		public int id_rango_salarial {get; set;}
		public int id_valor_vivienda {get; set;}
		public int id_vivienda_sustentable {get; set;}
		public Decimal monto {get; set;}
		public int acciones {get; set;}
	}
}
