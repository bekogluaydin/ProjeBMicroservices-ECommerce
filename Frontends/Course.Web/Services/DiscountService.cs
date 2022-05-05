using Course.Web.Models.Discounts;
using Course.Web.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Web.Services
{
    public class DiscountService : IDiscountService
    {
        public Task<DiscountViewModel> GetDiscount(string discountCode)
        {
            throw new NotImplementedException();
        }
    }
}
