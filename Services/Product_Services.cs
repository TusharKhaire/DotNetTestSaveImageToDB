using IRepository;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Product_Services : IProduct
    {
        private readonly IDAL db;
        public Product_Services(IDAL _db)
        {
            this.db = _db;
        }
        public async Task<bool> SaveProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
