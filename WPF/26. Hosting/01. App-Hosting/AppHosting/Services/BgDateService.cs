using AppHosting.Contracts;
using System;

namespace AppHosting.Services
{
    public class BgDateService : IBgDateService
    {
        public string FormatedDate => $"Днес е: {DateTime.Now.ToString("dd.MM.yyyy")}";
    }
}
