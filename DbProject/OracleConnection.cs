using System;
namespace DbProject
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string stringConnection, ITest test)
            : base(stringConnection,test)
        {
        }

        public override void Close()
        {
            Console.WriteLine("Close oracle");
        }

        public override void Open()
        {
            Console.WriteLine("Open oracle");
        }
    }
}
