using System;
using System.ComponentModel.DataAnnotations;

namespace GestioneContatti.Models
{
	public class PersonModel
	{
		[Display(Name ="Nome"), Required (ErrorMessage="Inserire il nome "), MaxLength(25)]

		public required string FirstName { get; set; }


        [Display(Name = "Cognome"), Required(ErrorMessage = "Inserire il Cognome "), MaxLength(25)]

        public required string LastName { get; set; }


    }
}

