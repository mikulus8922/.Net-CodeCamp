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
    public class WarehouseController : ControllerBase
    {
        private IWarehouseService _warehouseService;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="warehouseService"></param>
        public WarehouseController(IWarehouseService warehouseService)
        {
            _warehouseService = warehouseService;
        }

        /// <summary>
        /// Funkcja zwracająca listę magazynów
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var warehouses = _warehouseService.Get();
            return Ok(warehouses);
        }

        /// <summary>
        /// Funkcja dodająca magazyn do bazy danych
        /// </summary>
        /// <param name="warehouse"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] Warehouse warehouse)
        {
            int id = _warehouseService.Post(warehouse);
            return Ok(id);
        }

        /// <summary>
        /// Funkcja zamieniajaca dane magazynu
        /// Zwraca:
        /// "NoContent" jeśli zamiana danych powiodła się
        /// "Conflict" jeśli podamy różne id w zapytaniu i ścieżce
        /// "NotFound" jeśli nie istnieje magazyn o podanym id
        /// </summary>
        /// <param name="warehouse"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromBody] Warehouse warehouse, [FromRoute] int id)
        {
            if (id != warehouse.Id)
            {
                return Conflict("Given Ids do not match");
            }

            var isUpdateSuccessful = _warehouseService.Put(warehouse, id);

            if (isUpdateSuccessful)
            {
                return NoContent();
            }

            return NotFound("Warehouse with given Id does not exist");
        }

        /// <summary>
        /// Funkcja usuwająca magazyn
        /// Zwraca:
        /// "NoContent" jeśli usunięcie magazynu powiodło się
        /// "NotFound" jeśli nie istnieje magazyn o podanym id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var isDeletionSuccessful = _warehouseService.Delete(id);

            if (isDeletionSuccessful)
            {
                return NoContent();
            }

            return NotFound();
        }
    }
}
