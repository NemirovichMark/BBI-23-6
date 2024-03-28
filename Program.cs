// Задача 1 Вариант 5
//using System;

//class Book
//{
//    private string title;
//    private static int ISBN_ = 0;
//    private string autor;
//    private int yearOfPublication;
//    public Book(string title_, string autor_, int year_)
//    {
//        title = title_;
//        autor = autor_;
//        yearOfPublication = year_;
//        ISBN_++;
//    }
//    public string Autor
//    {
//        get => autor;
//    }
//    public int Year
//    {
//        get => yearOfPublication;
//    }
//    public void Print()
//    {
//        Console.WriteLine($"Название: \"{title}\", Автор: {autor}, Год издания: {yearOfPublication}, ISBN: {ISBN_}");
//    }
//}
//class Program
//{
//    static void findByAutor(Book[] books, string Autor)
//    {
//        Console.WriteLine($"Книги написаные: {Autor}:");
//        for (int i = 0; i < books.Length; ++i)
//        {
//            if (books[i].Autor == Autor)
//            {
//                books[i].Print();
//            }
//        }
//        Console.WriteLine();
//    }
//    static void findByCentury(Book[] books, int century)
//    {
//        Console.WriteLine($"Книги написанные в {century} веке:");
//        for (int i = 0; i < books.Length; ++i)
//        {
//            if (books[i].Year / 100 + 1 == century)
//            {
//                books[i].Print();
//            }
//        }
//        Console.WriteLine();
//    }
//    static void Main(string[] args)
//    {
//        Book[] books = new Book[10];

//        books[0] = new Book("Анна Каренина", "Лев Толстой", 1877);
//        books[1] = new Book("Мадам Бовари", "Гюстав Флюберт", 1857);
//        books[2] = new Book("Гарри Поттер", "Джоан Роулинг", 1997);
//        books[3] = new Book("Медный всадник", "Пушкин А. С.", 1833);
//        books[4] = new Book("Город в пустыне", "Петрова М. П.", 1960);
//        books[5] = new Book("Школьные годы", "Дроздова К. Е.", 1920);
//        books[6] = new Book("Евгений Онегин", "Пушкин А. С.", 1834);
//        books[7] = new Book("Война и мир", "Толстой Л. Н.", 1820);
//        books[8] = new Book("Руслан и Людмила", "Пушкин А. С.", 1818);
//        books[9] = new Book("Пир во время чумы", "Штольц Э. Ф.", 1801);

//        findByCentury(books, 19);
//        findByAutor(books, "Пушкин А. С.");

//    }
//}



// Задача 2
using System;
abstract class Book
{
    protected string title;
    protected static int ISBN_ = 0;
    protected string autor;
    protected int yearOfPublication;
    protected int cost = -1;

    public abstract int CountCost();

    public Book(string title_, string autor_, int year_)
    {
        title = title_;
        autor = autor_;
        yearOfPublication = year_;
        ISBN_++;
    }
    public string Autor
    {
        get => autor;
    }
    public int Year
    {
        get => yearOfPublication;
    }
    public abstract void Print();
}
class PaperBook : Book
{
    private bool hardcover;
    public PaperBook(string title_, string autor_, int year_, bool hardcover_)
    : base(title_, autor_, year_)
    {
        hardcover = hardcover_;
    }
    public override int CountCost()
    {
        if (cost != -1)
        {
            return cost;
        }
        cost = 300;
        if (hardcover)
        {
            cost += 500;
        }
        return cost;
    }
    public override void Print()
    {
        Console.Write($"Название: \"{title}\", Автор: {autor}, Год выпуска: {yearOfPublication}, ISBN: {ISBN_}, Type: AudioBook, Hardcover: ");
        if (hardcover) Console.WriteLine("yes");
        else Console.WriteLine("no");
    }
}
class ElectronicBook : Book
{
    private string format;

    public ElectronicBook(string title_, string autor_, int year_, string format_)
    : base(title_, autor_, year_)
    {
        format = format_;
    }
    public override int CountCost()
    {
        if (cost != -1)
        {
            return cost;
        }
        cost = 100;
        if (format == "pdf")
        {
            cost += 200;
        }
        else if (format == "fb2")
        {
            cost += 300;
        }
        else
        {
            cost += 150;
        }

        return cost;
    }
    public override void Print()
    {
        Console.WriteLine($"Название: \"{title}\", Автор: {autor}, Год выпуска: {yearOfPublication}, ISBN: {ISBN_}, Type: eBook, Format: {format}");
    }
}
class AudioBook : Book
{
    private bool studioRec;
    public AudioBook(string title_, string autor_, int year_, bool studioRec_)
    : base(title_, autor_, year_)
    {
        studioRec = studioRec_;
    }
    public override int CountCost()
    {
        if (cost != -1)
        {
            return cost;
        }

        cost = 200;
        if (studioRec)
        {
            cost += 200;
        }
        return cost;
    }
    public override void Print()
    {
        Console.Write($"Название: \"{title}\", Автор: {autor}, Год выпуска: {yearOfPublication}, ISBN: {ISBN_}, Type: AudioBook, Studio recording: ");
        if (studioRec) Console.WriteLine("yes");
        else Console.WriteLine("no");
    }
}
class Program
{
    static void sort(Book[] x)
    {
        for (int i = 0; i < x.Length - 1; i++)
        {
            for (int k = 0; k < x.Length - 1 - i; k++)
            {
                if (x[k].CountCost() < x[k + 1].CountCost())
                {
                    (x[k], x[k + 1]) = (x[k + 1], x[k]);
                }
            }
        }
    }
    static void findByAutor(Book[] books, string Autor)
    {
        Console.WriteLine($"Книга написана: {Autor}:");
        for (int i = 0; i < books.Length; ++i)
        {
            if (books[i].Autor == Autor)
            {
                books[i].Print();
            }
        }
        Console.WriteLine();
    }
    static void findByCentury(Book[] books, int century)
    {
        Console.WriteLine($"Книга написана в {century} веке:");
        for (int i = 0; i < books.Length; ++i)
        {
            if (books[i].Year / 100 + 1 == century)

            {
                books[i].Print();
            }
        }
        Console.WriteLine();
    }
    static void Main(string[] args)
    {

        Book[] pBooks = new Book[5];
        pBooks[0] = new PaperBook("Анна Каренина", "Лев Толстой", 1877, true);
        pBooks[1] = new PaperBook("Мадам Бовари", "Гюстав Флюберт", 1857, false);
        pBooks[2] = new PaperBook("Гарри Поттер", "Джоан Роулинг", 1997, true);
        pBooks[3] = new PaperBook("Медный всадник", "Пушкин А. С.", 1833, false);
        pBooks[4] = new PaperBook("Город в пустыне", "Петрова М. П.", 1960, true);

        Book[] eBooks = new Book[5];
        eBooks[0] = new ElectronicBook("Школьные годы", "Дроздова К. Е.", 1920, "pdf");
        eBooks[1] = new ElectronicBook("Евгений Онегин", "Пушкин А. С.", 1834, "epub");
        eBooks[2] = new ElectronicBook("Война и мир", "Толстой Л. Н.", 1820, "fb2");
        eBooks[3] = new ElectronicBook("Руслан и Людмила", "Пушкин А. С.", 1818, "pdf");
        eBooks[4] = new ElectronicBook("Пир во время чумы", "Штольц Э. Ф.", 1801, "epub");

        Book[] aBooks = new Book[5];
        aBooks[0] = new AudioBook("Школьные годы", "Дроздова К. Е.", 1920, true);
        aBooks[1] = new AudioBook("Евгений Онегин", "Пушкин А. С.", 1834, false);
        aBooks[2] = new AudioBook("Война и мир", "Толстой Л. Н.", 1820, false);
        aBooks[3] = new AudioBook("Руслан и Людмила", "Пушкин А. С.", 1818, true);
        aBooks[4] = new AudioBook("Пир во время чумы", "Штольц Э. Ф.", 1801, true);

        sort(eBooks);
        sort(aBooks);
        sort(pBooks);

        Console.WriteLine("\nЭлектронные книги:");
        for (int i = 0; i < 5; ++i)
        {
            eBooks[i].Print();
        }

        Console.WriteLine("\nПечатные книги:");
        for (int i = 0; i < 5; ++i)
        {
            pBooks[i].Print();
        }

        Console.WriteLine("\nАудио книги:");
        for (int i = 0; i < 5; ++i)
        {
            aBooks[i].Print();
        }

        Console.WriteLine("\n#######################################");

        Book[] allBooks = new Book[15];

        for (int i = 0; i < 15; ++i)
        {
            if (i < 5)
            {
                allBooks[i] = eBooks[i];
            }
            else if (i < 10)
            {
                allBooks[i] = pBooks[i % 5];
            }
            else
            {
                allBooks[i] = aBooks[i % 5];
            }
        }

        sort(allBooks);

        Console.WriteLine("\nВсе книги:");

        for (int i = 0; i < 15; ++i)
        {
            allBooks[i].Print();
        }

        Console.WriteLine();

        findByCentury(allBooks, 20);
        findByAutor(allBooks, "a1");
    }
}




