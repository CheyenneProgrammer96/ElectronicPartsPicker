using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicPartsPicker
{
    /// <summary>
    /// Represents a Customer placing an order
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// The customer's legal first name
        /// </summary>
        public char FirstName { get; set; }

        /// <summary>
        /// The customer's legal last name
        /// </summary>

        public char LastName { get; set; }

        /// <summary>
        /// The customer's email address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The customer's phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The shipping address where the order will arrive
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Represents the number given after placing an order
        /// </summary>
        public string OrderNumber { get; set; }
    }
}
