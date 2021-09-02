using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class conavi_06100_fte_his
	{
		public DateTime fecha_operacion {get; set;}
		[StringLength(10)] public string genero {get; set;}
		[StringLength(10)] public string edad {get; set;}
		public Decimal monto_subsidio_federal {get; set;}
		public Decimal valor_solucion_habitacional {get; set;}
		public Decimal ingresos_vsmgv {get; set;}
		public Decimal ingresos_en_pesos {get; set;}
		public string modalidad {get; set;}
		[StringLength(10)] public string linea_apoyo {get; set;}
		[StringLength(10)] public string clave_entidad_federativa {get; set;}
		[StringLength(10)] public string clave_municipio {get; set;}
		[StringLength(10)] public string clave_localidad {get; set;}
		[StringLength(10)] public string clave_ejecutora {get; set;}
		public string entidad_ejecutora {get; set;}
		[StringLength(50)] public string tipo_de_vivienda {get; set;}
		public string desarrollador {get; set;}
		[StringLength(10)] public string cuv {get; set;}
		[StringLength(50)] public string subpro {get; set;}
		public int acciones {get; set;}
		[StringLength(50)] public string organo_ejecutor_de_obra {get; set;}
		public int puntaje {get; set;}
		[StringLength(10)] public string ubicacion {get; set;}
		[StringLength(50)] public string esquemas {get; set;}
		[StringLength(10)] public string nama {get; set;}
		public int folio {get; set;}
		[StringLength(50)] public string curp {get; set;}
		public int anio {get; set;}
		public int mes {get; set;}
		[StringLength(10)] public string periodo_rep {get; set;}
		[StringLength(10)] public string tipo_municipio {get; set;}
		[StringLength(10)] public string municipio_indigena {get; set;}
		public int id_programa_presupuestal {get; set;}
		public int id {get; set;}
	}
}
