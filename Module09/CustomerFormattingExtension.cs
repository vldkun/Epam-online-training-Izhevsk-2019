using System.Globalization;
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
        /// <param name="flag">Byte flag.
        /// Left bit - name.
        /// Middle bit - revenue.
        /// Right bit - phone.</param>
        /// <returns>Returns string - customer's properties.</returns>
        public static string StringRepresentation(this Customer customer, byte flag)
        {
            byte mask1 = 1;
            byte mask2 = 2;
            byte mask3 = 4;
            var strCustomerSb = new StringBuilder("Customer record:");
            if ((flag & mask3) == mask3)
            {
                strCustomerSb.Append(" " + customer.Name + ",");
            }
            if ((flag & mask2) == mask2)
            {
                strCustomerSb.Append(" " + string.Format(new CultureInfo("en-US", false), "{0:N}",customer.Revenue) + ",");
            }
            if ((flag & mask1) == mask1)
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
