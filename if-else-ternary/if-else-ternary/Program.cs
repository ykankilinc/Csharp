using System;

namespace if_else_ternary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If-Else Yapısı ve Ternary If");
            int time = DateTime.Now.Hour;
            Console.WriteLine(time);
            if (time >= 6 && time > 11)
                Console.WriteLine("Günaydın");
            else if (time <= 18)
                Console.WriteLine("İyi Günler");
            else
                Console.WriteLine("İyi Geceler");
            string sonuc = time <= 18 ? "İyi Günler" : "İyi Geceler";
            sonuc = time >= 6 && time < 11 ? "Günaydın" : time >= 18 ? "İyi Günler" : "İyi Geceler";
            Console.WriteLine(sonuc);


        }
    }
}
