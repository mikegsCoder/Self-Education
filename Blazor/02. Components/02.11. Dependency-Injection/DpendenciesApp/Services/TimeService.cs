namespace DpendenciesApp.Services
{
    public class TimeService : ITimeService
    {
        public string GetTime() => DateTime.Now.ToLongTimeString();
    }
}
