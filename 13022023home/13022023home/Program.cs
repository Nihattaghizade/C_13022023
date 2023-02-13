using System;

namespace _13022023home
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string opt;
            do
            {
                Console.WriteLine("\n1. Qrup elave et");
                Console.WriteLine("2. Bütün qruplara bax");
                Console.WriteLine("3. Verilmiş point aralığındaki qruplara bax");
                Console.WriteLine("4. Verilmiş nömrəsi qrupa bax");
                Console.WriteLine("5. Verilmiş qruplar üzrə axtarış et");
                Console.WriteLine("0. Menudan cix");

                Console.WriteLine("\nSecim edin:");
                opt = Console.ReadLine();

                switch (opt)
                {
                    case "0":
                        Console.WriteLine("Menudan cix");
                        break;
                    case "1":
                        Console.WriteLine("Qrup elave et");
                        break;
                    case "2":
                        Console.WriteLine("Bütün qruplara bax");
                        break;
                    case "3":
                        Console.WriteLine("Verilmiş point aralığındaki qruplara bax");
                        break;
                    case "4":
                        Console.WriteLine("Verilmiş nömrəsi qrupa bax");
                        break;
                    case "5":
                        Console.WriteLine("Verilmiş qruplar üzrə axtarış et");
                        break;
                    default:
                        Console.WriteLine("Seciminiz yanlisdir");
                        break;
                }

            } while (opt != "0");
        }



    }        
    
}
