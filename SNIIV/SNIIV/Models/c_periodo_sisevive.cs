using System;
using System.ComponentModel.DataAnnotations;
namespace SNIIV.Models
{
	public class c_periodo_sisevive
	{
		[Key] public DateTime fecha {get; set;}
		public Boolean actual {get; set;}
	}
}
