using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace SampleWebApp_With_NunitTest.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        // Here build DbConnection;


        public T Get(T entity)
        {
            //return Connection.Get<T>(entity);

            return null;
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
