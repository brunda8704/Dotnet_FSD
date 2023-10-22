using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingComplexTypes
{
    internal class Student:IComparable<Student>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }

        public int CompareTo(Student other)
        {
            //if(this.Marks>other.Marks)
            //    return 1;
            //else if(this.Marks<other.Marks)
            //    return -1;
            //else
            //    return 0;

            return this.Marks.CompareTo(other.Marks);
        }

        //public class SortByMarks : IComparer<Student>
        //{
        //    public int Compare(Student x, Student y)
        //    {
        //        return x.Marks.CompareTo(y.Marks);
        //    }
        //}
    }

}
