using Librarian.Core.LiterarySource;
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
        private List<BaseField> _fieldList;

        // Конструктор
        public ReferenceBuilder()
        {
            _fieldList = new List<BaseField>();
        }
    
        // Методы
        public void AddField(BaseField field)
        {
            _fieldList.Add(field);
        }
        public string Build()
        {
            StringBuilder sb = new StringBuilder();
            foreach (BaseField field in _fieldList)
            {
                sb.Append(field.Build());
            }
            return sb.ToString();
        }
    }
}
