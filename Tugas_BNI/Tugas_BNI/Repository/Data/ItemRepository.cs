using API.Context;
using API.Models;
using API.ViewModels;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.Data
{
    public class ItemRepository : GeneralRepository<MyContext, Item, string>
    {
       
        public IConfiguration _configuration;
        readonly DynamicParameters _parameters = new DynamicParameters();
        public ItemRepository(MyContext myContext, IConfiguration configuration) : base(myContext)
        {
            _configuration = configuration;
        }
        public InsertItemsVM Insert(InsertItemsVM insert)
        {
            var _customer = new GeneralDapperRepository<InsertItemsVM>(_configuration);
            _parameters.Add("@Name", insert.Name);
            _parameters.Add("@Stok", insert.Stok);
            _parameters.Add("@Price", insert.Price);
            _parameters.Add("@Type", insert.Type);
            var result = _customer.Query("SP_InsertItems", _parameters);

            return result;
        }

        public IEnumerable<GetItemVM> GetItem()
        {
            var _customer = new GeneralDapperRepository<GetItemVM>(_configuration);
            var result = _customer.Get("SP_GetItem", _parameters);
            return result;
        }
    }
}
