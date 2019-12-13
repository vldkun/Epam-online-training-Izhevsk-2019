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
        /// <returns>Returns string - customer's properties.</returns>
        public static string StringRepresentation(this Customer customer)
        {
            var strCustomerSb = new StringBuilder("Customer record:");
            if (!string.IsNullOrEmpty(customer.Name))
            {
                strCustomerSb.Append(" " + customer.Name + ",");
            }
            if (!(customer.Revenue < 0))
            {
                strCustomerSb.Append(" " + string.Format(new CultureInfo("en-US", false), "{0:N}",customer.Revenue) + ",");
            }
            if (!string.IsNullOrEmpty(customer.ContactPhone))
            {
                strCustomerSb.Append(" " + customer.ContactPhone + ",");
            }

            if (strCustomerSb[strCustomerSb.Length - 1] == ',')
            {
                strCustomerSb.Remove(strCustomerSb.Length - 1, 1);
            }

            return strCustomerSb.ToString();
        }
    }
}
