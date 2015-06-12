using System;
using System.Reflection;

namespace OrdenarItens
{
    class GenericOrder
    {
        PropertyInfo myProperty;
        bool up;

        public GenericOrder(Type getType, string columnOrder, bool up)
        {
            this.up = up;
            myProperty = getType.GetProperty(columnOrder);
        }

        public int Compare(object x, object y)
        {
            return ((IComparable)myProperty.GetValue(up ? x : y, null)).CompareTo(myProperty.GetValue(up ? y : x, null));            
        }
    }
}
