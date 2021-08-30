using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class conavi_semanal
	{
		public int folio {get; set;}
		public DateTime fech_operacion {get; set;}
		public int id_genero {get; set;}
		public int edad {get; set;}
		public Decimal monto_subsidio_federal {get; set;}
		public Decimal valor_solucion_habitacional {get; set;}
		public Decimal ingreso_pesos {get; set;}
		public int id_modalidad {get; set;}
		[StringLength(10)] public string clave_entidad_federativa {get; set;}
		[StringLength(10)] public string clave_municipio {get; set;}
		[StringLength(10)] public string clave_localidad {get; set;}
		public int id_ee {get; set;}
		public int id_tipo_vivienda {get; set;}
		public string desarrollador {get; set;}
		[StringLength(50)] public string cuv {get; set;}
		public int acciones {get; set;}
		public int id_oeo {get; set;}
		public int puntaje {get; set;}
		public int id_esquema {get; set;}
		public int id_tipo_ee {get; set;}
		public int anio {get; set;}
		public int mes {get; set;}
		public int id_vivienda_sustentable {get; set;}
		public int id_pcu {get; set;}
	}
}
