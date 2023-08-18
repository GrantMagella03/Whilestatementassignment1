using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whilestatementassignment1
{
    internal class Student
    {
        public static int NID { get; set; } = 1;
        public int id { get; set; }
        public int code = 010123;
        public string name { get; set; }
        public string state { get; set; }
        public void ChangeName(string nName = "Student")
        {
            name = nName;
        }
        public void ChangeName(string fN,string lN)
        { 
            name = fN+" "+lN;
        }
        public Student(String name) : this(name,"Ohio")
        {

        }
        public Student(string name="Student", string state = "Ohio")
        {
            this.id= NID;
            NID++;
            this.name = name;
            this.state = state;
        }
    }
}
