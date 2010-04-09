using System;
using System.Collections.Generic;
using System.Text;

namespace rupban.core
{
    public class TemplateCollum
    {
        public int ID { set; get; }
        public string Title{ set; get; }
        public List<TemplateRow> TemplateRows{ set; get; }
        
    }
}
