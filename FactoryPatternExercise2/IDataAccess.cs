using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    // define the IDataAccess interface with LoadData and SaveData methods
    public interface IDataAccess
    {
        // method to load data from a data source and return a list of properties
        List<Product> LoadData();
        //method to save data to a data source, taking a list of products as input
        void SaveData(List<Product> products);
    }
}
