namespace Common.Messages
{
    public class BackupMessage
    {
        public int PlanId { get; set; }

        public string SaleType { get; set; }

        public string BillingCycle { get; set; }

        public int Price { get; set; }
    }
}