using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Defines a method that a type implements to compare two objects.
    /// </summary>
    /// <typeparam name="T">The type of objects to compare.</typeparam>
    public interface IComparer<in T>
    {
        /// <summary>
        /// Compares two objects and returns a value indicating whether one is less than, equal to, or greater than the other.
        /// </summary>
        /// <param name="lhs">The first object to compare.</param>
        /// <param name="rhs">The second object to compare.</param>
        /// <returns>A signed integer that indicates the relative values of lhs and rhs.
        /// Value Meaning Less than zero lhs is less than rhs.Zero lhs equals rhs. Greater
        /// than zero lhs is greater than rhs.</returns>
        int Compare(T lhs, T rhs);
    }
}
