using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{   // implement ListDataAccess class
    public class ListDataAccess : IDataAccess
    {
        // implement method that retrieves data from the list and returns it
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from a List");
            return new List<Product>(); // return an empty list
        }

        // implement method to save data to a list
        // is void because doesn't need to return anything
        public void SaveData(List<Product> products)
        {
            Console.WriteLine("I am saving data to a List database");
        }
    }
}
