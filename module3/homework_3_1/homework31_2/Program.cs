using System;

namespace homework31_2
{
    class TemeratureConvertImp
    {
        public double ConvertCelsiusToFahrenheit(double celsius)
        {
            return 9.0 / 5 * celsius + 32;
        }
        public double ConvertFahrenheitToCelsius(double fahrenheit)
        {
            return 5.0 / 9 * (fahrenheit - 32);
        }
    }

    class StaticTempConverters
    {
        public static double ConvertCelsiusToKelvin(double celsius)
        {
            return celsius + 273.15;
        }
        public static double ConvertKelvinToCelsius(double kelvin)
        {
            return kelvin - 273.15;
        }
        
        public static double ConvertCelsiusToRankin(double celsius)
        {
            return 9.0 / 5 * celsius + 491.67;
        }
        public static double ConvertRankinToCelsius(double rankin)
        {
            return 5.0 / 9 * (rankin - 491.67);
        }
        
        public static double ConvertCelsiusToReomur(double celsius)
        {
            return 4.0 / 5 * celsius;
        }
        public static double ConvertReomurToCelsius(double reomur)
        {
            return 5.0 / 4 * reomur;
        }
    }
    
    class Program
    {
        delegate double DelegateConvertTemerature(double number);
        static void Main(string[] args)
        {
            TemeratureConvertImp converter = new();
            DelegateConvertTemerature[] mas = new DelegateConvertTemerature[4];
            mas[0] = converter.ConvertCelsiusToFahrenheit;
            mas[1] = StaticTempConverters.ConvertCelsiusToKelvin;
            mas[2] = StaticTempConverters.ConvertCelsiusToRankin;
            mas[3] = StaticTempConverters.ConvertCelsiusToReomur;
            Console.WriteLine(StaticTempConverters.ConvertCelsiusToReomur(45));
            while (true)
            {
                Console.WriteLine("Введите вещественное число, или 999, если хотите выйти из цикла: ");
                if (double.TryParse(Console.ReadLine(), out double number))
                {
                    foreach (var con in mas)
                    {
                        Console.WriteLine(con(number));
                    }
                }
                if (number == 999) break;
            }
        }
    }
}