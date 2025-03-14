﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class CourseRegister
    {
        public int CourseRegisterId { get; set; }

        public int AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
