using Librarian.Core.LiterarySources;
using Librarian.Core.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Core.References
{
    public class FieldsFactory
    {
        public static AuthorsField CreateAuthorsField(LiterarySource literarySource,StyleConfig config)
        {
            return new AuthorsField(literarySource.Authors, config.AuthorPrefix, config.AuthorPostfix, config.AuthorDelimiter, config.AuthorLastDelimiter);
        }

        internal static SimpleField CreateYearField(LiterarySource literarySource, StyleConfig config)
        {
            return new SimpleField(literarySource.PublishInfo.Year, config.YearPrefix, config.YearPostfix);
        }

        internal static SimpleField CreateArticleTitleField(LiterarySource literarySource, StyleConfig config)
        {
            return new SimpleField(literarySource.Title, config.TitlePrefix, config.TitlePostfix);
        }

        internal static SimpleField CreateJournalTitleField(LiterarySource literarySource, StyleConfig config)
        {
            return new SimpleField(literarySource.JournalTitle, config.JournalTitlePrefix, config.JournalTitlePostfix);
        }

        internal static DateField CreateDateField(LiterarySource literarySource, StyleConfig config)
        {
            return new DateField(literarySource.ReadDate, config.DateFormat, config.DatePrefix,config.DatePostfix);
        }

        internal static SimpleField CreateSourceField(LiterarySource literarySource, StyleConfig config)
        {
            return new SimpleField(literarySource.Source, config.SourcePrefix, config.SourcePostfix);
        }
        internal static SimpleField CreatePageNumberField(LiterarySource literarySource, StyleConfig config)
        {
            return new SimpleField(literarySource.Source, config.PageNumberPrefix, config.PageNumberPostfix);
        }

        internal static SimpleField CreatePrintEditionField(LiterarySource literarySource, StyleConfig config)
        {
            return new SimpleField(literarySource.Source, config.PrintEditionPrefix, config.PrintEditionPostfix);
        }

        internal static SimpleField CreatePageCountField(LiterarySource literarySource, StyleConfig config)
        {
            return new SimpleField(literarySource.Source, config.PageCountPrefix, config.PageCountPostfix);
        }

        internal static BaseField CreatePublisherField(LiterarySource literarySource, StyleConfig config)
        {
            return new SimpleField(literarySource.Source, config.PublisherPrefix, config.PublisherPostfix);
        }

        internal static BaseField CreateCityField(LiterarySource literarySource, StyleConfig config)
        {
            return new SimpleField(literarySource.Source, config.CityPrefix, config.CityPostfix);
        }
    }
}
