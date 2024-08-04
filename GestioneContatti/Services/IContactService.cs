using System;
using GestioneContatti.Models;

namespace GestioneContatti.Services
{
	public interface IContactService
	{

		Task AddPerson(string firstName, string lastName);

		Task AddCompany(string companyName);

		Task UpdatePerson(int personId, string firstName, string lastName);

		Task UpdateCompany(int companyId, string companyName);

		Task Delete(int contactId);

		Task<IEnumerable<Contact>> GetAll();

		Task <IEnumerable<Person>> GetPeople();

		Task<IEnumerable<Company>> GetCompanies();
	}
}

