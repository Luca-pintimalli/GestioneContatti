using System;
using System.ComponentModel.DataAnnotations;

namespace GestioneContatti.Models
{
	public class Department: Entity 
	{
		[Required, MaxLength(50)]
        public required string Name { get; set; }


		public List<Contact> OwnedContacts { get; set; } //visto che ogni reparto gestisce dei contatti , bisogna passergli la lista dei contatti 
	}
}

