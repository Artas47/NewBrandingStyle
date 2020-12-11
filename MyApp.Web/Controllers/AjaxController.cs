using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApp.Web.Models;

namespace MyApp.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyAPIController : ControllerBase
    {
        [HttpPost]
        [Route("AddNewItem")]
        public IActionResult AddNewItem(CompanyModel companyModel)
        {
            return Ok("Item added succesfully!");
        }
    }
}