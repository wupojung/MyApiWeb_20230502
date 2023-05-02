using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApi.Services;

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RpgController : ControllerBase
    {
        private RpgService _service;

        public RpgController() //建構方法 
        {
            _service = new RpgService();
        }

        [HttpGet]
        [Route("{id}")]
        public Rpg Get(int id)
        {
            Rpg result = null;

            result = _service.Get(id);

            return result;
        }
        
        [HttpPost]
        public Rpg Post(Rpg rpg)
        {
            Rpg result = null;

            result = _service.Create(rpg);

            return result;
        }
    }
}