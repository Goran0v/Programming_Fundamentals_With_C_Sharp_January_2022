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
                string[] function = command.Split('|', StringSplitOptions.RemoveEmptyEntries);
                string action = function[0];
                if (action == "Add Book ")
                {
                    string bookName = function[1];
                    string newBook = bookName.Remove(0, 1);
                    if (!books.Contains(newBook))
                    {
                        books.Insert(0, newBook);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (action == "Take Book ")
                {
                    string bookName = function[1];
                    string newBook = bookName.Remove(0, 1);
                    if (books.Contains(newBook))
                    {
                        books.Remove(newBook);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (action == "Swap Books ")
                {
                    string book1 = function[1];
                    string book2 = function[2];
                    string newBook1 = book1.Remove(0, 1);
                    newBook1 = newBook1.Remove(newBook1.Length - 1, 1);
                    string newBook2 = book2.Remove(0, 1);
                    //newBook2 = newBook2.Remove(newBook2.Length - 1, 1);
                    string savedValue = newBook1;
                    string otherSavedValue = newBook2;
                    if (books.Contains(newBook1) && books.Contains(newBook2))
                    {
                        int firstIndex = books.IndexOf(newBook1);
                        int secondIndex = books.IndexOf(newBook2);
                        if (firstIndex < secondIndex)
                        {
                            for (int i = 0; i < books.Count; i++)
                            {
                                if (books[i] == newBook1)
                                {
                                    books.Insert(i, newBook2);
                                    books.Remove(newBook1);
                                    continue;
                                }
                                else if (books[i] == newBook2)
                                {
                                    books.RemoveAt(i);
                                    books.Insert(i, savedValue);
                                    break;
                                }
                            }
                        }
                        else if (secondIndex < firstIndex)
                        {
                            for (int i = 0; i < books.Count; i++)
                            {
                                if (books[i] == newBook2)
                                {
                                    books.Insert(i, newBook1);
                                    books.Remove(newBook2);
                                    continue;
                                }
                                else if (books[i] == newBook1)
                                {
                                    books.RemoveAt(i);
                                    books.Insert(i, otherSavedValue);
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (action == "Insert Book ")
                {
                    string bookName = function[1];
                    string newBook = bookName.Remove(0, 1);
                    if (!books.Contains(newBook))
                    {
                        books.Add(newBook);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (action == "Check Book ")
                {
                    string bookName = function[1];
                    string newBook = bookName.Remove(0, 1);
                    int index = int.Parse(newBook);
                    if (index >= 0 && index < books.Count)
                    {
                        Console.WriteLine(books[index]);
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", books));
        }
    }
}