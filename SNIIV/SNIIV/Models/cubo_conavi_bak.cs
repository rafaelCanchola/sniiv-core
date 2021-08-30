using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SNIIV.Models
{
	public class cubo_conavi_bak
	{
		[Column(TypeName = "bigint")]
		public int folio { get; set; }
		public int id_programa_presupuestal { get; set; }
		public int anio {get; set;}
		public int mes {get; set;}
		[StringLength(10)] public string clave_estado {get; set;}
		[StringLength(10)] public string clave_municipio {get; set;}
		public int? id_linea_apoyo {get; set;}
		public int id_modalidad {get; set;}
		public int id_esquema {get; set;}
		public int id_tipo_ee {get; set;}
		public int id_ee {get; set;}
		public int id_oeo {get; set;}
		public int id_genero {get; set;}
		public int id_rango_edad {get; set;}
		public int id_rango_salarial {get; set;}
		public int id_valor_vivienda {get; set;}
		public int id_tipo_vivienda {get; set;}
		public int id_dc {get; set;}
		public int id_vivienda_sustentable {get; set;}
		public int id_pcu {get; set;}
		public Decimal monto {get; set;}
		public int acciones {get; set;}
	}
}
