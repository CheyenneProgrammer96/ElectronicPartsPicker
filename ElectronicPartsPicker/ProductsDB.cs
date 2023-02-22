using ElectronicPartsPicker.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicPartsPicker
{
    public class ProductsDB : OrderContext
    {
        private readonly OrderContext _context;

        public ProductsDB(OrderContext context)
        {
            _context = context;
        }
    }
}
