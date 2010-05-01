using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Rupban.Core
{
     [DataContract]
    public class Project
    {
         [DataMember]
        public string Name { get; set; }
         [DataMember]
        public Board Board { get; set; }
         [DataMember]
         public List<Resource> Resources { get; set; }
    }
}
