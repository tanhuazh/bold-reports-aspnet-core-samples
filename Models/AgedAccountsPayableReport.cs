
namespace AgExpert.Accounting.Models.DataObjects
{
    public class AgedAccountsPayableReport
    {
        public string ContactId { get; set; }
        public string BusinessName { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string Supplier { get; set; }
        public decimal PayableBalance { get; set; }
        public decimal ThirtyDaysTotal { get; set; }
        public decimal SixtyDaysTotal { get; set; }
        public decimal NinetyDaysTotal { get; set; }
        public decimal PlusNinetyDaysTotal { get; set; }
    }
}