using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SNIIV.Models
{
	public class issste
	{
		[Key]
		[Column(TypeName = "bigint")]
		public int id {get; set;}
		public int anio {get; set;}
		public int mes {get; set;}
		[StringLength(10)] public string clave_entidad_federativa {get; set;}
		public string paterno {get; set;}
		public string materno {get; set;}
		public string nombre {get; set;}
		public int tno {get; set;}
		public int id_nombramiento {get; set;}
		public int id_genero {get; set;}
		public Decimal sueldo {get; set;}
		public int mult_sdo {get; set;}
		public DateTime fecha_alta {get; set;}
		public DateTime fecha_ingreso {get; set;}
		public int antiguedad {get; set;}
		public int id_ramo {get; set;}
		public int id_modalidad {get; set;}
		public int id_sector {get; set;}
	}
}
