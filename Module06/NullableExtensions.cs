using System;


namespace Module06
{
    /// <summary>
    /// Task Izh-06-3. Methods in details. 
    /// </summary>
    public static class NullableExtensions
    {
        /// <summary>
        /// For nullable types checking is reference null.
        /// </summary>
        /// <typeparam name="T">Nullable type.</typeparam>
        /// <param name="var">Variable to check.</param>
        /// <returns>Returns true if null, false if not.</returns>
        public static bool IsNull<T>(this T var)
        {
            return var == null;
        } 
    }
}
