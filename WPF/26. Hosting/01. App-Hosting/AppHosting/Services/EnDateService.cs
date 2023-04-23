using AppHosting.Contracts;
using System;

namespace AppHosting.Services
{
    public class EnDateService : IEnDateService
    {
        public string FormatedDate => $"Today: {DateTime.Now.ToString("MM.dd.yyyy")}";
    }
}
