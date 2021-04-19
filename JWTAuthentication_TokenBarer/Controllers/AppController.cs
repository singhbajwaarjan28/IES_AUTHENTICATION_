using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthentication_TokenBarer.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("[controller]")]
    public class AppController : ControllerBase
    {
        private readonly List<app> apps = new List<app>()
        {
            new app { appid = 101, appname = "whatsapp", genre = "communication", downloads= 2000000},
            new app { appid = 102,appname = "camera", genre = "media", downloads= 400000},
            new app { appid = 103,appname = "instagram", genre = "communication", downloads= 800000},
            new app { appid = 104,appname = "mxplayer", genre = "media", downloads= 500000},
            new app { appid = 105,appname = "snapchat", genre = "communication", downloads= 10000000},

        };
        private readonly ILogger<AppController> _logger;
        public AppController(ILogger<AppController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IEnumerable<app> Get()
        {
            return apps;  
        }
        [HttpGet("{appid:int}")]
        public app GetOne(int appid)
        {
            return apps.SingleOrDefault(x => x.appid == appid );
        }

    }
}