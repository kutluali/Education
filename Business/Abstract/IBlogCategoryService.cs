﻿using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBlogCategoryService : IGenericService<BlogCategory>
    {

        List<BlogCategory> TGetCategoriesWithBlogs();
    }
}
