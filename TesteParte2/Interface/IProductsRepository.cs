using System;
using System.Collections.Generic;
using TesteParte2.Domains;

namespace TesteParte2.Interface
{
    public interface IProductsRepository
    {
        List<Products> GetProducts();

        Products GetById(Guid id);

        void Post(Guid id, Products products);

        void Put(Products products);

        void Delete(Guid id);


        object? GetAll();
    }
}




