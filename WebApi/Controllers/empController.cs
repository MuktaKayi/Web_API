using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using WebApi.Database;
using WebApi.Model;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/Controller")]
    public class empController : Controller
    {
        private readonly databasedbcontext databasedbcontext;
        public empController(databasedbcontext dbc) {
            databasedbcontext = dbc;
        }

        [HttpGet]
        public async Task<IActionResult> Getallemploye()
        {
            
            try
            {
                var result = await databasedbcontext.employee.ToListAsync();
                if (result==null)
                {
                    return BadRequest(result);
                }
                else
                {
                    return Ok(result);
                }

            }
            catch(Exception ex)
            {
                throw ex;

            }

        }

        [HttpPost]
        public async Task<IActionResult>Addemploye([FromBody]employe emp)
        {
            try {
                await databasedbcontext.employee.AddAsync(emp);
                int result = await databasedbcontext.SaveChangesAsync();
                if (result == null)
                {
                    return BadRequest(emp);
                }
                else
                {
                    return Ok(emp);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
