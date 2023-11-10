namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer customer1 = new Customer();
            //customer1.Name = "Eren";
            //customer1.LastName = "Macit";
            //customer1.Id = 1;
            //customer1.TaxNumber = "144444";
            //customer1.CustomerNo = "122222";
            //customer1.CompanyName = "?";
            
            //Eğer bir değer, class amacına uymuyorsa soyutlama hatası yapılmıştır. Company name Gerçek kişi değildir.
            //Burada gerçek kişi - tüzel kişi karmaşası mevcuttur.
            //SOLID

            IndividualCustomer individualCustomer1 = new IndividualCustomer();
            individualCustomer1.Id = 1;
            individualCustomer1.CustomerNo = "123142";
            individualCustomer1.Name = "Eren";
            individualCustomer1.LastName = "Macit";
            individualCustomer1.IdentityNumber = "22";

            //Macit Coorp.
            CorporateCustomer corporateCustomer1 = new CorporateCustomer();
            corporateCustomer1.Id = 2;
            corporateCustomer1.CustomerNo = "123";
            corporateCustomer1.CompanyName = "Macit Coorp.";
            corporateCustomer1.TaxNumber = "22";

            Customer individualCustomer2 = new IndividualCustomer();
            Customer corporateCustomer2 = new CorporateCustomer();
                
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(individualCustomer1);
            customerManager.Add(corporateCustomer1);
            customerManager.Add(individualCustomer2);
            customerManager.Add(corporateCustomer2);
        }
    }
}