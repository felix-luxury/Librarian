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
        public StyleFamily Family { get; set; }
        public LiterarySource LiterarySource { get; set; }


        // Конструктор
        public ReferenceBuilder(LiterarySource literarySource, StyleFamily family)
        {
            //_fields = new List<BaseField>();
            LiterarySource = literarySource;
            Family = family;
        }
        public List<BaseField> GetFields()
        {
            List<BaseField> fields = new List<BaseField>();
            var style = GetActiveStyle();
            foreach (var fieldType in style.Fields)
            {
                BaseField field;
                switch (fieldType)
                {
                    case FieldType.Authors:
                        field = FieldsFactory.CreateAuthorsField(LiterarySource, style.Config);
                        break;
                    case FieldType.Year:
                        field = FieldsFactory.CreateYearField(LiterarySource, style.Config);
                        break;
                    case FieldType.Title:
                        field = FieldsFactory.CreateArticleTitleField(LiterarySource, style.Config);
                        break;
                    case FieldType.JournalTitle:
                        field = FieldsFactory.CreateJournalTitleField(LiterarySource, style.Config);
                        break;
                    case FieldType.ReadDate:
                        field = FieldsFactory.CreateDateField(LiterarySource, style.Config);
                        break;
                    case FieldType.Source:
                        field = FieldsFactory.CreateSourceField(LiterarySource, style.Config);
                        break;
                    case FieldType.EditionNumber:
                        field = FieldsFactory.CreatePrintEditionField(LiterarySource, style.Config);
                        break;
                    case FieldType.PageCount:
                        field = FieldsFactory.CreatePageCountField(LiterarySource, style.Config);
                        break;
                    case FieldType.PageNumber:
                        field = FieldsFactory.CreatePageNumberField(LiterarySource, style.Config);
                        break;
                    case FieldType.Publisher:
                        field = FieldsFactory.CreatePublisherField(LiterarySource, style.Config);
                        break;
                    case FieldType.City:
                        field = FieldsFactory.CreateCityField(LiterarySource, style.Config);
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
        private Style GetActiveStyle()
        {
            if (!Family.Contains(LiterarySource.LiterarySourceType))
            {
                throw new StyleNotFoundException("Стиль для этого типа источника не определён в семействе");
            }
            return Family[LiterarySource.LiterarySourceType];
        }
    }
}
