//using System;
//using System.Collections.Generic;
//using System.Numerics;
//using System.Runtime.ConstrainedExecution;
//using System.Text;

//public abstract class Book
//{
//    protected string name;
//    protected static int ISBN = 0;
//    protected string author;
//    protected int year;
//    protected int price;


//    public Book(string name, string author, int year, int price)
//    {
//        this.name = name;
//        this.author = author;
//        this.year = year;
//        ++ISBN;
//        this.price = price;
//    }

//    public virtual int Price_count()
//    {
//        return price;
//    }

//    public void Info()
//    {
//        Console.WriteLine($"Книга: {name}");
//        Console.WriteLine($"Автор: {author}");
//        Console.WriteLine($"ISBN: {ISBN}");
//        Console.WriteLine($"Год издания: {year}");
//        Console.WriteLine($"Цена: {Price_count()}");
//        Console.WriteLine();
//    }

//    public void Info_author(Book[] list, string aut)
//    {
//        for (int i = 0; i < list.Length; i++)
//        {
//            if (list[i].author == aut)
//            {
//                list[i].Info();
//            }
//        }
//    }

//    public void Info_vek(Book[] list, int vek)
//    {
//        for (int i = 0; i < list.Length; i++)
//        {
//            if (list[i].year >= vek * 100 - 99 && list[i].year <= vek * 100)
//            {
//                list[i].Info();
//            }
//        }
//    }


//}

//class PaperBook : Book
//{
//    bool per;
//    public bool Flag { get { return per; } }
//    public PaperBook(string name, string author, int year, int price, bool per) : base(name, author, year, price)
//    {
//        this.per = per;
//    }
//    public override int Price_count()
//    {
//        if (per)
//        {
//            return price * 2;
//        }
//        else
//        {
//            return price;
//        }
//    }
//}

//class ElectronicBook : Book
//{
//    private string format;
//    public ElectronicBook(string name, string author, int year, int price, string format) : base(name, author, year, price)
//    {
//        this.format = format;
//    }

//    public override int Price_count()
//    {
//        if (format == "pdf")
//        {
//            return price;
//        }
//        else
//        {
//            if (format == "fb2")
//            {
//                return price * 2;
//            }
//            else { return price; }
//        }
//    }
//}

//class AudioBook : Book
//{
//    bool studio;
//    public bool Flag { get { return studio; } }
//    public AudioBook(string name, string author, int year, int price, bool studio) : base(name, author, year, price)
//    {
//        this.studio = studio;
//    }

//    public override int Price_count()
//    {
//        if (studio)
//        {
//            return price * 3;
//        }
//        else
//        {
//            return price;
//        }
//    }
//}

//public class Program
//{

//    static Book[] Sort(Book[] list)
//    {
//        for (int i = 1; i < list.Length; i++)
//        {
//            int k = list[i].Price_count();
//            Book now = list[i];
//            int j = i - 1;

//            while (j >= 0 && list[j].Price_count() < k)
//            {
//                list[j + 1] = list[j];
//                j--;
//            }
//            list[j + 1] = now;
//        }
//        return list;
//    }

//    static void Print_sort(Book[] sortlist)
//    {
//        for (int i = 0; i < sortlist.Length; i++)
//        {
//            sortlist[i].Info();
//        }
//    }

//    public static void Main(string[] args)
//    {
//        Book[] paper_list = new PaperBook[5];
//        Book[] electro_list = new ElectronicBook[5];
//        Book[] audio_list = new AudioBook[5];
//        Book[] list = new Book[15];
//        int price1 = 200;
//        int price2 = 160;
//        int price3 = 180;
//        for (int i = 0; i < 5; i++)
//        {
//            paper_list[i] = new PaperBook("fff", "me", 2023, price1, true);
//            electro_list[i] = new ElectronicBook("fff", "me", 2024, price2, "fb2");
//            audio_list[i] = new AudioBook("fff", "me", 2005, price3, true);
//            price2 += 10;
//            price3 += 20;
//            price1 += 30;
//        }

//        for (int i = 0; i < 5; i++)
//        {
//            list[i] = paper_list[i];
//        }
//        for (int i = 0; i < 5; i++)
//        {
//            list[i + 5] = electro_list[i];
//        }
//        for (int i = 0; i < 5; i++)
//        {
//            list[i + 10] = audio_list[i];
//        }


//        paper_list = Sort(paper_list);
//        Print_sort(paper_list);

//        electro_list = Sort(electro_list);
//        Print_sort(electro_list);

//        electro_list = Sort(electro_list);
//        Print_sort(electro_list);

//        audio_list = Sort(audio_list);
//        Print_sort(audio_list);

//        list = Sort(list);
//        Print_sort(list);

//    }

//}