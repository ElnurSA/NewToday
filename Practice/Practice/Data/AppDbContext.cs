using System;
using Practice.Models;

namespace Practice.Data
{
	public class AppDbContext
	{
		public Person[] People()
		{
			return new Person[]
			{
				new Person
				{
					Id = 1,
					FullName = "Meryem Eliyeva",
					Age = 23,
				},
				new Person
				{
					Id = 2,
					FullName = "Metanet Abbasova",
					Age = 21
				},
				new Person
				{
					Id = 10,
					FullName = "Haciaga Ehmedov",
					Age = 28
				}
			};
		}
	}
}

