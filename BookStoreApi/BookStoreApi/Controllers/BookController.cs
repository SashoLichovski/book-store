using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreApi.Services.Interfaces;
using BookStoreApi.Services.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService bookService;

        public BookController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var model = bookService.GetAll();
            return Ok(model);
        }

        [HttpPut]
        public IActionResult Update(UpdateBookViewModel model)
        {
            bookService.Update(model);
            return Ok();
        }

        [HttpDelete]
        [Route("delete/{id}/{bookType}")]
        public IActionResult Delete(int id, string bookType)
        {
            bookService.Delete(id, bookType);
            return Ok();
        }

        [HttpPost]
        public IActionResult Create(CreateBookViewModel model)
        {
            bookService.Create(model);
            return Ok();
        }
    }
}
