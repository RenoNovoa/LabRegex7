using System;
using System.Text.RegularExpressions;


namespace LabRegex7
{
    class Program
    {
        //private static object w;

        static void Main(string[] args)
        {    //Here  we can use the Regex from \w{1,29} to \b{1,29}...
            Regex validNamePattern = new Regex(@"[A-Z]{1}\w{1,29}");

            Console.Write("Please enter a valid Name:");
            string validName = Console.ReadLine();

            string badvalidName = "Sorry, name No bueno";

            if (validNamePattern.IsMatch(validName))
            {
                Console.WriteLine("Valid Name. Continue!");
            }
            if (!validNamePattern.IsMatch(badvalidName))
            {
                Console.WriteLine("Sorry, name is not valid! ");
            }

            Console.WriteLine();

            Regex validEmailPattern = new Regex(@"^[a-z0-9]{5,30}@[a-z0-9]{5,10}\.[a-z]{2,3}");


            Console.Write("Please enter a valid email: "); 
            string validEmail = Console.ReadLine();

            string badEmail = "This is not a number ;)";

            if (validEmailPattern.IsMatch(validEmail))
            {
                Console.WriteLine("Email Valido :-)");
            }

            if (!validEmailPattern.IsMatch(badEmail))
            {
                Console.WriteLine("Email No valido :(");
            }


            Console.WriteLine();

            Regex phoneNumberPattern = new Regex(@"^((\d{3}-)|(\(\d{3}\)(-| )))?\d{3}-\d{4}$");

            Console.WriteLine("please insert a valid phone number");
            string phoneNumber = Console.ReadLine();

            string badPhoneNumber = "This is not a number ;)";

            if (phoneNumberPattern.IsMatch(phoneNumber))
            {
                Console.WriteLine("Number Valido :-)");
            }

            if (!phoneNumberPattern.IsMatch(badPhoneNumber))
            {
                Console.WriteLine("Number No valido :(");
            }

             Console.WriteLine();


            Regex fachaValidaPattern = new Regex(@"^(0[1 - 9] |[12][0 - 9] | 3[01])[- /.](0[1 - 9] | 1[012])[- /.](19 | 20)\d\d$");

              
            Console.WriteLine("Por Favor ingresa fecha valida");
            string fechaValida = Console.ReadLine();

            string sinfechaValida = "This is not a fecha ;)";

            if (fachaValidaPattern.IsMatch(fechaValida))
            {
                Console.WriteLine("Fecha Valida :-)");
            }

            if (!phoneNumberPattern.IsMatch(sinfechaValida))
            {
                Console.WriteLine("Fecha No Valida :(");
            }




            Console.ReadKey();
   
        }
    }
}
