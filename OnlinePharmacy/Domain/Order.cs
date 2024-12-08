namespace OnlinePharmacy.Domain
{
    public class Order : BaseDomainModel
    {
        public int? Quantity { get; set; }
        public int ProductId { get; set; }
        public int ShopId { get; set; }
        public int CustId { get; set; }
        public int PaymentId { get; set; }
    }
}
