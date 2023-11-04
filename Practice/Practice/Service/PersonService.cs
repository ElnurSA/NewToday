using System;
using Practice.Data;
using Practice.Models;
using Practice.Service.Interfaces;

namespace Practice.Service
{
    public class PersonService : IPersonService
    {
        private readonly AppDbContext _context;

        public PersonService()
        {
            _context = new AppDbContext();
        }

        public Person GetById(int? id)
        {
            if (id is null) throw new ArgumentNullException();

            Person? existPerson = _context.People().FirstOrDefault(m => m.Id == id);

            if (existPerson == null) throw new NullReferenceException("Data not found");

            return existPerson;
        }
    }
}

