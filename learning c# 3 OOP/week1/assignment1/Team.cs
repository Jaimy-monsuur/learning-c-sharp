using System;
using System.Collections.Generic;
using System.Text;

namespace asignment1
{
    class Team
    {
        List<programmer> programmers = new List<programmer>();

        public void AddProgrammer(programmer p)
        {
            programmers.Add(p);
        }


        public void PrintAllTeamMembers()
        {
            foreach (programmer p in programmers)
            {
                p.print();
            }
        }
    }
}
