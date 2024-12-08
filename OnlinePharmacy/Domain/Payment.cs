namespace OnlinePharmacy.Domain
{
    public class Payment : BaseDomainModel
    {
        public string? Payment_Type { get; set; }
        public DateTime P_Date { get; set; }
        public int OrderId { get; set; }
        public int CustId { get; set; }

    }
}
