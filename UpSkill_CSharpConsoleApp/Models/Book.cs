using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpSkill_CSharpConsoleApp.Models
{
    [Flags]
    public enum Format
    {
        None = 0,
        Hardback = 1,
        Paperback = 2,
        Ebook = 4,
        AudioBook = 8
    }


    public class Book
    {
        public string Title { get; set; } = String.Empty;

        public string Author { get; set; } = String.Empty;

        public Format AvailableFormats { get; set; }

        public override string ToString() => $"{Title} by {Author}. Formats: {AvailableFormats}";
    }
}
