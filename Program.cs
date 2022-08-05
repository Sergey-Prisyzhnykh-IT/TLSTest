using System.Text;
using TLSTest;

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

bool checkChoice = false;
int choiceSaveFile = 0;
string path = Directory.GetCurrentDirectory();
ReadFile readFile = new ReadFile();
IWriter writer;

var menu = new List<MenuItem>
            {
                new MenuItem() { Id = 1, Text = "Сохранить в Json", Action = () => { Menu.Print("Выбран Json"); } },
                new MenuItem() { Id = 2, Text = "Сохранить в CSV", Action = () => { Menu.Print("Выбран CSV");} }
            };

var file = await Task.Run(() => readFile.OpenExcelFile(path));
readFile.ShowText(file);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("В каком формате сохранить файл");
Console.ResetColor();

while (!checkChoice)
{
    Menu.PrintMenu(menu);
    try
    {
        choiceSaveFile = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Веден неверный символ");
        Console.ResetColor();
    }
    

    if (choiceSaveFile == 0 || !menu.Any(x => x.Id == choiceSaveFile))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Menu.Print("Это еще не реализовано, ждите обновления \n");
        Console.ResetColor();
        continue;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        menu.First(x => x.Id == choiceSaveFile).Action();
        Console.ResetColor();
        checkChoice = true;
    }
}
switch (choiceSaveFile)
{
    case 1:       
            writer = new WriterJson();
            await writer.WriteFileAsync(path, file);
            break;
        case 2:
            writer = new WriteCSV();
            await writer.WriteFileAsync(path, file);
            break;

    default:
        Console.WriteLine("Неверный формат");
        break;
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Запись прошла успешна");
Console.WriteLine($@"Путь до файла {path}\DataBase");;
Console.ResetColor();

Console.ReadKey();