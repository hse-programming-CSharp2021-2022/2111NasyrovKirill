using System;

namespace homework32
{
    class Plant
    {
        private double _growth;
        private double _photosensitivity;
        private double _frostresistance;

        public Plant(double growth, double photosensitivity, double frostresistance)
        {
            _growth = growth;
            _photosensitivity = photosensitivity;
            _frostresistance = frostresistance;
        }

        public double Growth
        {
            get
            {
                return _growth;
            }
            set
            {
                _growth = value;
            }
        }
        
        public double Photosensitivity
        {
            get
            {
                return _photosensitivity;
            }
            set
            {
                _photosensitivity = value;
            }
        }
        
        public double Frostresistance
        {
            get
            {
                return _frostresistance;
            }
            set
            {
                _frostresistance = value;
            }
        }

        public override string ToString()
        {
            return $"рост: {_growth}; светоучстойчивость: {_photosensitivity}; морозоустойчивость: {_frostresistance}";
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);
            Plant[] arr = new Plant[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = new Plant(25 + rnd.NextDouble() * 75, rnd.NextDouble() * 100, rnd.NextDouble() * 80);
            }
            Array.ForEach(arr, plant => Console.WriteLine(plant));
            Console.WriteLine();
            
            Array.Sort(arr, (plant1, plant2) => -plant1.Growth.CompareTo(plant2.Growth));
            Array.ForEach(arr, plant => Console.WriteLine(plant));
            Console.WriteLine();
            
            Array.Sort(arr, (plant1, plant2) => plant1.Frostresistance.CompareTo(plant2.Frostresistance));
            Array.ForEach(arr, plant => Console.WriteLine(plant));
            Console.WriteLine();
            
            Array.Sort(arr, (plant1, plant2) => (int)plant1.Photosensitivity % 2 == 0? -1 : 1);
            Array.ForEach(arr, plant => Console.WriteLine(plant));
            
            Array.ConvertAll(arr, (plant) => (int)plant.Frostresistance % 2 == 0? plant.Frostresistance / 3 : plant.Frostresistance / 2);
        }
    }
}