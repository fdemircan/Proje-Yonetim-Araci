using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class WorkFlow
    {
        public int workFlowID { get; set; }
        public int processID { get; set; }
        public string name { get; set; }
        public DateTime startDate { get; set; }
        public DateTime finishDate { get; set; }
        public int userID { get; set; }
        public int complateRate { get; set; }
    }
}
