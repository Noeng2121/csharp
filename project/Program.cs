// See https://aka.ms/new-console-template for more information

//File stream

Console.WriteLine("Hello, World!");
Console.WriteLine("My name is saing sreynoeng");


Console.Write("Name : ");
//string name = Console.ReadLine()??"(NA)"; // It mean that not null but empty
string? name = Console.ReadLine();
if (string.IsNullOrEmpty(name)) name = "(NA)";
Console.ReadLine();

Console.Write("Gender : ");
//string gender = Console.ReadLine() ?? "Female";// It mean that not null but empty
string? gender = Console.ReadLine();
if (string.IsNullOrEmpty(gender)) gender = "Female";
Console.ReadLine();
string message = "My name is " + name + ". I'm " + gender + ".";

Console.WriteLine(message);



