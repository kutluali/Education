using WebUI.DTOs.CourseDtos;
using WebUI.DTOs.UserDtos;

namespace WebUI.DTOs.CourseRegisterDtos
{
    public class UpdateCourseRegisterDto
    {
        public int CourseRegisterId { get; set; }

        public int AppUserId { get; set; }
        public ResultUserDto AppUser { get; set; }

        public int CourseId { get; set; }

        public ResultCourseDto Course { get; set; }
    }
}
