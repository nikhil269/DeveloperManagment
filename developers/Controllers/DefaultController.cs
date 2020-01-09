using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using developers.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace developers.Controllers
{
    public class DefaultController : Controller
    {
        private readonly DeveloperListContext _context;

        public DefaultController(DeveloperListContext context)
        {
            _context = context;
        }
        //[HttpGet]
        //public IActionResult GetAllDevelopers()
        //{
        //   var developer = _context.Developer.ToList();
        //    return Ok(developer);

        //}
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeveloperList>>> GetDeveloperLists([FromQuery]Parameter parameter, string searchstring)
        {
            var developer = from d in _context.DeveloperLists select d;
            return await _context.DeveloperLists.Skip((parameter.PageNumber - 1) * parameter.PageSize)
                .Where(d => d.Name.Contains(searchstring) || string.IsNullOrWhiteSpace(searchstring))
                .Take(parameter.PageSize).ToListAsync();

        }
    }
}