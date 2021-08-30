using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class cnbv_coofinanciamiento
	{
		[Key] public int id { get; set; }
		[StringLength(10)] public string cve_institucion {get; set;}
		[StringLength(10)] public string cve_periodo {get; set;}
		public int numero_de_creditos {get; set;}
		public int Responsabilidad_total {get; set;}
		[StringLength(10)] public string cve_marginal {get; set;}
		public int cve_destino_credito {get; set;}
		[StringLength(10)] public string cve_moneda {get; set;}
		public int monto_original_del_credito {get; set;}
		public int originacion_valor_vivienda {get; set;}
		public int Ingreso_men_bruto_acred {get; set;}
		[StringLength(10)] public string cve_tipo_comp_ingresos {get; set;}
		[StringLength(10)] public string cve_sec_lab_acred {get; set;}
		[StringLength(10)] public string cve_estado {get; set;}
		[StringLength(10)] public string cve_municipio {get; set;}
		[StringLength(10)] public string cve_genero {get; set;}
		[StringLength(10)] public string edad {get; set;}
		[StringLength(10)] public string cve_producto_hipotecario {get; set;}
		[StringLength(10)] public string cve_entidad_confinanciamiento {get; set;}
	}
}
