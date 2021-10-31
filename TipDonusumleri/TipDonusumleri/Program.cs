using System;
namespace tip_donusumleri
{
    class program
    {
        public static void Main(string[] args)
        {
            //implicit Conversion)
            Console.WriteLine("*****implicit Conversion*****");
            byte a = 5;
            sbyte b = 90;
            short c = 40;
            int d = a + b + c;
            Console.WriteLine("d:"+d);
            long e = d;
            Console.WriteLine("e:"+e);
            float f = e;
            Console.WriteLine("f:"+f);
            string g = "yusuf";
            char h = 'z';
            object o = f+g+h;
            Console.WriteLine(o);
            //explicit convertion
            Console.WriteLine("*****explicit convertion*****");
            Console.WriteLine("*****ToString Methodu*****");
            //ToString
            int xx = 6;
            string yy= xx.ToString();
            Console.WriteLine(yy);
            Console.WriteLine("*****system convert*****");
            //system convert
            string s1 = "10";
            string s2 = "20";
            int sayi1, sayi2;
            int toplam;
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
            // parse
            Console.WriteLine("*****Parse Methodu*****");
            ParseMethod();
        }
        public static void ParseMethod()
        {
            string metin1 = "10", metin2 = "10,25";
            int rakam1;
            double double1;
            rakam1 = int.Parse(metin1);
            double1=Double.Parse(metin2);
            Console.WriteLine("rakam1:" + rakam1);
            Console.WriteLine("double1:" + double1);
        }
    }
}