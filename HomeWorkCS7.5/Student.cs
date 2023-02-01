using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkCS7._5
{
    internal class Student
    {
        public int No;
        public string Name;
        public string GroupNo;


        static int _totalCount;
        static Student()
        {
            _totalCount=0;
        }
        public Student()
        {
            _totalCount++;
            No = _totalCount;
        }

    }
}
