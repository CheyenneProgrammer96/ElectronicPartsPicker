using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicPartsPicker.Products
{
    public class Processor
    {
        /// <summary>
        /// The unique identifier of the Processor
        /// </summary>
        public int ProcessorId { get; set; }

        /// <summary>
        /// The name of the Processor
        /// </summary>
        public string ProcessorName { get; set; }

        /// <summary>
        /// The value of the Processor
        /// </summary>
        public double ProcessorValue { get; set; }
    }
}
