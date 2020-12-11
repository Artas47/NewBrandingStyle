using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MyApp.Web.Database;
using MyApp.Web.Entities;
using Microsoft.AspNetCore.Mvc;
using MyApp.Web.Models;

namespace MyApp.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyNewController : ControllerBase
    {
        [HttpPost]
        [Route("AddNewItem")]
        public IActionResult AddNewItem(CompanyModel companyModel)
        {
            return Ok();
        }
    }
}