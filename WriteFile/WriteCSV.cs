using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLSTest
{
    public class WriteCSV : IWriter
    {
        public async Task WriteFileAsync(string path, List<DataBase> dataBases)
        {
            StringBuilder text = new StringBuilder();
            text.Append("Id;Segment;Country;Product;Discount Band;Units Sold;Manufacturing Price;Sale Price;Gross Sales;Discounts;Sales;COGS;Profit;Date;Month Number;Month Name;Year \n");
            foreach (var data in dataBases)
            {
                text.Append($"{data.Id} ; {data.Segment} ; {data.Country} ; {data.Product} ; " +
                            $"{data.DiscountBand} ; {data.UnitsSold} ; {data.ManufacturingPrice} " +
                            $"; {data.SalePrice} ; {data.GrossSales} ; {data.Discounts} ; {data.Sales} ; {data.COGS} " +
                            $"; {data.Profit} ; {data.Date} ; {data.MonthNumber} ; {data.MonthName} ; {data.Year} \n");

            }
            await File.WriteAllTextAsync(path + @"\DataBase.csv", text.ToString());
        }
    }
}

