namespace pz_23
{
    internal class Program
    {
        private static string? Author;
        private static int ID;
        private static string? Title;
        private static string? Year;
        private static string? Condition;
        private static string? Direction;
        private static int ReceiptDate;

        static void Main(string[] args)
        {
            ScientificBookCard ScientificBookCard = new ScientificBookCard();
            ScientificBookCard ScientificBookCard2 = new ScientificBookCard(111111, "Дмитрий Гласов", "Белоснежка", 2015, "Вышла", "Художственная", 1);
            ScientificBookCard ScientificBookCard3 = new ScientificBookCard();
            {
                Author = "Олег Ямаи";
                ID = 111112;
                Title = "путешествие щенка";
                Year = "2010";
                Condition = "Вышла";
                Direction = "Художественная";
                ReceiptDate = 1;
            }
            ScientificBookCard ScientificBookCard4 = new ScientificBookCard();
            {

            }
            ScientificBookCard.GetBookInfo();
            ScientificBookCard2.GetBookInfo();
            ScientificBookCard3.GetBookInfo();
            ScientificBookCard4.GetBookInfo();

            Console.ReadLine();
        }
    }
}