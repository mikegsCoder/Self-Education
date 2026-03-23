namespace DpendenciesApp.Services
{
    public class TimeFormatService
    {
        private ITimeService timeService;

        public TimeFormatService(ITimeService service)
        {
            timeService = service;
        }

        public string FormatTime() => $"Current Time: {timeService.GetTime()}";
    }
}
