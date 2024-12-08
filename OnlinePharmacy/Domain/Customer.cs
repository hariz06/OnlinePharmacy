namespace OnlinePharmacy.Domain
{
    public class Customer : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Password { get; set; }
        public string? Contact { get; set; }
        public int ShopId { get; set; }
    }
}
