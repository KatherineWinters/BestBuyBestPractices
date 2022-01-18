using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBuyBestPractices
{
    internal class DapperProductRepository : IProductRepository
    {
            private readonly System.Data.IDbConnection _connection;

        void IProductRepository.CreateProduct(string name, double price, int categoryID)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Product> IProductRepository.GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Department> GetAllProducts()
        {
            return (IEnumerable<Department>)_connection.Query<Product>("SELECT * FROM PRODUCTS;").ToList();
        }
    }

    }
}
