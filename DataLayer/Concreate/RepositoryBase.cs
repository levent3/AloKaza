using Dapper;
using DataLayer.Abstract;
using DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Concreate
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class ,new()
    {
        private readonly IDataContext _dataContext;

        public RepositoryBase(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void Add(T entity)
        {
            string query = "INSERT INTO " + typeof(T).Name + "s (Name,TcNo) VALUES (@Name,@TcNo)";


            _dataContext.Connection.Execute(query,entity);


        }

      

        public void Delete(int id)
        {
            using (var connection = _dataContext.Connection)
            {
                string query = "SELECT * FROM " + typeof(T).Name + "s WHERE Id=@Id";
                connection.Execute(query);


            }
        }

        public IEnumerable<T> GetAll()
        {
            using (var connection = _dataContext.Connection)
            {
                string query="SELECT * FROM " +typeof(T).Name+"s";
                return connection.Query<T>(query);


            }
        }

        public T GetById(int id)
        {
            using (var connection = _dataContext.Connection)
            {
                string query = $"SELECT * FROM {typeof(T).Name}s WHERE Id = @Id";
                return connection.QueryFirstOrDefault<T>(query, new { Id = id });
            }
        }

        public void Update(T entity)
        {
            string query = $"UPDATE " + typeof(T).Name + "s SET Name = @Name, Age = @Age, TcNo = @TcNo WHERE Id = @Id";

            _dataContext.Connection.Execute(query,entity);    
        }
    }


}
