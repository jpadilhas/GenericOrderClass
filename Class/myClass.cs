using System;
using System.Collections.Generic;

namespace OrdenarItens
{
    class myClass
    {
        public class myDomainClassOrder : IComparer<myDomainClass>
        {
            GenericOrder order;
            public myDomainClassOrder(string columnOrder, bool up)
            {
                order = new GenericOrder(typeof(myDomainClass), columnOrder, up);
            }

            public int Compare(myDomainClass x, myDomainClass y)
            {
                return order.Compare(x, y);
            }
        } 
    }
}
