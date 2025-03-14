﻿using AutoMapper;
using Business.Abstract;
using DTO.DTOs.BlogDtos;
using Entity.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Authorize(Roles = "Admin, Teacher")]
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController(IMapper _mapper, IBlogService _blogService) : ControllerBase
    {
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Get()
        {
            var values = _blogService.TGetBlogsWithCategories();
            var blogs = _mapper.Map<List<ResultBlogDto>>(values);
            return Ok(blogs);
        }
        [AllowAnonymous]
        [HttpGet("GetLast4Blogs")]
        public IActionResult GetLast4Blogs()
        {
            var values = _blogService.TGetLast4BlogsWithCategories();
            var blogs = _mapper.Map<List<ResultBlogDto>>(values);
            return Ok(blogs);
        }

        [AllowAnonymous]

        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            var value = _blogService.TGetBlogWithCategory(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _blogService.TDelete(id);
            return Ok("Blog Alanı Silindi");
        }

        [HttpPost]
        public IActionResult Create(CreateBlogDto createBlogDto)
        {
            var newValue = _mapper.Map<Blog>(createBlogDto);
            _blogService.TCreate(newValue);
            return Ok("Yeni Blog Alanı Oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateBlogDto updateBlogDto)
        {
            var value = _mapper.Map<Blog>(updateBlogDto);
            _blogService.TUpdate(value);
            return Ok("Blog Alanı Güncellendi");
        }

        [HttpGet("GetBlogByWriterId/{id}")]
        public IActionResult GetBlogByWriterId(int id)
        {
            var values = _blogService.TGetBlogsWithCategoriesByWriterId(id);
            var mappedValues = _mapper.Map<List<ResultBlogDto>>(values);
            return Ok(mappedValues);

        }

        [AllowAnonymous]
        [HttpGet("GetBlogCount")]
        public IActionResult GetBlogCount()
        {
            var blogCount = _blogService.TCount();
            return Ok(blogCount);
        }
        [AllowAnonymous]
        [HttpGet("GetBlogsByCategoryId/{id}")]
        public IActionResult GetBlogsByCategoryId(int id)
        {
            var blogs = _blogService.TGetBlogsByCategoryId(id);
            return Ok(blogs);
        }
    }
}
