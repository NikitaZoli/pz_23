using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_23
{
    internal class BookCard
    {
        public int ID { get; set; }
        public string author { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public string condition { get; set; }

        public BookCard(int iD, string author, string title, int year, string condition)
        {
            ID = iD;
            this.author = author;
            this.title = title;
            this.year = year;
            this.condition = condition;
        }

        public BookCard(BookCard bookCard)
        {
            this.ID = bookCard.ID;
            this.author = bookCard.author;
            this.title = bookCard.title;
            this.year = bookCard.year;
            this.condition = bookCard.condition;
        }
        public void GetBookInfo()
        {
            Console.WriteLine($"ID: {ID}\nАвтор: {author}\nТитульник: {title}\nГод издания: {year}\nСостояние книги: {condition}\n");
        }
    }
}
