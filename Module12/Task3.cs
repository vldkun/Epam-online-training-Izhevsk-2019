using System;
using System.Collections;

namespace Module12
{
    /// <summary>
    /// Izh-12-3. Generics and Collections
    /// </summary>
    public class Task3
    {
        /// <summary>
        /// Counting of the Fibonacci's numbers.
        /// </summary>
        /// <param name="count">Number of Fibonacci numbers > 0.</param>
        /// <returns>Returns n Fibonacci numbers.</returns>
        public static IEnumerable Fibonacci(int count)
        {
            if (!(count > 0))
            {
                throw new ArgumentOutOfRangeException();
            }
            var preLast = 0;
            var last = 1;
            yield return preLast;
            if (count > 1)
            {
                yield return last;
            }
            for (int i = 2; i < count; i++)
            {
                var next = preLast + last;
                yield return next;
                preLast = last;
                last = next;
            }
        }
    }
}
