using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleManagement
{
   public class PaymentModule 
    {
        IProduct _product;
        public PaymentModule(IProduct product)
        {
            _product = product;
        }

        public bool PayForTheProduct(double amount)
        {
            _product.PayForTheProduct(amount);
            return true;
        }
    }
}
