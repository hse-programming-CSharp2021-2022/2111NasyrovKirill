using System;
using System.IO;

namespace homework311
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string fileName = "Numbers.bin";

            using (FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (var writer = new BinaryWriter(stream))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        writer.Write((byte)rnd.Next(1, 101));
                    }
                }
            }

            using (FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                using (var reader = new BinaryReader(stream))
                {
                    int cnt = 0;
                    while (cnt<10)
                    {
                        int a = reader.ReadByte();
                        Console.WriteLine(a);
                        Console.Write("Введите число: ");
                        byte d = byte.Parse(Console.ReadLine());
                        using (var writer = new BinaryWriter(stream))
                        {
                            stream.Seek(cnt, SeekOrigin.Begin);
                            writer.Write(d);
                        }
                        cnt+=1;
                    }
                }
            }

            using (FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (var reader = new BinaryReader(stream))
                {
                    int cnt = 0;
                    while (cnt < 10) 
                    {
                        int a = reader.ReadByte();
                        Console.WriteLine(a);
                        cnt += 1;
                    }
                }
            }
        }
    }
}
