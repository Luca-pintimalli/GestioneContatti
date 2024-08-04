using System;
using System.ComponentModel.DataAnnotations;

namespace GestioneContatti.Models
{
	public class Person : Contact
	{
		[Required, MaxLength(25)]
		public required string  FirstName {get;set; }

        [Required, MaxLength(25)]
        public required string LastName { get; set; }


    }
}

