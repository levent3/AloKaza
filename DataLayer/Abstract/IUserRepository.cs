﻿using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LinqToDB.Reflection.Methods.LinqToDB.Insert;

namespace DataLayer.Abstract
{
    public interface IUserRepository:IRepositoryBase<User>
    {

        IEnumerable<User> GetAllUser();
    }
}
