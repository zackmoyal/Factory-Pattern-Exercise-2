using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    // implement MongoDataAccess class
    public class MongoDataAccess : IDataAccess
    {
        // implement method to load data from a Mongo database
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from a Mongo database");
            return new List<Product>(); // return an empty list
        }

        // implement method to save data to a Mongo database
        public void SaveData(List<Product> products)
        {
            Console.WriteLine("I am saving data to a Mongo database");
        }
    }
}
