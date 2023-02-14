using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicPartsPicker.Products
{
    public class Nic
    {
        /// <summary>
        /// THe unique identifier of the NIC
        /// </summary>
        public int NicId { get; set; }

        /// <summary>
        /// The name of the NIC
        /// </summary>
        public string NicName { get; set; }
        
        /// <summary>
        /// The value of the NIC
        /// </summary>
        public double NicValue { get; set; }
    }
}
