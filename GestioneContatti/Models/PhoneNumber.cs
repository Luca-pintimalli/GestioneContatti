using System;
using System.ComponentModel.DataAnnotations;

namespace GestioneContatti.Models
{
	public class PhoneNumber : Recipient 
	{
		[MaxLength(5)]
		public string ? NationalCode { get; set; }

		[MaxLength(15)]
		public required string Number { get; set; }
		
	}
}

