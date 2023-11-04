using System;
using Practice.Models;

namespace Practice.Service.Interfaces
{
	public interface IPersonService
	{
		Person GetById(int? id);
	}
}

