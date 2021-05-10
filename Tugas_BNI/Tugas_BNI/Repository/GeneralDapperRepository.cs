using API.Repository.Interface;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace API.Repository
{
    public class GeneralDapperRepository<Entity> : IDapperRepository<Entity> where Entity : class
    {
        private readonly IConfiguration _configuration;
        private readonly IDbConnection _connection;

        public GeneralDapperRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = new SqlConnection(_configuration.GetConnectionString("TugasBNI"));
        }
        public Entity Query(string query, DynamicParameters parameters)
        {
            var result = _connection.Query<Entity>(query, parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return result;
        }

        public IEnumerable<Entity> Get(string query, DynamicParameters parameters)
        {
            var result = _connection.Query<Entity>(query, parameters, commandType: CommandType.StoredProcedure).ToList();
            return result;
        }
        public int Update(string query, DynamicParameters parameters)
        {
            var result = _connection.Execute(query, parameters, commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}
