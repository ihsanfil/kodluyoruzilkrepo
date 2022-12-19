using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
                                     
          static int Topla (int a, int b){
            return a+b;
          }
          
          int sonuc = Topla(10,43);
          // Console.WriteLine(sonuc);

          Metotlar metot = new Metotlar();
          // metot.EkranaYazdir(Convert.ToString(sonuc));

          // int carp= metot.Carp(10,3);
          // metot.EkranaYazdir(Convert.ToString(carp));
          int a= 10;
          int b= 43;
          int sonuc1 = Topla(a,b);
          int sonuc2 = metot.ArttirveTopla(ref a,ref b);
          metot.EkranaYazdir(Convert.ToString(sonuc1));
          metot.EkranaYazdir(Convert.ToString(sonuc2));
          metot.EkranaYazdir(Convert.ToString(a));
          metot.EkranaYazdir(Convert.ToString(b));

        }      
            
    }//Program-class-end

    class Metotlar{

     public void EkranaYazdir(string veri) {
         Console.WriteLine(veri);
     }
     public int Carp(int a, int b){
       
       return a*b;
     }
     public int ArttirveTopla(ref int deger1,ref int deger2){
      //orjinal değişken değerini değiştirir/atama yapar
        deger1+=1;
        deger2+=1;

      return deger1+deger2;
     }
    }
}
