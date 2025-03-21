﻿using DTO.DTOs.CourseCategoryDtos;
using Entity.Entities;

namespace DTO.DTOs.CourseDtos
{
    public class ResultCourseDto
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string ImageUrl { get; set; }
        public int CourseCategoryId { get; set; }
        public ResultCourseCategoryDto CourseCategory { get; set; }
        public decimal Price { get; set; }
        public bool IsShown { get; set; }

        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}
