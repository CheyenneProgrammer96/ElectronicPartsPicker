using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicPartsPicker.Products
{
    public class gpu
    {
        /// <summary>
        /// The unique identifier of the GPU
        /// </summary>
        public int gpuId { get; set; }

        /// <summary>
        /// The name of the GPU
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The value of the GPU
        /// </summary>
        public double gpuValue { get; set; }
    }
}
