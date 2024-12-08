using System.Globalization;

namespace OnlinePharmacy.Domain
{
    public class Shop : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Contact { get; set; }

    }
}
