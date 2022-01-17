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
            ReferenceConfig config = new ReferenceConfig();
            config.AddAuthorField(litSource.Authors, postfix: " ");
            config.AddYear(litSource.PublishInfo.Year, "(", "). ");
            config.AddArticleName(litSource.Title, "", ". ");
            config.AddJournalName(litSource.JournalTitle, "", ". ");
            config.AddDate(litSource.ReadDate, "dd MMMM yyyy", "Доступ ", ", ");
            config.AddSource(litSource.UrlAddress, "источник ", "");

            ReferenceBuilder rb = new ReferenceBuilder(config);
            return rb;
        }
    }
}
