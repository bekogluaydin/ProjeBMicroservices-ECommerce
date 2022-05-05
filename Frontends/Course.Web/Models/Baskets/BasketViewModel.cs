using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Web.Models.Baskets
{
    public class BasketViewModel
    {
        public BasketViewModel()
        {
            _basketItems = new List<BasketItemViewModel>();
        }
        public string UserId { get; set; }

        public string DiscountCode { get; set; }

        public int? DiscountRate { get; set; }

        private List<BasketItemViewModel> _basketItems;

        public List<BasketItemViewModel> BasketItems
        {
            get
            {
                if (HasDiscount)
                {
                    // Örnek; kurs fiyat 100 TL indirim kodu %10
                    _basketItems.ForEach(x =>
                    {
                    var discountPrice = x.Price * ((decimal)DiscountRate.Value / 100); // buradan 10 TL gelir.
                        x.AppliedDiscount(Math.Round(x.Price - discountPrice, 2)); // kurs fiyat 100 tl - indirim 10 TL = 90,00 TL
                    });
                }
                return _basketItems;
            }
            set { _basketItems = value; }
        }

        public decimal TotalPrice
        {
            get => _basketItems.Sum(x => x.GetCurrentPrice * x.Quantity);
        }

        public bool HasDiscount
        {
            get => !string.IsNullOrEmpty(DiscountCode) && DiscountRate.HasValue;
        }

        public void CancelDiscount()
        {
            DiscountCode = null;
            DiscountRate = null;      
        }

        public void ApplyDiscount(string code, int rate)
        {
            DiscountCode = code;
            DiscountRate = rate;
        }
    }
}
