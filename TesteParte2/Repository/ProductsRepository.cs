using TesteParte2.Domains;
using TesteParte2.Interface;

namespace TesteParte2.Repository
{
    public class ProductsRepository : IProductsRepository
    {
        ProductsContext _context = new ProductsContext();
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Products> GetProducts()
        {
            throw new NotImplementedException();
        }

        public Products GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Post(Guid id, Products products)
        {
            throw new NotImplementedException();
        }

        public void Put(Products products)
        {
            throw new NotImplementedException();
        }

        public object? GetAll()
        {
            throw new NotImplementedException();
        }
    }

    internal class ProductsContext
    {
    }
}
