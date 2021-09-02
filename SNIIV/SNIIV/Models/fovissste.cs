using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SNIIV.Models
{
	public class fovissste
	{
		[Column(TypeName = "bigint")]
		public int folio {get; set;}
		public DateTime fecha_firma {get; set;}
		[StringLength(10)] public string genero {get; set;}
		public int edad {get; set;}
		public Decimal monto {get; set;}
		public Decimal ingreso {get; set;}
		public Decimal valor_vivienda {get; set;}
		public int id_modalidad {get; set;}
		[StringLength(10)] public string clave_entidad_federativa {get; set;}
		[StringLength(10)] public string clave_municipio {get; set;}
		public int id_linea_credito {get; set;}
		public int id_esquema {get; set;}
		public int id_intermediario {get; set;}
		[StringLength(50)] public string cuv {get; set;}
		[StringLength(10)] public string observaciones {get; set;}
		public string desarrollador {get; set;}
		public int acciones {get; set;}
		public int mes {get; set;}
		public int vivienda_sustentable {get; set;}
		public int anio {get; set;}
	}
}
