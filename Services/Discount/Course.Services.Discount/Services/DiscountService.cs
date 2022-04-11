using Course.Shared.Dtos;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Services.Discount.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly IConfiguration _configuration;
        private readonly IDbConnection _dbConnection;

        public DiscountService(IConfiguration configuration)
        {
            _configuration = configuration;

            _dbConnection = new NpgsqlConnection(_configuration.GetConnectionString("PostgreSql")); 
        }

        public async Task<Response<NoContent>> Delete(int id)
        {
            var deleteStatus = await _dbConnection.ExecuteAsync("DELETE from discount where id=@Id", new { Id = id });

            return deleteStatus > 0 ? Response<NoContent>.Success(204) : Response<NoContent>.Fail("Discount not found", 404);
        }

        public async Task<Response<List<Models.Discount>>> GetByCodeAndUserId(string code, string userId)
        {
            var discounts = await _dbConnection.QueryAsync<Models.Discount>("SELECT * from discount where userid=@UserId and code=@Code", new {
                UserId=userId,
                Code=code
            });

            var hasDiscount = discounts.FirstOrDefault();

            return hasDiscount == null ? Response<List<Models.Discount>>.Fail("Discount not found", 404) : Response<List<Models.Discount>>.Success(discounts.ToList(), 200);
        }

        public async Task<Response<List<Models.Discount>>> GettAll()
        {
            var discounts = await _dbConnection.QueryAsync<Models.Discount>("Select * from discount");

            return Response<List<Models.Discount>>.Success(discounts.ToList(), 200);
        }

        public async Task<Response<Models.Discount>> GettById(int id)
        {
            var discount = (await _dbConnection.QueryAsync<Models.Discount>("Select * from discount where id=@Id", new { Id=id})).SingleOrDefault();

            return discount == null ? Response<Models.Discount>.Fail("Discount not found", 404) : Response<Models.Discount>.Success(discount, 200);
        }

        public async Task<Response<NoContent>> Save(Models.Discount discount)
        {
            var saveStatus = await _dbConnection.ExecuteAsync("INSERT INTO discount (userid,rate,code) VALUES (@UserID,@Rate,@Code)", discount);
            
            return saveStatus > 0 ? Response<NoContent>.Success(204) : Response<NoContent>.Fail("an error accurred while adding", 500);
        }

        public async Task<Response<NoContent>> Update(Models.Discount discount)
        {
            var updateStatus = await _dbConnection.ExecuteAsync("UPDATE discount set userid=@UserId, code=@Code, rate=@Rate WHERE id=@Id", new {
                Id = discount.Id,
                UserId = discount.UserId,
                Code = discount.Code,
                Rate = discount.Rate
            });

            return updateStatus > 0 ? Response<NoContent>.Success(204) : Response<NoContent>.Fail("Discount not found", 404);
        }
    }
}
