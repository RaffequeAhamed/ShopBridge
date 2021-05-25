using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Controllers
{
    public class BaseController : Controller
    {
        protected readonly ILogger<Controller> _logger;
        public BaseController(ILogger<Controller> logger)
        {
            _logger = logger;
        }
    }
}
