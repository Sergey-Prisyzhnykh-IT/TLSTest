using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TLSTest
{
    public class WriterJson : IWriter
    {
        public async Task WriteFileAsync(string path, List<DataBase> dataBases)
        {
            await using FileStream createStream = File.Create(path + @"\DataBase.json");
            await JsonSerializer.SerializeAsync(createStream, dataBases);
        }
    }
}
