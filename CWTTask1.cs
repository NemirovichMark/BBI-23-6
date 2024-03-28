//using System;
//using System.Collections.Generic;
//using System.Numerics;
//using System.Text;

//public class Program
//{
//    struct Book
//    {
//        private string name;
//        private static int ISBN=0;
//        private string author;
//        private int year;

//        public Book(string name, string author, int year)
//        {
//            this.name = name;
//            this.author = author;
//            this.year = year;
//            ++ISBN;
//        }

//        public void Info()
//        {
//            Console.WriteLine($"Книга: {name}");
//            Console.WriteLine($"Автор: {author}");
//            Console.WriteLine($"ISBN: {ISBN}");
//            Console.WriteLine($"Год издания: {year}");
//            Console.WriteLine();
//        }

//        public static void Info_author(Book[] list, string aut)
//        {
//            for (int i = 0; i < list.Length; i++)
//            {
//                if (list[i].author == aut)
//                {
//                    list[i].Info();
//                }
//            }
//        }

//        public static void Info_vek(Book[] list, int vek)
//        {
//            for (int i = 0; i < list.Length; i++)
//            {
//                if (list[i].year >= vek * 100 - 99 && list[i].year <= vek * 100)
//                {
//                    list[i].Info();
//                }
//            }
//        }

//    }

//    public static void Main(string[] args)
//    {
//        Book[] list_book = new Book[10];
//        list_book[0] = new Book("Гарри Поттер", "Джоан Роулинг", 2019);
//        list_book[1] = new Book("Евгений Онегин", "Пушкин", 1883);
//        list_book[2] = new Book("Зимнее утро", "Пушкин", 1829);
//        list_book[3] = new Book("Капитанская дочка", "Пушкин", 1836);
//        list_book[4] = new Book("ое", "Ляля", 2017);
//        list_book[5] = new Book("яяя", "Ляля", 2000);
//        list_book[6] = new Book("любовь", "Ляля", 2018);
//        list_book[7] = new Book("песни", "Ляля", 2023);
//        list_book[8] = new Book("не знай", "Пупу", 2024);
//        list_book[9] = new Book("красота", "Пупу", 1899);
//    }
//}