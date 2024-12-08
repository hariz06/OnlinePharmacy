namespace OnlinePharmacy.Domain
{
    public class Product : BaseDomainModel
    {
        public string? Prod_Name { get; set; }
        public string? Prod_Type { get; set; }
        public string? Cost { get; set; }
        public int? Quantity { get; set; }
        public int ShopId { get; set; }
    }
}
