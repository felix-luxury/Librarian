using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian.LiterarySource
{
    abstract class LiterarySource
    {
        private string title;
        private string author;
        private PublishInfo publishInfo;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        public PublishInfo PublishInfo
        {
            get
            {
                return publishInfo;
            }
            set
            {
                publishInfo = value;
            }
        }
    }
}
