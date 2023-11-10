// See https://aka.ms/new-console-template for more information

using System.Collections.Specialized;
using System.Drawing;

Console.WriteLine("Input Rectangle data(Width & Lenght separated by space)");
int count = 0;
double total = 0;
string result = "";
while (true)
{
    Console.Write($"[{count + 1}]: ");
    string? line = Console.ReadLine();
    if (string.IsNullOrEmpty(line)) break;
    Rectangle rec = new();
    if (rec.SetData(line) == false) continue;
    count++;
    total += rec.GetArea();
    if (result != "") result += "\n";
    result += $"{count,8} {rec.GetInfo()}";
}
string heading = $"{"no",8} {Rectangle.GetHeading()}";

string bar = new string('-', 8) + Rectangle.GetBar('-');
string totalText = $"total : {total:n2}";
string totalInfo = $"{totalText,35}";
Console.WriteLine();
Console.WriteLine(heading);
Console.WriteLine(bar);
Console.WriteLine(result);
Console.WriteLine(bar);
Console.WriteLine(totalInfo);
Console.ReadKey();