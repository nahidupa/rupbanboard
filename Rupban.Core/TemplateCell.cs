using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Rupban.Core
{
    [DataContract]
    public class TemplateCell
    {
        
        private string _id;
       
        [DataMember]
        public string Id
        {
            get
            {

                return _id;
            }
            set {
                _id = value;
            }
        }

        public TemplateCell()
        {
            _id = Guid.NewGuid().ToString();
        }

    }
}
