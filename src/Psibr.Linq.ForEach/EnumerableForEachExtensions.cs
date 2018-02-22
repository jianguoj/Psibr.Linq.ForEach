using System;
using System.Collections;
using System.Collections.Generic;
#if !NET40
using System.Threading.Tasks;
#endif

// ReSharper disable once CheckNamespace
namespace System.Linq
{
    public static class EnumerableForEachExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (var item in enumerable)
            {
                action(item);
            }
        }

        public static void ForEach(this IEnumerable enumerable, Action<object> action)
        {
            foreach (var item in enumerable)
            {
                action(item);
            }
        }

#if !NET40
        public static async Task ForEachAsync<T>(this IEnumerable<T> enumerable, Func<T, Task> action)
        {
            foreach (var item in enumerable)
            {
                await action(item);
            }
        }
#endif
    }
}
