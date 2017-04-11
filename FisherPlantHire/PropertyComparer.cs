using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace FisherPlantHire
{
    public class PropertyComparer<T> : IComparer<T>
    {
        // Adapted from http://stackoverflow.com/questions/17912479/order-a-list-without-hardcoding-the-fields-or-direction

        private PropertyDescriptor Property;
        private ListSortDirection Direction;

        // Constructor
        public PropertyComparer(PropertyDescriptor property, ListSortDirection direction)
        {
            Property = property;
            Direction = direction;
        }

        // IComparer<T> interface
        public int Compare(T xValue, T yValue)
        {
            object x = GetPropertyValue(xValue, Property.Name);
            object y = GetPropertyValue(yValue, Property.Name);

            // Determine list order
            if (Direction == ListSortDirection.Ascending)
            {
                return CompareAscending(x, y);
            }
            else
            {
                return CompareDescending(x, y);
            }
        }

        public bool Equals(T xValue, T yValue)
        {
            return xValue.Equals(yValue);
        }

        public int GetHashCode(T obj)
        {
            return obj.GetHashCode();
        }

        private int CompareAscending(object xValue, object yValue)
        {
            // TODO: Implement IComparer interfaces on Hirer and Machine

            int Result;

            if (xValue == null && yValue != null) return -1;
            if (yValue == null && xValue != null) return 1;
            if (xValue == null && yValue == null) return 0;

            // If values implement IComparer
            if (xValue is IComparable)
            {
                Result = ((IComparable)xValue).CompareTo(yValue);
            }
            // If values don't implement IComparer but are equivalent
            else if (xValue.Equals(yValue))
            {
                Result = 0;
            }
            // Values don't implement IComparer and are not equivalent, so 
            // compare as string valuse
            else
            {
                Result = xValue.ToString().CompareTo(yValue.ToString());
            }

            // Return resulting value
            return Result;
        }

        private int CompareDescending(object xValue, object yValue)
        {
            // Return result for ascending or descending sort order is 
            // multiplied by 1 for ascending or -1 for descending
            return CompareAscending(xValue, yValue) * -1;
        }

        private object GetPropertyValue(T value, string property)
        {
            // Get property
            PropertyInfo pi = value.GetType().GetProperty(property);

            // Return value of property
            return pi.GetValue(value, null);
        }
    }
}
