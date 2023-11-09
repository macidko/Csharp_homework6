using System.Runtime.InteropServices;

namespace ValueAndReferanceType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int number1 = 10;
            int number2 = 30;
            number1 = number2;
            number2 = 65;
            //Console.WriteLine(number1); CEVAP: 30 - Value Type
            //Value Types: int, decimal, float, double

            int[] numbers1 = new int[] {10,20,30};
            int[] numbers2 = new int[] {100,200,300};
            numbers1 = numbers2;
            numbers2[0] = 999;
            //Console.WriteLine(numbers1[0]); CEVAP: 999 - Reference Type
            //Reference Types: array, class, interface

            //Bellekte(RAM) Stack ve Heap diye 2 alan vardır.
            //değer tip olanlar YALNIZCA stack'te gerçekleşir ve değer tipte yalnızca değer aktarılır. Değer aktarma işleminde, değişkenler arasındaki iletişim yalnızca o satırda
            //gerçekleşir. Ardından iletişim kopar. Amaç yalnızca değer aktarmakdır.

            //Referans tiplerde de değişken tanımlandığında (int[] number) stack'te tutulur. Ancak değer tanımlamak için "NEW" yazıldığı anda ramdeki "heap"
            //bölümünde yeni bir adres oluşturur ve değeri oraya yazar. Bağlantı, stack'te tutulan değişkenin heap'te tutulan değer adresini
            //işaret etmesi ile kurulur.
            //Dolayısıyla sayilar1 = sayilar2 yazıldığında, sayılar1'in heap adresi, sayilar2 adresi olarak değiştirilir ve sayilar1'in ramdeki heap adresi silinir(GARBAGE COLLECTOR).
            //yani sayilar1'in ramdeki referansı değiştirilir. Böylece sayilar1'in değer karlığı her zaman sayılar2'nin değerini işaret eder. (POINTER) 
        }
    }
}