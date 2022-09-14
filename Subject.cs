using SimpliLearnOOPSProj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpliLearnOOPSProj
{
    public class Subject : Teacher
    {

        public string SubName { get; set; }
        public string SubjectCode { get; set; }
        public Teacher Teacher;
    }
}
