using System;
using System.Collections.Generic;

namespace Jaworski.BL
{
    public class Product : BaseClass
    {
        public Product()
        {

        }

        public Product(int ProductID)
        {
            this.ProductID = ProductID;
        }

        private int ProductID { get; set; }
        public Decimal? CurrentPrice { get; set; }
        //"Decimal?" - it can be "0", type -> nullable
        public string Description { get; set; }
        public string NameOfProduct { get; set; }

        //Methods
        /// <summary>
        /// Check data of product
        /// </summary>
        /// <returns></returns>
        public bool ValidateData()
        {
            var ProperVal = true;

            if (string.IsNullOrWhiteSpace(NameOfProduct))
                ProperVal = false;
            if (CurrentPrice == null)
                ProperVal = false;

            return ProperVal;
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

        /// <summary>
        /// This method will be download one, particluar Product data
        /// </summary>
        /// <param name="ProductID"></param>
        /// <returns></returns>
        public Client DownloadData(int ProductID)
        {
            // code to download ProductID data
            return new Client();
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
    }
}
