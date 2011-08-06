using System;
using System.Collections.Generic;

namespace HoiPolloi.Collections
{
    public static class DictionaryExtensions
    {
        public static TValue GetValue<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue)
        {
            if(dictionary == null) throw new ArgumentNullException("dictionary");

            TValue value;
            return dictionary.TryGetValue(key, out value) ? value : defaultValue;
        }
    }
}
