using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProjectHerculesService.Common;
using ProjectHerculesService.Data.Models;
using ProjectHerculesService.Repository.Interface;

namespace ProjectHerculesService.Repository.Implementation
{
    [ExcludeFromCodeCoverage]
    public class ContextContainer : IContextContainer
    {
        private readonly IConfiguration _configuration;

        public ContextContainer(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public HerculesContext GetHerculesServiceContextInstance()
        {
            string connectionString = _configuration[ConfigurationKeys.HerculesDatabaseConnectionString];

            HerculesContext context = new HerculesContext(connectionString);

            return context;
        }
    }
}