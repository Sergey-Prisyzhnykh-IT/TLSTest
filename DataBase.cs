namespace TLSTest
{
    public class DataBase
    {
        public int Id { get; set; }
        public string Segment { get; set; }
        public string Country { get; set; }
        public string Product { get; set; }
        public string DiscountBand { get; set; }
        public decimal UnitsSold { get; set; }
        public decimal ManufacturingPrice { get; set; }
        public decimal SalePrice { get; set; }
        public decimal GrossSales { get; set; }
        public decimal Discounts { get; set; }
        public decimal Sales { get; set; }
        public decimal COGS { get; set; }
        public decimal Profit { get; set; }
        public DateTime Date { get; set; }
        public int MonthNumber { get; set; }
        public string MonthName { get; set; }
        public int Year { get; set; }

        public DataBase(object id, object segment, object country, object product, object discountBand, object unitsSold,
    object manufacturingPrice, object salePrice, object grossSales, object discounts, object sales,
    object cOGS, object profit, object date, object monthNumber, object monthName, object year)
        {
            Id = Convert.ToInt32(id);
            Segment = (string)segment;
            Country = (string)country;
            Product = (string)product;
            DiscountBand = (string)discountBand;
            UnitsSold = Convert.ToDecimal(unitsSold);
            ManufacturingPrice = Convert.ToDecimal(manufacturingPrice);
            SalePrice = Convert.ToDecimal(salePrice);
            GrossSales = Convert.ToDecimal(grossSales);
            Discounts = Convert.ToDecimal(discounts);
            Sales = Convert.ToDecimal(sales);
            COGS = Convert.ToDecimal(cOGS);
            Profit = Convert.ToDecimal(profit);
            Date = (DateTime)date;
            MonthNumber = Convert.ToInt32(monthNumber);
            MonthName = (string)monthName;
            Year = Convert.ToInt32(year);
        }
    }
}
