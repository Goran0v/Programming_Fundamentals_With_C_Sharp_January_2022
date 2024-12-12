using System;
using System.Linq;
using System.Collections.Generic;

namespace Articles2._0
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public Article(string title, string content, string autor)
        {
            Title = title;
            Content = content;
            Author = autor;
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
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                List<string> information = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
                var newArticle = new Article(information[0], information[1], information[2]);
                articles.Add(newArticle);
            }
            string orderBy = Console.ReadLine();
            if (orderBy == "title")
            {
                articles = articles.OrderBy(x => x.Title).ToList();
            }
            else if (orderBy == "content")
            {
                articles = articles.OrderBy(x => x.Content).ToList();
            }
            else if (orderBy == "author")
            {
                articles = articles.OrderBy(x => x.Author).ToList();
            }

            Console.WriteLine(string.Join(Environment.NewLine, articles));
        }
    }
}
