using System;
using System.Collections.Generic;
using DAL;  
using DTO;  

namespace BLL
{
    public class ProductBLL
    {
        private ProductDAL productDAL;

        public ProductBLL()
        {
            productDAL = new ProductDAL(); 
        }
        //public List<Product> GetAllProducts()
        //{
        //    return productDAL.GetAllProducts(); 
        //}

    }
}
