﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOs.SubscriberDtos
{
    public class CreateSubscriberDto
    {

        public string Email { get; set; }

        private bool IsActive { get => false; }
    }
}
