using System;
using System.Collections;
namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            //  liste.Add("Ayşe");
            //  liste.Add(2);
            //  liste.Add(true);
            //  liste.Add('A');
           
            //Console.WriteLine(liste[0]);          
            //  foreach(var item in liste) {
            //     Console.WriteLine(item);                             
            //  }

            //AddRange
            // Console.WriteLine("**** Add Range ****");       
            // string[] renkler = {"Kırmızı","Mavi","Siyah"};
            List<int> sayilar = new List<int>(){1,2,5,67,7};
            // liste.AddRange(renkler);
            liste.AddRange(sayilar);

            
            //Sort
            // Console.WriteLine("**** Sort ****");  
            // liste.Sort();
            

            // foreach(var item in liste) {
            //     Console.WriteLine(item);                             
            // }

            //BinarySearch

           // Console.WriteLine(liste.BinarySearch(5));

            //Reverse
            //liste.Sort();
            liste.Reverse();
            Console.WriteLine("**** Reverse ****");  
             foreach(var item in liste) {
                Console.WriteLine(item);                             
            }
            Console.WriteLine("**** Clear ****");  
            liste.Clear();
            Console.WriteLine("**** Reverse ****");  
            foreach(var item in liste) {
                Console.WriteLine(item);                             
            }
        }
            
     }
}

