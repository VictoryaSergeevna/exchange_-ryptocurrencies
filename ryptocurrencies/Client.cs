using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp30
{
    class Client : IObserver
    {
        public double USD { get; set; }
        public double BTC { get; set; }
        public double CourseForSell { get; set; }
        public double SumForSell { set; get; }
        public double CourseForBuy { get; set; }
        public double SumForBuy { set; get; }
        public string Login {set;get;}
        public void Update(IMyOBservable observer)
        {
            Stock stock = observer as Stock;
            if (stock.BTCCourse <= this.CourseForBuy)
            {
                if (this.SumForBuy * stock.BTCCourse < this.USD)
                {
                    this.BTC += this.SumForBuy;
                    this.USD -= this.SumForBuy * stock.BTCCourse;
                    this.SumForBuy = 0;
                }
            }
            else
            if(stock.BTCCourse >= this.CourseForSell)
            {
                if (this.BTC > this.CourseForSell)
                {
                    this.USD += this.SumForSell * stock.BTCCourse;
                    this.BTC -= this.SumForSell;
                    this.SumForSell = 0;
                }
            }
        }
    }
}
