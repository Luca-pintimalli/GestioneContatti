using System;
using GestioneContatti.Models;
using Microsoft.EntityFrameworkCore;

namespace GestioneContatti.Services
{
    public class ContactsDbContext : DbContext
	{
        public ContactsDbContext(DbContextOptions opt) : base(opt) { }



        public virtual DbSet<Department> Departments { get; set; }

        public virtual DbSet<Contact> Contacts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Recipient>()
                .HasDiscriminator<int>("type")
                .HasValue<PhoneNumber>(0)
                .HasValue<Email>(1)
                ;


            modelBuilder.Entity<Company>()
                .ToTable("Companies");


            modelBuilder.Entity<Person>()
                .ToTable("People");
        }





    }



}

