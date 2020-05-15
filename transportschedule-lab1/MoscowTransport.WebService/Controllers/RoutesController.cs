using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Torg.DomainObjects;

namespace Torg.Controllers
{
    [ApiController]
    [Torg("[controller]")]
    public class TorgController : ControllerBase
    {
        private readonly ILogger<TorgController> _logger;

        public TorgController(ILogger<TorgController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Torg> GetTorg()
        {
            return new List<Torg>() 
            { 
                new Torg() 
                { 
                    Id = 1,
                    Name = "Одежда. Обувь. Промтовары",
                    ObjType = "Минимаркет",
                    Ocrug = Ocrug.North,
                    Location = new Location()
                    {
                        Id = 1,
                        Rayon = "район Беговой",
                        Address = "город Москва, Беговая аллея, дом 3А"
                    }
                } 
            };
        }
    }
}
