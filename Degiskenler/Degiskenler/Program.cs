using System;

namespace Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Degiskenler ve Veri Tipleri");
            DateTime Tarih=DateTime.Now;
            Console.WriteLine(Tarih.ToString());
            Byte byte1 = 1;
            Byte byte2 = 2;
            Console.WriteLine(byte1);
            Console.WriteLine(byte2);
            SByte sbyte1 = 1;
            Console.WriteLine(sbyte1);
            short short1 = 1;
            Console.WriteLine(short1);
            ushort ushort1 = 1;
            Console.WriteLine(ushort1);
            int int1 = 1;
            Console.WriteLine(int1);
            float float1 = 1;
            Console.WriteLine(float1);
            double double1 = 1;
            Console.WriteLine(double1);
            char char1 = 'a';
            Console.WriteLine(char1);
            bool bool1 = true;
            Console.WriteLine(bool1);
            string string1 = "string veri tipi";
            Console.WriteLine(string1);
            object obj1 = "obje1"; 
            Console.WriteLine(obj1);
            Console.WriteLine("Değişken Dönüşümleri");
            string string2 = "20";
            int int2 = 1;
            string string3 = string2 +int2.ToString();
            Console.WriteLine(string3);
            int int3 = 1 + Convert.ToInt32(string3);
            Console.WriteLine(int3);
            int int4 = int3 + int.Parse(string3);
            Console.WriteLine(int4);
        }
    }
}
