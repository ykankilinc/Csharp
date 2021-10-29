using OfficeOpenXml.FormulaParsing.Excel.Functions.Information;
using System;

namespace Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İşlevlerine göre operatörler aşağıdaki gibi kategorilendirilir.");
            Console.WriteLine("**********");
            Console.WriteLine("Atama ve İşlemli Atama Operatörleri =, +=, -=, *=, /=");
            int int1 = 100;
            Console.WriteLine(int1);
            int int2 = 20;
            Console.WriteLine(int2);
            int1 -= 1;
            Console.WriteLine(int1);
            int2 += 1;
            Console.WriteLine(int2);
            Console.WriteLine("İlişkisel Operatörler ==,!=, <, >, >=,<=");
            
            if (int1==int2)
            {
                Console.WriteLine("int1==int2");

            };
            if (int1<int2)
            {
                Console.WriteLine("int1 küçük int2 den ");

            }
            if(int1>int2)
            {
                Console.WriteLine("int1 büyük 1 den");
            }
            Console.WriteLine("Aritmetik +, -, *, /, %, ++, --");
            int sonuc = int1 + int2;
            Console.WriteLine(sonuc);
            sonuc =int1 - int2;
            Console.WriteLine(sonuc);
            sonuc = int1 / int2;
            Console.WriteLine(sonuc);
            sonuc = int1 * int2;
            Console.WriteLine(sonuc);
            sonuc = int1 % int2;
            Console.WriteLine(sonuc);

            Console.WriteLine("Matıksal &&, ||, !");
            bool isSuccess = true;
            bool isCompleted = false;
            if (isSuccess && isCompleted) 
            Console.WriteLine("Perfect!");
            if (isSuccess || isCompleted) 
            Console.WriteLine("Great!");
            if (isSuccess && !isCompleted) 
            Console.WriteLine("Good!");



        }
    }
}
