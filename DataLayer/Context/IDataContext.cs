using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;


namespace DataLayer.Context
{
    public interface IDataContext
    {

        IDbConnection Connection { get; }
    }
}

