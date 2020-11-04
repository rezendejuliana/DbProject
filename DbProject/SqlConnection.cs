using System;
namespace DbProject
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string stringConnection, ITest test)
            : base (stringConnection, test)
        {
        }

        public override void Close()
        {
            Console.WriteLine("Close sql.");
        }

        public override void Open()
        {
            Console.WriteLine("Open sql.");
        }
    }
}
