using System;
using System.Collections.Generic;
using Rupban.Core;
using Rupban.Project;

namespace Rupban.Agent
{
    public class TrackAgent
    {
        public List<Ticket> ImportTicket()
        {
           var backLogImporter=new BackLogImporter();
           return  backLogImporter.ImportTicket();
        }
    }
}