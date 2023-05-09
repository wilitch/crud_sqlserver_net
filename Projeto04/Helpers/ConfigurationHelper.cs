using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto04.Helpers
{
    public class ConfigurationHelper
    {
        public static string GetConnectionString()
        {
            //lendo o conteudo do arquivo /appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            //retornando o valor da connectionstring contida no arquivo
            return configuration.GetConnectionString("Projeto04");
        }
    }
}
