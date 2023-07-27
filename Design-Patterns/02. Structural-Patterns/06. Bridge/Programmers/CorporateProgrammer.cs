namespace Programmers
{
    public class CorporateProgrammer : Programmer
    {
        public CorporateProgrammer(ILanguage lang)
            : base(lang)
        {}

        public override void EarnMoney()
        {
            Console.WriteLine("Get salary in the end of the month.");
        }
    }
}
