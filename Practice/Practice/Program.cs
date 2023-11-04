using Practice;
using Practice.Controllers;
using Practice.Exceptions;
using Practice.Helpers;
#region Indexer
//Library library = new Library();

//Book book = new Book();
//book.Id = 1;
//book.Name = "test1";

//library[0] = book;

//Console.WriteLine(library[0].Name);
#endregion







//try
//{
//    int a = 5;
//    int b = 0;

//    int result = a / b;

//    Console.WriteLine(result);
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (NullReferenceException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    Console.WriteLine("Salam Aqshin bey");
//}

//static void Register(string username, string password)
//{
//    bool isSuccess = false;
//    try
//    {
//        if (username == "semed123")
//        {
//            Console.WriteLine("Register success");
//            isSuccess = true;
//        }
//        else
//        {
//            throw new RegisterFailedException("Sagolun Metanet xanim");
//        }
//    }
//    catch (Exception ex)
//    {

//        Console.WriteLine(ex.Message);
//    }
//    finally
//    {
//        SendMail(isSuccess);
//    }

//}

//Register("semed12", "dasddas");

//static void SendMail(bool isSuccess)
//{
//    if (isSuccess)
//    {
//        Console.WriteLine(AccountMessages.RegisterEmailSuccess);
//    }
//    else
//    {
//        Console.WriteLine(AccountMessages.RegisterEmailFail);
//    }


//}

//ShowText(null);

//static void ShowText(string text)
//{
//    try
//    {
//        if (text is null)
//        {
//            throw new ArgumentNullException();
//        }
//        else
//        {
//            Console.WriteLine(text);
//        }
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//}

PersonController personController = new();

personController.GetById();