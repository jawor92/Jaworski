namespace Jaworski.BL
{
    public class OrderDisplayPosition
    {
        public int OrderPositionID { get; private set; }
        public int Amount { get; set; }
        public string ProductName { get; set; }
        public decimal? PurchasePrice { get; set; }
    }
}