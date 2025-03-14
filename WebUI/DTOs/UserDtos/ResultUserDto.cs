using WebUI.DTOs.BlogDtos;
using WebUI.DTOs.CourseDtos;
using WebUI.DTOs.CourseRegisterDtos;
using WebUI.DTOs.TeacherSocialDtos;

namespace WebUI.DTOs.UserDtos
{
    public class ResultUserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string? ImageUrl { get; set; }

        public List<ResultTeacherSocialDto> TeacherSocials { get; set; }

        public List<ResultCourseDto> Courses { get; set; }
        public List<ResultCourseRegisterDto> CourseRegisters { get; set; }

        public List<ResultBlogDto> Blogs { get; set; }

    }
}
