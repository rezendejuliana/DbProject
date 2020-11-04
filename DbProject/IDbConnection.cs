using System;
namespace DbProject
{
    public interface IDbConnection
    {
        void Open();
        void Close();
    }
}
