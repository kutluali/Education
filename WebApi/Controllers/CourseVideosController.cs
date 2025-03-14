using AutoMapper;
using Business.Abstract;
using DTO.DTOs.CourseVideoDtos;
using Entity.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Authorize(Roles = "Admin, Teacher, Student")]
    [Route("api/[controller]")]
    [ApiController]
    public class CourseVideosController(IGenericService<CourseVideo> _courseVideoService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _courseVideoService.TGetList();
            return Ok(values);
        }

        [HttpGet("GetCourseVideosByCourseId/{id}")]
        public IActionResult GetCourseVideosByCourseId(int id)
        {
            var values = _courseVideoService.TGetFilteredList(x => x.CourseId == id);
            return Ok(values);
        }

        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            var value = _courseVideoService.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _courseVideoService.TDelete(id);
            return Ok("Kurs Video Alanı Silindi");
        }

        [HttpPost]
        public IActionResult Create(CreateCourseVideoDto createCourseVideoDto)
        {
            var newValue = _mapper.Map<CourseVideo>(createCourseVideoDto);
            _courseVideoService.TCreate(newValue);
            return Ok("Yeni Kurs Video Alanı Oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateCourseVideoDto updateCourseVideoDto)
        {
            var value = _mapper.Map<CourseVideo>(updateCourseVideoDto);
            _courseVideoService.TUpdate(value);
            return Ok("Kurs Video Alanı Güncellendi");

        }
    }
}
