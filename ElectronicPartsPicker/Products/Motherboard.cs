using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicPartsPicker.Products
{
    public class Motherboard
    {
        /// <summary>
        /// The unique identifer of the Motherboard
        /// </summary>
        public int MotherboardId { get; set; }

        /// <summary>
        /// The name of the Motherboard
        /// </summary>
        public string MotherboardName { get; set; }

        /// <summary>
        /// The sales price of the Motherboard
        /// </summary>
        public double MotherboardPrice { get; set; }
    }
}
