using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            //   string sayi = "999";
            //   //int outSayi;

            //  bool sonuc= int.TryParse(sayi,out int outSayi);     

            //   if(sonuc)
            //   {
            //     Console.WriteLine("Başarılı "+ outSayi);
            //   }else{
            //     Console.WriteLine("Başarısız ");
            //   }    

            Metotlar instance = new Metotlar();
            //   instance.Topla(4,5,out int sonuc3);
            //   Console.WriteLine("sonuc3= "+sonuc3);   

            //   //Metot Overloading - Aşırı Yükleme
            //   int ifade = 999;
            //   instance.EkranaYazdir(ifade);
         
           //##Extension ve Rekürsif Metotlar
           //Rekürsif Metotlar
            // int result = 1;
            // for(int i = 1; i < 5 ; i++)
            //   result = result*3;
            //   Console.WriteLine(result);
            // Console.WriteLine(instance.Expo(5,2));

           //Extension  Metotlar

           string ifade = "Zikriye Ürkmez";
          //  bool sonuc = ifade.CheckSpaces();
          //  Console.WriteLine(sonuc);
          //  if(sonuc){
          //    var clean= ifade.CleanSpaces();
          //    Console.WriteLine(clean);
          //  }
          //Console.WriteLine(ifade.MakeUpperCase());
          int[] dizi ={10,25,2,1,15,17,23,32,36};
         
          var sonuc = dizi.ArrayOrdered();
          for(int i = 0; i < sonuc.Length ; i++) {
            if(i == sonuc.Length-1){
              Console.Write(sonuc[i]);
              break;
            }else{
              Console.Write(sonuc[i]+",");
            }
              
          }       
         
          

        }      
            
    }//Program-class-end
   class Metotlar 
   {
            //  public void Topla (int a, int b,out int toplam)
            //  {
            //   toplam = a+b;
            //  }

            //  public void EkranaYazdir(string veri){
            //   Console.WriteLine(veri);
            //  }
            //   public void EkranaYazdir(int veri){ //overloading
            //   Console.WriteLine(veri);
            //  }

            // public int Expo(int sayi,int us){
            //   if(us <2){
            //     return sayi;
            //   }
            //   return Expo(sayi,us-1)*sayi;
            // }
          

    }
    public static class Extension {

      public static bool CheckSpaces(this string param){

        return param.Contains(" ");

      }

      public static string CleanSpaces(this string param){
              
          string sonuc=  param.Replace(" ","");
          return sonuc;
      }

      public static string MakeUpperCase(this string param) {

        return param.ToUpper();
      }

      public static int[] ArrayOrdered(this int[] array)
      {
          
        int[] sonuc = array.OrderBy(c =>c).ToArray();
        return sonuc;
      }

    }

    
}

