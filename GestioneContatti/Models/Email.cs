using System;
using System.ComponentModel.DataAnnotations;

namespace GestioneContatti.Models
{
	public class Email : Recipient 
	{
		[Required , MaxLength(128)]
		public required string Address { get; set; }
		
	}
}

