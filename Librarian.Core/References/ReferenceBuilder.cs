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
        private ReferenceConfig _config;

        public ReferenceConfig Config
        {
            get { return _config; }
            set { _config = value; }
        }


        // Конструктор
        public ReferenceBuilder(ReferenceConfig config)
        {
            _config = config;
        }
    
        public string Build()
        {
            StringBuilder sb = new StringBuilder();
            foreach (BaseField field in Config.Fields)
            {
                sb.Append(field.Build());
            }
            return sb.ToString();
        }
    }
}
