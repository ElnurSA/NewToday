using System;
using Practice.Helpers;

namespace Practice.Exceptions
{
	public class RegisterFailedException : Exception
	{
		public RegisterFailedException() : this(AccountMessages.RegisterFailed)
		{

		}
		public RegisterFailedException(string msj) : base(msj)
		{

		}
	}
}

