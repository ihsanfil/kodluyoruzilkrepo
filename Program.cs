using System;

namespace degisken 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int deger = 2;
            string degisken = " ";
            byte b = 5;
            short s = 5;
            ushort us= 5;
            int i= 2;
            Int16 i16= 1;
            Int32 i32 = 32;
            Int64 i64 =64;

            uint ui = 2;
            long l =2;
            ulong ul = 2;
            
            float f=2;
            double d= 2;
            decimal de= 2;

            char c='c';
            string c2= "strng";

            bool tr =true;  

            DateTime dt= DateTime.Now;
            //Console.WriteLine(dt);
            object o1 = "x";
            object o2 = 'c';
            string str1  =string.Empty;
            str1 = "Test";
            string ad = "Zikriye";
            string soyad = "Ürkmez";
            string adSoyad = ad+" "+soyad;
            //Console.WriteLine(adSoyad);
            
            int int1=5;
            int int2=3;
            int  int3 = int1* int2;
            //Console.WriteLine(int3);

            bool b1 = 10<2;
            //Console.WriteLine(b1);

           string st22 = "20";
           int int20 = 20;

           string strdeger = st22 + int20.ToString();
          // Console.WriteLine(strdeger);

           int toplam = Convert.ToInt32(st22) + int20;
           int toplam1 = int20 + int.Parse(st22);
          // Console.WriteLine(toplam1);
          string gun = DateTime.Now.ToString("dd-MM-yyyy");
          string gun1 = DateTime.Now.ToString("M'/'dd'/'yy");
          string gun2 = DateTime.Now.ToString("dd.MM.yyyy");
          string saat = DateTime.Now.ToString("HH:mm");
          Console.WriteLine(gun);
          Console.WriteLine(gun1);
          Console.WriteLine(gun2);
          Console.WriteLine(saat);


        }
    }
}