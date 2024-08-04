using System;
namespace GestioneContatti.Models
{
	public class Contact : Entity
	{
		public bool IsPubblic { get; set; } //PER CAPIRE SE UN CONTATTO è PUBBLICO O PRIVATO

		public virtual List<Recipient> Recipients { get; set; } = []; //gestione recapiti
	}
}

