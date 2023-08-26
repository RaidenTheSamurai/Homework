using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__5.Part_1
{
    public class Play : IDisposable
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        public Play() : this("Name of play")
        { }
        public Play(string name) : this(name, "Plays author")
        { }
        public Play(string name, string author) : this(name, author, "Plays genere")
        { }
        public Play(string name, string author, string genre) : this(name, author, genre, 2023)
        { }
        public Play(string name, string author, string genre, int year)
        {
            Name = name;
            Author = author;
            Genre = genre;
            Year = year;
        }

        public void Show()
        {
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Author: {this.Author}");
            Console.WriteLine($"Genre: {this.Genre}");
            Console.WriteLine($"Year: {this.Year}");
        }
        public void Dispose()
        {
            Console.WriteLine("Dispose worked!");
        }
        ~Play()
        {
            Dispose();
            Console.WriteLine("Destructor worked!");
        }
    }
}
