using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Rupban.Core
{
    [DataContract]
    public class Resource
    {
        private string _name = "";
        [DataMember]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        [DataMember]
        public string Id { get; set; }

        public Resource()
        {
            Id = Guid.NewGuid().ToString();
        }

    }
}
