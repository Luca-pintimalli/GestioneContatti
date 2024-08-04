using System;
using System.ComponentModel.DataAnnotations;

namespace GestioneContatti.Models
{
	public class Company : Contact
	{
		[Required , MaxLength(50)]
		public required string Name { get; set; }

	}
}

