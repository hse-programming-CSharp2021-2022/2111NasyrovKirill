using System;

namespace prog3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            VideoFile videoFile = new("File", 500, 400);
            Console.WriteLine($"Создаётся массив видеофайлов:");
            VideoFile[] videoFiles = new VideoFile[rnd.Next(5, 16)];
            for (int i = 0; i < videoFiles.Length; i++)
            {
                videoFiles[i] = new(GetRandomName(), rnd.Next(60, 361), rnd.Next(100, 1001));
                Console.WriteLine($"{i + 1}. {videoFiles[i]}");
            }
            Console.WriteLine("Нужные видеофайлы:");
            for (int i = 0; i < videoFiles.Length; i++)
            {
                if (videoFiles[i].Size > videoFile.Size)
                    Console.WriteLine($"{i + 1}. {videoFiles[i]}");
            }
        }


        public static string GetRandomName()
        {
            Random rnd = new Random();
            char[] name = new char[rnd.Next(2, 10)];
            for (int i = 0; i < name.Length; i++)
            {
                int randomCase = rnd.Next(1, 3);
                if (randomCase == 1)
                    name[i] = (char)rnd.Next('A', 'Z' + 1);
                else
                    name[i] = (char)rnd.Next('a', 'z' + 1);
            }
            return new(name);
        }

    }

    class VideoFile
    {
        string name;
        int duration;
        int quality;
        public VideoFile(string name, int duration, int quality)
        {
            this.name = name;
            this.duration = duration;
            this.quality = quality;
        }
        public int Size
        {
            get
            {
                return duration * quality;
            }
            set
            {
                
            }
            
        }
        public override string ToString()
        {
            return $"Имя: {name}; Длительность: {duration} с; Качество: {quality}; Размер: {Size}.";
        }
    }
}
