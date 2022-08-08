using System;
using Extension_Method;


namespace Extension_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string exit="1";
            while (exit != "0")
            {
                Console.WriteLine("Enter\n 1. TOConvert \n 0. EXIT");
                var option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Enter Number");
                        string value = Console.ReadLine();
                        Console.WriteLine(value.ToCurrency());
                        break;
                    case "0":
                        exit = "0";
                        break;
                    default:
                        Console.WriteLine("invalid Option");
                        break;

                }
                
               
            }

           
        }
    }

    public static class CurrencyExtension
    {
        public static string ToCurrency(this string value)//extension for  TOCurrency  
        {

            try
            {
                int valueCheck = int.Parse(value);
                var valueCheckString = string.Concat('$', valueCheck);
                return valueCheckString;
            }
            catch (Exception)
            {
                throw new Exception("Value is not a number");
            }
        }
    }
}
