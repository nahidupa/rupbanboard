using System;
using System.Collections.Generic;
using rupban.core;
using rupban.project;

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