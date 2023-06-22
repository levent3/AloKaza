using Dapper;
using DataLayer.Abstract;
using DataLayer.Context;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LinqToDB.Reflection.Methods.LinqToDB.Insert;

namespace DataLayer.Concreate
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        private readonly IDataContext _dataContext;

        public UserRepository(IDataContext dataContext) : base(dataContext)
        {
           _dataContext = dataContext;
        }
            
        public IEnumerable<User> GetAllUser()
        {
            using (var connection = _dataContext.Connection)
            {
               
                return connection.Query<User>("GetAllUser" /* Stored Procedure adını buraya yazın */, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
