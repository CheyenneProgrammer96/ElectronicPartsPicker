using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicPartsPicker.Products
{
    public class Memory
    {
        /// <summary>
        /// The unique identifier of the Memory
        /// </summary>
        public int MemoryId { get; set; }

        /// <summary>
        /// The name of the Memory
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The value of the Memory
        /// </summary>
        public double memoryValue { get; set; }
    }
}
