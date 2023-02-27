

using UpSkill_CSharpConsoleApp.Models;


/* FlagsEnum Exmple */
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