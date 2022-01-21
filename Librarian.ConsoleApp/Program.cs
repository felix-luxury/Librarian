using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Librarian.Core.LiterarySources;
using Librarian.Core.MongoDb;
using Librarian.Core.References;
using Librarian.Core.Styles;

namespace Librarian.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoAdd();


        }
        static void MongoAdd()
        {
            MongoDb db = new MongoDb("mongodb://localhost:27017");
            //var source = GetLiterarySource();
            //db.InsertLitSource(source);
            var source1 = db.GetLiterarySources();
            var source = GetLiterarySource();
            source.Authors = new string[] { "Иван, О.В.}" };

            db.UpsertLiterarySources(new Guid("{b88082ef-1d07-4dc4-a0bb-d0d5478d8030}"), source);
            
            var source2 = db.GetLiterarySources();
        }
        static void XmlTest()
        {
            LiterarySource source;
            Style style;


            source = GetLiterarySource();
            style = GetStyle();

            XmlSerializer litSourceFormatter = new XmlSerializer(typeof(LiterarySource));
            XmlSerializer styleFormatter = new XmlSerializer(typeof(Style));

            using (FileStream fs = new FileStream("testLitSource.xml", FileMode.OpenOrCreate))
            {
                litSourceFormatter.Serialize(fs, source);
                Console.WriteLine("Лит источник сериализован");
            }
            using (FileStream fs = new FileStream("testStyle.xml", FileMode.OpenOrCreate))
            {
                styleFormatter.Serialize(fs, style);
                Console.WriteLine("Стиль сериализован");
            }

            using (FileStream fs = new FileStream("testLitSource.xml", FileMode.OpenOrCreate))
            {
                source = (LiterarySource)litSourceFormatter.Deserialize(fs);
                Console.WriteLine("Лит источник десериализован");
            }
            using (FileStream fs = new FileStream("testStyle.xml", FileMode.OpenOrCreate))
            {
                style = (Style)styleFormatter.Deserialize(fs);
                Console.WriteLine("Стиль десериализован");
            }


            var builder = new ReferenceBuilder(source, style);
            Console.WriteLine(builder.Build());
        }


        static LiterarySource GetLiterarySource()
        {
            LiterarySource litSource = new LiterarySource();
            PublishInfo pub = new PublishInfo();

            string[] authors = { "Автор1", "Автор2", "Автор3" };
            litSource.Authors = authors;
            litSource.Title = "Материализация Бреда";
            litSource.JournalTitle = "Вестник психиатрии";
            pub.Year = 2000;
            litSource.PublishInfo = pub;
            litSource.ReadDate = DateTime.Today;
            litSource.Source = "https://google.com";
            return litSource;
        }
        static Style GetStyle()
        {
            StyleConfig config = new StyleConfig();
            config.TitlePostfix = ". ";
            config.TitlePrefix = "";
            config.AuthorDelimiter = ", ";
            config.AuthorLastDelimiter = " и ";
            config.AuthorPostfix = " ";
            config.AuthorPrefix = "";
            config.DateFormat = "dd MMMM yyyy";
            config.DatePostfix = ", ";
            config.DatePrefix = "Доступ ";
            config.JournalTitlePostfix = ". ";
            config.JournalTitlePrefix = "";
            config.SourcePostfix = "";
            config.SourcePrefix = "источник ";
            config.YearPostfix = "). ";
            config.YearPrefix = "(";

            StyleBuilder builder = new StyleBuilder(config);
            builder
                .AddAuthors()
                .AddYear()
                .AddArticleTitle()
                .AddJournalTitle()
                .AddDate()
                .AddSource()
                ;


            return builder.Build();
        }
    }
}
