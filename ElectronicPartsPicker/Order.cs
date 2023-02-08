using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicPartsPicker
{
    /// <summary>
    /// Represents a single order to be placed
    /// </summary>
    public class Order
    {
        /// <summary>
        /// The unique order number 
        /// </summary>
        [Key]
        public int OrderNumber { get; set; }

        /// <summary>
        /// The name of the customer
        /// </summary>
        public char CustomerName { get; set; }
        
        /// <summary>
        /// The name of the part being ordered
        /// </summary>
        public char PartName { get; set; }

        /// <summary>
        /// The sales price of the parts
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// The total price amount of the parts being ordered
        /// </summary>
        public decimal PriceTotal { get; set;}
    }
}
