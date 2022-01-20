using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Core.Styles
{
    public class StyleBuilder
    {
        public StyleBuilder(StyleConfig config)
        {
            Fields = new List<FieldType>();
            Config = config;
        }
        public List<FieldType> Fields { get; set; }
        public StyleConfig Config { get; set; }
        public StyleBuilder AddAuthors()
        {
            Fields.Add(FieldType.Authors);
            return this;
        }
        public StyleBuilder AddYear()
        {
            Fields.Add(FieldType.Year);
            return this;
        }
        public StyleBuilder AddArticleTitle()
        {
            Fields.Add(FieldType.ArticleTitle);
            return this;
        }
        public StyleBuilder AddJournalTitle()
        {
            Fields.Add(FieldType.JournalTitle);
            return this;
        }
        public StyleBuilder AddDate()
        {
            Fields.Add(FieldType.Date);
            return this;
        }
        public StyleBuilder AddSource()
        {
            Fields.Add(FieldType.Source);
            return this;
        }
        public Style Build()
        {
            return new Style(Fields.ToArray(), Config);
        }
    }
}
