using System.Text;
Console.OutputEncoding = System.Text.Encoding.UTF8;
StringBuilder report = new StringBuilder();
report.AppendLine("Текстовий Звіт Подій");
report.AppendLine("=====================");
report.AppendLine($"Дата {DateTime.Now.ToString()}");
report.AppendLine("\nСписок Подій:");
report.AppendLine("=====================");

int eventnumber = 1;
string eventtext;
while (true)
{
    Console.WriteLine("Введіть подію (або натисніть Enter для завершення):");
        eventtext = Console.ReadLine();
    if(string.IsNullOrWhiteSpace(eventtext))
    {
        break;
    }
    report.AppendLine($"{eventnumber}. {eventtext}.");
    eventnumber++;
}
report.AppendLine("=====================");
report.AppendLine("Кінець звіту.");
Console.WriteLine("\nОсь ваш звіт:\n");
Console.WriteLine(report.ToString());