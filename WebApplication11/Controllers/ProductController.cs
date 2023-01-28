﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {


        ORIENTDBContext db = new ORIENTDBContext();

        [Route("api/[controller]")]
        [HttpGet]

        public List<Product> Get()
        {
            return db.Products.ToList();
        }

        [Route("api/[controller]/{id}")]
        [HttpGet]

        public Product Get(int id)
        {
            Product data = db.Products.Find(id);
            return data;
        }


        [Route("api/[controller]")]
        [HttpPost]

        public string gonder(Product pro)
        {
            string netice = "";
            try
            {
                db.Products.Add(pro);
                db.SaveChanges();
                netice = "success";
            }
            catch (SqlException ex)
            {
                netice = ex.Message;
            }
            finally
            {
                db.Dispose();
            }
            return netice;
        }

        [Route("api/[controller]/{id}")]
        [HttpPut]

        public string deyis(int id, Product product)
        {
            string netice = "";
            try
            {
                var pro = db.Products.Find(id);
                pro.Name = product.Name;
                pro.Category = product.Category;
                pro.MadedBy = product.MadedBy;
                pro.ProductDate = product.ProductDate;
                pro.Price = product.Price;
                db.SaveChanges();
                netice = "success";

            }
            catch (SqlException)
            {
                netice = "error";
            }

            finally
            {
                db.Dispose();
            }
            return netice;

        }

        [Route("api/[controller]/{id}")]
        [HttpDelete]
        public string sil(int id)
        {
            var pro = db.Products.Find(id);
            string netice = "";
            try
            {
                db.Remove(pro);
                db.SaveChanges();
                netice = "success";
            }
            catch (SqlException)
            {
                netice = "error";
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return netice;
        }
    }
}
