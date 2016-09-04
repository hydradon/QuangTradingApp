using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuangsTradingApp
{
    public class Stock
    {
        public string StockName { get; set; }
        public int Number { get; set; }
        public double MinPrice { get; set; }
        public double MaxPrice { get; set; }

        public Stock() { }

        public Stock(string stockName, int numStock, double minPrice, double maxPrice)
        {
            this.StockName = stockName;
            this.Number = numStock;
            this.MinPrice = minPrice;
            this.MaxPrice = maxPrice;
        }

        public override string ToString()
        {
            return this.StockName;
        }

        public string Details
        {
            get
            {
                return string.Format($"There are {Number} of {StockName} stock. Minprice: {MinPrice} Maxprice: {MaxPrice}");
            }
        }
    }
}
