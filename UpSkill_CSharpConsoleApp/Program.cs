using Microsoft.Extensions.Configuration;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UpSkill_CSharpConsoleApp.Models;

var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json",optional: true, reloadOnChange:true); 
var configuration = builder.Build();


/* FlagsEnum Exmple */
Console.WriteLine("FLAGS ENUM EXAMPLE:");

var book = new Book
{
    Title = "Frankenstein",
    Author = "Mary Shelley",
    AvailableFormats = Format.Hardback | Format.AudioBook
};

Console.WriteLine(book.ToString());

if (book.AvailableFormats.HasFlag(Format.AudioBook))
{
    Console.WriteLine("Book is available in Audio format!");

}



Console.WriteLine("");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

/* Async/Await Example */

Console.WriteLine("ASYNC/AWAIT EXAMPLE:");


Console.WriteLine("--Blocking Example--");
var tea = new UpSkill_CSharpConsoleApp.Helpers.Tea();
Console.WriteLine(tea.MakeTea());

Console.WriteLine("");
Console.WriteLine("--Non-Blocking Example--");
var teaAsync = new UpSkill_CSharpConsoleApp.Helpers.Tea();
Console.WriteLine(await teaAsync.MakeTeaAsync());




Console.WriteLine("");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

/* Configuration JSON Settings Example */

Console.WriteLine($"Example Setting A: {configuration["ExampleSettings:SettingA"]}.");
Console.WriteLine($"Example Setting B: {configuration["ExampleSettings:SettingB"]}.");