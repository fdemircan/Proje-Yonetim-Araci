using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Process
    {
        public int processID { get; set; }
        public string name { get; set; }
        public int projectID { get; set; }
        public int processTypeID { get; set; }
        public int duration { get; set; }
        public DateTime startDate { get; set; }
        public DateTime finishDate { get; set; }
        public int complateRate { get; set; }
        public string detail { get; set; }
        public int priority { get; set; }
        public int createUserID { get; set; }
        public string Desc { get; set; }
        public string Note { get; set; }

    }
}
