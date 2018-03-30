using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_12_A_B.Classes
{
    class Lesson
    {
        public string courseId { get; set; }
        public int startingHour { get; set; }
        public int endingHour { get; set; }
        public string classRoom { get; set; }
        public int Day { get; set; }
        public void Test()
        {

        }
        public int numofStudents { get; set; }
        public Lesson()
        {
            
        }
        public override string ToString()
        {
            return courseId + "\\";
        }
    }
}
