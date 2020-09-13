﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bicyclefinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BicyclesController : ControllerBase
    {
        private static readonly List<Bicycle> Bicycles = new List<Bicycle>
        {
            new Bicycle {Id = 1, Brand = "Kildemoes", Colors = "Silver black", FrameNumber = "1WE31", KindOfBicycle = "Man", MissingFound = "lost", Place = "Roskilde", Date = "20200913", UserId = 1},
            new Bicycle {Id=2, Brand = "Raleigh", Colors="Orange", FrameNumber = "2WD3S", KindOfBicycle = "Woman", MissingFound = "lost", Place = "Roskilde", Date = "20200913", UserId = 2}
        };

        private static int _nextId = Bicycles.Count + 1;

        // GET: api/<BicyclesController>
        [HttpGet]
        public IEnumerable<Bicycle> Get()
        {
            return Bicycles;
        }
        
        // GET: api/<BicyclesController>
        [HttpGet("lost")]
        public IEnumerable<Bicycle> GetAllMissing()
        {
            return Bicycles.FindAll(bicycle =>
                bicycle.MissingFound.Equals("lost", StringComparison.OrdinalIgnoreCase));
        }
        
        // GET: api/<BicyclesController>
        [HttpGet("found")]
        public IEnumerable<Bicycle> GetAllFound()
        {
            return Bicycles.FindAll(bicycle =>
                bicycle.MissingFound.Equals("found", StringComparison.OrdinalIgnoreCase));
        }

        
        // GET api/<BicyclesController>/5
        [HttpGet("{id}")]
        public Bicycle Get(int id)
        {
            return Bicycles.FirstOrDefault(bicycle => bicycle.Id == id);
        }

        // POST api/<BicyclesController>
        [HttpPost]
        public Bicycle Post([FromBody] Bicycle value)
        {
            // TODO extra generator method. Call from static list
            value.Id = _nextId++;
            DateTime now = DateTime.Now;
            string nowStr = now.ToString("yyyy-MM-dd");
            value.Date = nowStr;
            Bicycles.Add(value);
            return value;
        }
        
        /*/ PUT api/<BicyclesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }*/

        /*/ DELETE api/<BicyclesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}