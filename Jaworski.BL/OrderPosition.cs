namespace Jaworski.BL
{
    public class OrderPosition
    {
        public OrderPosition()
        {

        }

        public OrderPosition(int PositionOrderID)
        {
            this.PositionOrderID = PositionOrderID;
        }

        public int PositionOrderID { get; set; }
        public int AmountOrder { get; set; }
        public int ProductID { get; set; }
        public decimal? PriceOfPurchase { get; set; }

        //Methods
        /// <summary>
        /// Check data of postion of order
        /// </summary>
        /// <returns></returns>
        public bool ValidateData()
        {
            var ProperVal = true;

            if (AmountOrder <= 0)
                ProperVal = false;            
            
            if (ProductID <= 0)
                ProperVal = false;

            if (PriceOfPurchase == 0)
                ProperVal = false;

            return ProperVal;
        }

        /// <summary>
        /// This method will be postion of order
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //code to saved defined postion of order
            return true;
        }

        /// <summary>
        /// This method will be download one, particluar postion of order
        /// </summary>
        /// <param name="PositionOrderID"></param>
        /// <returns></returns>
        public Client DownloadData(int PositionOrderID)
        {
            // code to download PositionOrderID data
            return new Client();
        }

    }
}
