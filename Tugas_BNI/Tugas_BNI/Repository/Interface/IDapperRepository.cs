using Dapper;
using System.Collections.Generic;

namespace API.Repository.Interface
{
    public interface IDapperRepository<Entity> where Entity : class
    {
        Entity Query(string query, DynamicParameters parameters);
        IEnumerable<Entity> Get(string query, DynamicParameters parameters);
        int Update(string query, DynamicParameters parameters);
    }
}
