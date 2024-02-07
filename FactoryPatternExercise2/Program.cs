namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ask the user what database they want to use store their response
            Console.WriteLine("Enter the database type you want to use (list, sql, mongo):");
            string databaseType = Console.ReadLine();

            try
            {
                // call the factory method and store what it returns in an IDataAccess variable
                IDataAccess dataAccess = DataAccessFactory.GetDataAccessType(databaseType);

                // call the LoadData and SaveData methods of the IDataAccess variable
                List<Product> products = dataAccess.LoadData();
                dataAccess.SaveData(products);
            }
            catch (ArgumentException ex)
            {
                // invalid input
                Console.WriteLine(ex.Message);
            }
        }
    }
}
