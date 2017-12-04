using System;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace Project
{
    public class Project 
    {
        public int projectID { get; set; }
        public string name { get; set; }
        public DateTime startDate { get; set; }
        public DateTime finishDate { get; set; }
        public float budget { get; set; }
        public bool isActive { get; set; }
        public int createID { get; set; }
        public int projectUserID { get; set; }

        public void ProjeOlustur()
        {

        }

        
    }
}
