using ExcelDataReader;
using System.Data;

namespace TLSTest
{
    public class ReadFile
    {
        public List<DataBase> OpenExcelFile(string path)
        {
            List<DataBase> linesDataBase = new List<DataBase>();
            FileStream stream = File.Open(path + @"\finExample.xlsx", FileMode.Open, FileAccess.Read);
            IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);

            DataSet dataSet = reader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = x => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true,
                }
            });

            foreach (DataTable table in dataSet.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    if (Convert.ToDecimal(row.ItemArray[12]) > 100000)
                    {
                        DataBase db = new DataBase(row.ItemArray[0], row.ItemArray[1], row.ItemArray[2], row.ItemArray[3], row.ItemArray[4],
                            row.ItemArray[5], row.ItemArray[6], row.ItemArray[7], row.ItemArray[8], row.ItemArray[9], row.ItemArray[10],
                            row.ItemArray[11], row.ItemArray[12], row.ItemArray[13], row.ItemArray[14], row.ItemArray[15], row.ItemArray[16]);
                        
                        linesDataBase.Add(db);
                    }
                }
            }
            return linesDataBase;
        }

        public void ShowText(List<DataBase> dataBases)
        {
            foreach (var data in dataBases)
            {
                Console.WriteLine($"Id:{data.Id} | Segment:{data.Segment} | Country:{data.Country} | Product:{data.Product} | " +
                    $"Discount Band:{data.DiscountBand} | Units Sold:{data.UnitsSold} | Manufacturing Price:{data.ManufacturingPrice} " +
                    $"| Sale Price:{data.SalePrice} | Gross Sales:{data.GrossSales} | Discounts:{data.Discounts} | Sales:{data.Sales} | COGS:{data.COGS} " +
                    $"| Profit:{data.Profit} | Date:{data.Date} | Month Number:{data.MonthNumber} | Month Name:{data.MonthName} | Year:{data.Year}");
                Console.WriteLine();
            }
        }
    }
}
