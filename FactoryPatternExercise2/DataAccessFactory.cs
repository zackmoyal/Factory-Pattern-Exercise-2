using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    // implement DataAccessFactory class
    public static class DataAccessFactory
    {
        // method to create an instance of IDataAccess based on the database type
        public static IDataAccess GetDataAccessType(string databaseType)
        {
            // switch on the databaseType variable
            switch (databaseType.ToLower())
            {
                // if a user types in "list", return a new instance of ListDataAccess
                case "list":
                    return new ListDataAccess();

                // if a user types in "sql", return a new instance of SQLDataAccess
                case "sql":
                    return new SQLDataAccess();

                // if a user types in "mongo", return a new instance of MongoDataAccess
                case "mongo":
                    return new MongoDataAccess();

                default:
                    throw new ArgumentException("Invalid database type.");
            }
        }
    }
}
