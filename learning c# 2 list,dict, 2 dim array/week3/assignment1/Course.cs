using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    public class Course
    {
        public string status = "";
        public string Name;
        public int Grade;
        public PracticalGrade practical;

        public enum PracticalGrade
        {
            None, Absent, Insufficient, Sufficient, Good
        }

        public bool Passed()
        {
            return ((Grade >= 55) && ((practical == PracticalGrade.Sufficient) || (practical == PracticalGrade.Good)));
        }

        public bool CumLaude()
        {
            return ((Grade >= 80) && (practical == PracticalGrade.Good));
        }
    }
}
