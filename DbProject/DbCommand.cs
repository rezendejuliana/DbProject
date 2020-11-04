using System;
namespace DbProject
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;

        public DbCommand(DbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public void Execute(string instruction)
        {
            _dbConnection._test.Run();

            _dbConnection.Open(); //Open the connection

            Console.WriteLine(instruction); //Run the instruction

            _dbConnection.Close();  //Close the connection

        }
    }
}
