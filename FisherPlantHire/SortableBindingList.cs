using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FisherPlantHire
{
    public class SortableBindingList<T> : BindingList<T>
    {
        // Adapted from https://msdn.microsoft.com/en-us/library/ms993236.aspx

        private bool IsSorted;

        protected override bool SupportsSortingCore { get { return true; } }
        protected override bool IsSortedCore { get { return IsSorted; } }

        public SortableBindingList() : base()
        {
        }

        public SortableBindingList(IList<T> list) : base(list)
        {
        }

        protected override void RemoveSortCore()
        {
            IsSorted = false;
        }

        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            // Get List<T> to sort
            List<T> items = this.Items as List<T>;

            // Apply and set the sort, if items to sort
            if (items != null)
            {
                PropertyComparer<T> pc = new PropertyComparer<T>(prop, direction);
                items.Sort(pc);
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
