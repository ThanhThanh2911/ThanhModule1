﻿using ShopShoes.BAL.Interface;
using ShopShoes.DAL.Interface;
using ShopShoes.Domain.Request;
using ShopShoes.Domain.Response.Product;
using System;
using System.Collections.Generic;

namespace ShopShoes.BAL
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public bool DeleteProduct(int id)
        {
            return productRepository.DeleteProduct(id);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return productRepository.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            return productRepository.GetProductById(id);
        }

        public IEnumerable<Product> GetProductByName(string name)
        {
            return productRepository.GetProductByName(name);
        }

        public SaveProductRes SaveProductRes(SaveProductReq saveProductReq)
        {
            return productRepository.SaveProduct(saveProductReq);
        }
    }
}
