using System;

namespace DbProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var sqlDbConnection = new SqlConnection("sql",new TesteGabriel());
            var command = new DbCommand(sqlDbConnection);
            command.Execute("sql");

            var oracleDbConnection = new OracleConnection("oracle", new TesteJuliana());
            var cmd = new DbCommand(oracleDbConnection);
            cmd.Execute("oracle");

        }
    }
}
