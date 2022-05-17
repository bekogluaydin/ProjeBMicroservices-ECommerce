using Course.Web.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Web.Services.Interfaces
{
    public interface IOrderService
    {
        //Senkron İletişim - direkt order mikroservisine istek yapılacak.
        Task<OrderCreatedViewModel> CreateOrder(CheckoutInfoInput checkoutInfoInput);

        //Asenskron iletişim - sipariş bilgileri rabbitMQ'ya gönderilecek.
        Task<OrderSuspendViewModel> SuspendOrder(CheckoutInfoInput checkoutInfoInput);

        Task<List<OrderViewModel>> GetOrder();
    }

}
