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
        private readonly ExchangesDbContext _dbContext;

        public CompanyNewController(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpPost]
        [Route("AddNewItem")]
        public IActionResult AddNewItem(CompanyModel companyModel)
        {
            var entity = new ItemEntity
            {
                Name = companyModel.Name,
                Description = companyModel.Description,
                IsVisible = companyModel.IsVisible,
            };
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}