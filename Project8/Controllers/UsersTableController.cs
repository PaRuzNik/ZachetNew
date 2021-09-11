using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class UsersTableController : ControllerBase
    {
        private readonly ILogger<UsersTableController> _logger;

        public UsersTableController(ILogger<UsersTableController> logger)
        {
            _logger = logger;
        }

        // GET api/<UsersTableComponent>/5
        [HttpGet]
        public string Get()
        {
            string Character = "sdfdsfdf";
            return Character;
        }

    }
}
