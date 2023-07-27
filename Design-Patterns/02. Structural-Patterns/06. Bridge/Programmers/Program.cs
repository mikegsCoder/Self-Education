namespace Programmers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create new C++ programmer
            Programmer freelancer = new FreelanceProgrammer(new CPPLanguage());
            freelancer.DoWork();
            freelancer.EarnMoney();

            // new project needs C# language
            freelancer.Language = new CSharpLanguage();
            freelancer.DoWork();
            freelancer.EarnMoney();

            Console.Read();
        }
    }
}