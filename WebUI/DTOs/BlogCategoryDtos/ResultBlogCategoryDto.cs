using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebUI.DTOs.BlogDtos;

namespace WebUI.DTOs.BlogCategoryDtos
{
    public class ResultBlogCategoryDto
    {
        public int BlogCategoryId { get; set; }
        public string Name { get; set; }

        public List<ResultBlogDto> Blogs { get; set; }
    }
}
