using System;
namespace DbProject
{
    public abstract class DbConnection
    {
        private string _connectionString { get; set; }
        public TimeSpan _timeout { get; private set; }
        public ITest _test { get; private set;}

        public DbConnection(string connectionString, ITest test)
        {
            if (connectionString.Equals(null) || connectionString.Equals(""))
            {
                throw new Exception();
            }
            else
            {
                _connectionString = connectionString;
                _timeout = TimeSpan.FromSeconds(60);
                _test = test;
            }
        }

        public abstract void Open();
        public abstract void Close();
    }
}

