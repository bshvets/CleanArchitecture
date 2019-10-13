using IdealWay.Persistence;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdealWay.Web.Helpers
{
    public class ConnectionStringProvider : IConnectionStringProvider
    {
        public const string MainDatabaseConnection = "MainConnectionString";
        private readonly IConfiguration _configuration;

        public ConnectionStringProvider(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConnectionString()
        {
            return GetConnectionString(_configuration);
        }

        public static string GetConnectionString(IConfiguration configuration)
        {
            return configuration.GetConnectionString(MainDatabaseConnection);
        }
    }
}
