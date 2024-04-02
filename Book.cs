using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCHMI_LAB_PROJECT
{
    internal class Book
    {
        public int id { get; set; }

        public string title { get; set; }

        public string author { get; set; }

        public string genre { get; set; }

        public string description { get; set; }

        public int availability { get; set; }

        public Book() { }

        public Book(string title, string author, string genre, string description, int availability)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.description = description;
            this.availability = availability;
        }
    }
}
