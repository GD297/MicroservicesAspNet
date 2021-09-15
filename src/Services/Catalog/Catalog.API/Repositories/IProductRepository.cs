﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.API.Entities;

namespace Catalog.API.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProduct();

        Task<Product> GetProduct(string id);
        Task<IEnumerable<Product>> GetProductsByName(string name);

        Task<IEnumerable<Product>> GetProductsByCatagory(string categoryName);

        Task CreateProduct(Product product);

        Task<bool> UpdateProduct(Product product);

        Task<bool> DeleteProduct(string id);
    }
}
