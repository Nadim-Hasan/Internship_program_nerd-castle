using AutoMapper;
using BussinessLogicLayer.DTOs.CustomerDTOs;
using DataAccessLayer;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer.Services.CustomerServices
{
    public class ProductService
    {

        ///product Crud ///

        public static List<ProductDTO> GetProducts()
        {
            //  var data = DataAccessFactory.ProductData().Read();
            var data = DataAccessFactory.ProductData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ProductDTO>>(data);
            return mapped;
            
        }

        public static List<ProductDTO> GetProducts(int id)
        {
            //  var data = DataAccessFactory.ProductData().Read();
            var data = DataAccessFactory.ProductData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ProductDTO>>(data);
            return mapped;

        }

        

        public static ProductDTO InsertProduct(ProductDTO product)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ProductDTO, Product>();
            });
            var mapper = new Mapper(cfg);
            var mappedProduct = mapper.Map<Product>(product);
            var insertedProduct = DataAccessFactory.ProductData().Create(mappedProduct);
            return product;

        }

        public static ProductDTO Update(ProductDTO product)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ProductDTO, Product>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Product>(product);
            DataAccessFactory.ProductData().Update(mapped);
            return product;
        }

        public static bool DeleteProduct(int id)
        {
            var data = DataAccessFactory.ProductData().Delete(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<bool>(data);
            return mapped;
        }

    }
}
