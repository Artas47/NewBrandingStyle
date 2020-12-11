using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApp.Web.Database;
using MyApp.Web.Entities;
using MyApp.Web.Models;

namespace MyApp.Web.Controllers
{
    public class ExchangesController : Controller
    {
        private readonly ExchangesDbContext _dbContext;
        public ExchangesController(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpPost]
        [Route("AddNewItem")]
        public IActionResult Add(CompanyModel companyModel)
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


        [HttpGet]
        [Route("GetItems")]
        public async Task<IActionResult> GetItems()
        {
            var items = _dbContext.Items.ToList();

            if (items == null)
                return NotFound("Not Found");

            return Ok(items);
        }
    }
}
