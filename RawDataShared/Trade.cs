namespace RawDataShared
{
    public class Trade
    {
        public int TradeID { get; set; }
        public Instrument Instrument { get; set;}
        public BusinessUnit BusinessUnit { get; set;}
        public ProfitCentre ProfitCentre { get; set;}
        public decimal ReportingAmount { get; set;}
    }
}
