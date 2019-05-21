using Dapper;
using Microsoft.Extensions.Configuration;
using my_vue_starter.Interfaces;
using my_vue_starter.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace my_vue_starter.DataProviders
{
    public class PersonsDataProvider : IPersons
    {
        private readonly string connectionString;
        public PersonsDataProvider(IConfiguration configuration)
        {
            this.connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public async Task<IEnumerable<Persons>> GetPersons(int Id)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                await sqlConnection.OpenAsync();
                var dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@id",Id);
                return await sqlConnection.QueryAsync<Persons>(
                    "getPersons",
                    dynamicParameters,
                    commandType: CommandType.StoredProcedure);
            }
        }
    }
}
