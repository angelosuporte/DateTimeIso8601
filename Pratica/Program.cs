using System;
using System.Globalization;


namespace Pratica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Padrão Iso8601
            //yyyy-MM-ddTHH:mm:ssZ
            //Z indica que a data/hora em Utc

            //Exemplos:
            DateTime date1 = DateTime.Parse("2020-08-15 16:59:58");
            DateTime date2 = DateTime.Parse("2020-08-15T16:59:58Z"); //<--como possível ver a data armazenada vai ficar no padrâo UTC
                                                                    // mas para o usuário será mostrado a hora de acordo com a localidade 


            Console.WriteLine(date1);
            Console.WriteLine(date2); // <--Fará a conversão para o usuário de acordo com a localidade, ou seja, o país onde o usuário está");
            Console.WriteLine("------------------------------------------------------");

            
            Console.WriteLine("date1: " + date1);
            Console.WriteLine("date1 Kind: " + date1.Kind);
            Console.WriteLine("date1 to Local: " + date1.ToLocalTime());
            Console.WriteLine("ddate1 to Utc: " + date1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("date2: " + date2);
            Console.WriteLine("date2 Kind: " + date2.Kind);
            Console.WriteLine("date2 to Local: " + date2.ToLocalTime());
            Console.WriteLine("date2 to Utc: " + date2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine(date2.ToString("yyyy-MM-ddTHH:mm:ssZ")); //<--não irá converter, porque é necessário passar oToUniversalTime
            Console.WriteLine(date2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }
}



            