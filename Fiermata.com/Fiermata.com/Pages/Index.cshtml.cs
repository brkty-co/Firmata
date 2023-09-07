using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiermata.com.Models;
using Fiermata.com.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Fiermata.com.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileBusService BusService;
        public IEnumerable<Bus> Buses { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, JsonFileBusService Busservice)
        {
            _logger = logger;
            BusService = Busservice;
        }

        public void OnGet()
        {
            Buses = BusService.GetBuses();
        }
    }
}
