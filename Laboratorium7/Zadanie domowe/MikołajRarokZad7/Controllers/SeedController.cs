using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MikołajRarokZad7.Models;
using MikołajRarokZad7.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MikołajRarokZad7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeedController : ControllerBase
    {
        private ISeedService _seedService;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="seedService"></param>
        public SeedController(ISeedService seedService)
        {
            _seedService = seedService;
        }

        /// <summary>
        /// Funkcja zwracająca listę nasion
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var seeds = _seedService.Get();
            return Ok(seeds);
        }

        /// <summary>
        /// Funkcja dodająca rodzaj nasion do bazy danych
        /// </summary>
        /// <param name="seed"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody]Seed seed)
        {
            int id = _seedService.Post(seed);

            if (id == -1)
            {
                return Conflict("Warehouse with given Id does not exist");
            }

            return Ok(id);
        }

        /// <summary>
        /// Funkcja zamieniajaca dane typu nasion
        /// Zwraca:
        /// "NoContent" jeśli zamiana danych powiodła się
        /// "Conflict" jeśli podamy różne id w zapytaniu i ścieżce
        /// "NotFound" jeśli nie istnieje magazyn o podanym id
        /// "NotFound" jeśli nie istnieje typ nasion o podanym id
        /// </summary>
        /// <param name="seed"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromBody]Seed seed, [FromRoute]int id)
        {
            if(id != seed.Id)
            {
                return Conflict("Given Ids do not match");
            }

            var isUpdateSuccessful = _seedService.Put(seed, id);

            if (isUpdateSuccessful == 0)
            {
                return NoContent();
            }

            if (isUpdateSuccessful == -1)
            {
                return NotFound("Warehouse with given Id does not exist");
            }

            return NotFound("Seed type with given Id does not exist");
        }

        /// <summary>
        /// Funkcja usuwająca typ nasion
        /// Zwraca:
        /// "NoContent" jeśli usunięcie typu nasion powiodło się
        /// "NotFound" jeśli nie istnieje typ nasion o podanym id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute]int id)
        {
            var isDeletionSuccessful = _seedService.Delete(id);

            if (isDeletionSuccessful) 
            {
                return NoContent();
            }

            return NotFound();
        }

    }
}
