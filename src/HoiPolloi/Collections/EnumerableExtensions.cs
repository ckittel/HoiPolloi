using System;
using System.Collections.Generic;
using System.Linq;

namespace HoiPolloi.Collections
{
    public static class EnumerableExtensions
    {

        public static void ForEach<T>(this IEnumerable<T> items, Action<T> action)
        {
            foreach (var item in items)
                action(item);
        }

        public static bool IsNullOrEmpty<T>(this IEnumerable<T> list)
        {
            return (list == null) || (!list.Any());
        }

    }
}
