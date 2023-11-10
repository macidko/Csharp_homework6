namespace OOP3
{
    internal class Program
    {
        //Interface'ler birbirinin alternatifi olan ancak içerikleri farklı olan örnekler için kullanılır
        static void Main(string[] args)
        {
            //PersonalFinanceCredit personalFinanceCredit = new PersonalFinanceCredit();
            //personalFinanceCredit.Calculate();

            //VehicleCreditManager vehicleCreditManager = new VehicleCreditManager();
            //vehicleCreditManager.Calculate();

            //MortgageManager mortgageManager = new MortgageManager();
            //mortgageManager.Calculate();


            //Interfaceler de, o interface'i implemente eden class'ın ref numarasını tutabilir.
            ICreditManager personalFinanceCredit = new PersonalFinanceCredit();
            //personalFinanceCredit.Calculate();k

            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            //vehicleCreditManager.Calculate();

            ICreditManager mortgageManager = new MortgageManager();
            //mortgageManager.Calculate();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Application(vehicleCreditManager, databaseLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>() { personalFinanceCredit, vehicleCreditManager };
            //applicationManager.Inform(credits);
        }
    }
}