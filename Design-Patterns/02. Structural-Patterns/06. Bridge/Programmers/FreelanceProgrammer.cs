namespace Programmers
{
    public class FreelanceProgrammer : Programmer
    {
        public FreelanceProgrammer(ILanguage lang) : base(lang)
        {}

        public override void EarnMoney()
        {
            Console.WriteLine("Get money for completed project.");
        }
    }
}
