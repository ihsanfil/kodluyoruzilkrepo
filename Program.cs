using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {

         //string degisken = "Dersimiz Csharp2, Hoşgeldiniz";
         //string degisken2 = "Dersimiz Csharp";
         //#ToUpper - ToLower
         //Console.WriteLine(degisken.Length);
         //Console.WriteLine(degisken.ToUpper());
         //Console.WriteLine(degisken.ToLower());

         //#Concat
         //Console.WriteLine(string.Concat(degisken," Merhaba!"));

         //#Compare - CompareTo
         //Console.WriteLine(degisken.CompareTo(degisken2)); //0,1,-1
         //Console.WriteLine(string.Compare(degisken,degisken2,false)); //büyük küçük harf duyarlı olsun

         //#Contains,EndsWith,StartsWith, IndexOf, Insert          
         //Console.WriteLine(degisken.Contains("Csharp"));
         //Console.WriteLine(degisken2.EndsWith("Hoşgeldiniz"));
         //Console.WriteLine(degisken2.StartsWith("Dersimiz"));
         //Console.WriteLine(degisken.IndexOf("2"));
         //Console.WriteLine(degisken.Insert(0,"Merhaba "));
         //Console.WriteLine(degisken.LastIndexOf("rp"));
         
         //#PadLeft PadRight
         //Console.WriteLine(degisken+ degisken2.PadLeft(30));
         //Console.WriteLine(degisken+ degisken2.PadLeft(30,'*'));
         //Console.WriteLine(degisken.PadRight(50,'-')+ degisken2.PadLeft(30,'*'));
          
         //#Remove
         //Console.WriteLine(degisken.Remove(10,10));

         //#Replace
         //Console.WriteLine(degisken.Replace(" ","-"));

         //#Split
         //Console.WriteLine(degisken.Split(" ")[1]);

         //#Substring
         //Console.WriteLine(degisken.Substring(5,10));
          
          //#Hazır Metotlar 2 DateTime ve Math
          //Console.WriteLine(DateTime.Now);
          //Console.WriteLine(DateTime.Now.Date);
          //Console.WriteLine(DateTime.Now.Day);
          //Console.WriteLine(DateTime.Now.Month);
          //Console.WriteLine(DateTime.Now.Year);
          //Console.WriteLine(DateTime.Now.Hour);
          //Console.WriteLine(DateTime.Now.Minute);
          //Console.WriteLine(DateTime.Now.Second);

          //Console.WriteLine(DateTime.Now.DayOfWeek);
          //Console.WriteLine(DateTime.Now.DayOfYear);

          //Console.WriteLine(DateTime.Now.ToLongDateString());
          //Console.WriteLine(DateTime.Now.ToShortDateString());
          
          //Console.WriteLine(DateTime.Now.ToLongTimeString());
          //Console.WriteLine(DateTime.Now.ToShortTimeString()); 
          

          //Console.WriteLine(DateTime.Now.AddHours(3));
          //Console.WriteLine(DateTime.Now.AddSeconds(2));
          //Console.WriteLine(DateTime.Now.AddMonths(5));
          //Console.WriteLine(DateTime.Now.AddYears(10));
          //Console.WriteLine(DateTime.Now.AddMilliseconds(50));

          //DateTime Formats
          //Console.WriteLine(DateTime.Now.ToString("dd"));
          //Console.WriteLine(DateTime.Now.ToString("ddd"));
          //Console.WriteLine(DateTime.Now.ToString("dddd"));

          //Console.WriteLine(DateTime.Now.ToString("MM"));
          //Console.WriteLine(DateTime.Now.ToString("MMM"));
          //Console.WriteLine(DateTime.Now.ToString("MMMM"));

          //Console.WriteLine(DateTime.Now.ToString("YY"));
          //Console.WriteLine(DateTime.Now.ToString("YYYY"));
          
        //  Console.WriteLine("/**********== MATH KUTUPHANESI ==*************/");
          //#Math Kütüphanesi
        //   Console.WriteLine(Math.Abs(-25)); //mutlak alır eksi değer verirsen artısını getirir
        //   Console.WriteLine(Math.Sin(10)); 
        //   Console.WriteLine(Math.Cos(10)); 
        //   Console.WriteLine(Math.Tan(10)); 
        //   Console.WriteLine(Math.Ceiling(10.53)); // 10.53'ten büyük en küçük tam sayıyı getirir 11 yani
        //   Console.WriteLine(Math.Round(10.43));  //  Hangisine daha yakınsa ona yuvarlar yani 10 getirir hangisine daha yakınsa 05 e bakar
        //   Console.WriteLine(Math.Floor(10.53));  //  Aşağı yuvarlar 10

        //   Console.WriteLine(Math.Max(2,6));
        //   Console.WriteLine(Math.Min(2,6));
          
        //   Console.WriteLine("/**********== MATH KUTUPHANESI 2. bolum==*************/"); 
        //   Console.WriteLine(Math.Pow(3,4)); //3 üstü 4 ü hesaplar 81 yani verir
        //   Console.WriteLine(Math.Sqrt(9));  //karekök dışına sayı alır 3
        //   Console.WriteLine(Math.Log(9));  //9'un e tabanındaki logoritmik karşılığını getirir
        //   Console.WriteLine(Math.Exp(3));  //e üzeri 3'ü verir
        //   Console.WriteLine(Math.Log10(10)); //10'sayısının logoritma 10 tabanındaki karşılığı

        // decimal d = 3.1M;
        // var d2 = 3.99955;
        // Console.WriteLine((d % 1) == 0);
        // d = 3.0M;
        // Console.WriteLine((d % 1) == 0);
        // if (d2 is double){
        //     Console.WriteLine("doble doğru");
        // }
        // if (d2 is decimal){
        //     Console.WriteLine("decimal doğru");
        // }

        List<int> sayiListesi= new List<int>();
           sayiListesi.Add(23);
           sayiListesi.Add(10);
           sayiListesi.Add(4);
           sayiListesi.Add(5);
           sayiListesi.Add(92);
           sayiListesi.Add(34);
        List<string> renkListesi = new List<string>();
        renkListesi.Add("Kırmızı");
        renkListesi.Add("Mavi");
        renkListesi.Add("Turuncu");
        renkListesi.Add("Sari");
        renkListesi.Add("Yeşil");
        // sayiListesi.Add(10);
        // sayilistesi.Add(4);
        // sayiListesi.Add(5);
        // sayiListesi.Add(92);
        // sayiListesi.Add(34);

        //Foreach ve List. ForEach ile elemanlara erişin
        // foreach (var sayi in sayiListesi)
        // Console.WriteLine(sayi);
        // foreach (var renk in renkListesi)
        // Console.WriteLine(renk);
        sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
        renkListesi.ForEach(renk => Console.WriteLine(renk));
        // //Listeden eleman çıkarma
        sayiListesi.RemoveAt(4);
       // renkListesi.Remove("Yeşil");
        sayiListesi.RemoveAt(0);
        //renkListesi.RemoveAt(1);
       
        sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
        renkListesi.ForEach(renk => Console.WriteLine(renk));

        //Liste içerisinde arama 

        // Console.WriteLine(sayiListesi.Contains(4));
        // Console.WriteLine(renkListesi.Contains("Kırmızı"));

        //Eleman ile index'e erişme

       // Console.WriteLine(renkListesi.BinarySearch("Sari"));
         
       //Diziyi listeye çevirme

        // string[] dizi = {"test 1","test 2","test 3"};

        // List<string> diziList = new List<string>(dizi);

        // foreach (var item in diziList) {
        //     Console.WriteLine(item);
        // }
        

       List<Kullanıcılar> kullaniciListesi = new List<Kullanıcılar>();
        
         Kullanıcılar kullanici1 = new Kullanıcılar();
         kullanici1.Isim= "ihsan";
         kullanici1.Soyisim= "ihsan";
         kullanici1.Yas= 34;

         Kullanıcılar kullanici2 = new Kullanıcılar();
         kullanici1.Isim= "ihsan 1";
         kullanici1.Soyisim= "ihsan 1";
         kullanici1.Yas= 35;

         kullaniciListesi.Add(kullanici1);
         kullaniciListesi.Add(kullanici2);

         Console.WriteLine(kullaniciListesi.Count());
        }//Main         
    }//Program-class-end    
       
        public class Kullanıcılar{
            private string isim;
            private string soyisim;
            private int yas;
            
            public string Isim { get => isim; set => isim = value; }
            public string Soyisim { get => soyisim; set => soyisim = value; }
            public int Yas { get => yas; set => yas= value; }
        }
       
}

