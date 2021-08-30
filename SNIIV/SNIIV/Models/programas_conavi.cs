using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class programas_conavi
	{
		[Key] public int id {get; set;}
		public string folio {get; set;}
		public DateTime fecha_aprobacion_comite_financiamiento {get; set;}
		public string numero_comite_financiamiento {get; set;}
		public int id_programa_presupuestal {get; set;}
		[StringLength(10)] public string partida_presupuestal {get; set;}
		[StringLength(10)] public string unidad_medida {get; set;}
		public int id_modalidad {get; set;}
		public int id_linea_apoyo {get; set;}
		public int id_vertiente {get; set;}
		public string folio_conavi {get; set;}
		[StringLength(50)] public string curp {get; set;}
		[StringLength(10)] public string clave_entidad_federativa {get; set;}
		[StringLength(10)] public string clave_municipio {get; set;}
		[StringLength(10)] public string clave_localidad {get; set;}
		public int edad {get; set;}
		public int id_genero {get; set;}
		public Decimal ingreso_beneficiario {get; set;}
		public Decimal ingreso_beneficiario_UMA {get; set;}
		public int beneficiario_comprometidos {get; set;}
		public Decimal dato_presupuestal_importe_aprobado {get; set;}
		public Decimal dato_presupuestal_importe_ejercido {get; set;}
		public DateTime fecha_dispersion_presuesto {get; set;}
		[StringLength(50)] public string colonia {get; set;}
		[StringLength(25)] public string cve_asistente_oeo {get; set;}
		[StringLength(25)] public string cve_supervisor {get; set;}
		[StringLength(50)] public string cuv {get; set;}
		public Decimal longitud {get; set;}
		public Decimal latitud {get; set;}
		public int avance_obra {get; set;}
		[StringLength(10)] public string condicion_indigena {get; set;}
		[StringLength(10)] public string discapacidad {get; set;}
		public int id_derechohabiente {get; set;}
		[StringLength(10)] public string folio_sap {get; set;}
		public DateTime fecha_sap {get; set;}
		public int periodo_rep {get; set;}
		public Boolean status {get; set;}
		public int id_status {get; set;}
		[StringLength(10)] public string status_pago {get; set;}
	}
}
