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
        //private List<BaseField> _fields;

        // Свойства
        public Style Style { get; set; }
        public LiterarySource LiterarySource { get; set; }


        // Конструктор
        public ReferenceBuilder(LiterarySource literarySource, Style style)
        {
            //_fields = new List<BaseField>();
            LiterarySource = literarySource;
            Style = style;
        }
        public List<BaseField> GetFields()
        {
            List<BaseField> fields = new List<BaseField>();
            foreach (var fieldType in Style.Fields)
            {
                BaseField field;
                switch (fieldType)
                {
                    case FieldType.Authors:
                        field = FieldsFactory.CreateAuthorsField(LiterarySource, Style.Config);
                        break;
                    case FieldType.Year:
                        field = FieldsFactory.CreateYearField(LiterarySource, Style.Config);
                        break;
                    case FieldType.Title:
                        field = FieldsFactory.CreateArticleTitleField(LiterarySource, Style.Config);
                        break;
                    case FieldType.JournalTitle:
                        field = FieldsFactory.CreateJournalTitleField(LiterarySource, Style.Config);
                        break;
                    case FieldType.ReadDate:
                        field = FieldsFactory.CreateDateField(LiterarySource, Style.Config);
                        break;
                    case FieldType.Source:
                        field = FieldsFactory.CreateSourceField(LiterarySource, Style.Config);
                        break;
                    case FieldType.EditionNumber:
                        field = FieldsFactory.CreatePrintEditionField(LiterarySource, Style.Config);
                        break;
                    case FieldType.PageCount:
                        field = FieldsFactory.CreatePageCountField(LiterarySource, Style.Config);
                        break;
                    case FieldType.PageNumber:
                        field = FieldsFactory.CreatePageNumberField(LiterarySource, Style.Config);
                        break;
                    case FieldType.Publisher:
                        field = FieldsFactory.CreatePublisherField(LiterarySource, Style.Config);
                        break;
                    default:
                        throw new ArgumentException("Неизвестный тип поля");
                }
                fields.Add(field);
            }
            return fields;
        }
        public string Build()
        {
            List<BaseField> fields = GetFields();
            StringBuilder sb = new StringBuilder();
            foreach (var field in fields)
            {
                sb.Append(field.Build());
            }
            return sb.ToString();
        }
    }
}
