using System;
using Librarian.Core.LiterarySource;
using Librarian.Core.References;

namespace Librarian.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = GetWebSource();
            var builder = GetRefBuilder(source);
            Console.WriteLine(builder.Build());
        }

        static WebArticle GetWebSource()
        {
            WebArticle litSource = new WebArticle();
            PublishInfo pub = new PublishInfo();

            string[] authors = { "Автор1", "Автор2", "Автор3" };
            litSource.Authors = authors;
            litSource.Title = "Материализация Бреда";
            litSource.JournalTitle = "Вестник психиатрии";
            pub.Year = 2000;
            litSource.PublishInfo = pub;
            litSource.ReadDate = DateTime.Today;
            litSource.UrlAddress = "google.com";
            return litSource;
        }
        static ReferenceBuilder GetRefBuilder(WebArticle litSource)
        {
            ReferenceBuilder rb = new ReferenceBuilder();
            AuthorsField authorsField = new AuthorsField();
            authorsField.Authors = litSource.Authors;
            authorsField.Postfix = " ";
            SimpleField year = new SimpleField(litSource.PublishInfo.Year, "(", "). ");
            SimpleField articleTitle = new SimpleField(litSource.Title, "", ". ");
            SimpleField journalTitle = new SimpleField(litSource.JournalTitle, "", ". ");
            SimpleField date = new SimpleField("Доступ " + litSource.ReadDate.ToString("dd MMMM yyyy"), "", ", ");
            SimpleField source = new SimpleField("источник " + litSource.UrlAddress, "", "");


            rb.AddField(authorsField);
            rb.AddField(year);
            rb.AddField(articleTitle);
            rb.AddField(journalTitle);
            rb.AddField(date);
            rb.AddField(source);

            return rb;
        }
    }
}
