using System;

namespace asignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            Team team = new Team();

            team.AddProgrammer(new programmer("Peter", Specialty.Csharp));
            team.AddProgrammer(new programmer("Kevin", Specialty.Java));
            team.AddProgrammer(new programmer("John", Specialty.Csharp));
            team.AddProgrammer(new programmer("Susan", Specialty.Java));
            team.AddProgrammer(new programmer("Emma"));

            team.PrintAllTeamMembers();

            Console.ReadKey();
        }
    }

}
