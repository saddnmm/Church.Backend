namespace Church.Domain
{
    internal class Payment_donation
    {
        public Guid
            Payment_donationid
        { get; set; }

        public string Donation_name { get; set; }

        public decimal Donation_sum { get; set; }

        public string? description { get; set; }

        public string? phone_number { get; set; }

        public string? mail { get; set; }
    }
}
