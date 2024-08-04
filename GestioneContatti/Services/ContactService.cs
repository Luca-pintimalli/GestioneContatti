using System;
using GestioneContatti.Models;
using Microsoft.EntityFrameworkCore;

namespace GestioneContatti.Services
{
	public class ContactService: IContactService
	{

        private readonly ContactsDbContext _dbContext;


        public ContactService(ContactsDbContext dbContext)
		{
            _dbContext = dbContext;


        }


        
        public async Task AddCompany(string companyName)
        {
            _dbContext.Contacts.Add(new Company { Name = companyName });
            await _dbContext.SaveChangesAsync();
        }

        public async Task AddPerson(string firstName, string lastName)
        {
            _dbContext.Contacts.Add(new Person { FirstName = firstName, LastName = lastName });
            await _dbContext.SaveChangesAsync();
        }

        public async  Task Delete(int contactId)
        {
            var contact = await _dbContext.Contacts.SingleAsync(c => c.Id == contactId);
            _dbContext.Contacts.Remove(contact);
            await _dbContext.SaveChangesAsync();
           
        }

        public async Task<IEnumerable<Contact>> GetAll() => await _dbContext.Contacts.ToListAsync();


        public async Task<IEnumerable<Company>> GetCompanies() =>
            await _dbContext.Contacts.OfType<Company>().ToListAsync(); //OFTYPE CI PERMETTE DI ESTRARRE LE INFORMAZIONI SOLO DI UN DETERMINATO TIPO 

        public async Task<IEnumerable<Person>> GetPeople() =>
            await _dbContext.Contacts.OfType<Person>().ToListAsync();
       

        public Task UpdateCompany(int companyId, string companyName)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePerson(int personId, string firstName, string lastName)
        {
            throw new NotImplementedException();
        }
    }
}

