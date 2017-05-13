using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void DiscountOutput(string obj);

    public class Shop
    {
        //Properties
        public List<Good> Goods { get; set; } = new List<Good>();
        public DiscountOutput Output { get; set; }
        public event EventHandler<EventArgs> OutputDiscount;
        //Constructors
        public Shop()
        {

        }

        //Methods
        #region coment
        public void isPriceSmall()
        {
            foreach (var item in Goods)
            {
                if (item.Price < 200)
                {
                    OutputDiscount(item, new GoodEventArgs(item.ToString()));
                }
            }
        }
        #endregion
    }
}
