using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
namespace Rupban.Core
{
    [DataContract]
    public class PeerBox : TemplateCell
    {
        [DataMember]
        public Resource Resources
        {
            get;
            set;
        }
    }
}
