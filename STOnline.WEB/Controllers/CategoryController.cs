﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using STOnline.BLL.DTOs;
using STOnline.BLL.Interfaces.IServices;
using STOnline.DAL.Helpers.QueryParameters;
using STOnline.DAL.Models;

namespace STOnline.WEB.Controllers
{
    public class CategoryController : ControllerBase
    {
        ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [Route("Categoryes")]
        [HttpGet]
        public async Task<IEnumerable<CategoryDTO>> Get()
        {
            return await _categoryService.GetAllCategoryes();
        }
        [Route("CategoryesP")]
        [HttpGet]
        public IActionResult GetAll([FromQuery]CategoryQueryParametr categoryQueryParametr)
        {
            var categories = _categoryService.GetCategories(categoryQueryParametr).ToList();
            if(categories != null)
            {
                if (categoryQueryParametr.OrderBy == "desk")
                {
                    return Ok(categories.OrderByDescending(c => c.CategoryName));
                }
                else if (categoryQueryParametr.OrderBy == "ask")
                {
                    return Ok(categories.OrderBy(c => c.CategoryName));
                }
                return Ok(categories);
            } else
            {
                return NotFound("Categories list is empty or query parametr is incorrect");
            }
            
            
        }
        [Route("Category/{Id}")]
        [HttpGet]
        public async Task<CategoryDTO> Get(int Id)
        {
            return await _categoryService.GetCategoryById(Id);
        }
        [Route("Categoryes/category")]
        [HttpPost]
        public async Task<Category> Post([FromBody]CategoryDTO category)
        {
            return await _categoryService.AddCategory(category);
        }
        [Route("Category/category")]
        [HttpPut]
        public async Task<Category> Put([FromBody]CategoryDTO category)
        {
            return await _categoryService.UpdateCategory(category);
        }
        [Route("Category/delete/{Id}")]
        [HttpDelete]
        public async Task<int> Delete(CategoryDTO category)
        {
            return await _categoryService.DeleteCategory(category);

        }
    }
}