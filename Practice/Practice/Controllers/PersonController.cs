using System;
using Practice.Service;
using Practice.Service.Interfaces;

namespace Practice.Controllers
{
	public class PersonController
	{
		private readonly IPersonService _personService;

		public PersonController()
		{
			_personService = new PersonService();
		}

		public void GetById()
		{
			try
			{
                Console.WriteLine("Add person id: ");

                int id = int.Parse(Console.ReadLine());

                var response = _personService.GetById(id);

                var result = $"{response.Id} - {response.FullName} - {response.Age}";

                Console.WriteLine(result);
            }
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			
		}


	}
}

