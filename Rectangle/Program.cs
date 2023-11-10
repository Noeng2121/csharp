// See https://aka.ms/new-console-template for more information
using System.Collections.Specialized;

Console.WriteLine("Input Rectangle data(Width & Lenght separated by space)");
int count = 0;
double total  = 0;
string result = "";
while (true)
{
    Console.Write($"[{count + 1}]: ");
    string? line = Console.ReadLine();//ចាំទទួលតម្លៃ
    if (string.IsNullOrEmpty(line)) break;//ប្រសិនបើlineអត់មានតម្លៃវាbreak
    string[] sides = line.Split(" ");//spaceឪ្យline
    if (sides.Length < 2) continue;//គម្លាត​ដែលវាឃ្លាតលេខពីគ្នាគឺspaceត្រូវតូចជាង2
    if (double.TryParse(sides[0], out double width)== false) continue;//ការតាងអថេរwidth​​ and lenght ទាល់តែ width and lenght មានតម្លៃសិនទើបអនុវត្ដអាក្រោម
    if (double.TryParse(sides[1], out double lenght) == false) continue;//---||---

    count++;
    double area = width*lenght; 
    total += area;
    string lineInfo = $"{count,8} {width,8:n2} {lenght,8:n2} {area,8:n2}";
    if (result != "") result += "\n";
    result += lineInfo; //​ដូចជាarray line Info 
}
string heading = $"{"no",8} {"width",8} {"lenght",8} {"area",8}";
string bar = new string('-', 35);
string totalText = $"total : {total:n2}";
string totalInfo = $"{totalText,35}";
Console.WriteLine();
Console.WriteLine(heading);
Console.WriteLine(bar);
Console.WriteLine(result);
Console.WriteLine(bar);
Console.WriteLine(totalInfo);
Console.ReadKey();