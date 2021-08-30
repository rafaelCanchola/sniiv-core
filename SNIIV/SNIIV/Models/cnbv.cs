using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class cnbv
	{
		public int id {get; set;}
		[StringLength(10)] public string clave_entidad_federativa {get; set;}
		[StringLength(10)] public string clave_municipio {get; set;}
		[StringLength(10)] public string clave_intermediarios_financiero {get; set;}
		public int id_linea_credito {get; set;}
		public int responsabilidad_total {get; set;}
		public int id_moneda {get; set;}
		public int ingreso_VSMMDF {get; set;}
		public int valor_vivienda {get; set;}
		[StringLength(50)] public string tipo_comprobacion {get; set;}
		public int id_sector_laboral {get; set;}
		[StringLength(10)] public string genero {get; set;}
		public int edad {get; set;}
		[StringLength(10)] public string clave_entidad_cofinanciamiento {get; set;}
		[StringLength(10)] public string clave_producto_hipotecario {get; set;}
		public int acciones {get; set;}
		public int monto {get; set;}
		public int anio {get; set;}
		public int mes {get; set;}
		public Boolean cve_marginal {get; set;}
	}
}
