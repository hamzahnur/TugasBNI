using API.Context;
using API.Handler;
using API.Models;
using API.ViewModels;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace API.Repository.Data
{
    public class TranscationRepository : GeneralRepository<MyContext, Transcation, string>
    {
        public IConfiguration _configuration;
        readonly DynamicParameters _parameters = new DynamicParameters();
        private readonly SendEmail sendEmail = new SendEmail();
        private MyContext _myContext;
        public TranscationRepository(MyContext myContext, IConfiguration configuration) : base(myContext)
        {
            _configuration = configuration;
            _myContext = myContext;
        }
        public InsertTransactionVM Insert(InsertTransactionVM insert)
        {
            var time24 = DateTime.Now;
            var _transaction = new GeneralDapperRepository<InsertTransactionVM>(_configuration);
            _parameters.Add("@IdCustomer", insert.IdCustomer);
            _parameters.Add("@IdItem", insert.IdItem);
            _parameters.Add("@Date", time24);
            _parameters.Add("@TotalCost", insert.TotalCost);
            _parameters.Add("@Qty", insert.Qty);
            var result = _transaction.Query("SP_InsertTranscation", _parameters);
            return result;

        }
        public IEnumerable<GetTransactionVM> GetTransaction(string idTransaction)
        {
            var _customer = new GeneralDapperRepository<GetTransactionVM>(_configuration);
            _parameters.Add("@ID", idTransaction);
            var result = _customer.Get("SP_GetTransaction", _parameters);
            return result;
        }
        public int Deletes(string idTransaction)
        {
            var entity = _myContext.Transcations.Find(idTransaction);
            if (entity == null)
                throw new ArgumentNullException("entity");
            _myContext.Remove(entity);
            var result = _myContext.SaveChanges();
            return result;
        }
    }
}
