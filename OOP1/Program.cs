namespace OOP1
{
    internal class Program
    {
        //Main
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;


            Product product2 = new Product { Id = 2, CategoryId = 5, ProductName = "Kalem", UnitPrice = 20, UnitsInStock = 4 };

            //Instance creation
            //Case sensitive - PascalCase, camelCase
            //Ref ve out keywords?
            ProductManager productManager1 = new ProductManager();
            productManager1.Add(product1);
            Console.WriteLine(product1.ProductName);

            /*  REF VE OUT KEYWORDS
                C# programlama dilinde ref ve out anahtar kelimeleri, bir işlevin argümanlarını işlerken değişkenlerin nasıl kullanılacağını 
            belirlemek için kullanılır. İşte bu iki anahtar kelimenin açıklamaları:

            ref Anahtar Kelimesi:
                ref kelimesi, bir değişkeni işlevin içinde hem okuma hem de yazma amaçlarıyla kullanmanızı sağlar.
                İşlevin çağrıldığı yerdeki değişkenin aynı bellek hücresini işaret eder. Bu nedenle, işlev içinde yapılan değişiklikler, çağrıldığı yerdeki değişkene yansır.
                ref anahtar kelimesi, işlevin birden fazla değeri döndürmesine yardımcı olur, çünkü işlev çağrıldığında değişkenlerin içeriğini güncelleyebilir.

            ref kullanımı örnek:

                    void DegiskeniArtir(ref int sayi)
                    {
                        sayi++;
                    }

                    int deger = 5;
                    DegiskeniArtir(ref deger);
                    Console.WriteLine(deger); // 6

            out Anahtar Kelimesi:
                out kelimesi, işlevin içinde bir değişkeni yalnızca yazma amaçlarıyla kullanmanızı sağlar. İşlev, bu değişkeni belirli bir değerle doldurmak zorundadır.
                İşlevin çağrıldığı yerdeki değişkenin başlangıç değeri önemli değildir; işlev içinde başlatılmalıdır.
                out anahtar kelimesi, işlevin birden fazla değeri döndürmesini sağlar ve bu değerler işlev tarafından belirlenir.

            out kullanımı örnek:

                    void Hesapla(out int sonuc)
                    {
                        sonuc = 10;
                    }

                    int hesaplananDeger;
                    Hesapla(out hesaplananDeger);
                    Console.WriteLine(hesaplananDeger); // 10


            Bu anahtar kelimeler, işlevler aracılığıyla değişkenlere değer atamak veya geri döndürmek için kullanılırken,
            ref ve out kelimesi kullanıldığında çağrıldığı yerdeki değişkenlerin içeriği etkilenebilir. Ancak ref ve out arasındaki 
            temel fark, ref için çağrıldığı yerdeki değişkenin başlangıç değerine dikkat edilmesi gerekirken, out için böyle bir gereklilik yoktur, işlev başlatmalıdır.



            Özünde, ref ve out anahtar kelimeleri değer türlerinin içeriklerini değiştirmez, ancak bu anahtar kelimeler, 
            bir değer türünün referansını işlev içinde kullanarak işlevin dışındaki değişkenin değerini etkileyebilirler. 
            Başka bir deyişle, ref ve out kullanıldığında, işlev dışındaki değişkenin bellek adresi üzerinden çalışılır, 
            bu nedenle işlevin içindeki değişiklikler işlev dışındaki değişkeni etkileyebilir.

            İşte bir örnek:

                    void DegiskeniArtir(ref int sayi)
                    {
                        sayi++;
                    }

                    int deger = 5;
                    DegiskeniArtir(ref deger);
                    Console.WriteLine(deger); // 6

            Bu örnekte, ref anahtar kelimesi kullanıldığında, DegiskeniArtir işlevi dışındaki deger değişkeninin değeri arttı, 
            çünkü ref ile işlevin dışındaki deger değişkeni işlevin içindeki sayi değişkeni ile aynı bellek hücresini paylaşır.

            Buna karşılık, ref veya out anahtar kelimeleri kullanılmadan aynı işlemi gerçekleştirmeye çalışırsanız:

                    void DegiskeniArtir(int sayi)
                    {
                        sayi++;
                    }

                    int deger = 5;
                    DegiskeniArtir(deger);
                    Console.WriteLine(deger); // 5

            ref veya out kullanılmadan, işlevin içindeki değişiklikler işlev dışındaki deger değişkenini etkilemez, 
            çünkü sayi ve deger iki ayrı bellek hücresini temsil eder. ref veya out anahtar kelimeleri kullanılmadığında,
            değer türleri sadece kopyalandığı için işlevin içinde yapılan değişiklikler dışarıya yansımaz.

             */

        }
    }
}