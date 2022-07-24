using System;
using System.Collections.Generic;

namespace MultiFactory
{
    class Orders
    {
        List<object> OrderedProducts = new List<object>();
        public object AddOrder(object orderedProduct){
            OrderedProducts.Add(orderedProduct);
            return orderedProduct;
        }
        public List<object> GetOrders(){
            return OrderedProducts;
        }
    }
}
