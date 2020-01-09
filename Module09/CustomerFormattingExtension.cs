using System.Globalization;
using System.Linq;
using System.Text;

namespace Module09
{
    /// <summary>
    /// Izh-09-1. Framework Fundamentals
    /// </summary>
    public static class CustomerFormattingExtension
    {
        /// <summary>
        /// String representation of class customer.
        /// </summary>
        /// <param name="customer">Customer to convert his properties to string.</param>
        /// <param name="format">
        /// 
        /// NN - name,
        /// PP - contact phone,
        /// RR - revenue.
        /// </param>
        /// <returns>Returns string - customer's properties.</returns>
        public static string StringRepresentation(this Customer customer, string format)
        {
            var result = format;
            result = result.Replace("RR", string.Format(new CultureInfo("en-US", false), "{0:N}", customer.Revenue));
            result = result.Replace("NN", customer.Name);
            result = result.Replace("PP", customer.ContactPhone);
            return result;
        }
    }
}
