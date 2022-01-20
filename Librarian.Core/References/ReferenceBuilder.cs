using Librarian.Core.LiterarySources;
using Librarian.Core.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.Core.References
{
    public class ReferenceBuilder
    {
        // Поля
        private List<BaseField> _fields;

        // Свойства
        public Style Style { get; set; }
        public LiterarySource LiterarySource { get; set; }


        // Конструктор
        public ReferenceBuilder(LiterarySource literarySource, Style style)
        {
            _fields = new List<BaseField>();
            LiterarySource = literarySource;
            Style = style;
        }
    
        public string Build()
        {
            foreach (var fieldType in Style.Fields)
            {
                BaseField field;
                switch (fieldType)
                {
                    case FieldType.Authors:
                        field = FieldsBuilder.CreateAuthorsField(LiterarySource, Style.Config);
                        break;
                    case FieldType.Year:
                        field = FieldsBuilder.CreateYearField(LiterarySource, Style.Config);
                        break;
                    case FieldType.ArticleTitle:
                        field = FieldsBuilder.CreateArticleTitleField(LiterarySource, Style.Config);
                        break;
                    case FieldType.JournalTitle:
                        field = FieldsBuilder.CreateJournalTitleField(LiterarySource, Style.Config);
                        break;
                    case FieldType.Date:
                        field = FieldsBuilder.CreateDateField(LiterarySource, Style.Config);
                        break;
                    case FieldType.Source:
                        field = FieldsBuilder.CreateSourceField(LiterarySource, Style.Config);
                        break;
                    default:
                        throw new ArgumentException("Неизвестный тип поля");
                }
                _fields.Add(field);
            }
            StringBuilder sb = new StringBuilder();
            foreach (var field in _fields)
            {
                sb.Append(field.Build());
            }
            return sb.ToString();
        }
    }
}
