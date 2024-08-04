using System;
namespace GestioneContatti.Models
{
	public abstract class Recipient : Entity
	{
		public bool IsWork { get; set; } //per capire se un contatto è di lavoro o no 
	}
}

