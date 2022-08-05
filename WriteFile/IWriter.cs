
namespace TLSTest
{
    public interface IWriter
    {
        Task WriteFileAsync(string path, List<DataBase> dataBases);
    }
}