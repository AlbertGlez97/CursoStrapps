using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _01_MyWebAPI.models;

namespace _01_MyWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BadgesController : ControllerBase
    {
        private static readonly Badges badges = new Badges()
        {
      followers= 10,
      likes= 20,
      stars= 30,
      completed= 40,
      warnings= 50,
      notification= 60,
      unread= 70,
      drafs= 80,
      deleted= 90

        };

        private readonly ILogger<BadgesController> _logger;

        public BadgesController(ILogger<BadgesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Badges Get()
        {
           badges.followers++;
           badges.likes++;
           badges.stars--;
           badges.completed = badges.completed + 2;
           badges.warnings++;
           badges.notification++;
           badges.unread++;
           badges.drafs++;
           badges.deleted++;
           return badges;
        }
    }
}
