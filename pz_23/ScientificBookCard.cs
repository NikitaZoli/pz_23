using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_23
{
    internal class ScientificBookCard
    {
        public int ID { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Condition { get; set; }
        public string Direction { get; set; }   
        public int ReceiptDate { get; set; }

        public ScientificBookCard(int iD, string author, string title, int year, string condition, string direction, int receiptDate)
        {
            ID = iD;
            this.Author = author;
            this.Title = title;
            this.Year = year;
            this.Condition = condition;
            this.Direction = direction;
            this.ReceiptDate = receiptDate;  
        }

        public ScientificBookCard(ScientificBookCard ScientificBookCard)
        {
            this.ID = ScientificBookCard.ID;
            this.Author = ScientificBookCard.Author;
            this.Title = ScientificBookCard.Title;
            this.Year = ScientificBookCard.Year;
            this.Condition = ScientificBookCard.Condition;
            this.Direction = ScientificBookCard.Direction;
            this.ReceiptDate = ScientificBookCard.ReceiptDate;

        }

        public ScientificBookCard()
        {
            ID = 0;
            Author = "неизвестный";
            Title = "пусто";
            Year = 0;
            Condition = "неизвестно";
            Direction = "пусто";
            ReceiptDate = 0;
        }
        public void GetBookInfo()
        {
            Console.WriteLine($"ID: {ID}\nАвтор: {Author}\nТитульник: {Title}\nГод издания: {Year}\nСостояние книги: {Condition}\nНаправление: {Direction}\nСвежесть литературы: {ReceiptDate}");
        }
    }
}
