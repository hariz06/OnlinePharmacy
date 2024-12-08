namespace OnlinePharmacy.Domain
{
    public class Staff : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Role { get; set; }
        public string? Contact { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int ShopId { get; set; }
    }
}
