using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
              //out parametreler
              string sayi = "999";
              //int outSayi;

             bool sonuc= int.TryParse(sayi,out int outSayi);     

              if(sonuc)
              {
                Console.WriteLine("Başarılı "+ outSayi);
              }else{
                Console.WriteLine("Başarısız ");
              }    

              Metotlar instance = new Metotlar();
              instance.Topla(4,5,out int sonuc3);
              Console.WriteLine("sonuc3= "+sonuc3);   

              //Metot Overloading - Aşırı Yükleme
              int ifade = 999;
              instance.EkranaYazdir(ifade);
          

        }      
            
    }//Program-class-end
   class Metotlar 
   {
             public void Topla (int a, int b,out int toplam)
             {
              toplam = a+b;
             }

             public void EkranaYazdir(string veri){
              Console.WriteLine(veri);
             }
              public void EkranaYazdir(int veri){ //overloading
              Console.WriteLine(veri);
             }

   }
    
}

