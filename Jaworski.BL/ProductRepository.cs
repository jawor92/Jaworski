using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaworski.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// This method will be download one, particluar Product data
        /// </summary>
        /// <param name="ProductID"></param>
        /// <returns></returns>
        public Product DownloadData(int ProductID)
        {
            // Creating poroduct instance

            Product Product = new Product(ProductID);

            // code to download ProductID data

            //temporary hardcoded values to return product
            if (ProductID == 5)
            {
                Product.NameOfProduct = "Blocks";
                Product.Description = "Blocks for Kids";
                Product.CurrentPrice = 89.99M;
            }

            return Product;
        }

        /// <summary>
        /// Download all Products data
        /// </summary>
        /// <returns></returns>
        public List<Product> DownloadData()
        {
            //Code can download all Products data
            return new List<Product>();
        }
        /// <summary>
        /// This method will be saved Product
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //code to saved defined Product
            return true;
        }
    }
}
