﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApp.Web.Models;

namespace NewBrandingStyle.Web.Controllers
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