using System.Collections.Generic;
using System.ComponentModel;

namespace FisherPlantHire
{
    public class SortableBindingList<T> : BindingList<T>
    {
        // Adapted from https://msdn.microsoft.com/en-us/library/ms993236.aspx

        private bool IsSorted;
        private ListSortDirection SortDirection;
        private PropertyDescriptor SortProperty;

        protected override bool SupportsSortingCore { get { return true; } }
        protected override bool IsSortedCore { get { return IsSorted; } }
        protected override PropertyDescriptor SortPropertyCore { get { return SortProperty; } }
        protected override ListSortDirection SortDirectionCore {  get { return SortDirection;  } }

        public SortableBindingList() : base()
        {
        }

        public SortableBindingList(IList<T> list) : base(list)
        {
        }

        protected override void RemoveSortCore()
        {
            SortProperty = null;
            SortDirection = ListSortDirection.Ascending;
            IsSorted = false;
        }

        protected override void ApplySortCore(PropertyDescriptor property, ListSortDirection direction)
        {
            // Get List<T> to sort
            List<T> items = this.Items as List<T>;

            // Apply and set the sort, if items to sort
            if (items != null)
            {
                PropertyComparer<T> pc = new PropertyComparer<T>(property, direction);
                items.Sort(pc); //Apparently Sort() is unstable
                //this.OrderBy(t => t, pc); // OrderBy() instead of Sort() doesn't seem to work at all                
                SortProperty = property;
                SortDirection = direction;
                IsSorted = true;
            }
            else
            {
                IsSorted = false;
            }

            // Let bound controls know they should referesh their views
            this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }
    }
}
