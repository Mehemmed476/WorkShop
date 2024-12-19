using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShopManagement.DAL.Helpers;

public class ConnectionStr
{
    public static string GetConnectionString()
    {
        ConfigurationManager configurationManager = new ConfigurationManager();
        configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "..", "WorkShopManagement.API"));
        configurationManager.AddJsonFile("appsettings.json");

        string? connectionString = configurationManager.GetConnectionString("PcMsSql");
        if (connectionString is null)
        {
            throw new Exception("Connection String not found");
        }
        return connectionString;
    }
}
