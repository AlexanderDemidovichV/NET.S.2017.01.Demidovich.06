using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ComparisonAdaptor<T>: IComparer<T>
    {

        private readonly Comparison<T> comparison;

        public ComparisonAdaptor(Comparison<T> comparison)
        {
            if (ReferenceEquals(comparison, null))
                throw new ArgumentNullException();

            this.comparison = comparison;
        }

        public int Compare(T lhs, T rhs) => comparison(lhs, rhs);
    }
}
