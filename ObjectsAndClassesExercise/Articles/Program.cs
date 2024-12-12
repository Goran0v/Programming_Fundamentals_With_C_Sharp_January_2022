using System;
using System.Linq;
using System.Collections.Generic;

namespace Articles
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries).ToArray();
            Article article = new Article();
            article.Title = names[0];
            article.Content = names[1].Remove(0, 1);
            article.Author = names[2].Remove(0, 1);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] newNames = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string action = newNames[0];
                string newName = newNames[1].Remove(0, 1);
                if (action == "Edit")
                {
                    article.Edit(newName);
                }
                else if (action == "ChangeAuthor")
                {
                    article.ChangeAuthor(newName);
                }
                else if (action == "Rename")
                {
                    article.Rename(newName);
                }
            }
            Console.WriteLine(article.ToString());
        }
    }
}
