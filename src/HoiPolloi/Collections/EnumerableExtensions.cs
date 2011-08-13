using System;
using System.Collections.Generic;
using System.Linq;

namespace HoiPolloi.Collections
{
    public static class EnumerableExtensions
    {

        /// <summary>
        /// Execute an action on each item in the enumeration.
        /// </summary>
        /// <param name="items">The list to act on</param>
        /// <param name="action">The action to call for each item.</param>
        public static void ForEach<T>(this IEnumerable<T> items, Action<T> action)
        {
            foreach (var item in items)
                action(item);
        }

        /// <summary>
        /// Gets if the list is null or has no items in it.
        /// </summary>
        /// <param name="list">The list to check</param>
        /// <returns>True if <paramref name="list" /> is null or contains zero items, false otherwise.</returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> list)
        {
            return (list == null) || (!list.Any());
        }

    }
}
