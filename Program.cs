using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
          //#1 
          //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
          //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
          //Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
          //  Console.WriteLine("Kaç Sayı Gireceksiniz");
          //  int total = Convert.ToInt32(Console.ReadLine());
          //  List<int> numbers = new List<int>();
          //  for(int i = 0; i < total; i++){
          //       Console.WriteLine((i+1)+". sayıyı giriniz");
          //       int readNumber = Convert.ToInt32(Console.ReadLine());
          //       numbers.Add(readNumber);
          //  }
          //   Console.WriteLine("/****== Girilen Çift Sayılar ==****/");
          //   foreach(var item in numbers){
          //     if(item %2 == 0){
          //       Console.WriteLine(item);
          //     }
          //   }


          //#2
          //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
          //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
          //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın. 
         
          //  Console.WriteLine("Kaç sayı gireceksiniz?");
          //  int totalNum = Convert.ToInt32(Console.ReadLine());
          //  Console.WriteLine("Baz alınacak sayıyı Giriniz -m");
          //  int numberM = Convert.ToInt32(Console.ReadLine());
          
          //  List<int> numbersTwo = new List<int>();

          //  for(int i = 0; i < totalNum; i++){
          //         Console.WriteLine((i+1)+". sayıyı giriniz");
          //         int readNumber = Convert.ToInt32(Console.ReadLine());
          //         numbersTwo.Add(readNumber);
          //  }
          
          //  //m'e eşit yada tam bölünenler
          //  Console.WriteLine("/****== m'e eşit yada tam bölünenler ==****/");
          //  foreach(var item in numbersTwo){
          
          //   if(item == numberM || numberM % item == 0) {
          //     Console.WriteLine(item);
          //   }
          //  }
        
          //#3
          //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
          //Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
          //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
          
          // Console.WriteLine("Kaç kelime gireceksiniz?");
          // int totalKey = Convert.ToInt32(Console.ReadLine());
          // List<string> keyList = new List<string>();

          // for(int i= 0; i < totalKey; i++){
          //    Console.WriteLine((i+1)+". kelimeyi giriniz");
          //    keyList.Add(Console.ReadLine());
          // }
          // Console.WriteLine("/****== Kelimeler ==****/");
          // keyList.Reverse();
          // foreach(var item in keyList){
          //      Console.WriteLine(item);
          // }
          
          //#4
          //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
          //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

          // Console.WriteLine("Bir kelime yazın");
          // string readstring = Console.ReadLine();
          // var word = readstring.Split(' ');
          // var letter = readstring.Replace(" ","");
          // Console.WriteLine(word.Length+" adet kelime var");
          // Console.WriteLine(letter.Length+" adet harf var");

        }//Main      
    }//Program-class-end     
}

