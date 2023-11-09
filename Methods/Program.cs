namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(); //Class'ın örneği
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Description = "Amasya Elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Description = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };

            //type-safe
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("----------------------METHODS------------------------------");

            //instance - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Add2("Elma", "Yeşil Elma", 12, 3,);
            sepetManager.Add2("Karpuz", "Diyarbakır Karpuzu", 12, 1);
        }

    }
}
//Methodlar, tekrar tekrar kullanılabilirliği sağlayan kod blocklarıdır.
//Kod tekrarının önüne geçer
//Temiz kod yazılmasını sağlar
//Dont repeat yourself - DRY - Clean Code
//Manager, DataAccess, BLL?, DAL