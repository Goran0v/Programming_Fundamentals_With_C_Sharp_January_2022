using System;
using System.Linq;
using System.Collections.Generic;

namespace SchoolLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine().Split('&', StringSplitOptions.RemoveEmptyEntries).ToList();
            string command;
            while ((command = Console.ReadLine()) != "Done")
            {
                string[] function = command.Split('|');
                string action = function[0];
                if (action == "Add Book")
                {
                    string bookName = function[1];
                    if (!books.Contains(bookName))
                    {
                        books.Insert(0, bookName);
                    }
                    //else
                    //{
                    //    continue;
                    //}
                }
                else if (action == "Take Book")
                {
                    string bookName = function[1];
                    if (books.Contains(bookName))
                    {
                        books.Remove(bookName);
                    }
                    //else
                    //{
                    //    continue;
                    //}
                }
                else if (action == "Swap Books")
                {
                    string book1 = function[1];
                    string book2 = function[2];
                    string savedBook = book1;
                    if (books.Contains(book1) && books.Contains(book2))
                    {
                        for (int i = 0; i < books.Count; i++)
                        {
                            if (books[i] == book1)
                            {
                                books.Remove(book1);
                                books.Insert(i, book2);
                                break;
                            }
                        }
                        for (int i = books.Count - 1; i >= 0; i--)
                        {
                            if (books[i] == book2)
                            {
                                books.RemoveAt(i);
                                books.Insert(i, savedBook);
                            }
                        }
                    }
                    //else
                    //{
                    //    continue;
                    //}
                }
                else if (action == "Insert Book")
                {
                    string bookName = function[1];
                    if (!books.Contains(bookName))
                    {
                        books.Add(bookName);
                    }
                    //else
                    //{
                    //    continue;
                    //}
                }
                else if (action == "Check Book")
                {
                    int index = int.Parse(function[1]);
                    if (index >= 0 && index < books.Count)
                    {
                        Console.WriteLine(books[index]);
                    }
                    //else
                    //{
                    //    continue;
                    //}
                }
            }

            Console.WriteLine(string.Join(", ", books));
        }
    }
}