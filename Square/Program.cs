// See https://aka.ms/new-console-template for more information
using System.Collections.Specialized;

Console.WriteLine("Input Triangle data (bottom & height)");
int count = 0;
string result = "";
double total = 0;
while (true)
{
    Console.Write($"[{count + 1}]:");
    string? line = Console.ReadLine();
    if (string.IsNullOrEmpty(line)) break;
    string[] sides = line.Split(" ");
    if (sides.Length < 1) continue;
    if (double.TryParse(sides[0], out double a) == false) continue;
    

    count++;
    double area = (a*a*a);
    total += area;
    string lineInfo = $"{count,8} {a,8:n2} {area,8:n2}";
    if (result != "") result += "\n";
    result += lineInfo; //​ដូចជាarray line Info 
}
string heading = $"{"no",8} {"a",8} {"area",8}";
string bar = new string('-', 26);
string totalText = $"total : {total:n2}";
string totalInfo = $"{totalText,26}";
Console.WriteLine();
Console.WriteLine(heading);
Console.WriteLine(bar);
Console.WriteLine(result);
Console.WriteLine(bar);
Console.WriteLine(totalInfo);
Console.ReadKey();
